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
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDatepicker1 = new ns1.BunifuDatepicker();
            this.txt_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
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
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.materialSingleLineTextField3);
            this.panel2.Controls.Add(this.materialSingleLineTextField2);
            this.panel2.Controls.Add(this.materialSingleLineTextField1);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.bunifuDatepicker1);
            this.panel2.Controls.Add(this.label1);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(12, 69);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(159, 26);
            this.bunifuDatepicker1.TabIndex = 4;
            this.bunifuDatepicker1.Value = new System.DateTime(2017, 2, 22, 12, 22, 19, 144);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_name.Depth = 0;
            this.txt_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_name.Hint = "Nombre";
            this.txt_name.Location = new System.Drawing.Point(12, 118);
            this.txt_name.MaxLength = 32767;
            this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.Size = new System.Drawing.Size(368, 23);
            this.txt_name.TabIndex = 5;
            this.txt_name.TabStop = false;
            this.txt_name.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.materialSingleLineTextField1.Hint = "Text1";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(12, 167);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(197, 23);
            this.materialSingleLineTextField1.TabIndex = 6;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.materialSingleLineTextField2.Hint = "Text2";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(280, 167);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(197, 23);
            this.materialSingleLineTextField2.TabIndex = 7;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.materialSingleLineTextField3.Hint = "Text3";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(12, 217);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(269, 23);
            this.materialSingleLineTextField3.TabIndex = 8;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Snow;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Grabar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(400, 379);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(142, 44);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuFlatButton btn_alta;
        private ns1.BunifuFlatButton btn_reportes;
        private ns1.BunifuFlatButton btn_salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuImageButton bunifuImageButton2;
        private ns1.BunifuDatepicker bunifuDatepicker1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_name;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}

