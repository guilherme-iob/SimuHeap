import os
import pandas as pd
import matplotlib.pyplot as plt

# ============================================================
# CONFIGURAÇÕES
# ============================================================

ARQUIVO_PRE = "questionario_previo_padronizado_atualizado.csv"
ARQUIVO_POS = "questionario_posterior_padronizado_atualizado.csv"

PASTA_SAIDA = "resultados_analise"
QUESTOES = [f"Q{i}" for i in range(1, 11)]
CHAVE = ["Disciplina", "NumeroChamada"]

ROTULOS = {
    "Q1": "Alocação dinâmica e heap",
    "Q2": "Organização dos dados na memória",
    "Q3": "malloc x calloc",
    "Q4": "free e reutilização",
    "Q5": "realloc",
    "Q6": "Sequência de alocações/liberações",
    "Q7": "Metadados e alinhamento",
    "Q8": "Algoritmos de busca",
    "Q9": "Split e coalescing",
    "Q10": "Fragmentação interna/externa"
}

os.makedirs(PASTA_SAIDA, exist_ok=True)


# ============================================================
# LEITURA
# ============================================================

pre = pd.read_csv(ARQUIVO_PRE, sep=";")
pos = pd.read_csv(ARQUIVO_POS, sep=";")

for q in QUESTOES:
    pre[q] = pd.to_numeric(pre[q])
    pos[q] = pd.to_numeric(pos[q])


# ============================================================
# VALIDAÇÃO
#
# Um mesmo número pode existir em turmas diferentes.
# O que não pode existir é a mesma combinação
# Disciplina + NumeroChamada repetida.
# ============================================================

for nome, df in [("Prévio", pre), ("Posterior", pos)]:

    duplicados = df[df.duplicated(CHAVE, keep=False)]

    if not duplicados.empty:
        print(f"\nATENÇÃO: alunos duplicados no questionário {nome}:")
        print(
            duplicados[
                CHAVE + ["Idade", "Curso", "Semestre"]
            ].sort_values(CHAVE).to_string(index=False)
        )

        raise ValueError(
            f"Existem identificadores duplicados no questionário {nome}. "
            "Corrija antes de continuar."
        )


# ============================================================
# PAREAMENTO PRÉ X PÓS
# ============================================================

auditoria = pre[CHAVE].merge(
    pos[CHAVE],
    on=CHAVE,
    how="outer",
    indicator=True
)

nao_pareados = auditoria[
    auditoria["_merge"] != "both"
]

if not nao_pareados.empty:
    print("\nRespostas sem par pré/pós:")
    print(
        nao_pareados.to_string(index=False)
    )


dados = pre.merge(
    pos,
    on=CHAVE,
    how="inner",
    suffixes=("_Pre", "_Pos"),
    validate="one_to_one"
)


# ============================================================
# GANHO POR QUESTÃO E POR ALUNO
# ============================================================

for q in QUESTOES:
    dados[f"{q}_Ganho"] = dados[f"{q}_Pos"] - dados[f"{q}_Pre"]

COLUNAS_PRE = [f"{q}_Pre" for q in QUESTOES]
COLUNAS_POS = [f"{q}_Pos" for q in QUESTOES]
COLUNAS_GANHO = [f"{q}_Ganho" for q in QUESTOES]

dados["Media_Pre"] = dados[COLUNAS_PRE].mean(axis=1)
dados["Media_Pos"] = dados[COLUNAS_POS].mean(axis=1)
dados["Ganho_Medio"] = dados["Media_Pos"] - dados["Media_Pre"]

dados["Questoes_Melhoraram"] = (dados[COLUNAS_GANHO] > 0).sum(axis=1)
dados["Questoes_Iguais"] = (dados[COLUNAS_GANHO] == 0).sum(axis=1)
dados["Questoes_Pioraram"] = (dados[COLUNAS_GANHO] < 0).sum(axis=1)


# ============================================================
# 1. GANHO INDIVIDUAL GERAL
# ============================================================

individual = dados[
    CHAVE
    + [
        "Curso_Pre",
        "Semestre_Pre",
        "Media_Pre",
        "Media_Pos",
        "Ganho_Medio",
        "Questoes_Melhoraram",
        "Questoes_Iguais",
        "Questoes_Pioraram"
    ]
    + COLUNAS_GANHO
].copy()

individual.rename(
    columns={
        "Curso_Pre": "Curso",
        "Semestre_Pre": "Semestre"
    },
    inplace=True
)

individual.sort_values(
    ["Disciplina", "NumeroChamada"],
    inplace=True
)

individual.to_csv(
    f"{PASTA_SAIDA}/ganho_individual.csv",
    sep=";",
    index=False,
    encoding="utf-8-sig"
)


print("\n")
print("=" * 70)
print("GANHO INDIVIDUAL - TODOS OS ALUNOS")
print("=" * 70)

print(
    individual[
        [
            "Disciplina",
            "NumeroChamada",
            "Media_Pre",
            "Media_Pos",
            "Ganho_Medio"
        ]
    ].round(2).to_string(index=False)
)


