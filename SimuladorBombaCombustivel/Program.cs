using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBombaCombustivel
{
    internal class Program
    {
        static BombaDeCombustivel bomba1 = new BombaDeCombustivel("Gasolina", 3, 1000);
        static void Main(string[] args)
        {
            // Emanuel e Henrique 2A informatica

            int opc;
            do
            {
                opc = 0;
                Console.WriteLine("\t\t---Simulador Bomba Combustivel---\n\n");
                bomba1.MostarInformacoesBomba();
                Console.Write("\n[1] Abastecer por Litro\n" +
                    "[2] Abastecer por valor\n" +
                    "[3] Alterar valor de combustivel\n" +
                    "[4] ALterar tipo combustivel\n" +
                    "[5] Alterar quantidade de combustivel\n" +
                    "[6] Sair\n" +
                    "\nQual opção deseja execultar: ");
                opc = int.Parse(Console.ReadLine());

                if (opc > 0)
                {
                    switch (opc)
                    {
                        case 1:
                            Console.Write("Informe a quantidade que deseja abastecer: ");
                            double Litro = double.Parse(Console.ReadLine());
                            if (Litro > 0)
                            {
                                if (Litro <= bomba1.QuantidadeCombustivel)
                                {
                                    bomba1.AbastecerPorLitro(Litro);
                                }
                                else
                                {
                                    Console.WriteLine("A quantidade que deseja abastecer exede a quantidade disponivel na bomba!");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("O valor informado é negativo!");
                                Console.ReadKey();
                            }
                            break;

                        case 2:
                            Console.Write("Informe o valor que deseja abastecer: ");
                            double valorAbastec = double.Parse(Console.ReadLine());
                            if (valorAbastec > 0)
                            {
                                if (valorAbastec / bomba1.ValorLitro <= bomba1.QuantidadeCombustivel)
                                {
                                    bomba1.AbastecerPorValor(valorAbastec);
                                }
                                else
                                {
                                    Console.WriteLine("A quantidade que deseja abastecer exede a quantidade disponivel na bomba!");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("O valor informado é negativo!");
                                Console.ReadKey();
                            }
                            
                            break;

                        case 3:
                            Console.Write("Informe o novo valor do combustivel: ");
                            double nvValor = double.Parse(Console.ReadLine());
                            if (nvValor > 0)
                            {
                                bomba1.AlterarValor(nvValor);
                            }
                            else
                            {
                                Console.WriteLine("O valor informado é negativo!");
                                Console.ReadKey();
                            }
                            break;

                        case 4:
                            Console.Write("Informe o novo tipo de combustivel: ");
                            string nvTipo = Console.ReadLine();
                            bomba1.AlterarCombustivel(nvTipo);
                            break;

                        case 5:
                            Console.Write("Informe a nova quantidade de combustivel que a maquina possuirá: ");
                            double nvQuantidade = double.Parse(Console.ReadLine());
                            if (nvQuantidade > 0)
                            {
                                bomba1.AlterarQuantidadeDeCombustivel(nvQuantidade);
                            }
                            else
                            {
                                Console.WriteLine("O valor informado é negativo!");
                                Console.ReadKey();
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção é menor que zero!");
                    Console.ReadKey();
                }
                Console.Clear();
            } while (opc != 6);

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
    }
}
