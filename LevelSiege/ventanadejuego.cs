using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LevelSiege
{
   
    public partial class ventanadejuego : Form
    {
        
        public ventanadejuego()
        {
            InitializeComponent();
        }

        private void ventanadejuego_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JUEGO nuestrojuego = new JUEGO();
            nuestrojuego.Show();
            this.Hide();
        }
    }
}