# ============================================================
# 2. RESULTADO GERAL
# ============================================================

media_pre_geral = dados["Media_Pre"].mean()
media_pos_geral = dados["Media_Pos"].mean()
ganho_geral = dados["Ganho_Medio"].mean()

melhoraram = (dados["Ganho_Medio"] > 0).sum()
iguais = (dados["Ganho_Medio"] == 0).sum()
pioraram = (dados["Ganho_Medio"] < 0).sum()

print("\n")
print("=" * 70)
print("RESULTADO GERAL")
print("=" * 70)

print(f"Participantes pareados: {len(dados)}")
print(f"Média pré: {media_pre_geral:.2f}")
print(f"Média pós: {media_pos_geral:.2f}")
print(f"Ganho médio: {ganho_geral:+.2f}")

print(
    f"Alunos que melhoraram: "
    f"{melhoraram}/{len(dados)} "
    f"({melhoraram / len(dados) * 100:.1f}%)"
)

print(f"Sem alteração: {iguais}")
print(f"Reduziram: {pioraram}")


# ============================================================
# 3. GANHO POR TURMA
# ============================================================

resumo_turmas = dados.groupby(
    "Disciplina"
).agg(
    Alunos=("NumeroChamada", "count"),
    Media_Pre=("Media_Pre", "mean"),
    Media_Pos=("Media_Pos", "mean"),
    Ganho_Medio=("Ganho_Medio", "mean")
).reset_index()

resumo_turmas["Alunos_Melhoraram"] = resumo_turmas["Disciplina"].map(
    dados.groupby("Disciplina")["Ganho_Medio"]
    .apply(lambda x: (x > 0).sum())
)

resumo_turmas["Percentual_Melhoraram"] = (
    resumo_turmas["Alunos_Melhoraram"]
    / resumo_turmas["Alunos"]
    * 100
)

resumo_turmas.to_csv(
    f"{PASTA_SAIDA}/ganho_por_turma.csv",
    sep=";",
    index=False,
    encoding="utf-8-sig"
)


print("\n")
print("=" * 70)
print("GANHO POR TURMA")
print("=" * 70)

print(
    resumo_turmas.round(2).to_string(index=False)
)


# ============================================================
# 4. GANHO INDIVIDUAL POR TURMA
# ============================================================

for disciplina, turma in dados.groupby("Disciplina"):

    print("\n")
    print("=" * 70)
    print(disciplina.upper())
    print("=" * 70)

    tabela = turma[
        [
            "NumeroChamada",
            "Media_Pre",
            "Media_Pos",
            "Ganho_Medio"
        ]
    ].sort_values("NumeroChamada")

    print(
        tabela.round(2).to_string(index=False)
    )


# ============================================================
# 5. GANHO POR QUESTÃO - GERAL
# ============================================================

resultado_questoes = []

for q in QUESTOES:

    media_pre = dados[f"{q}_Pre"].mean()
    media_pos = dados[f"{q}_Pos"].mean()

    resultado_questoes.append({
        "Questao": q,
        "Tema": ROTULOS[q],
        "Media_Pre": media_pre,
        "Media_Pos": media_pos,
        "Ganho_Medio": media_pos - media_pre,
        "Alunos_Melhoraram_%": (
            dados[f"{q}_Ganho"] > 0
        ).mean() * 100
    })


resultado_questoes = pd.DataFrame(
    resultado_questoes
).sort_values(
    "Ganho_Medio",
    ascending=False
)

resultado_questoes.to_csv(
    f"{PASTA_SAIDA}/ganho_por_questao.csv",
    sep=";",
    index=False,
    encoding="utf-8-sig"
)


print("\n")
print("=" * 70)
print("QUESTÕES QUE MAIS SURTIRAM EFEITO - GERAL")
print("=" * 70)

print(
    resultado_questoes.round(2).to_string(index=False)
)


# ============================================================
# 6. GANHO POR QUESTÃO EM CADA TURMA
# ============================================================

questoes_turmas = []

for disciplina, turma in dados.groupby("Disciplina"):

    for q in QUESTOES:

        media_pre = turma[f"{q}_Pre"].mean()
        media_pos = turma[f"{q}_Pos"].mean()

        questoes_turmas.append({
            "Disciplina": disciplina,
            "Questao": q,
            "Tema": ROTULOS[q],
            "Media_Pre": media_pre,
            "Media_Pos": media_pos,
            "Ganho_Medio": media_pos - media_pre,
            "Alunos_Melhoraram_%": (
                turma[f"{q}_Ganho"] > 0
            ).mean() * 100
        })


questoes_turmas = pd.DataFrame(
    questoes_turmas
)

questoes_turmas.to_csv(
    f"{PASTA_SAIDA}/ganho_questoes_por_turma.csv",
    sep=";",
    index=False,
    encoding="utf-8-sig"
)


