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

        }
        public Data(int dia, int mes, int ano, int horas,string diaSemana): base(horas)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
            DiaSemana = diaSemana;
        }
        public Data(Hora d)
        {
            Dia = d.Horas;
            Mes = d.Minuto;
            Ano = d.Segundo;
        }
    }
}