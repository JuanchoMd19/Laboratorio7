using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    internal class Propiedad
    {
        int numeroCasa;
        double dpiDueño;
        int cuotaMatenimiento;

        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public double DpiDueño { get => dpiDueño; set => dpiDueño = value; }
        public int CuotaMatenimiento { get => cuotaMatenimiento; set => cuotaMatenimiento = value; }
    }
}
