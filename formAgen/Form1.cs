using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formAgen
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            
            
        }      

        

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }       

      

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void btn_alta_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            bunifuSeparator1.Visible = true;
            bunifuSeparator2.Visible = false;//test
            
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            
            panel3.Visible = true;
            panel4.Visible = false;
            bunifuSeparator1.Visible = false;
            bunifuSeparator2.Visible = true;
            
        }

        private void bunifuGradientPanel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_localDataSet.Datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.bD_localDataSet.Datos);

        }
    }
}
