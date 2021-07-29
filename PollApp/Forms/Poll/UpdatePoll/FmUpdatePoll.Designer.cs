
namespace PollApp.Forms.Poll.UpdatePoll
{
    partial class FmUpdatePoll
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
            this.LblQuestions = new System.Windows.Forms.Label();
            this.DgvQuestion = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUnselectQuestion = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdateQuestion = new System.Windows.Forms.Button();
            this.BtnInsertQuestion = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuestion)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LblQuestions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvQuestion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblQuestions
            // 
            this.LblQuestions.AutoSize = true;
            this.LblQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblQuestions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestions.Location = new System.Drawing.Point(158, 0);
            this.LblQuestions.Name = "LblQuestions";
            this.LblQuestions.Size = new System.Drawing.Size(460, 108);
            this.LblQuestions.TabIndex = 4;
            this.LblQuestions.Text = "Preguntas";
            this.LblQuestions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DgvQuestion
            // 
            this.DgvQuestion.AllowUserToAddRows = false;
            this.DgvQuestion.AllowUserToDeleteRows = false;
            this.DgvQuestion.AllowUserToResizeColumns = false;
            this.DgvQuestion.AllowUserToResizeRows = false;
            this.DgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvQuestion.Location = new System.Drawing.Point(158, 111);
            this.DgvQuestion.Name = "DgvQuestion";
            this.DgvQuestion.ReadOnly = true;
            this.DgvQuestion.RowHeadersWidth = 62;
            this.DgvQuestion.RowTemplate.Height = 33;
            this.DgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvQuestion.Size = new System.Drawing.Size(460, 320);
            this.DgvQuestion.TabIndex = 0;
            this.DgvQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvQuestion_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnUnselectQuestion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnUpdateQuestion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnInsertQuestion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 437);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 104);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // BtnUnselectQuestion
            // 
            this.BtnUnselectQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUnselectQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUnselectQuestion.Location = new System.Drawing.Point(235, 57);
            this.BtnUnselectQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUnselectQuestion.Name = "BtnUnselectQuestion";
            this.BtnUnselectQuestion.Size = new System.Drawing.Size(220, 42);
            this.BtnUnselectQuestion.TabIndex = 3;
            this.BtnUnselectQuestion.Text = "Deseleccionar";
            this.BtnUnselectQuestion.UseVisualStyleBackColor = true;
            this.BtnUnselectQuestion.Click += new System.EventHandler(this.BtnUnselectQuestion_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(5, 57);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(220, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdateQuestion
            // 
            this.BtnUpdateQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdateQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdateQuestion.Location = new System.Drawing.Point(235, 5);
            this.BtnUpdateQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUpdateQuestion.Name = "BtnUpdateQuestion";
            this.BtnUpdateQuestion.Size = new System.Drawing.Size(220, 42);
            this.BtnUpdateQuestion.TabIndex = 1;
            this.BtnUpdateQuestion.Text = "Actualizar";
            this.BtnUpdateQuestion.UseVisualStyleBackColor = true;
            this.BtnUpdateQuestion.Click += new System.EventHandler(this.BtnUpdateQuestion_Click);
            // 
            // BtnInsertQuestion
            // 
            this.BtnInsertQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnInsertQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertQuestion.Location = new System.Drawing.Point(5, 5);
            this.BtnInsertQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.BtnInsertQuestion.Name = "BtnInsertQuestion";
            this.BtnInsertQuestion.Size = new System.Drawing.Size(220, 42);
            this.BtnInsertQuestion.TabIndex = 0;
            this.BtnInsertQuestion.Text = "Insertar";
            this.BtnInsertQuestion.UseVisualStyleBackColor = true;
            this.BtnInsertQuestion.Click += new System.EventHandler(this.BtnInsertQuestion_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(149, 102);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(143, 45);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Atrás";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FmUpdatePoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmUpdatePoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Encuesta";
            this.Load += new System.EventHandler(this.FmUpdatePoll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuestion)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvQuestion;
        private System.Windows.Forms.Label LblQuestions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnInsertQuestion;
        private System.Windows.Forms.Button BtnUnselectQuestion;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdateQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnBack;
    }
}