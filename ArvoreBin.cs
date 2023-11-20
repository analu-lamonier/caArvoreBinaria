using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace caArvoreBinaria
{
    internal class ArvoreBin
    {
        // atributos 
        private NohArvore root;

        // métodos
        public ArvoreBin()
        {
            root = null;
        }

        public bool isEmpty()
        {
            if (root == null)
                return true;
            else
                return false;
        }

        public void inserir(int n) // aridade 1
        {
            inserir(this.root, n); // aridade 2
        }


        public void inserir(NohArvore node, int valor) // aridade 2
        {                               // 10 e 15
            if (this.root == null)
            {
                this.root = new NohArvore(valor);
            }
            else
            {
                if (valor < node.Valor)
                {
                    if (node.NoEsquerda != null)
                    {
                        inserir(node.NoEsquerda, valor);
                    }
                    else // subarvore da esquerda está vazia
                    {
                        //Se nodo esquerdo vazio insere o novo no aqui 
                        node.NoEsquerda = new NohArvore(valor);
                    }
                }
                else if (valor > node.Valor)
                {
                    //Se tiver elemento no no direito continua a busca 
                    if (node.NoDireita != null)
                    {
                        inserir(node.NoDireita, valor);
                    }
                    else // subárvore da direita está vazia
                    {
                        //Se nodo direito vazio insere o novo no aqui 
                        node.NoDireita = new NohArvore(valor);
                    }
                }
            }

        }

        public void imprimirArvore()
        {
            if (this.root == null)
                Console.WriteLine("Árvore vazia");
            else
                imprimirArvore(this.root);
        }

        public void imprimirArvore(NohArvore node)
        {
            if (node.NoEsquerda != null)
            {
                imprimirArvore(node.NoEsquerda);
            }

            Console.WriteLine("           Noh: " + node.Valor);

            if (node.NoDireita != null)
            {
                imprimirArvore(node.NoDireita);
            }

        }

        public void remover(int n)
        {
            remover(this.root, n);
        }


        public NohArvore remover(NohArvore node, int n)
        {
            if (node == null)
            {
                Console.WriteLine("Número " + n +" não encontrado");
                return null;
            }
            else
            {
                if (node.Valor == n) //caso o nó a ser removido seja a raiz (quando encontrar o noh
                {
                    if (node.NoEsquerda == null & node.NoDireita == null)//noh sem filhos
                    {
                        return null;
                    }
                    else if (node.NoEsquerda != null & node.NoDireita != null) //noh com 2 filhos
                    {
                        NohArvore nodeAux2 = node.NoEsquerda; //percorrendo a subarvore a esquerda do noh q quer remover ate achar o ultimo elemento a direita
                        while (nodeAux2.NoDireita != null)
                        {
                            nodeAux2 = nodeAux2.NoDireita;
                        }
                        node.Valor = nodeAux2.Valor; //fazendo a troca do valor a ser removido pelo noh folha mais a direita da subarvore da esquerda
                        nodeAux2.Valor = n;
                        //agora é feita a remoção como se fosse um nó sem filho ou um nó com 1 filho (chama a função de novo)
                        node.NoEsquerda = remover(node.NoEsquerda, n);
                    }
                    else //noh com 1 filho 
                    {
                        NohArvore nodeAux = new NohArvore();
                        if (node.NoEsquerda != null)
                        {
                            nodeAux = node.NoEsquerda;
                        }
                        else
                        {
                            nodeAux = node.NoDireita;
                        }
                        return nodeAux;
                    }
                }
                else if (n < node.Valor)
                {
                    node.NoEsquerda = remover(node.NoEsquerda, n); //isso faz que quando remover o noh ele seja atualizado para nulo
                }
                else if (n > node.Valor)
                {
                    node.NoDireita = remover(node.NoDireita, n);
                }

                return node;
            }

        }
        public int alturaArvore()
        {
            return alturaArvore(root);
        }

        public int alturaArvore(NohArvore node) 
        {

            if (isEmpty())
            {
                Console.WriteLine("Arvore Vazia");
                return 0;
            }
            else if (node == null)
            {
                return -1;
            }
            else
            {

                int esq = alturaArvore(node.NoEsquerda);
                int dir = alturaArvore(node.NoDireita);

                return Math.Max(esq, dir) + 1;

            }
            
        }

        public int qtdNohs()
        {
            return qtdNohs(root);
        }

        public int qtdNohs(NohArvore node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + qtdNohs(node.NoEsquerda) + qtdNohs(node.NoDireita);
            }
        }
        

        public int qtdFolhas()
        {
            return qtdFolhas(root);
        }

        public int qtdFolhas(NohArvore node)
        {
            if (node == null)
            {
                return 0;
            }
            else if (node.NoEsquerda == null & node.NoDireita == null) //Noh Folha
            {
                return 1;
            }
            else
            {
                return qtdFolhas(node.NoEsquerda) + qtdFolhas(node.NoDireita);
            }
            
        }

        public bool saoIguais(ArvoreBin arvore2)
        {
            return saoIguais(root, arvore2.root);
        }


        public bool saoIguais(NohArvore node1, NohArvore node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            return (node1.Valor == node2.Valor) && saoIguais(node1.NoEsquerda, node2.NoEsquerda) && saoIguais(node1.NoDireita, node2.NoDireita);           
        }

    }
}
