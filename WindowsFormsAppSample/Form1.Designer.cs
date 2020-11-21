
namespace WindowsFormsAppSample
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.label1 = new System.Windows.Forms.Label();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnOK = new System.Windows.Forms.Button();
         this.lblBanyakRecordData = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(12, 11);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(51, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nama";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtNama
         // 
         this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNama.Location = new System.Drawing.Point(69, 11);
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(100, 23);
         this.txtNama.TabIndex = 0;
         this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNama_KeyDown);
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
         this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
         this.dgvData.Location = new System.Drawing.Point(12, 67);
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.RowTemplate.Height = 25;
         this.dgvData.Size = new System.Drawing.Size(984, 482);
         this.dgvData.TabIndex = 2;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Nim";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Nama";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Width = 200;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Jenis Kelamin";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         this.Column3.Width = 120;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Program Studi";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         this.Column4.Width = 120;
         // 
         // Column5
         // 
         this.Column5.HeaderText = "Waktu Kuliah";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         this.Column5.Width = 120;
         // 
         // Column6
         // 
         this.Column6.HeaderText = "Kelas";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(175, 11);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 1;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // lblBanyakRecordData
         // 
         this.lblBanyakRecordData.Location = new System.Drawing.Point(12, 41);
         this.lblBanyakRecordData.Name = "lblBanyakRecordData";
         this.lblBanyakRecordData.Size = new System.Drawing.Size(374, 23);
         this.lblBanyakRecordData.TabIndex = 4;
         this.lblBanyakRecordData.Text = "{ banyak record data }";
         this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 561);
         this.Controls.Add(this.lblBanyakRecordData);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.dgvData);
         this.Controls.Add(this.txtNama);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Sample ";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.Resize += new System.EventHandler(this.Form1_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.DataGridView dgvData;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
   }
}

