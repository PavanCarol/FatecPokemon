namespace TestePokedex
{
    partial class FormTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTime));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.IndianRed;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 172);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(425, 291);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(412, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 61);
            label1.TabIndex = 9;
            label1.Text = "POKÉDEX";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(93, 203);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(167, 157);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(287, 261);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 50);
            label2.TabIndex = 12;
            label2.Text = "Bulbasaur";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(104, 148, 204);
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(131, 391);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 28;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = false;
            button1.Click += this.button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.Header;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1000, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = Properties.Resources.Header;
            pictureBox3.Location = new Point(-190, 868);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1189, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(104, 148, 204);
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(301, 391);
            button2.Name = "button2";
            button2.Size = new Size(140, 42);
            button2.TabIndex = 57;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(104, 148, 204);
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(753, 392);
            button3.Name = "button3";
            button3.Size = new Size(140, 42);
            button3.TabIndex = 63;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(104, 148, 204);
            button4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(583, 392);
            button4.Name = "button4";
            button4.Size = new Size(140, 42);
            button4.TabIndex = 62;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(739, 262);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 50);
            label3.TabIndex = 61;
            label3.Text = "Bulbasaur";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(545, 204);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.IndianRed;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(517, 173);
            dataGridView3.Margin = new Padding(4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(425, 291);
            dataGridView3.TabIndex = 59;
            // 
            // FormTime
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1000, 852);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView3);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormTime";
            Text = "Times";
            Load += this.FormTime_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView3;
    }
}