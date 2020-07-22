/*Programa para conversão de medidas, moedas ou peso.
 Programador(a): Maria P. Campos
 Data: 29/10/2019 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    class Program
    {
        static void Main(string[] args)
        {

            //DECLARAÇÃO DE VARIAVEIS
            int type_conversor, type_conversor2, type_conversor3;
            double value, converted_value, cotacao;


            do
            {
                // MENU PRINCIPAL DO PROGRAMA, entrada da escolha do usuário
                Console.WriteLine("\n\n════════════════════ BEM VINDO ao menu principal do CONVERSOR ════════════════════ \nPara começar, escolha a opção do tipo de conversor que deseja utilizar. \n\n 1 - CONVERSOR DE MEDIDAS \n 2 - CONVERSOR DE MOEDAS \n 3 - CONVERSOR DE PESO \n 4 - SAIR");
                Console.Write("\nDigite o número da opção desejada: ");
                type_conversor = int.Parse(Console.ReadLine());
                Console.Clear();

                //VALIDAÇÃO DE ENTRADA, O PROGRAMA NÃO AVANÇA SE O USUÁRIO NÃO DIGITAR UM NÚMERO VÁLIDO
                while (type_conversor < 1 || type_conversor > 4)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n════════════════════ BEM VINDO ao menu principal do CONVERSOR ════════════════════ \nPara começar, escolha a opção do tipo de conversor que deseja utilizar. \n\n 1 - CONVERSOR DE MEDIDAS \n 2 - CONVERSOR DE MOEDAS \n 3 - CONVERSOR DE PESO \n 4 - SAIR");
                    Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                    type_conversor = int.Parse(Console.ReadLine());
                }

                //Utilização do switch para ler a escolha do usuário no menu principal
                Console.Clear();
                switch (type_conversor)
                {

                    case 1:

                        do
                        {
                            //SEGUNDO MENU - CONVERSOR DE MEDIDAS, entrada da escolha do usuário
                            Console.WriteLine("\n\n════════════════════ Voce escolheu o CONVERSOR DE MEDIDAS ════════════════════ \nAgora selecione a opção desejada. \n\n 1 - MÉTRICAS \n 2 - VOLUMÉTRICAS \n 3 - VOLTAR AO MENU PRINCIPAL.");
                            Console.Write("\nDigite o número da opção desejada: ");
                            type_conversor2 = int.Parse(Console.ReadLine());

                            //VALIDAÇÃO DE ENTRADA, usuário deve escolher uma das opções dadas (1, 2 ou 3)
                            while (type_conversor2 < 1 || type_conversor2 > 3)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n════════════════════ Voce escolheu o CONVERSOR DE MEDIDAS ════════════════════ \nAgora selecione a opção desejada. \n\n 1 - MÉTRICAS \n 2 - VOLUMÉTRICAS \n 3 - VOLTAR AO MENU PRINCIPAL.");
                                Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                                type_conversor2 = int.Parse(Console.ReadLine());
                                Console.Clear();

                            }

                            Console.Clear();

                            //Utilização de switch para ler a escolha do usuário no segundo menu
                            switch (type_conversor2)
                            {


                                case 1:
                                    //MENU CONVERSOR MÉTRICO, entrada da escolha do usuário
                                    Console.WriteLine("\n\n═════════════════════ CONVERSOR MÉTRICO ════════════════════ \n \n 1 - Metro p/ Centímetro \n 2 - Centímetro p/ Metros \n 3 - VOLTAR AO MENU ANTERIOR");
                                    Console.Write("\nDigite o número da opção desejada: ");
                                    type_conversor3 = int.Parse(Console.ReadLine());
                                    Console.Clear();

                                    //VALIDAÇÃO DE ENTRADA, usuário deve escolher uma das opções dadas (1, 2 ou 3)
                                    while (type_conversor3 < 1 || type_conversor3 > 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n═════════════════════ CONVERSOR MÉTRICO ════════════════════ \n \n 1 - Metro p/ Centímetro \n 2 - Centímetro p/ Metros \n 3 - VOLTAR AO MENU ANTERIOR");
                                        Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                                        type_conversor3 = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    switch (type_conversor3)
                                    {
                                        case 1:
                                            //METROS P/ CENTIMETROS, entrada do valor a ser convertido
                                            Console.Write("\n\n═════════════════════ METROS P/ CENTÍMETROS ════════════════════  \n\nDigite o valor, em metros, a ser convertido para centímetros: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRADA, usuário não pode colocar um número negativo para ser convertido 
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═════════════════════ METROS P/ CENTÍMETROS ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //conta a ser realizada para que ocorra a conversão
                                            converted_value = value * 100;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════ \n\n{0} Metros = {1} Centímetros", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 2:
                                            //CENTIMETROS P/ METROS, entrada do valor a ser convertido
                                            Console.Write("\n\n═════════════════════ CENTÍMETROS P/ METROS ════════════════════  \n\nDigite o valor, em centímetros, a ser convertido para metros: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRADA, usuário não pode colocar um número negativo para ser convertido 
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═════════════════════ METROS P/ CENTÍMETROS ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //conta a ser realizada para que ocorra a conversão
                                            converted_value = value / 100;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════ \n\n{0} Centímetros = {1,2} Metros", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;


                                    }

                                    break;


                                case 2:
                                    //MENU CONVERSOR VOLUMÉTRICO
                                    Console.WriteLine("\n\n═════════════════════ CONVERSOR VOLUMÉTRICO ════════════════════ \n \n 1 - Litro p/ Mililitro \n 2 - Mililitro p/ Litro \n 3 - VOLTAR AO MENU ANTERIOR");
                                    Console.Write("\nDigite o número da opção desejada: ");
                                    type_conversor3 = int.Parse(Console.ReadLine());
                                    Console.Clear();

                                    //VALIDAÇÃO DE ENTRADA, usuário deve escolher uma das opções dadas (1, 2 ou 3)
                                    while (type_conversor3 < 1 || type_conversor3 > 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n═════════════════════ CONVERSOR VOLUMÉTRICO ════════════════════ \n \n 1 - Litro p/ Mililitro \n 2 - Mililitro p/ Litro \n 3 - VOLTAR AO MENU ANTERIOR");
                                        Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                                        type_conversor3 = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }

                                    //Utilização de switch para ler a entrada do usuário
                                    switch (type_conversor3)
                                    {

                                        case 1:
                                            //LITROS P/ MILILITROS, entrada do valor a ser convertido
                                            Console.Write("\n\n═════════════════════ LITROS P/ MILILITROS ════════════════════ \n\nDigite o valor, em litros, a ser convertido para mililitros: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRDA, usuário não pode colocar um número negativo para ser convertido
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═════════════════════ LITROS P/ MILILITROS ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //Conta a ser realizada para que ocorra a conversão
                                            converted_value = value * 1000;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════ \n\n{0} Litros = {1,2} Mililitros", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 2:
                                            //MILILITROS P/ LITROS, entrada do valor a ser convertido
                                            Console.Write("\n\n═════════════════════ MILILITROS P/ LITROS ════════════════════ \n\nDigite o valor, em mililitros, a ser convertido para litros: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRDA, usuário não pode colocar um número negativo para ser convertido
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═════════════════════ MILILITROS P/ LITROS ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //Conta a ser realizada para que ocorra a conversão
                                            converted_value = value / 1000;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════ \n\n{0} Mililitros = {1,2} Litros", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }

                                    break;
                            }
                        }
                        //Ciclo de repeteição enquanto a escolha do usuário não for a opção 3 (Voltar ao menu anterior)
                        while (type_conversor2 != 3);

                        break;


                    case 2:

                        do
                        {

                            //SEGUNDO MENU - CONVERSOR DE MOEDAS
                            Console.WriteLine("\n\n════════════════════ Voce escolheu o CONVERSOR DE MOEDAS ════════════════════. \nAgora selecione a opção desejada. \n\n 1 - DÓLAR \n 2 - EURO \n 3 - VOLTAR AO MENU PRINCIPAL.");
                            Console.Write("\nDigite o número da opção desejada: ");
                            type_conversor2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            //VALIDAÇÃO DE ENTRADA, usuário presia digita uma das opções possiveis (1, 2 ou 3)
                            while (type_conversor2 < 1 || type_conversor2 > 3)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n════════════════════ Voce escolheu o CONVERSOR DE MOEDAS ════════════════════. \nAgora selecione a opção desejada. \n\n 1 - DÓLAR \n 2 - EURO \n 3 - VOLTAR AO MENU PRINCIPAL.");
                                Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                                type_conversor2 = int.Parse(Console.ReadLine());
                                Console.Clear();

                            }

                            Console.Clear();

                            //Utilização de switch para validar a escolha do usuário
                            switch (type_conversor2)
                            {

                                case 1:
                                    //MENU CONVERSOR DOLAR, Entrada do valor da cotação do dólar a ser digitado pelo usuário
                                    Console.Write("\n\n═════════════════════ CONVERSOR PARA DÓLAR ════════════════════ \n\nPor favor, indique a cotação atual do dólar: BRL ");
                                    cotacao = double.Parse(Console.ReadLine());

                                    //VALIDAÇÃO DE ENTRADA, usuário não pode escolher um número negativo para ser convertido
                                    while (cotacao < 0)
                                    {
                                        Console.Clear();
                                        Console.Write("\n\n═════════════════════ CONVERSOR PARA DÓLAR ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite uma cotação maior que zero: ");
                                        cotacao = double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }

                                    //TERCEIRO MENU - CONVERSOR DE DÓLAR
                                    Console.Clear();
                                    Console.Write("\n\n═════════════════════ CONVERSOR PARA DÓLAR ════════════════════");
                                    Console.Write("\n\nAgora escolha uma das opções abaixo:\n \n 1 - Dólar p/ Real \n 2 - Real p/ Dólar \n 3 - VOLTAR AO MENU ANTERIOR");
                                    Console.Write("\n\nDigite o número da opção desejada: ");
                                    type_conversor3 = int.Parse(Console.ReadLine());
                                    Console.Clear();

                                    //VALIDAÇÃO DE ENTRADA, usuário precisa digitar uma opção válida (1, 2 ou 3)
                                    while (type_conversor3 < 1 || type_conversor3 > 3)
                                    {
                                        Console.Clear();
                                        Console.Write("\n\n═════════════════════ CONVERSOR PARA DÓLAR ════════════════════");
                                        Console.WriteLine("\n\nAgora escolha uma das opções abaixo:\n \n 1 - Dólar p/ Real \n 2 - Real p/ Dólar \n 3 - VOLTAR AO MENU ANTERIOR");
                                        Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                                        type_conversor3 = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }

                                    //Switch para ler a escolha do usuário
                                    switch (type_conversor3)
                                    {
                                        case 1:
                                            //DOLAR P/ REAL, entrada do valor a ser convertido
                                            Console.Write("\n\n═════════════════════ DÓLAR P/ REAL ════════════════════  \n\nDigite o valor, em dólares, a ser convertido para reais: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRADA, usuário não pode digitar um número negativo
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═════════════════════ DÓLAR P/ REAL ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //Conversão do valor de entrada
                                            converted_value = value * cotacao;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════\n\n USD {0} = BRL {1,2} ", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 2:
                                            //REAL P/ DOLAR, entrada do valor a ser convertido
                                            Console.Write("\n\n═════════════════════ REAL P/ DÓLAR ════════════════════ \nDigite o valor, em reais, a ser convertido para dólares: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRADA, usuário não pode digitar um número negativo
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═════════════════════ REAL P/ DÓLAR ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //Conversão do valor de entrada
                                            converted_value = value / cotacao;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════\n\n BRL {0} = USD {1,2} ", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }
                                    break;

                                case 2:
                                    //MENU CONVERSOR EURO, Entrada do valor da cotação do euro a ser digitado pelo usuário
                                    Console.Write("\n\n═════════════════════ CONVERSOR PARA EURO ════════════════════ \n \nPor favor, indique a cotação atual do euro: BRL ");
                                    cotacao = double.Parse(Console.ReadLine());

                                    //VALIDAÇÃO DE ENTRADA, usuário não pode digitar um número negativo
                                    while (cotacao < 0)
                                    {
                                        Console.Clear();
                                        Console.Write("\n\n═════════════════════ CONVERSOR PARA DÓLAR ════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite uma cotação maior que zero: ");
                                        cotacao = double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }

                                    //TERCEIRO MENU - CONVERSOR PARA EURO
                                    Console.Clear();
                                    Console.Write("\n\n═════════════════════ CONVERSOR PARA EURO ════════════════════");
                                    Console.Write("\n\nAgora escolha uma das opções abaixo:\n \n 1 - Euro p/ Real \n 2 - Real p/ Euro \n 3 - VOLTAR AO MENU ANTERIOR");
                                    Console.Write("\n\nDigite o número da opção desejada: ");
                                    type_conversor3 = int.Parse(Console.ReadLine());
                                    Console.Clear();

                                    //VALIDAÇÃO DE ENTRADA, usuário precisa digitar uma escolha válida (1, 2 ou 3)
                                    while (type_conversor3 < 1 || type_conversor3 > 3)
                                    {
                                        Console.Clear();
                                        Console.Write("\n\n═════════════════════ CONVERSOR PARA EURO ════════════════════");
                                        Console.Write("\n\nAgora escolha uma das opções abaixo:\n \n 1 - Euro p/ Real \n 2 - Real p/ Euro \n 3 - VOLTAR AO MENU ANTERIOR");
                                        Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                                        type_conversor3 = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }

                                    //Switch para validar a escolha do usuário
                                    switch (type_conversor3)
                                    {
                                        case 1:
                                            //EURO P/ REAL, entrada do valor a ser convertido
                                            Console.Write("\n\n═══════════════════════════ EURO P/ REAL ════════════════════════ \nDigite o valor, em euros, a ser convertido para reais: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRADA, usuário não pode entrar um número negativo para ser convertido
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═══════════════════════════ EURO P/ REAL ════════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //Conversão
                                            converted_value = value * cotacao;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════\n\n EUR {0} = BRL {1,2} ", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 2:
                                            //REAL P/ EURO, entrada do valor a ser convertido
                                            Console.Write("\n\n═══════════════════════════ REAL P/ EURO ════════════════════════ \nDigite o valor, em euros, a ser convertido para reais: ");
                                            value = double.Parse(Console.ReadLine());

                                            //VALIDAÇÃO DE ENTRADA, usuário não pode entrar um número negativo para ser convertido
                                            while (value < 0)
                                            {
                                                Console.Clear();
                                                Console.Write("\n\n═══════════════════════════ REAL P/ EURO ════════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                                value = double.Parse(Console.ReadLine());
                                                Console.Clear();
                                            }

                                            //CONVERSÃO
                                            converted_value = value / cotacao;
                                            Console.Clear();
                                            Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════\n\n BRL {0} = EUR {1,2} ", value, converted_value);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }
                                    break;
                            }

                        }
                        //CICLO DE REPETIÇÃO, até que p usuario escolha a opção 3 (Voltar ao menu anterior)
                        while (type_conversor2 != 3);

                        break;

                    case 3:
                        //MENU CONVERSOR DE PESO
                        Console.WriteLine("\n\n════════════════════ Voce escolheu o CONVERSOR DE PESO ════════════════════. \nAgora selecione a opção desejada. \n\n 1 - Quilo p/ Gramas \n 2 - Gramas p/ Quilos \n 3 - VOLTAR AO MENU PRINCIPAL.");
                        Console.Write("\nDigite o número da opção desejada: ");
                        type_conversor2 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        //VALIDAÇÃO DE ENTRADA, usuário precisa digitar um número entre 1 e 3
                        while (type_conversor2 < 1 || type_conversor2 > 3)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n════════════════════ Voce escolheu o CONVERSOR DE PESO ════════════════════. \nAgora selecione a opção desejada. \n\n 1 - Quilo p/ Gramas \n 2 - Gramas p/ Quilos \n 3 - VOLTAR AO MENU PRINCIPAL.");
                            Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                            type_conversor2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }

                        //switch para ler a escolha do usuário
                        switch (type_conversor2)
                        {
                            case 1:
                                //QUILO P/ GRAMAS, entrada do valor a ser convertido
                                Console.Write("\n\n═══════════════════════════ QUILOS P/ GRAMAS ════════════════════════ \nDigite o valor, em quilos, a ser convertido para gramas: ");
                                value = double.Parse(Console.ReadLine());

                                //VALIDAÇÃO DE ENTRADA, valor a ser convertido não pode ser negativo
                                while (value < 0)
                                {
                                    Console.Clear();
                                    Console.Write("\n\n═══════════════════════════ QUILOS P/ GRAMAS ════════════════════════  \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                    value = double.Parse(Console.ReadLine());
                                    Console.Clear();
                                }

                                //CONVERSÃO
                                converted_value = value * 1000;
                                Console.Clear();
                                Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════\n\n {0} QUILOS = {1,2} GRAMAS ", value, converted_value);
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 2:
                                //GRAMAS P/ QUILOS, entrada do valor a ser convertido
                                Console.Write("\n\n═══════════════════════════ GRAMAS P/ QUILOS ════════════════════════ \nDigite o valor, em gramas, a ser convertido para quilos: ");
                                value = double.Parse(Console.ReadLine());

                                //VALIDAÇÃO DE ENTRADA, valor a ser convertido não pode ser negativo
                                while (value < 0)
                                {
                                    Console.Clear();
                                    Console.Write("\n\n═══════════════════════════ GRAMAS P/ QUILOS ════════════════════════   \n\nVALOR INVÁLIDO. Por favor, digite um número maior que zero: ");
                                    value = double.Parse(Console.ReadLine());
                                    Console.Clear();
                                }

                                //CONVERSÃO
                                converted_value = value / 1000;
                                Console.Clear();
                                Console.Write("\n\n═══════════════════════════CONVERSÃO FINALIZADA════════════════════════\n\n {0} GRAMAS = {1,2} QUILOS ", value, converted_value);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }


                        break;

                }

            }
            //CICLO DE REPETIÇÃO, o programa está em loop até que o usuário escolha a opção 4 no primeiro menu (SAIR)
            while (type_conversor != 4);
        }
    }
}
