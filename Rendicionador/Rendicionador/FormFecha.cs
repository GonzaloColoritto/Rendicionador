using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rendicionador
{
    public partial class FormFecha : Form
    {
        public FormFecha()
        {
            InitializeComponent();
        }
        /*
         PASAR LA FECHA Y EL NRO DE LA RENDICION POR PARAMETRO HACIA EL NUEVO FORMULARIO DE CARGA DE ITEMS, SINO
        CUANDO SE QUISIESE CANCELAR LA OPERACION, NO PERMITIRIA BORRARLO, YA QUE TODOS LOS DATOS SE CARGARAN EN ESTE FORM
         */
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormFecha_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¿Ingreso la informacion correctamente?","CONFIRMACIÓN",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            int nroRenProvisorio = 0;
            int reffacProvisorio = 0;
            if (MessageBox.Show("¿Ingreso la información correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (int.TryParse(txtNroRen.Text, out nroRenProvisorio) && int.TryParse(txtRefFac.Text,out reffacProvisorio))
                {
                    FormCargaItems formItemsNew = new FormCargaItems(dateRen.Value,nroRenProvisorio,reffacProvisorio);
                    formItemsNew.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el ingreso de datos. Recuerde únicamente utilizar números.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la carga de la Rendición?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para los números de rendiciones, como las referencias \nno usar caracteres especiales como: -, +, /, letras, etc. \nÚnicamente números.","Info",MessageBoxButtons.OK);
        }
    }
}
