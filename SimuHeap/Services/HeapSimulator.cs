using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Services
{
    public class HeapSimulator
    {
        public byte[] Memoria { get; }
        public LinkedList<BlocoDeMemoria> Blocos { get; }
        public int TamanhoHeap => Memoria.Length;
        private int proximoId = 1;
        public HeapSimulator(int tamanhoHeap)
        {
            Memoria = new byte[tamanhoHeap];
            Blocos = new LinkedList<BlocoDeMemoria>();

            Resetar();
        }

        public void Resetar()
        {
            Array.Clear(Memoria);
            Blocos.Clear();

            Blocos.AddLast(BlocoDeMemoria.CriarLivre(0, TamanhoHeap, Color.FromArgb(40, 140, 70)));
            proximoId = 1;
        }

        public BlocoDeMemoria Alocar(int tamanhoSolicitado, TiposDeVariaveis tipo, Color cor, AlgoritmosDeAlocacao algoritmo)
        {
            throw new NotImplementedException();
        }

        public bool Liberar(int id)
        {
            throw new NotImplementedException();
        }

        private void DividirBloco() 
        { 
            throw new NotImplementedException(); 
        }

        private void UnirBlocosLivres()
        {
            throw new NotImplementedException();
        }

        private int GerarNovoId() 
        { 
            return proximoId++; 
        }
    }
}
