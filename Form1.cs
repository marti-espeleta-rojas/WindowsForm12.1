using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindForm11_06_24.Models;

namespace WindForm11_06_24
{
    public partial class Form1 : Form
    {
        Competencia competencia = new Competencia();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            FormInscripcion fInscripcion = new FormInscripcion();

            if (fInscripcion.ShowDialog() == DialogResult.OK)
            {
                competencia.AgregarCompetidor(fInscripcion.tbNombre.Text);
            }
        }

        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            TiemposCompetidores tcompet = new TiemposCompetidores();

            for (int i = 0; i < competencia.contador; i++)
            {
                if(tcompet.ShowDialog()==DialogResult.OK)
                {
                    int hh = Convert.ToInt32(tcompet.tbTiempo1.Text);

                    int mm=0;
                    competencia.CargarTiempo(i, hh, mm);
                }
            }

        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            VerResultados verlosres = new VerResultados();

            competencia.OrdenarCompetidores(tiempos[1000]);

            if (verlosres.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i <= competencia.contador;i++)
                {
                    listBox1.Items.Add()
                }
            }   
        }
    }
}
