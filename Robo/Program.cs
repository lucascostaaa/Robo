using System;


namespace Robo
{
    class Program
    {
        static void Main(string[] args)
        {

            //A área escolhida para análise é curiosamente retangular e os robôs devem andar por ela com suas câmeras ligadas coletando todo tipo de informação. A posição de um
            //robô é representada por uma combinação de coordenadas X e Y e também uma letra representando a direção que ele está olhando. A área é dividida em um grid para
            //simplificar a navegação.Um exemplo de posição poderia ser: 0,0,N, significando o robô está na parte inferior esquerda com a face para o norte. Use as orientações: N
            //= norte, S = sul, L = leste, O = oeste.
            //Para controlar o robô, a AEB envia simples strings com os comandos.Letras possíveis são: E, D e M.As letras E e D fazem o robô virar 90 graus para esquerda e direita
            //respectivamente, sem sair do lugar.A letra M significa se mover uma posição no grid para frente, mantendo a mesma direção. 
            //Assuma que mover o robô para frente, significa mover sua posição de(X, Y) para(X, Y + 1).Por exemplo, um robô na posição(0,0) com a face para o norte, ao se mover
            //uma posição, vai parar em(0,1)

            int valorX, valorY = 0;
            string direcao = "";
            string[] andar = new string[1];
            int opcao = 0;



            {

                while (opcao != 2)
                {
                    valorX = RecebeValorX();

                    valorY = RecebeValorY();

                    direcao = RecebeasCoordenadas();

                    if (direcao != "N" && direcao != "S" && direcao != "L" && direcao != "O"
                       && direcao != "n" && direcao != "s" && direcao != "l" && direcao != "o")

                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Voce digitou uma direção que não esta no sistema, tente novamente");
                        Console.ReadLine();
                        Console.Clear();

                        continue;

                    }

                    for (int i = 0; i < andar.Length; i++)
                    {

                        Console.WriteLine("Digite os comandos, [D = DIREITA], [E = ESQUERDA], [M = MOVER]");
                        andar[i] = Console.ReadLine();

                        string auxiliar = andar[i];

                        // char para fazer o caminho percorrido
                        char[] caminho = auxiliar.ToCharArray();

                        //FOR = Contadores a serem repetidos
                        contadorFor(ref valorX, ref valorY, direcao, caminho);

                        // REF indica que um argumento é passado por referência, não por valor. A palavra-chave ref torna o parâmetro formal um alias para o argumento,
                        // que deve ser uma variável. Em outras palavras, qualquer operação no parâmetro é feita no argumento.

                        Console.WriteLine();

                        // CONCATENAÇÃO DOS VALORES E DA ROTA FINAL DO ROBO
                        string resuldaoFinal = $"{valorX} {valorY} {direcao}";
                        Console.WriteLine(resuldaoFinal);
                        Console.ReadLine();
                        Console.Clear();

                        opcao++;
                    }
                }
            }
        }

        private static string RecebeasCoordenadas()
        {
            string direcao;
            Console.WriteLine("Digite a direção, [N - NORTE],[S = SUL],[L = LESTE],[O - OESTE]");
            direcao = Console.ReadLine();
            return direcao;
        }

        private static int RecebeValorY()
        {
            int valorY;
            Console.WriteLine("Digite o valor de Y");
            valorY = Convert.ToInt32(Console.ReadLine());
            return valorY;
        }

        private static int RecebeValorX()
        {
            int valorX;
            Console.WriteLine("Digite o valor de X");
            valorX = Convert.ToInt32(Console.ReadLine());
            return valorX;
        }

        private static void contadorFor(ref int valorX,ref int valorY,string direcao, char[] caminho)
        {
            for (int contador = 0; contador < caminho.Length; contador++)
            {
                if (caminho[contador] == 'M' || caminho[contador] == 'm')
                {
                    {
                        somaLocalizacao(ref valorX, ref valorY, direcao);

                    }
                }

                if (caminho[contador] == 'D' || caminho[contador] == 'd')
                {
                    direcao = moveDireita(direcao);
                }

                if (caminho[contador] == 'E' || caminho[contador] == 'e')
                {
                    direcao = moveEsquerda(direcao);
                }
            }
        }

        private static void somaLocalizacao(ref int valorX, ref int valorY, string direcao)
        {
            if (direcao == "N" || direcao == "n")
            {
                valorY++;
            }
            else if (direcao == "S" || direcao == "s")

            {
                valorY--;
            }

            else if (direcao == "L" || direcao == "l")
            {
                valorX++;
            }

            else if (direcao == "O" || direcao == "o")
            {
                valorX--;
            }
        }

        private static string moveDireita(string direcao)
        {
            if (direcao == "N" || direcao == "n")
            {
                direcao = "L";

            }
            else if (direcao == "S" || direcao == "s")
            {
                direcao = "O";

            }
            else if (direcao == "L" || direcao == "l")
            {
                direcao = "S";

            }
            else if (direcao == "O" || direcao == "o")
            {
                direcao = "N";
            }

            return direcao;
        }

        private static string moveEsquerda(string direcao)
        {
            if (direcao == "N" || direcao == "n")
            {
                direcao = "O";

            }
            else if (direcao == "S" || direcao == "s")
            {
                direcao = "L";

            }
            else if (direcao == "L" || direcao == "l")
            {
                direcao = "N";

            }
            else if (direcao == "O" || direcao == "o")
            {
                direcao = "S";
            }

            return direcao;
        }


    }

}