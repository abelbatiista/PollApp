
namespace PollApp
{
    partial class FmSignUp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblSignup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblSignup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TxtConfirmPassword, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtPassword, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtUsername, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtLastname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSignUp, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(105, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 316);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtConfirmPassword
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtConfirmPassword, 2);
            this.TxtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtConfirmPassword.Location = new System.Drawing.Point(3, 211);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.PlaceholderText = "Confirmar Contraseña";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(466, 39);
            this.TxtConfirmPassword.TabIndex = 4;
            this.TxtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtConfirmPassword.TextChanged += new System.EventHandler(this.TxtConfirmPassword_TextChanged);
            // 
            // TxtPassword
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtPassword, 2);
            this.TxtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(3, 159);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderText = "Contraseña";
            this.TxtPassword.Size = new System.Drawing.Size(466, 39);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // TxtUsername
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtUsername, 2);
            this.TxtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.Location = new System.Drawing.Point(3, 107);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PlaceholderText = "Nombre de Usuario";
            this.TxtUsername.Size = new System.Drawing.Size(466, 39);
            this.TxtUsername.TabIndex = 2;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // TxtLastname
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtLastname, 2);
            this.TxtLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtLastname.Location = new System.Drawing.Point(3, 55);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.PlaceholderText = "Apellido";
            this.TxtLastname.Size = new System.Drawing.Size(466, 39);
            this.TxtLastname.TabIndex = 1;
            this.TxtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLastname.TextChanged += new System.EventHandler(this.TxtLastname_TextChanged);
            // 
            // TxtName
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtName, 2);
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(3, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Nombre";
            this.TxtName.Size = new System.Drawing.Size(466, 39);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // BtnSignUp
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BtnSignUp, 2);
            this.BtnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSignUp.Enabled = false;
            this.BtnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSignUp.Location = new System.Drawing.Point(30, 265);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(412, 46);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Registrar";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(96, 34);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Atrás";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblSignup
            // 
            this.LblSignup.AutoSize = true;
            this.LblSignup.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSignup.Location = new System.Drawing.Point(105, 0);
            this.LblSignup.Name = "LblSignup";
            this.LblSignup.Size = new System.Drawing.Size(472, 32);
            this.LblSignup.TabIndex = 2;
            this.LblSignup.Text = "Registrar";
            this.LblSignup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.FmSignUp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblSignup;
    }
}