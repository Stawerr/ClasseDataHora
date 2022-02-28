using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseDataHora
{
    class Data : Hora
    {
        private int _dia;
        private int _mes;
        private int _ano;
        private string _diaSemana;

        public int Dia { get => _dia; set => _dia = value; }
        public int Mes { get => _mes; set => _mes = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public string DiaSemana { get => _diaSemana; set => _diaSemana = value; }

        public Data()
        {
            Dia = 01;
            Mes = 01;
            Ano = 2000;
            DiaSemana = "segunda-feira";
        }

        public Data(Hora d)
        {
            Dia = 01;
            Mes = 01;
            Ano = 2000;
            DiaSemana = "segunda-feira";
            Dia = d.Horas;
            Mes = d.Minuto;
            Ano = d.Segundo;
        }

        public Data(int dia, int mes, int ano, string diaSemana, int horas, int minuto, int segundo ) : base(horas, minuto, segundo)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
            DiaSemana = diaSemana;
            Horas = horas;
            Minuto = minuto;
            Segundo = segundo;
        }

        public override string ToString()
        {
            return Dia+"/"+Mes+"/"+Ano+ " - "+ DiaSemana;
        }
        public string toString()
        {
            return Dia + " " + Mes + " " + Ano + " " + DiaSemana + " " + Horas + ":" + Minuto + ":" + Segundo ;
        }
        public static Data CriarData()
        {
            Console.Clear();
            Data data = new Data();

            Console.WriteLine("Insira o Dia da Data ");
            data.Dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Mes da Data 1");
            data.Mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Ano da Data 1");
            data.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Dia da Semana Data 1");
            data.DiaSemana = Console.ReadLine();
            Console.WriteLine(data.ToString());

            return data;
        }

        public int calcularIdade()
        {

            return DateTime.Now.Year - Ano;
        }
    }
}