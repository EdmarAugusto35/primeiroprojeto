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
    public partial class usuario : Form
    {
        Conexao con;
        Usuario Usuario;
        public usuario()
        {
            InitializeComponent();
            con = new Conexao();
            Usuario = new Usuario();
        }
        private void lerdados()
        {
            Usuario obju = new Usuario();
            obju.id = int.Parse(txtid.Text.Trim());
            obju.nome = txtnome.Text;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lerdados();
            List<Usuario> listusuario = new List<Usuario>();
            con.OpenConnection();
            MySqlDataReader reader;
            String Mysql = $"SELECT * FROM tb_usuario WHERE id='{Usuario.id} 'AND nome = '{Usuario.nome}' ";
            reader = con.executeQuery(Mysql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario Usuarios = new Usuario();
                    Usuarios.id = reader.GetInt32(0);
                    Usuarios.nome = reader.GetString(1);

                    listusuario.Add(Usuarios);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            frmUsu.DataSource = null;
            frmUsu.DataSource = listusuario;
        }
        public void atualizarGrid()
        {
            List<Usuario> listconsulta = new List<Usuario>();
            con.OpenConnection();
            MySqlDataReader reader;
            String Mysql = $"SELECT * FROM tb_usuario";
            reader = con.executeQuery(Mysql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario consulta = new Usuario();
                    consulta.id = reader.GetInt32(0);
                    consulta.nome = reader.GetString(1);
                    consulta.email = reader.GetString(2);
                    //consulta.senha = reader.GetString(3);
                    consulta.usuario =reader.GetString(4);
                    consulta.status = reader.GetBoolean(5);
                    consulta.id_perfil = reader.GetInt32(6);
                    listconsulta.Add(consulta);


                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

            frmUsu.DataSource = null;
            frmUsu.DataSource = listconsulta;
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void frmUsu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
    }
}
