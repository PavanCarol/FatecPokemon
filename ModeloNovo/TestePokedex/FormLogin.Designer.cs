namespace TestePokedex
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnLogar;
            Button btnCriarConta;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnLogar = new Button();
            btnCriarConta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(104, 148, 204);
            btnLogar.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogar.ForeColor = Color.Black;
            btnLogar.Location = new Point(85, 421);
            btnLogar.Margin = new Padding(4, 4, 4, 4);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(379, 48);
            btnLogar.TabIndex = 16;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.FromArgb(104, 148, 204);
            btnCriarConta.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarConta.ForeColor = Color.Black;
            btnCriarConta.Location = new Point(124, 469);
            btnCriarConta.Margin = new Padding(4, 4, 4, 4);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(301, 48);
            btnCriarConta.TabIndex = 20;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 105);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = Properties.Resources.Box2;
            pictureBox4.Location = new Point(541, 94);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(375, 375);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(413, 122);
            label1.TabIndex = 17;
            label1.Text = "Login de Treinador\r\nPokémon";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(85, 318);
            txtSenha.Margin = new Padding(4, 4, 4, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(378, 41);
            txtSenha.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(85, 250);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(378, 41);
            txtEmail.TabIndex = 14;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnCriarConta);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormLogin";
            Text = "FormAutenticacao";
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(txtSenha, 0);
            Controls.SetChildIndex(btnLogar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(pictureBox4, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnCriarConta, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtEmail;
    }
}