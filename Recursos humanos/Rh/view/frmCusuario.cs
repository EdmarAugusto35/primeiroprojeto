﻿using Rh.view;
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
    public partial class frmCusuario : Form
    {
        Usuario obju;
        Conexao con;
        public frmCusuario()
        {
            InitializeComponent();
            obju = new Usuario();
            con = new Conexao();
        }
        private void lerdados()
        {
            Usuario obju = new Usuario();
            obju.id = int.Parse(txtid.Text.Trim());
            obju.nome = txtnome.Text;
            obju.email = txtemail.Text;
            obju.usuario = txtusuario.Text;
            obju.status = Boolean.Parse(cmbstatus.SelectedValue.ToString());
            obju.senha = txtsenha.Text;
            obju.id_perfil  = int.Parse(cmbidperfil.SelectedValue.ToString());

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar o cadastro:?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String Mysql = $"insert into tb_usuario values ='{obju.id }'{obju.nome}'{obju.email}'{obju.senha}'{obju.usuario}'{obju.status}'{obju.id_perfil}'";
            if (con.executeQuery(Mysql)==null)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
           
        }
        private void carregarbox()
        {
            List<perfil> listPerfil = new List<perfil>();
            con.OpenConnection();
            MySqlDataReader reader;
            String Mysql = $"SELECT * FROM tb_perfil";
            reader = con.executeQuery(Mysql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    perfil Perfill = new perfil();
                    Perfill.idp = reader.GetInt32(0);
                    Perfill.nome = reader.GetString(1);

                    listPerfil.Add(Perfill);
                }

            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();
            cmbidperfil.DataSource = listPerfil;
            cmbidperfil.DisplayMember = "nome";
            cmbidperfil.ValueMember = "id";
        }
        private void frmCusuario_Load(object sender, EventArgs e)
        {
            carregarbox();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbidperfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
