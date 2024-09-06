using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePokedex
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Obtenha os valores dos TextBox
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            // Verifique se os campos não estão vazios
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // String de conexão com o banco de dados PostgreSQL
            string connectionString = "User ID=postgres;Password=fatec;Host=localhost;Port=5432;Database=Pokedex;";

            // Query de inserção
            string query = "INSERT INTO users (email, senha) VALUES (@Email, @Senha)";

            // Usando bloco try-catch para capturar erros
            try
            {
                // Criando uma nova conexão com o banco de dados
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Criando um novo comando
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Adicionando parâmetros para evitar SQL Injection
                        command.Parameters.AddWithValue("Email", email);
                        command.Parameters.AddWithValue("Senha", senha);

                        // Executando o comando
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar usuário.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
