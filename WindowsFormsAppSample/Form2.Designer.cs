
namespace WindowsFormsAppSample
{
   partial class Form2
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dgvData = new WindowsFormsAppSample.DataGridViewAD();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.lblBanyakRecordData = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
         this.dgvData.Location = new System.Drawing.Point(12, 35);
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.RowTemplate.Height = 25;
         this.dgvData.Size = new System.Drawing.Size(984, 514);
         this.dgvData.TabIndex = 0;
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
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Jenis Kelamin";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Program Studi";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         // 
         // Column5
         // 
         this.Column5.HeaderText = "Waktu Kuliah";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         // 
         // Column6
         // 
         this.Column6.HeaderText = "Kelas";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         // 
         // lblBanyakRecordData
         // 
         this.lblBanyakRecordData.Location = new System.Drawing.Point(12, 9);
         this.lblBanyakRecordData.Name = "lblBanyakRecordData";
         this.lblBanyakRecordData.Size = new System.Drawing.Size(374, 23);
         this.lblBanyakRecordData.TabIndex = 5;
         this.lblBanyakRecordData.Text = "{ banyak record data }";
         this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 561);
         this.Controls.Add(this.lblBanyakRecordData);
         this.Controls.Add(this.dgvData);
         this.KeyPreview = true;
         this.Name = "Form2";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Sample Data [DataGridView DoubleBuffered=True]";
         this.Load += new System.EventHandler(this.Form2_Load);
         this.Resize += new System.EventHandler(this.Form2_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DataGridViewAD dgvData;
      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
   }
}