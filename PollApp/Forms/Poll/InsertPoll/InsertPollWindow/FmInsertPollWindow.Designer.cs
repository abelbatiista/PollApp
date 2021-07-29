
namespace PollApp.Forms.Poll.InsertPoll.InsertPollWindow
{
    partial class FmInsertPollWindow
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
            this.TxtPollTitle = new System.Windows.Forms.TextBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TxtQuestionsQuantity = new System.Windows.Forms.TextBox();
            this.lblInsertPollWindow = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblAdvice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInsertPollWindow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblAdvice, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.TxtPollTitle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnNext, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtQuestionsQuantity, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(146, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66665F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66665F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66665F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(665, 343);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtPollTitle
            // 
            this.TxtPollTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPollTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPollTitle.Location = new System.Drawing.Point(69, 37);
            this.TxtPollTitle.Name = "TxtPollTitle";
            this.TxtPollTitle.PlaceholderText = "Nombre Encuesta";
            this.TxtPollTitle.Size = new System.Drawing.Size(526, 39);
            this.TxtPollTitle.TabIndex = 0;
            this.TxtPollTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNext
            // 
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNext.Location = new System.Drawing.Point(96, 221);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(472, 81);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Siguiente";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TxtQuestionsQuantity
            // 
            this.TxtQuestionsQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestionsQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuestionsQuantity.Location = new System.Drawing.Point(69, 128);
            this.TxtQuestionsQuantity.Name = "TxtQuestionsQuantity";
            this.TxtQuestionsQuantity.PlaceholderText = "Cantidad Preguntas";
            this.TxtQuestionsQuantity.Size = new System.Drawing.Size(526, 39);
            this.TxtQuestionsQuantity.TabIndex = 9;
            this.TxtQuestionsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuestionsQuantity.TextChanged += new System.EventHandler(this.TxtQuestionsQuantity_TextChanged);
            // 
            // lblInsertPollWindow
            // 
            this.lblInsertPollWindow.AutoSize = true;
            this.lblInsertPollWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInsertPollWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInsertPollWindow.Location = new System.Drawing.Point(146, 0);
            this.lblInsertPollWindow.Name = "lblInsertPollWindow";
            this.lblInsertPollWindow.Size = new System.Drawing.Size(665, 74);
            this.lblInsertPollWindow.TabIndex = 1;
            this.lblInsertPollWindow.Text = "Crear Encuesta";
            this.lblInsertPollWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(137, 68);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.tableLayoutPanel3.SetRowSpan(this.BtnBack, 2);
            this.BtnBack.Size = new System.Drawing.Size(131, 62);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Atrás";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblAdvice
            // 
            this.LblAdvice.AutoSize = true;
            this.LblAdvice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblAdvice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAdvice.Location = new System.Drawing.Point(817, 457);
            this.LblAdvice.Name = "LblAdvice";
            this.LblAdvice.Size = new System.Drawing.Size(139, 42);
            this.LblAdvice.TabIndex = 3;
            this.LblAdvice.Text = "Máximo 5 preguntas";
            this.LblAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmInsertPollWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(959, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmInsertPollWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Insertar Encuesta";
            this.Load += new System.EventHandler(this.FmInsertPollWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtPollTitle;
        private System.Windows.Forms.Label lblInsertPollWindow;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtQuestionsQuantity;
        private System.Windows.Forms.Label LblAdvice;
    }
}