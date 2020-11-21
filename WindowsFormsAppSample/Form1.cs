using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace WindowsFormsAppSample
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         this.dgvData.AutoGenerateColumns = false;
         this.lblBanyakRecordData.Text = $"{this.dgvData.Rows.Count:n0} Record Data.";
      }


      private async Task ResizeGridViewColumns()
      {
         int[] gridColumnPersentage = new int[] { 10, 25, 15, 15, 15, 10};
         await Task.Run(() =>
         {
            for (int i = 0; i <= gridColumnPersentage.GetUpperBound(0); i++)
            {
               this.dgvData.Columns[i].Width = (int)((double)gridColumnPersentage[i] * this.dgvData.Width / 100);
            }
         });
      }

      private async void Form1_Load(object sender, EventArgs e)
      {
         await ResizeGridViewColumns();
         string connString = @"Data Source=.\sql2019express; Initial Catalog=DB_Sample; Integrated Security=True;";
         try
         {
            using (var conn = new SqlConnection(connString))
            {
               var query = await conn.QueryAsync<Mahasiswa>("Select * From TMahasiswa");
               this.dgvData.DataSource = query;
               this.dgvData.Columns[0].DataPropertyName = nameof(Mahasiswa.Nim);
               this.dgvData.Columns[1].DataPropertyName = nameof(Mahasiswa.Nama);
               this.dgvData.Columns[2].DataPropertyName = nameof(Mahasiswa.JenisKelamin);
               this.dgvData.Columns[3].DataPropertyName = nameof(Mahasiswa.ProgramStudi);
               this.dgvData.Columns[4].DataPropertyName = nameof(Mahasiswa.WaktuKuliah);
               this.dgvData.Columns[5].DataPropertyName = nameof(Mahasiswa.Kelas);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         finally
         {
            this.lblBanyakRecordData.Text = $"{this.dgvData.Rows.Count:n0} Record Data.";
         }
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (this.txtNama.Text.Trim() != "")
         {
            MessageBox.Show($"Hi, {this.txtNama.Text.Trim()} !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void txtNama_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
      }

      private async void Form1_Resize(object sender, EventArgs e)
      {
         await ResizeGridViewColumns();
      }

   }
}
