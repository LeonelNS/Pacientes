namespace Pacientes
{
    partial class User
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
            this.GestorUsuarios = new System.Windows.Forms.GroupBox();
            this.CancelBtt = new System.Windows.Forms.Button();
            this.LoginBtt = new System.Windows.Forms.Button();
            this.Passlbl = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GestorUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // GestorUsuarios
            // 
            this.GestorUsuarios.Controls.Add(this.CancelBtt);
            this.GestorUsuarios.Controls.Add(this.LoginBtt);
            this.GestorUsuarios.Controls.Add(this.Passlbl);
            this.GestorUsuarios.Controls.Add(this.Userlbl);
            this.GestorUsuarios.Controls.Add(this.Pass);
            this.GestorUsuarios.Controls.Add(this.textBox1);
            this.GestorUsuarios.Location = new System.Drawing.Point(12, 34);
            this.GestorUsuarios.Name = "GestorUsuarios";
            this.GestorUsuarios.Size = new System.Drawing.Size(539, 296);
            this.GestorUsuarios.TabIndex = 0;
            this.GestorUsuarios.TabStop = false;
            this.GestorUsuarios.Text = "Gestion de usuarios";
            // 
            // CancelBtt
            // 
            this.CancelBtt.Location = new System.Drawing.Point(152, 145);
            this.CancelBtt.Name = "CancelBtt";
            this.CancelBtt.Size = new System.Drawing.Size(75, 23);
            this.CancelBtt.TabIndex = 11;
            this.CancelBtt.Text = "Cancel";
            this.CancelBtt.UseVisualStyleBackColor = true;
            // 
            // LoginBtt
            // 
            this.LoginBtt.Location = new System.Drawing.Point(71, 145);
            this.LoginBtt.Name = "LoginBtt";
            this.LoginBtt.Size = new System.Drawing.Size(75, 23);
            this.LoginBtt.TabIndex = 10;
            this.LoginBtt.Text = "Login";
            this.LoginBtt.UseVisualStyleBackColor = true;
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(5, 81);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(57, 15);
            this.Passlbl.TabIndex = 9;
            this.Passlbl.Text = "Password";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(5, 39);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(60, 15);
            this.Userlbl.TabIndex = 8;
            this.Userlbl.Text = "Username";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(71, 78);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(195, 23);
            this.Pass.TabIndex = 7;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 6;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 508);
            this.Controls.Add(this.GestorUsuarios);
            this.Name = "User";
            this.Text = "User";
            this.GestorUsuarios.ResumeLayout(false);
            this.GestorUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GestorUsuarios;
        private Button CancelBtt;
        private Button LoginBtt;
        private Label Passlbl;
        private Label Userlbl;
        private TextBox Pass;
        private TextBox textBox1;
    }
}