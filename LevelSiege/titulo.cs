using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace LevelSiege
{
    public partial class titulo : Form
    {
        public System.Media.SoundPlayer sonido = new System.Media.SoundPlayer(Properties.Resources.brave);
        public titulo()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void titulo_Load(object sender, EventArgs e)
        {
            sonido.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0)
            {
                this.Opacity -= 0.02;
            }
            else
            {


                ventanadejuego ventana = new ventanadejuego();
                ventana.Show();



                timer1.Stop();



                this.Hide();
            }
        }
    }
}
