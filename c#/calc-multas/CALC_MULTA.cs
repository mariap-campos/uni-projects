/* ATIVIDADE 2 
FUNÇÃO: Calcular o valor da multa baseado no quanto a velocidade da pista foi excedida
Programadora: Maria Paula F. Campos
Data:14/09/2019*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTAS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis.
            double limite_veloc, veloc_aferida, veloc_considerada;
            //É preciso associar valor as variaveis abaixo ou elas não são iniciadas.
            double porcentagem = 0;
            double valor_multa = 0;

            //Entrada de dados: Velocidade Aferida.
            Console.WriteLine("\n\nCALCULE O VALOR DE SUA MULTA POR EXCESSO DE VELOCIDADE. " +
                "\nPara dar ínicio, por favor indique, em km/hr, a velocidade aferida: ");
            veloc_aferida = double.Parse(Console.ReadLine());
            Console.Clear();

            //Testar se a velocidade dada pelo usuário é aceitavel (positiva e menor que 400km/hr).
            if ((veloc_aferida > 0) && (veloc_aferida < 400))
            {
                //Caso a velocidade seja menor que 100, a velocidade considerada é (VA-7).
                if (veloc_aferida <= 100)
                {
                    veloc_considerada = (double)veloc_aferida - 7;

                }
                //Caso a velocidade sem maior que 100, a velocidade considerada será (VA - (VA*0.07).
                else
                {
                    veloc_considerada = veloc_aferida - (veloc_aferida * 0.07);
                }

                //Determinada a velocidade considerada, aqui temos outra entrada de dados: Limite de velocidade da pista.
                Console.Write("\n\n\nAgora digite, em km/hr, o limite de velocidade de pista: ");
                limite_veloc = double.Parse(Console.ReadLine());
                porcentagem = (veloc_considerada - limite_veloc) * (100 / limite_veloc);
                Console.Clear();

                //Caso o usuario não tenha excedido em nada o limite da pista, o valor da multa será:
                if (porcentagem < 0)
                {
                    valor_multa = 0.00;
                }
                else
                {
                    //Caso o usuario tenha excedido o limite da pista em menos de 20%, o valor da multa será:
                    if (porcentagem <= 20)
                    {
                        valor_multa = 130.16;
                    }
                    else
                    {
                        //Caso o usuario tenha excedido o limite da pista entre de 20% e 50%, o valor da multa será:
                        if ((porcentagem > 20) && (porcentagem <= 50))
                        {
                            valor_multa = 195.23;
                        }
                        //Na situação contrária as especificadas acima (ultrapssou em mais de 50%), o valor da multa será:
                        else
                        {
                            valor_multa = 880.41;
                        }
                    }
                }

            }
            else
            {
                Console.Write("\n\n\nA velocidade digitada é inválida. Por favor tente novamente.");
            }
            //Aqui temos a saida em função das variaveis porcentagem e valor_multa, definidas anteriormente.
            Console.Write("\n\n\nVoce ultrapassou o limite da velocidade em {0:F2}%. \nO valor da sua multa será de: BRL {1:F2}.", porcentagem, valor_multa);
            Console.ReadKey();

        }
    }
}
