
namespace PollApp.Forms.Poll
{
    partial class FmPoll
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
            this.DgvPoll = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUnselectPoll = new System.Windows.Forms.Button();
            this.BtnDeletePoll = new System.Windows.Forms.Button();
            this.BtnUpdatePoll = new System.Windows.Forms.Button();
            this.BtnInsertPoll = new System.Windows.Forms.Button();
            this.LblPolls = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnViewPoll = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPoll)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DgvPoll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblPolls, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 744);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvPoll
            // 
            this.DgvPoll.AllowUserToAddRows = false;
            this.DgvPoll.AllowUserToDeleteRows = false;
            this.DgvPoll.AllowUserToResizeColumns = false;
            this.DgvPoll.AllowUserToResizeRows = false;
            this.DgvPoll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPoll.Location = new System.Drawing.Point(178, 151);
            this.DgvPoll.Name = "DgvPoll";
            this.DgvPoll.ReadOnly = true;
            this.DgvPoll.RowHeadersWidth = 62;
            this.DgvPoll.RowTemplate.Height = 33;
            this.DgvPoll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPoll.Size = new System.Drawing.Size(520, 440);
            this.DgvPoll.TabIndex = 0;
            this.DgvPoll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPoll_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnUnselectPoll, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDeletePoll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnUpdatePoll, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnInsertPoll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(178, 597);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 144);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnUnselectPoll
            // 
            this.BtnUnselectPoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUnselectPoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUnselectPoll.Location = new System.Drawing.Point(265, 77);
            this.BtnUnselectPoll.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUnselectPoll.Name = "BtnUnselectPoll";
            this.BtnUnselectPoll.Size = new System.Drawing.Size(250, 62);
            this.BtnUnselectPoll.TabIndex = 3;
            this.BtnUnselectPoll.Text = "Deseleccionar";
            this.BtnUnselectPoll.UseVisualStyleBackColor = true;
            this.BtnUnselectPoll.Click += new System.EventHandler(this.BtnUnselectPoll_Click);
            // 
            // BtnDeletePoll
            // 
            this.BtnDeletePoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeletePoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletePoll.Location = new System.Drawing.Point(5, 77);
            this.BtnDeletePoll.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDeletePoll.Name = "BtnDeletePoll";
            this.BtnDeletePoll.Size = new System.Drawing.Size(250, 62);
            this.BtnDeletePoll.TabIndex = 2;
            this.BtnDeletePoll.Text = "Eliminar";
            this.BtnDeletePoll.UseVisualStyleBackColor = true;
            this.BtnDeletePoll.Click += new System.EventHandler(this.BtnDeletePoll_Click);
            // 
            // BtnUpdatePoll
            // 
            this.BtnUpdatePoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdatePoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdatePoll.Location = new System.Drawing.Point(265, 5);
            this.BtnUpdatePoll.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUpdatePoll.Name = "BtnUpdatePoll";
            this.BtnUpdatePoll.Size = new System.Drawing.Size(250, 62);
            this.BtnUpdatePoll.TabIndex = 1;
            this.BtnUpdatePoll.Text = "Actualizar";
            this.BtnUpdatePoll.UseVisualStyleBackColor = true;
            this.BtnUpdatePoll.Click += new System.EventHandler(this.BtnUpdatePoll_Click);
            // 
            // BtnInsertPoll
            // 
            this.BtnInsertPoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnInsertPoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertPoll.Location = new System.Drawing.Point(5, 5);
            this.BtnInsertPoll.Margin = new System.Windows.Forms.Padding(5);
            this.BtnInsertPoll.Name = "BtnInsertPoll";
            this.BtnInsertPoll.Size = new System.Drawing.Size(250, 62);
            this.BtnInsertPoll.TabIndex = 0;
            this.BtnInsertPoll.Text = "Insertar";
            this.BtnInsertPoll.UseVisualStyleBackColor = true;
            this.BtnInsertPoll.Click += new System.EventHandler(this.BtnInsertPoll_Click);
            // 
            // LblPolls
            // 
            this.LblPolls.AutoSize = true;
            this.LblPolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPolls.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPolls.Location = new System.Drawing.Point(178, 0);
            this.LblPolls.Name = "LblPolls";
            this.LblPolls.Size = new System.Drawing.Size(520, 148);
            this.LblPolls.TabIndex = 2;
            this.LblPolls.Text = "Encuestas";
            this.LblPolls.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BtnLogout, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 142);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogout.Location = new System.Drawing.Point(3, 3);
            this.BtnLogout.Name = "BtnLogout";
            this.tableLayoutPanel3.SetRowSpan(this.BtnLogout, 2);
            this.BtnLogout.Size = new System.Drawing.Size(163, 63);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.Text = "Cerrar";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtnViewPoll, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnApply, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(704, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(171, 142);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // BtnViewPoll
            // 
            this.BtnViewPoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnViewPoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnViewPoll.Location = new System.Drawing.Point(3, 3);
            this.BtnViewPoll.Name = "BtnViewPoll";
            this.BtnViewPoll.Size = new System.Drawing.Size(165, 65);
            this.BtnViewPoll.TabIndex = 0;
            this.BtnViewPoll.Text = "Visualizar";
            this.BtnViewPoll.UseVisualStyleBackColor = true;
            this.BtnViewPoll.Click += new System.EventHandler(this.BtnViewPoll_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnApply.Location = new System.Drawing.Point(3, 74);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(165, 65);
            this.BtnApply.TabIndex = 1;
            this.BtnApply.Text = "Aplicar";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // FmPoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(878, 744);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmPoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuesta";
            this.Load += new System.EventHandler(this.FmPoll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPoll)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvPoll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnUnselectPoll;
        private System.Windows.Forms.Button BtnDeletePoll;
        private System.Windows.Forms.Button BtnUpdatePoll;
        private System.Windows.Forms.Button BtnInsertPoll;
        private System.Windows.Forms.Label LblPolls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnViewPoll;
        private System.Windows.Forms.Button BtnApply;
    }
}