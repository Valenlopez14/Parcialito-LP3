using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; // permite usar Trace

namespace pry._24._04._23.LP3
{
    public partial class frmMinimaMaxima : Form
    {
        public frmMinimaMaxima()
        {
            InitializeComponent();
        }

        private void frmMinimaMaxima_Load(object sender, EventArgs e)
        {

            

            try
            {
                //Cargar Localidades
                // cargar el comboBox con los datos de los Localidades
                clsLocalidades Loc = new clsLocalidades();
                lstLocalidad.DisplayMember = "nombre";
                lstLocalidad.ValueMember = "localidad";
                lstLocalidad.DataSource = Loc.GetLocalidades();
                Loc.Dispose();
               

            }
            catch (Exception error)
            {
                MessageBox.Show("", Convert.ToString(error));
                throw;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            int localidades = Convert.ToInt32(lstLocalidad.SelectedValue);
            string Fecha = dtpFecha.Text;
            

            


        }
    }
}
