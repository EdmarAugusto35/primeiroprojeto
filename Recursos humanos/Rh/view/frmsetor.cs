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

namespace Rh.view
{
    public partial class frmsetor : Form
    {
        Conexao con;
        Setor fsetor;
        public frmsetor()
        {
            InitializeComponent();
            con = new Conexao();
            fsetor = new Setor();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStatus.DisplayMember = "Ativo";
            cmbStatus.DisplayMember = "Inativo";
        }
        private void lerdados()
        {
           Setor objsetor = new Setor();
            objsetor.id = int.Parse(txtid.Text.Trim());
            objsetor.nome = txtnome.Text;
            objsetor.Status = Boolean.Parse(cmbStatus.SelectedValue.ToString());
          


        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String Mysql = $"insert into tb_setor values ='{fsetor.id }'{fsetor.nome}'{fsetor.Status}'";
          
            if (con.executeQuery(Mysql) == null)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            

        }
        private void carregarboxsetor()
        {
      
            cmbStatus.DisplayMember = "Ativo";
            cmbStatus.DisplayMember = "Inativo";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void frmsetor_Load(object sender, EventArgs e)
        {
            cmbStatus.DisplayMember = "Ativo";
            cmbStatus.DisplayMember = "Inativo";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar o cadastro:?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }
    }
}
