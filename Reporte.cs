using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    internal class Reporte
    {
        string nombre;
        string apellido;
        int numeroCasa;
        int cuotaMantenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public int CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
