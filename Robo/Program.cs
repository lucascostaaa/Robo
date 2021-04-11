using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo
{
    // A área escolhida para análise é curiosamente retangular e os robôs devem andar por ela com suas câmeras ligadas coletando todo tipo de informação.A posição de um
    // robô é representada por uma combinação de coordenadas X e Y e também uma letra representando a direção que ele está olhando.A área é dividida em um grid para
    //simplificar a navegação.Um exemplo de posição poderia ser: 0,0, N, significando o robô está na parte inferior esquerda com a face para o norte. Use as orientações: N
    // = norte, S = sul, L = leste, O = oeste.
    //Para controlar o robô, a AEB envia simples strings com os comandos. Letras possíveis são: E, D e M.As letras E e D fazem o robô virar 90 graus para esquerda e direita
    // respectivamente, sem sair do lugar.A letra M significa se mover uma posição no grid para frente, mantendo a mesma direção. 
    // Assuma que mover o robô para frente, significa mover sua posição de (X, Y) para (X, Y+1). Por exemplo, um robô na posição(0,0) com a face para o norte, ao se mover
    // uma posição, vai parar em(0,1). 

    class Program
    {

        static void Main(string[] args)
        {
            int valorX, valorY, soma = 0;

            string comandos, direcao;

            // INSERINDO OS DADOS
            valorX = InserindoValorX();
            valorY = InserindoValorY();
            direcao = InserindoPosicao();
            VisualizarDirecao(direcao);
            comandos = InserindoComandos();

            VerificandoCaixasDeCaracteres(comandos);
            soma = DirecaoNorte(valorY, soma, direcao);


            


            Console.WriteLine("{0} {1} {2}", soma, direcao, comandos);


            Console.ReadKey(true);



        }

        private static int DirecaoNorte(int valorY, int soma, string direcao)
        {
            if (direcao == "n" || direcao == "N")

            {
                soma = valorY + 1;
            }

            return soma;
        }

        private static void VerificandoCaixasDeCaracteres(string comandos)
        {
            if ((comandos == "E" || comandos == "e") && (comandos == "D" || comandos == "d") && (comandos == "M" || comandos == "n"))
            {
            }
        }

        private static string InserindoComandos()
        {
            string comandos;
            Console.WriteLine("Digite os comando, [E = ESQUERDA ], [D = DIREITA ], [M = MOVER]");
            comandos = Console.ReadLine();
            return comandos;
        }

        private static void VisualizarDirecao(string direcao)
        {
            if (direcao == "N" || direcao == "n")
            {
            }
            else if (direcao == "S" || direcao == "s")
            {
            }
            else if (direcao == "L" || direcao == "l")
            {
            }
            else if (direcao == "O" || direcao == "o")
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Posição incorreta, Tente novamente");
                Console.ReadLine();
                Console.ResetColor();

            }
        }

        private static string InserindoPosicao()
        {
            string direcao;
            Console.WriteLine("Digite a poisição, sendo [N = Norte], [S = Sul], [L = Leste], [O = Oeste]");
            direcao = Console.ReadLine();
            return direcao;
        }

        private static int InserindoValorY()
        {
            int valorY;
            Console.WriteLine("Digite o Valor Y: ");
            valorY = int.Parse(Console.ReadLine());
            return valorY;
        }

        private static int InserindoValorX()
        {
            int valorX;
            Console.WriteLine("Digite o valor X: ");
            valorX = int.Parse(Console.ReadLine());
            return valorX;
        }
    }
}

