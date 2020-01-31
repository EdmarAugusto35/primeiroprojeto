using Rh.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rh
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnfun_Click(object sender, EventArgs e)
        {

        }
        
        private void btnusu_Click(object sender, EventArgs e)
        {
            usuario usu = new usuario();
            usu.Show();
        }

        private void tSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tfun_Click(object sender, EventArgs e)
        {

        }

        private void tu_Click(object sender, EventArgs e)
        {
            frmCusuario Cusu = new frmCusuario();
            Cusu.Show();
        }
    }
}
