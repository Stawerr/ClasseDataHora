using System;

namespace ClasseDataHora
{

    class Program
    {
        static void Main(string[] args)
        {
            //Hora hora1 = new Hora();
            //Console.WriteLine(hora1.ToString());
            // Data e Hora concatenados
            //Data d2 = new Data(16, 01, 1995, "terça-feira", 15, 10, 11);
            //Console.WriteLine(d.toString());

            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das seguintes opções");
                Console.WriteLine("1-Diferença entre duas datas");
                Console.WriteLine("2-Diferença entre duas horas");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                    break;
                else if (op == 1)
                    Console.WriteLine("A diferença entre as duas datas é de " + difEntre2Anos() + " anos.");
                else if (op == 2)
                    Console.WriteLine("A diferença entre as duas horas é de " + difEntre2Horas() + " horas.");
                else
                    Console.WriteLine("Opção inválida, tente novamente");
                Console.ReadKey();
            }
        }

        private static int difEntre2Horas()
        {
            Console.Clear();
            int horaa1;
            int horaa2;

            Hora hora1 = new Hora();
            Console.WriteLine("Insira a Hora 1");
            hora1.Horas = int.Parse(Console.ReadLine());

            Hora hora2 = new Hora();
            Console.WriteLine("Insira a Hora 2");
            hora2.Horas = int.Parse(Console.ReadLine());

            horaa1 = hora1.Horas;
            horaa2 = hora2.Horas;

            return Math.Abs(horaa1 - horaa2);
        }

        private static int difEntre2Anos()
        {
            Console.Clear();
            int idade1;
            int idade2;

            Data data1 = new Data();
            Console.WriteLine("Insira o Ano da Data 1");
            data1.Ano = int.Parse(Console.ReadLine());
            idade1 =  data1.Ano;
           

            Data data2 = new Data();
            Console.WriteLine("Insira o Ano da Data 2");
            data2.Ano = int.Parse(Console.ReadLine());
            idade2 = data2.Ano;

            return  Math.Abs(idade1 - idade2);
        }
    }
}