for disciplina in dados["Disciplina"].unique():

    tabela = questoes_turmas[
        questoes_turmas["Disciplina"] == disciplina
    ].sort_values(
        "Ganho_Medio",
        ascending=False
    )

    print("\n")
    print("=" * 70)
    print(f"QUESTÕES COM MAIOR GANHO - {disciplina.upper()}")
    print("=" * 70)

    print(
        tabela[
            [
                "Questao",
                "Tema",
                "Media_Pre",
                "Media_Pos",
                "Ganho_Medio",
                "Alunos_Melhoraram_%"
            ]
        ].round(2).to_string(index=False)
    )


# ============================================================
# GRÁFICO 1 - GANHO INDIVIDUAL GERAL
# ============================================================

grafico = dados.copy()

grafico["Aluno"] = (
    grafico["Disciplina"].str.slice(0, 4)
    + " - "
    + grafico["NumeroChamada"].astype(str)
)

grafico.sort_values(
    "Ganho_Medio",
    inplace=True
)

plt.figure(figsize=(11, 8))

plt.barh(
    grafico["Aluno"],
    grafico["Ganho_Medio"]
)

plt.axvline(0, linewidth=1)

plt.xlabel("Ganho médio (Pós - Pré)")
plt.ylabel("Aluno")
plt.title("Ganho individual após o uso do simulador")

plt.tight_layout()

plt.savefig(
    f"{PASTA_SAIDA}/ganho_individual_geral.png",
    dpi=200
)

plt.show()


# ============================================================
# GRÁFICO 2 - GANHO INDIVIDUAL POR TURMA
# ============================================================

for disciplina, turma in dados.groupby("Disciplina"):

    turma = turma.sort_values(
        "Ganho_Medio"
    )

    plt.figure(figsize=(9, 6))

    plt.barh(
        turma["NumeroChamada"].astype(str),
        turma["Ganho_Medio"]
    )

    plt.axvline(0, linewidth=1)

    plt.xlabel("Ganho médio (Pós - Pré)")
    plt.ylabel("Número de chamada")

    plt.title(
        f"Ganho individual - {disciplina}"
    )

    plt.tight_layout()

    nome = (
        disciplina
        .lower()
        .replace(" ", "_")
        .replace("ç", "c")
        .replace("ã", "a")
        .replace("á", "a")
        .replace("é", "e")
        .replace("í", "i")
        .replace("ó", "o")
        .replace("ú", "u")
    )

    plt.savefig(
        f"{PASTA_SAIDA}/ganho_individual_{nome}.png",
        dpi=200
    )

    plt.show()


# ============================================================
# GRÁFICO 3 - GANHO MÉDIO POR TURMA
# ============================================================

plt.figure(figsize=(10, 6))

plt.bar(
    resumo_turmas["Disciplina"],
    resumo_turmas["Ganho_Medio"]
)

plt.ylabel("Ganho médio (Pós - Pré)")
plt.title("Ganho médio por turma")

plt.xticks(
    rotation=15,
    ha="right"
)

plt.tight_layout()

plt.savefig(
    f"{PASTA_SAIDA}/ganho_por_turma.png",
    dpi=200
)

plt.show()


# ============================================================
# GRÁFICO 4 - QUESTÕES QUE MAIS SURTIRAM EFEITO
# ============================================================

grafico_questoes = resultado_questoes.sort_values(
    "Ganho_Medio"
)

plt.figure(figsize=(10, 6))

plt.barh(
    grafico_questoes["Questao"],
    grafico_questoes["Ganho_Medio"]
)

plt.xlabel("Ganho médio (Pós - Pré)")
plt.ylabel("Questão")

plt.title(
    "Ganho médio por questão"
)

plt.tight_layout()

plt.savefig(
    f"{PASTA_SAIDA}/ganho_por_questao.png",
    dpi=200
)

plt.show()


# ============================================================
# RESUMO FINAL
# ============================================================

print("\n")
print("=" * 70)
print("RESUMO FINAL")
print("=" * 70)

print(
    f"No conjunto geral, a média passou de "
    f"{media_pre_geral:.2f} para "
    f"{media_pos_geral:.2f}, "
    f"com ganho médio de {ganho_geral:+.2f} ponto."
)

print(
    f"{melhoraram} dos {len(dados)} alunos "
    f"({melhoraram / len(dados) * 100:.1f}%) "
    f"apresentaram aumento na média das respostas."
)

print("\nGanho por turma:")

for _, turma in resumo_turmas.iterrows():

    print(
        f"- {turma['Disciplina']}: "
        f"{turma['Media_Pre']:.2f} -> "
        f"{turma['Media_Pos']:.2f} "
        f"(ganho {turma['Ganho_Medio']:+.2f})"
    )


print("\nQuestões com maior ganho geral:")

for _, linha in resultado_questoes.head(3).iterrows():

    print(
        f"- {linha['Questao']} - "
        f"{linha['Tema']}: "
        f"{linha['Ganho_Medio']:+.2f}"
    )