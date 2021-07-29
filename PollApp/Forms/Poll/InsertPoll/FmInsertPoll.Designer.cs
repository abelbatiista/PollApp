
namespace PollApp.Forms.Poll.InsertPoll
{
    partial class FmInsertPoll
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtQuestion5 = new System.Windows.Forms.TextBox();
            this.TxtQuestion4 = new System.Windows.Forms.TextBox();
            this.TxtQuestion3 = new System.Windows.Forms.TextBox();
            this.TxtQuestion2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtQuestion1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1678, 944);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(161, 88);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Atrás";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.TxtQuestion5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtQuestion4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtQuestion3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtQuestion2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TxtQuestion1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(170, 97);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1336, 749);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TxtQuestion5
            // 
            this.TxtQuestion5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuestion5.Location = new System.Drawing.Point(69, 499);
            this.TxtQuestion5.Name = "TxtQuestion5";
            this.TxtQuestion5.PlaceholderText = "Pregunta";
            this.TxtQuestion5.Size = new System.Drawing.Size(1196, 39);
            this.TxtQuestion5.TabIndex = 14;
            this.TxtQuestion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuestion5.Visible = false;
            // 
            // TxtQuestion4
            // 
            this.TxtQuestion4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuestion4.Location = new System.Drawing.Point(69, 375);
            this.TxtQuestion4.Name = "TxtQuestion4";
            this.TxtQuestion4.PlaceholderText = "Pregunta";
            this.TxtQuestion4.Size = new System.Drawing.Size(1196, 39);
            this.TxtQuestion4.TabIndex = 11;
            this.TxtQuestion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuestion4.Visible = false;
            // 
            // TxtQuestion3
            // 
            this.TxtQuestion3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuestion3.Location = new System.Drawing.Point(69, 251);
            this.TxtQuestion3.Name = "TxtQuestion3";
            this.TxtQuestion3.PlaceholderText = "Pregunta";
            this.TxtQuestion3.Size = new System.Drawing.Size(1196, 39);
            this.TxtQuestion3.TabIndex = 8;
            this.TxtQuestion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuestion3.Visible = false;
            // 
            // TxtQuestion2
            // 
            this.TxtQuestion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuestion2.Location = new System.Drawing.Point(69, 127);
            this.TxtQuestion2.Name = "TxtQuestion2";
            this.TxtQuestion2.PlaceholderText = "Pregunta";
            this.TxtQuestion2.Size = new System.Drawing.Size(1196, 39);
            this.TxtQuestion2.TabIndex = 5;
            this.TxtQuestion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuestion2.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.BtnInsert, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(69, 623);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1196, 123);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsert.Location = new System.Drawing.Point(401, 3);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(392, 117);
            this.BtnInsert.TabIndex = 0;
            this.BtnInsert.Text = "Insertar";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtQuestion1
            // 
            this.TxtQuestion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuestion1.Location = new System.Drawing.Point(69, 3);
            this.TxtQuestion1.Name = "TxtQuestion1";
            this.TxtQuestion1.PlaceholderText = "Pregunta";
            this.TxtQuestion1.Size = new System.Drawing.Size(1196, 39);
            this.TxtQuestion1.TabIndex = 1;
            this.TxtQuestion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuestion1.Visible = false;
            // 
            // FmInsertPoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1678, 944);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmInsertPoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Encuesta";
            this.Load += new System.EventHandler(this.FmInsertPoll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtQuestion1;
        private System.Windows.Forms.TextBox TxtQuestion5;
        private System.Windows.Forms.TextBox TxtQuestion4;
        private System.Windows.Forms.TextBox TxtQuestion3;
        private System.Windows.Forms.TextBox TxtQuestion2;
    }
}