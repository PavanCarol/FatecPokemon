namespace TestePokedex
{
    partial class FormDescricaoPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescricaoPokemon));
            panel1 = new Panel();
            btnAddTime = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Hp = new Label();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAddTime);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Hp);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(481, 124);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 351);
            panel1.TabIndex = 6;
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = Color.Brown;
            btnAddTime.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTime.ForeColor = SystemColors.ButtonFace;
            btnAddTime.Location = new Point(234, 283);
            btnAddTime.Margin = new Padding(4);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new Size(256, 47);
            btnAddTime.TabIndex = 9;
            btnAddTime.Text = "Adicionar ao time";
            btnAddTime.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(395, 215);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 33);
            label7.TabIndex = 8;
            label7.Text = "numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(395, 161);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 33);
            label6.TabIndex = 7;
            label6.Text = "numero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(364, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 33);
            label5.TabIndex = 6;
            label5.Text = "numeroHp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 33);
            label4.TabIndex = 5;
            label4.Text = "Defesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 33);
            label3.TabIndex = 4;
            label3.Text = "Ataque";
            // 
            // Hp
            // 
            Hp.AutoSize = true;
            Hp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hp.Location = new Point(24, 104);
            Hp.Margin = new Padding(4, 0, 4, 0);
            Hp.Name = "Hp";
            Hp.Size = new Size(46, 33);
            Hp.TabIndex = 3;
            Hp.Text = "Hp";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(24, 283);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(202, 47);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(126, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 55);
            label2.TabIndex = 1;
            label2.Text = "Estatísticas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 124);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 440);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 55);
            label1.TabIndex = 12;
            label1.Text = "Bulbasaur";
            // 
            // FormDescricaoPokemon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 641);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "FormDescricaoPokemon";
            Text = "descricaoPokemon";
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Hp;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label7;
        private Button btnAddTime;
        private Label label1;
    }
}