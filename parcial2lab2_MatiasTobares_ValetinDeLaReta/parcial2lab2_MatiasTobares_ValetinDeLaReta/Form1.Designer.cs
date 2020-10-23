namespace parcial2lab2_MatiasTobares_ValetinDeLaReta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCamisa = new System.Windows.Forms.RadioButton();
            this.rbnPantalones = new System.Windows.Forms.RadioButton();
            this.ckbMangaCorta = new System.Windows.Forms.CheckBox();
            this.ckbBermuda = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbStandard = new System.Windows.Forms.RadioButton();
            this.rtbPremium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS POR MAYOR - PradBit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnPantalones);
            this.groupBox1.Controls.Add(this.ckbBermuda);
            this.groupBox1.Controls.Add(this.rbtCamisa);
            this.groupBox1.Controls.Add(this.ckbMangaCorta);
            this.groupBox1.Location = new System.Drawing.Point(27, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            // 
            // rbtCamisa
            // 
            this.rbtCamisa.AutoSize = true;
            this.rbtCamisa.Location = new System.Drawing.Point(7, 20);
            this.rbtCamisa.Name = "rbtCamisa";
            this.rbtCamisa.Size = new System.Drawing.Size(59, 17);
            this.rbtCamisa.TabIndex = 0;
            this.rbtCamisa.TabStop = true;
            this.rbtCamisa.Text = "Camisa";
            this.rbtCamisa.UseVisualStyleBackColor = true;
            // 
            // rbnPantalones
            // 
            this.rbnPantalones.AutoSize = true;
            this.rbnPantalones.Location = new System.Drawing.Point(7, 44);
            this.rbnPantalones.Name = "rbnPantalones";
            this.rbnPantalones.Size = new System.Drawing.Size(67, 17);
            this.rbnPantalones.TabIndex = 1;
            this.rbnPantalones.TabStop = true;
            this.rbnPantalones.Text = "Pantalón";
            this.rbnPantalones.UseVisualStyleBackColor = true;
            // 
            // ckbMangaCorta
            // 
            this.ckbMangaCorta.AutoSize = true;
            this.ckbMangaCorta.Location = new System.Drawing.Point(120, 19);
            this.ckbMangaCorta.Name = "ckbMangaCorta";
            this.ckbMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.ckbMangaCorta.TabIndex = 2;
            this.ckbMangaCorta.Text = "Manga corta";
            this.ckbMangaCorta.UseVisualStyleBackColor = true;
            // 
            // ckbBermuda
            // 
            this.ckbBermuda.AutoSize = true;
            this.ckbBermuda.Location = new System.Drawing.Point(120, 44);
            this.ckbBermuda.Name = "ckbBermuda";
            this.ckbBermuda.Size = new System.Drawing.Size(68, 17);
            this.ckbBermuda.TabIndex = 3;
            this.ckbBermuda.Text = "Bermuda";
            this.ckbBermuda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbPremium);
            this.groupBox2.Controls.Add(this.rtbStandard);
            this.groupBox2.Location = new System.Drawing.Point(27, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de la prenda";
            // 
            // rtbStandard
            // 
            this.rtbStandard.AutoSize = true;
            this.rtbStandard.Location = new System.Drawing.Point(7, 19);
            this.rtbStandard.Name = "rtbStandard";
            this.rtbStandard.Size = new System.Drawing.Size(68, 17);
            this.rtbStandard.TabIndex = 0;
            this.rtbStandard.TabStop = true;
            this.rtbStandard.Text = "Standard";
            this.rtbStandard.UseVisualStyleBackColor = true;
            // 
            // rtbPremium
            // 
            this.rtbPremium.AutoSize = true;
            this.rtbPremium.Location = new System.Drawing.Point(120, 19);
            this.rtbPremium.Name = "rtbPremium";
            this.rtbPremium.Size = new System.Drawing.Size(65, 17);
            this.rtbPremium.TabIndex = 1;
            this.rtbPremium.TabStop = true;
            this.rtbPremium.Text = "Premium";
            this.rtbPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(27, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Location = new System.Drawing.Point(147, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(7, 20);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(85, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(85, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCalculo.Location = new System.Drawing.Point(27, 246);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(230, 49);
            this.btnCalculo.TabIndex = 5;
            this.btnCalculo.Text = "Calcular precio final";
            this.btnCalculo.UseVisualStyleBackColor = false;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 313);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ventas al por mayor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbBermuda;
        private System.Windows.Forms.CheckBox ckbMangaCorta;
        private System.Windows.Forms.RadioButton rbnPantalones;
        private System.Windows.Forms.RadioButton rbtCamisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rtbPremium;
        private System.Windows.Forms.RadioButton rtbStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalculo;
    }
}

