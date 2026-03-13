namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtPassword1 = new TextBox();
            txtPassword2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bttnValidar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = SystemColors.InactiveCaption;
            txtPassword1.Location = new Point(180, 46);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(269, 27);
            txtPassword1.TabIndex = 0;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = SystemColors.InactiveCaption;
            txtPassword2.Location = new Point(180, 99);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(269, 27);
            txtPassword2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 3;
            label2.Text = "Confirmar contraseña";
            // 
            // bttnValidar
            // 
            bttnValidar.BackColor = Color.Silver;
            bttnValidar.BackgroundImage = (Image)resources.GetObject("bttnValidar.BackgroundImage");
            bttnValidar.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnValidar.ForeColor = SystemColors.ButtonFace;
            bttnValidar.Location = new Point(195, 170);
            bttnValidar.Name = "bttnValidar";
            bttnValidar.Size = new Size(235, 88);
            bttnValidar.TabIndex = 4;
            bttnValidar.Text = "Validar";
            bttnValidar.UseVisualStyleBackColor = false;
            bttnValidar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 222);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(735, 310);
            Controls.Add(pictureBox1);
            Controls.Add(bttnValidar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword1);
            Location = new Point(150, 150);
            Name = "Form1";
            Text = "Hola Mundo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword1;
        private TextBox txtPassword2;
        private Label label1;
        private Label label2;
        private Button bttnValidar;
        private PictureBox pictureBox1;
    }
}
