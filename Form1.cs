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

namespace Repaso3E
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Resumen> resumen = new List<Resumen>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CargarPropietarios()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.dpi = reader.ReadLine();
                propietario.nombre = reader.ReadLine();
                propietario.apellido = reader.ReadLine();

                propietarios.Add (propietario);
            }

            reader.Close();
        }

        private void CargarPropiedades()
        {
            FileStream stream = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                propiedad.numeroCasa = reader.ReadLine();
                propiedad.dpiDueno = reader.ReadLine();
                propiedad.cuota = Convert.ToDecimal(reader.ReadLine());

                propiedades.Add (propiedad);            

            }
            reader.Close ();

        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = resumen;
            dataGridView1.Refresh();

        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            CargarPropiedades();
            CargarPropietarios();

            for (int i = 0; i < propiedades.Count; i++)
            {                
                for (int j = 0; j < propietarios.Count; j++)
                {
                    if (propiedades[i].dpiDueno == propietarios[j].dpi)
                    {
                        Resumen datoTemp = new Resumen();
                        datoTemp.nombre = propietarios[j].nombre;
                        datoTemp.apellido = propietarios[j].apellido;
                        datoTemp.numeroCasa = propiedades[i].numeroCasa;
                        datoTemp.cuota = propiedades[i].cuota;

                        resumen.Add (datoTemp);
                    }
                }
            }
            
            CargarGrid();

            buttonMayorMenor.Enabled = true;
            buttonOrdenar.Enabled = true;
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            resumen = resumen.OrderBy(c => c.cuota).ToList();
            CargarGrid();

        }

        private void buttonMayorMenor_Click(object sender, EventArgs e)
        {
            labelMenor1.Text = resumen[0].cuota.ToString();

            int ultimo = resumen.Count();
            labelMayor1.Text = resumen[ultimo - 1].cuota.ToString();
            labelPropietario.Text = resumen[ultimo - 1].nombre +", "+ resumen[ultimo - 1].apellido;
        }
    }
}
