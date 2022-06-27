namespace Pacientes
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlAcceso = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.LoginBtt = new System.Windows.Forms.Button();
            this.CancelBtt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pacientes.Properties.Resources._1200px_Wiki_Project_Med_Foundation_logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ControlAcceso
            // 
            this.ControlAcceso.Controls.Add(this.CancelBtt);
            this.ControlAcceso.Controls.Add(this.LoginBtt);
            this.ControlAcceso.Controls.Add(this.Passlbl);
            this.ControlAcceso.Controls.Add(this.Userlbl);
            this.ControlAcceso.Controls.Add(this.Pass);
            this.ControlAcceso.Controls.Add(this.User);
            this.ControlAcceso.Location = new System.Drawing.Point(22, 183);
            this.ControlAcceso.Name = "ControlAcceso";
            this.ControlAcceso.Size = new System.Drawing.Size(353, 204);
            this.ControlAcceso.TabIndex = 1;
            this.ControlAcceso.TabStop = false;
            this.ControlAcceso.Text = "Acceso";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(75, 47);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(195, 23);
            this.User.TabIndex = 0;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(75, 89);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(195, 23);
            this.Pass.TabIndex = 1;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(9, 50);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(60, 15);
            this.Userlbl.TabIndex = 2;
            this.Userlbl.Text = "Username";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(9, 92);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(57, 15);
            this.Passlbl.TabIndex = 3;
            this.Passlbl.Text = "Password";
            // 
            // LoginBtt
            // 
            this.LoginBtt.Location = new System.Drawing.Point(75, 156);
            this.LoginBtt.Name = "LoginBtt";
            this.LoginBtt.Size = new System.Drawing.Size(75, 23);
            this.LoginBtt.TabIndex = 4;
            this.LoginBtt.Text = "Login";
            this.LoginBtt.UseVisualStyleBackColor = true;
            this.LoginBtt.Click += new System.EventHandler(this.LoginBtt_Click);
            // 
            // CancelBtt
            // 
            this.CancelBtt.Location = new System.Drawing.Point(156, 156);
            this.CancelBtt.Name = "CancelBtt";
            this.CancelBtt.Size = new System.Drawing.Size(75, 23);
            this.CancelBtt.TabIndex = 5;
            this.CancelBtt.Text = "Cancel";
            this.CancelBtt.UseVisualStyleBackColor = true;
            this.CancelBtt.Click += new System.EventHandler(this.CancelBtt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 431);
            this.Controls.Add(this.ControlAcceso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlAcceso.ResumeLayout(false);
            this.ControlAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox ControlAcceso;
        private Label Userlbl;
        private TextBox Pass;
        private TextBox User;
        private Button CancelBtt;
        private Button LoginBtt;
        private Label Passlbl;
    }
}