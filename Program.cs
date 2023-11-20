using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ======== Arvore Binaria ======= ");


            ArvoreBin arvorinha = new ArvoreBin();
         
            arvorinha.inserir(10);
            arvorinha.inserir(920);
            arvorinha.inserir(360);
            arvorinha.inserir(140);
            arvorinha.inserir(500);
            arvorinha.inserir(1);
            arvorinha.inserir(740);

            Console.WriteLine("\nImprimindo arvorinha: \n");
            arvorinha.imprimirArvore();

            Console.WriteLine("\nAltura: " + arvorinha.alturaArvore() + "  Quantidade de nós: " + arvorinha.qtdNohs() + "  Quantidade de folhas: " + arvorinha.qtdFolhas() + "\n");


            Console.WriteLine("......Removendo números..........\n");
            arvorinha.remover(30);
            arvorinha.remover(360);
            arvorinha.remover(10);
            arvorinha.remover(1);

            Console.WriteLine("\nImprimindo arvorinha após remoção de números: \n");
            arvorinha.imprimirArvore();
            

            Console.WriteLine("\nAltura: " + arvorinha.alturaArvore() + "  Quantidade de nós: " + arvorinha.qtdNohs() + "  Quantidade de folhas: " + arvorinha.qtdFolhas());
         


            ArvoreBin arvorinha2 = new ArvoreBin();
            arvorinha2.inserir(10);
            arvorinha2.inserir(920);
            arvorinha2.inserir(360);
            arvorinha2.inserir(140);
            arvorinha2.inserir(500);
            arvorinha2.inserir(1);
            arvorinha2.inserir(740);

            Console.WriteLine("\nImprimindo arvorinha 2: \n");
            arvorinha2.imprimirArvore();

            Console.WriteLine("\nAltura: " + arvorinha2.alturaArvore() + "  Quantidade de nós: " + arvorinha2.qtdNohs() + "  Quantidade de folhas: " + arvorinha2.qtdFolhas());


            Console.WriteLine("\n\nAs árvores são iguais? " + arvorinha.saoIguais(arvorinha2) + "\n");

            Console.WriteLine("......Removendo números..........\n");
            arvorinha2.remover(30);
            arvorinha2.remover(360);
            arvorinha2.remover(10);
            arvorinha2.remover(1);

            Console.WriteLine("\nImprimindo arvorinha 2 após remoção de números: \n");
            arvorinha2.imprimirArvore();


            Console.WriteLine("\nAltura: " + arvorinha2.alturaArvore() + "  Quantidade de nós: " + arvorinha2.qtdNohs() + "  Quantidade de folhas: " + arvorinha2.qtdFolhas());


            Console.WriteLine("\n\nAs árvores são iguais? " + arvorinha.saoIguais(arvorinha2));


            Console.Read();

        }
    }
}
