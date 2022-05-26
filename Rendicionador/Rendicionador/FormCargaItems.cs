using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace Rendicionador
{
    public partial class FormCargaItems : Form
    {
       
        Rendicion renProvisoria;
        DateTime dateProvisoria;
        int nroRenProvisorio;
        int refFacProvisoria;
        string oldFile = Environment.CurrentDirectory + @"\Documento.pdf";
        //string oldFile = Environment.CurrentDirectory + @"\ModeloLimpio.pdf";
        string watermarkedFile;
        public FormCargaItems(DateTime date, int nroRen, int refFac)
        {

            refFacProvisoria = refFac;
            dateProvisoria = date;
            nroRenProvisorio = nroRen;

            renProvisoria = new Rendicion(dateProvisoria,nroRenProvisorio,refFacProvisoria);
            InitializeComponent();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float importeProvisorio= 0;

            if (float.TryParse(txtImporte.Text,out importeProvisorio))
            {
                Item itemProvisorio = new Item(txtDetalle.Text.ToUpper(),importeProvisorio);
                renProvisoria.Items.Add(itemProvisorio);
                Actualizar();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error en el ingreso de valores.");
            }

        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dtgItemsRen.Rows.Count == 0)
            {
                btnEliminarItem.Enabled = false;
                MessageBox.Show("No hay items cargados aún.");
            }
            else
            {
                Item itemaux = (Item) dtgItemsRen.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show($"Eliminar item {itemaux.Detalle}?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Quitar(itemaux);
                }
                
            }

            Actualizar();
        }

        private void FormCargaItems_Load(object sender, EventArgs e)
        {
            this.Text = $"Carga de Items - {nroRenProvisorio.ToString("D10")}";
        }

        private void Actualizar()
        {
            dtgItemsRen.DataSource = null;
            dtgItemsRen.DataSource = renProvisoria.Items;
        }
        private void Limpiar()
        {
            txtDetalle.Text = null;
            txtImporte.Text = null;
        }
        private void Quitar(Item item)
        {
            renProvisoria.Items.Remove(item);
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            

            PdfReader reader1 = new PdfReader(oldFile);
            System.IO.Directory.CreateDirectory(@"C:\Rendiciones PDF");
            watermarkedFile = @"C:\Rendiciones PDF" + $@"\{renProvisoria.Numero.ToString("D8")}.pdf";

            
            
            using (FileStream fs = new FileStream(watermarkedFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (PdfStamper stamper = new PdfStamper(reader1, fs))
                {
                    
                    int pageCount = reader1.NumberOfPages;

                    PdfLayer layer = new PdfLayer("Layer", stamper.Writer);


                    iTextSharp.text.Rectangle rect = reader1.GetPageSize(1);
                    PdfContentByte cb = stamper.GetOverContent(1);
                    
                    cb.BeginLayer(layer);
                    

                    BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.SetFontAndSize(bf, 15);
                    

                    cb.BeginText();
                    cb.SetTextMatrix(400f, 660);
                    cb.ShowText($"{dateProvisoria.ToString("dd MM yy")}");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(70f, 585);
                    cb.ShowText($"TRACK MAR S.A.C.I");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(70f, 565);
                    cb.ShowText($"RUTA PANAMERICANA KM. 31,5");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(70f, 545);
                    cb.ShowText($"EL TALAR");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(340f, 545);
                    cb.ShowText($"1618");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(450f, 545);
                    cb.ShowText($"5230-1900");
                    cb.EndText();


                    cb.BeginText();
                    cb.SetTextMatrix(50f, 500);
                    cb.ShowText($"REF. FAC. {refFacProvisoria.ToString("D10")}");
                    cb.EndText();

                    float var = 480;


                    for (int i = 0; i<renProvisoria.Items.Count;i++)
                    {
                        cb.BeginText();
                        cb.SetTextMatrix(50f, var);
                        //              HORIZONTAL - VERTICAL
                        cb.ShowText($"{renProvisoria.Items[i].Detalle}");
                        cb.EndText();

                        cb.BeginText();
                        cb.SetTextMatrix(460f, var);
                        //              HORIZONTAL - VERTICAL
                        cb.ShowText($"${renProvisoria.Items[i].Importe.ToString("N2")}");
                        cb.EndText();

                        var = var - 20;
                    }
                    


                    cb.BeginText();
                    cb.SetTextMatrix(460f, var-20);
                    cb.ShowText($"------------");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(460f, var-40);
                    cb.ShowText($"${renProvisoria.CalcularTotal().ToString("N2")}");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(50f, var - 40);
                    cb.ShowText($"TOTAL:");
                    cb.EndText();

                    cb.BeginText();
                    cb.SetTextMatrix(50f, var - 80);
                    cb.ShowText($"{"SON PESOS "}{NumerosLetras.Convertir((decimal)renProvisoria.CalcularTotal(),"SON PESOS",true,true)}");
                    cb.EndText();


                    cb.EndLayer();



                }
                fs.Close();
            }
            
            


            MessageBox.Show($"Rendicion creada en {watermarkedFile.ToString()}");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la carga de items?","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
