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
    public partial class FormLogin : FormBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
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

            // Query para verificar se o usuário e senha estão corretos
            string query = "SELECT COUNT(1) FROM users WHERE email = @Email AND senha = @Senha";

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

                        // Executando o comando e verificando se existe um usuário com as credenciais fornecidas
                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!");

                            // Abrindo outro formulário (ex: FormMain) após login bem-sucedido
                            FormPesquisa pesquisa = new FormPesquisa();
                            pesquisa.Show();
                            this.Hide(); // Esconde o formulário de login
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }
    }
}
