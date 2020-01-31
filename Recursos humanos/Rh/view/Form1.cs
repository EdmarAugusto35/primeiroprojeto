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
    public partial class Form1 : Form
    {
        Usuario objusuario;
        Conexao con ;
        public Form1()
        {
           InitializeComponent();
            objusuario = new Usuario();
            con = new Conexao();
        }
        private void lerdados()
        {
            
            objusuario.usuario = txtUsuario.Text.Trim();
            objusuario.senha = txtsenha.Text.Trim();
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnentrar_Click(object sender, EventArgs e)
        {
            lerdados();
            String CrypSenha = CrypHash.ComputeSha256Hash(objusuario.senha);
            con.OpenConnection();
            String Mysql = $"SELECT * FROM tb_usuario WHERE usuario='{objusuario.usuario} 'AND senha = '{CrypSenha}' ";
           MySqlDataReader reader;

            reader = con.executeQuery(Mysql);

            if (reader.HasRows)
            {
                MessageBox.Show("Login com sucesso!");
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("nao logou!");
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtsenha.Text = "";
            Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
