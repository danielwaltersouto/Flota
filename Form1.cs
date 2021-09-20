using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flota
{
    public partial class FLOTA : Form
    {
        public FLOTA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FLOTA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            VehiculoFactory factory = new VehiculoFactory();
            factory.GetVehiculo(tbMarca.Text, tbModelo.Text, tbColor.Text);
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }
    }
}
