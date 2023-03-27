using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leerDatosFinalesReporte();
            mostrarDatosFinalesReporte();
        }

        private void leerDatosPropietario()
        {
            string fileName = "Propietario.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.Dpi = Convert.ToDouble(reader.ReadLine());
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                propietarios.Add(propietario);
            }
        }
        private void leerDatosPropiedad()
        {
            string fileName = "Propiedad.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                propiedad.NumeroCasa = Convert.ToInt32(reader.ReadLine());
                propiedad.DpiDueño = Convert.ToDouble(reader.ReadLine());
                propiedad.CuotaMatenimiento = Convert.ToInt32(reader.ReadLine());
                propiedades.Add(propiedad);
            }
            reader.Close();
        }

        private void leerDatosFinalesReporte()
        {
            leerDatosPropiedad();
            leerDatosPropietario();

            for (int i = 0; i < propietarios.Count; i++)
            {
                for (int j = 0; j < propiedades.Count; j++)
                {
                    if (propietarios[i].Dpi == propiedades[j].DpiDueño)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre = propietarios[i].Nombre;
                        reporte.Apellido = propietarios[i].Apellido;
                        reporte.NumeroCasa = propiedades[j].NumeroCasa;
                        reporte.CuotaMantenimiento = propiedades[j].CuotaMatenimiento;
                        reportes.Add(reporte);
                    }
                }
            }
        }

        private void mostrarDatosFinalesReporte()
        {
            dgvReporte.DataSource = null;
            dgvReporte.DataSource = reportes;
            dgvReporte.Refresh();
        }

        private void btnOrdenarCuotaMantenimiento_Click(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(r => r.CuotaMantenimiento).ToList();

            dgvReporte.DataSource = null; 
            dgvReporte.DataSource= reportes;
            dgvReporte.Refresh();
            dgvReporte.Refresh();
        }

        private void btnOrdenarMayorMenor_Click(object sender, EventArgs e)
        {
            //int max1=0, max2=0, max3=0;
            //int min1=0, min2=0, min3=0; 
            //Reporte reporte = new Reporte();
            //for (int i = 0; i < reportes.Count; i++)
            //{
            //    if (reportes[i].CuotaMantenimiento > reportes[i + 1].CuotaMantenimiento)
            //    {
            //        reportes[i] = Convert.ToInt32(max1);
            //    }
            //}

            double max = reportes.Max(M => M.CuotaMantenimiento);
            double min = reportes.Min(m => m.CuotaMantenimiento);

            dgvMaxCuota.DataSource = null;
            dgvMaxCuota.DataSource = reportes;
            dgvMaxCuota.Refresh();

            dgvMinCuota.DataSource = null;
            dgvMinCuota.DataSource = reportes;
            dgvMinCuota.Refresh();
        }
    }
}
