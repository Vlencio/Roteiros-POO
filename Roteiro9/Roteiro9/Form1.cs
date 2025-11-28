using System;
using Npgsql;
namespace Roteiro9
{
    public partial class Form1 : Form
    {
        private string connString = "Host=localhost;Username=postgres;Password=1307;Database=exemplo_db";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            if (string.IsNullOrWhiteSpace(nome) && string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Digite um nome.");
                MessageBox.Show("Digite um sobrenome.");
                return;
            }
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string insertSQL = "INSERT INTO usuarios (nome,sobrenome) VALUES (@nome,@sobrenome)";
                using (var cmd = new NpgsqlCommand(insertSQL, conn))
                {
                    cmd.Parameters.AddWithValue("nome",nome);
                    cmd.Parameters.AddWithValue("sobrenome", sobrenome);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Nome e sobrenome salvo com sucesso");
            txtNome.Clear();
            txtSobrenome.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarUsuarios.Items.Clear();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT nome, sobrenome FROM usuarios";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader.GetString(0);
                            string sobrenome = reader.GetString(1);
                            string nomeCompleto = nome + " " + sobrenome;
                            listarUsuarios.Items.Add(nomeCompleto);
                        }
                    }
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            if (string.IsNullOrWhiteSpace(nome)&& string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Digite um nome.");
                MessageBox.Show("Digite um sobrenome.");
                return;
            }
            else if (listarUsuarios.Items.Contains(nome + " " + sobrenome))
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE from usuarios where nome = (@nome) AND sobrenome = (@sobrenome)";
                    using(var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("sobrenome", sobrenome);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Nome e sobrenome deletado com sucesso");
                txtNome.Clear();
                txtSobrenome.Clear();
            }
        }
    }
}
