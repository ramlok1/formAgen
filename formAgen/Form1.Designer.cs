namespace formAgen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.btn_salir = new ns1.BunifuFlatButton();
            this.btn_reportes = new ns1.BunifuFlatButton();
            this.btn_alta = new ns1.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.txt_fecha = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 455);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.btn_salir);
            this.bunifuGradientPanel1.Controls.Add(this.btn_reportes);
            this.bunifuGradientPanel1.Controls.Add(this.btn_alta);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(197, 455);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(33, 33);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.BorderRadius = 0;
            this.btn_salir.ButtonText = "Salir";
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.DisabledColor = System.Drawing.Color.Gray;
            this.btn_salir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_salir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_salir.Iconimage")));
            this.btn_salir.Iconimage_right = null;
            this.btn_salir.Iconimage_right_Selected = null;
            this.btn_salir.Iconimage_Selected = null;
            this.btn_salir.IconMarginLeft = 0;
            this.btn_salir.IconMarginRight = 0;
            this.btn_salir.IconRightVisible = true;
            this.btn_salir.IconRightZoom = 0D;
            this.btn_salir.IconVisible = true;
            this.btn_salir.IconZoom = 50D;
            this.btn_salir.IsTab = false;
            this.btn_salir.Location = new System.Drawing.Point(0, 399);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_salir.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.btn_salir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_salir.selected = false;
            this.btn_salir.Size = new System.Drawing.Size(200, 57);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_salir.Textcolor = System.Drawing.Color.White;
            this.btn_salir.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes.BorderRadius = 0;
            this.btn_reportes.ButtonText = "Reportes";
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_reportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Iconimage")));
            this.btn_reportes.Iconimage_right = null;
            this.btn_reportes.Iconimage_right_Selected = null;
            this.btn_reportes.Iconimage_Selected = null;
            this.btn_reportes.IconMarginLeft = 0;
            this.btn_reportes.IconMarginRight = 0;
            this.btn_reportes.IconRightVisible = true;
            this.btn_reportes.IconRightZoom = 0D;
            this.btn_reportes.IconVisible = true;
            this.btn_reportes.IconZoom = 80D;
            this.btn_reportes.IsTab = false;
            this.btn_reportes.Location = new System.Drawing.Point(0, 167);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_reportes.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_reportes.selected = false;
            this.btn_reportes.Size = new System.Drawing.Size(200, 57);
            this.btn_reportes.TabIndex = 1;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reportes.Textcolor = System.Drawing.Color.White;
            this.btn_reportes.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_alta
            // 
            this.btn_alta.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_alta.BackColor = System.Drawing.Color.Transparent;
            this.btn_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alta.BorderRadius = 0;
            this.btn_alta.ButtonText = "Capturar Información";
            this.btn_alta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_alta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_alta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_alta.Iconimage")));
            this.btn_alta.Iconimage_right = null;
            this.btn_alta.Iconimage_right_Selected = null;
            this.btn_alta.Iconimage_Selected = null;
            this.btn_alta.IconMarginLeft = 0;
            this.btn_alta.IconMarginRight = 0;
            this.btn_alta.IconRightVisible = true;
            this.btn_alta.IconRightZoom = 0D;
            this.btn_alta.IconVisible = true;
            this.btn_alta.IconZoom = 80D;
            this.btn_alta.IsTab = false;
            this.btn_alta.Location = new System.Drawing.Point(0, 103);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_alta.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_alta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_alta.selected = true;
            this.btn_alta.Size = new System.Drawing.Size(200, 57);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Capturar Información";
            this.btn_alta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_alta.Textcolor = System.Drawing.Color.White;
            this.btn_alta.TextFont = new System.Drawing.Font("Century Gothic", 11F);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.txt_fecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 455);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(292, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario de Captura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(109, 69);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.White;
            this.txt_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_fecha.HintForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_fecha.HintText = "Fecha";
            this.txt_fecha.isPassword = false;
            this.txt_fecha.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_fecha.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.txt_fecha.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_fecha.LineThickness = 4;
            this.txt_fecha.Location = new System.Drawing.Point(10, 69);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 30);
            this.txt_fecha.TabIndex = 0;
            this.txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuFlatButton btn_alta;
        private ns1.BunifuFlatButton btn_reportes;
        private ns1.BunifuFlatButton btn_salir;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuMaterialTextbox txt_fecha;
        private ns1.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuImageButton bunifuImageButton2;
    }
}

