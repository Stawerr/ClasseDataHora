using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseDataHora
{
    class Hora
    {
        private int _horas;
        private int _minuto;
        private int _segundo;



        public int Horas { get => _horas; set => _horas = value; }
        public int Minuto { get => _minuto; set => _minuto = value; }
        public int Segundo { get => _segundo; set => _segundo = value; }

        public Hora()
        {

        }

        public Hora(int horas, int minuto, int segundo)
        {
            Horas = horas;
            Minuto = minuto;
            Segundo = segundo;
        }
        public Hora(int horas)
        {
            Horas = horas;
        }
        public Hora(Hora h)
        {
            Horas = h.Horas;
            Minuto = h.Minuto;
            Segundo = h.Segundo;
        }
    }
}
