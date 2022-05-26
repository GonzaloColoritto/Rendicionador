
namespace Rendicionador
{
    partial class FormCargaItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCancelar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaItems));
            this.btnTerminar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.dtgItemsRen = new System.Windows.Forms.DataGridView();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItemsRen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = System.Drawing.Color.Black;
            btnCancelar.Location = new System.Drawing.Point(12, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(104, 31);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(406, 295);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(115, 34);
            this.btnTerminar.TabIndex = 5;
            this.btnTerminar.Text = "Guardar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(26, 35);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(168, 20);
            this.txtDetalle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DETALLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMPORTE";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(26, 76);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(99, 20);
            this.txtImporte.TabIndex = 2;
            // 
            // dtgItemsRen
            // 
            this.dtgItemsRen.AllowUserToAddRows = false;
            this.dtgItemsRen.AllowUserToDeleteRows = false;
            this.dtgItemsRen.AllowUserToResizeRows = false;
            this.dtgItemsRen.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgItemsRen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgItemsRen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItemsRen.Location = new System.Drawing.Point(258, 19);
            this.dtgItemsRen.Name = "dtgItemsRen";
            this.dtgItemsRen.ReadOnly = true;
            this.dtgItemsRen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItemsRen.Size = new System.Drawing.Size(263, 220);
            this.dtgItemsRen.TabIndex = 5;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.BackColor = System.Drawing.Color.Red;
            this.btnEliminarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarItem.Image")));
            this.btnEliminarItem.Location = new System.Drawing.Point(485, 245);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(35, 32);
            this.btnEliminarItem.TabIndex = 4;
            this.btnEliminarItem.UseVisualStyleBackColor = false;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(160, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(34, 31);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormCargaItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 338);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.dtgItemsRen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnTerminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCargaItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de items";
            this.Load += new System.EventHandler(this.FormCargaItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItemsRen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.DataGridView dtgItemsRen;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnAgregar;
    }
}