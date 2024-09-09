namespace TestePokedex
{
    partial class FormCadastro
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
            Button btnCadastrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            pictureBox4 = new PictureBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(104, 148, 204);
            btnCadastrar.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(55, 418);
            btnCadastrar.Margin = new Padding(4, 4, 4, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(445, 52);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.Header;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1000, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = Properties.Resources.Header;
            pictureBox3.Location = new Point(-189, 521);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1189, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(494, 122);
            label1.TabIndex = 8;
            label1.Text = "Cadastro de Treinador\r\nPokémon";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(55, 329);
            txtSenha.Margin = new Padding(4, 4, 4, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(210, 41);
            txtSenha.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(55, 245);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.ShortcutsEnabled = false;
            txtEmail.Size = new Size(444, 36);
            txtEmail.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(558, 121);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(391, 364);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.Location = new Point(289, 329);
            txtConfirmarSenha.Margin = new Padding(4, 4, 4, 4);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Confirmar senha";
            txtConfirmarSenha.Size = new Size(210, 41);
            txtConfirmarSenha.TabIndex = 14;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 48, 48);
            ClientSize = new Size(1000, 562);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(pictureBox4);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private PictureBox pictureBox4;
        private TextBox txtConfirmarSenha;
    }
}