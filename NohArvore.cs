using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreBinaria
{
    internal class NohArvore
    {
        // atributos
        private int valor;
        private NohArvore noEsquerda; // sae
        private NohArvore noDireita;  // sad

        // métodos
        public NohArvore() { }

        public NohArvore(int _valor)
        {
            noEsquerda = null;
            this.valor = _valor;
            noDireita = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal NohArvore NoEsquerda { get => noEsquerda; set => noEsquerda = value; }
        internal NohArvore NoDireita { get => noDireita; set => noDireita = value; }
    }
}
