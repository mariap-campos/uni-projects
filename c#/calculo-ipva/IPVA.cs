/*Programa para cálculo do IPVA.
 Programador(es): Maria Paula F. Campos
 RGM: 11192100887
 Disciplina: Intro. Desenvolvimento de Software
 Data: 14/11/2019 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC_3
{
    class Program
    {
        //Metodo para determinar a fração se o carro for novo 
        static double Fracao(double e)
        {
            if (e == 1)
            {
                int mes;
                Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                Console.Write("Por Favor, indique o número correspondente ao mês da compra (1 a 12): ");
                mes = int.Parse(Console.ReadLine());

                while (mes < 1 || mes > 12)
                {
                    Console.Clear();
                    Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                    Console.Write("NÚMERO INVÁLIDO. Por Favor, indique o número correspondente ao mês da compra (1 a 12): ");
                    mes = int.Parse(Console.ReadLine());
                }

                return ((double)(12 - mes + 1) / 12);
            }
            else
                return (12 / 12);
        }
        //metodo para determinar o desconto
        static double Desconto(double c)
        {
            if (c == 2)
                return (0.7);
            else
                return (1);
        }
        //metodo para determinar a aliquota
        static void CalcAliquota(double categ, out double a)
        {
            if (categ == 1)
                a = 0.04;
            else
                if (categ == 2)
                a = 0.03;
            else
                if (categ == 3 || categ == 4)
                a = 0.02;
            else
                a = 0.01;

        }

        static void Main(string[] args)
        {

            double valor_veiculo, fracao, desconto, aliquota, ipva;
            int escolha, categoria, combustivel, estado;

            //ciclo de repetição para calcular outro ipva ou sair do programa
            do
            {
                Console.Clear();
                Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                //entrada do valor do veiculo
                Console.Write("Bem vindo á calculadora digital de IPVA. \n\nPara começar, por favor, insira o valor do veículo: BRL ");
                valor_veiculo = double.Parse(Console.ReadLine());

                //validação do valor de entrada
                while (valor_veiculo < 2000 || valor_veiculo > 10000000)
                {
                    Console.Clear();
                    Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                    Console.Write("Bem vindo á calculadora digital de IPVA. \n\nO valor digitado é INVALÍDO, por favor, insira um valor válido (entre BRL 2000 e BRL 10 milhões): BRL ");
                    valor_veiculo = double.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                Console.WriteLine("O valor do carro é de {0}.", valor_veiculo);
                Console.Write("\nPor favor, Informe a categoria do veículo: \n\n CATEGORIA 1 = Automóveis, veículos de uso misto e utilitários. \n CATEGORIA 2 = Caminhonetes de carga (pick-ups) e furgão." +
                    "\n CATEGORIA 3 = Automóveis, veículos de uso misto e utilitários com autorização para transporte público (táxi, escolar) " +
                    "\n CATEGORIA 4 = Motocicletas e similares. \n CATEGORIA 5 = Veículos de locadoras (pessoa jurídica). \n CATEGORIA 6 = Ônibus, micro ônibus, caminhão, caminhão trator.");
                Console.Write("\n\nDigite o número da categoria: ");
                //entrada categoria do veiculo
                categoria = int.Parse(Console.ReadLine());

                //validação de entrada
                while (categoria < 1 || categoria > 6)
                {

                    Console.Write("OPÇÃO INVÁLIDA. Por favor, digita uma das opções listadas no menu acima: ");
                    categoria = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                Console.WriteLine("\nPor favor, indique o tipo de combustível usado.");
                Console.WriteLine(" 1 = Gasolina \n 2 = Etanol \n 3 = Diesel \n 4 = GVN \n 5 = Flex");
                Console.Write("Digite a opção: ");
                //entrada tipo de combustivel
                combustivel = int.Parse(Console.ReadLine());

                //validação da entrada
                while (combustivel < 1 || combustivel > 5)
                {

                    Console.Write("OPÇÃO INVÁLIDA. Por favor, digita uma das opções listadas no menu acima: ");
                    combustivel = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                Console.WriteLine("\n\nO veiculo em questão é: \n 1 = NOVO \n 2 = USADO");
                Console.Write("\nDigite a opção:");
                //entrada estado do veiculo (usado ou novo)
                estado = int.Parse(Console.ReadLine());

                //validação da entrada
                while (estado < 1 || estado > 2)
                {
                    Console.Clear();
                    Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                    Console.WriteLine("\n\nO veiculo em questão é: \n 1 = NOVO \n 2 = USADO");
                    Console.Write("\nOPÇÃO INVÁLIDA. Por favor, digita uma das opções listadas no menu acima: ");
                    estado = int.Parse(Console.ReadLine());
                }

                //chamada dos metodos
                Console.Clear();
                fracao = Fracao(estado);
                desconto = Desconto(combustivel);
                CalcAliquota(categoria, out aliquota);

                Console.Clear();
                Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                ipva = valor_veiculo * aliquota * fracao * desconto;
                //saida do valor total do ipva
                Console.WriteLine("\n\nO preço total do IPVA do veículo é de:  {0:f2}", ipva);
                Console.WriteLine("\n 1 = REALIZAR CÁLCULO DO IPVA DE OUTRO VEÍCULO \n 2 = SAIR");
                //opção do usuario de realizar outro calculo ou sair do programa
                escolha = int.Parse(Console.ReadLine());
                while (escolha < 1 || escolha > 2)
                {
                    Console.WriteLine("\n════════════════════ CÁLCULO DO IPVA ════════════════════");
                    Console.WriteLine("\n 1 = REALIZAR CÁLCULO DO IPVA DE OUTRO VEÍCULO \n 2 = SAIR");
                    Console.Write("OPÇÃO INVÁLIDA. Por favor, escolha uma das opções acima: ");
                    escolha = int.Parse(Console.ReadLine());
                }

            }
            while (escolha == 1);
        }
    }
}
