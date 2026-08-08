using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuHeap.Data;

namespace SimuHeap.Models
{
    public class BlocoDeMemoria
    {
        public int Id { get; internal set; }
        public EstadoBlocoMemoria EstadoBlocoMemoria { get; internal set; }
        public int EnderecoInicio { get; internal set; }
        public int TamanhoPayload { get; internal set; }
        public int TamanhoPadding { get; internal set; }
        public TiposDeVariaveis? TipoDado { get; internal set; }
        public Color Cor { get; internal set; }
        public int TamanhoHeader => Configuracoes.TAM_HEADER;
        public int TamanhoFooter => Configuracoes.TAM_FOOTER;
        public int TamanhoTotal => TamanhoHeader + TamanhoPayload + TamanhoPadding + TamanhoFooter;
        public int EnderecoFim => EnderecoInicio + TamanhoTotal - 1;
        public int EnderecoHeader => EnderecoInicio;
        public int EnderecoPayload => EnderecoHeader + TamanhoHeader;
        public int EnderecoPadding => EnderecoPayload + TamanhoPayload;
        public int EnderecoFooter => EnderecoPadding + TamanhoPadding;
        public bool EstaLivre => EstadoBlocoMemoria == EstadoBlocoMemoria.Livre;

        public BlocoDeMemoria() { }

        public static BlocoDeMemoria CriarOcupado(int id, int enderecoInicio, int tamanhoSolicitado, TiposDeVariaveis tipoDado, Color cor)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "O ID deve ser maior que zero.");
            }

            if (enderecoInicio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(enderecoInicio), "O endereço de início não pode ser negativo.");
            }

            if (tamanhoSolicitado <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tamanhoSolicitado), "O tamanho solicitado deve ser maior que zero.");
            }

            return new BlocoDeMemoria
            {
                Id = id,
                EstadoBlocoMemoria = EstadoBlocoMemoria.Ocupado,
                EnderecoInicio = enderecoInicio,
                TamanhoPayload = tamanhoSolicitado,
                TamanhoPadding = Configuracoes.CalcularPadding(tamanhoSolicitado),
                TipoDado = tipoDado,
                Cor = cor
            };
        }

        public static BlocoDeMemoria CriarLivre(int enderecoInicio, int tamanhoTotal, Color cor)
        {
            if (enderecoInicio < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(enderecoInicio));
            }

            int tamanhoMetadados =
                Configuracoes.TAM_HEADER +
                Configuracoes.TAM_FOOTER;

            if (tamanhoTotal < tamanhoMetadados)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(tamanhoTotal),
                    "O bloco livre não comporta os metadados mínimos.");
            }

            return new BlocoDeMemoria
            {
                Id = -1,
                EstadoBlocoMemoria = EstadoBlocoMemoria.Livre,
                EnderecoInicio = enderecoInicio,

                // O espaço disponível do bloco livre é representado
                // como payload, sem padding adicional.
                TamanhoPayload = tamanhoTotal - tamanhoMetadados,
                TamanhoPadding = 0,

                TipoDado = null,
                Cor = cor
            };
        }

        public static BlocoDeMemoria CriarOcupadoComBlocoInteiro(int id, int enderecoInicio, int tamanhoSolicitado, int tamanhoTotalDisponivel, TiposDeVariaveis tipoDado, Color cor)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "O ID deve ser maior que zero.");
            }

            if (enderecoInicio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(enderecoInicio), "O endereço de início não pode ser negativo.");
            }

            if (tamanhoSolicitado <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tamanhoSolicitado), "O tamanho solicitado deve ser maior que zero.");
            }

            int tamanhoFixo = Configuracoes.TAM_HEADER + tamanhoSolicitado + Configuracoes.TAM_FOOTER;
            int padding = tamanhoTotalDisponivel - tamanhoFixo;

            if(padding < 0)
            {
                throw new ArgumentException("O bloco disponível não comporta a alocação.");
            }

            return new BlocoDeMemoria
            {
                Id = id,
                EstadoBlocoMemoria = EstadoBlocoMemoria.Ocupado,
                EnderecoInicio = enderecoInicio,
                TamanhoPayload = tamanhoSolicitado,
                TamanhoPadding = padding,
                TipoDado = tipoDado,
                Cor = cor
            };
        }

        public RegiaoBlocoMemoria ObterRegiao(int endereco)
        {
            if (endereco < EnderecoInicio || endereco > EnderecoFim)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(endereco),
                    "O endereço não pertence ao bloco.");
            }

            if (EstaLivre)
            {
                return RegiaoBlocoMemoria.Livre;
            }

            if (endereco < EnderecoPayload)
            {
                return RegiaoBlocoMemoria.Header;
            }

            if (endereco < EnderecoPadding)
            {
                return RegiaoBlocoMemoria.Payload;
            }

            if (endereco < EnderecoFooter)
            {
                return RegiaoBlocoMemoria.Padding;
            }

            return RegiaoBlocoMemoria.Footer;
        }

        public bool ContemEndereco(int endereco)
        {
            return endereco >= EnderecoInicio &&
                   endereco <= EnderecoFim;
        }

        public override string ToString()
        {
            return EstaLivre
                ? $"Livre: {EnderecoInicio}-{EnderecoFim} " +
                  $"({TamanhoTotal} bytes)"
                : $"Bloco #{Id}: {EnderecoInicio}-{EnderecoFim} " +
                  $"({TamanhoTotal} bytes)";
        }

        public BlocoDeMemoria Clonar()
        {
            return new BlocoDeMemoria
            {
                Id = this.Id,
                EstadoBlocoMemoria = this.EstadoBlocoMemoria,
                EnderecoInicio = this.EnderecoInicio,
                TamanhoPayload = this.TamanhoPayload,
                TamanhoPadding = this.TamanhoPadding,
                TipoDado = this.TipoDado,
                Cor = this.Cor
            };
        }
    }
}
