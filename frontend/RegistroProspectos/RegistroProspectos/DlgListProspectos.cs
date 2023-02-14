using RegistroProspectos.Clases;
using RegistroProspectos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroProspectos
{
    public partial class DlgListProspectos : Form
    {
        DataTable dataProspectos = new DataTable();
        DataTable dataDocumentos = new DataTable();
        
        public DlgListProspectos()
        {
            InitializeComponent();
            CGetProspectos prospectos = new CGetProspectos();

            dataProspectos = prospectos.getProspectos();
            foreach(DataRow row in dataProspectos.Rows)
            {
                dgvProspectos.Rows.Add(row[1], row[2], row[3], row[10]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProspectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDocumentos.Rows.Clear();
            tbNombre.Text = dataProspectos.Rows[e.RowIndex][1].ToString();
            tbPirmerAp.Text = dataProspectos.Rows[e.RowIndex][2].ToString();
            tbSegundoAp.Text = dataProspectos.Rows[e.RowIndex][3].ToString();
            tbCalle.Text = dataProspectos.Rows[e.RowIndex][4].ToString();
            tbNumero.Text = dataProspectos.Rows[e.RowIndex][5].ToString();
            tbColonia.Text = dataProspectos.Rows[e.RowIndex][6].ToString();
            tbCodigoPostal.Text = dataProspectos.Rows[e.RowIndex][7].ToString();
            tbTelefono.Text = dataProspectos.Rows[e.RowIndex][8].ToString();
            tbRfc.Text = dataProspectos.Rows[e.RowIndex][9].ToString();
            tbEstatus.Text= dataProspectos.Rows[e.RowIndex][10].ToString();
            tbObservaciones.Text = dataProspectos.Rows[e.RowIndex][11].ToString();
            CGetProspectos prospectos = new CGetProspectos();

            dataDocumentos = prospectos.getDocumentos((int)dataProspectos.Rows[e.RowIndex][0]);
            foreach (DataRow row in dataDocumentos.Rows)
            {
                dgvDocumentos.Rows.Add(row[4], row[3]);
            }
        }


        private void dgvDocumentos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ruta = @"C:\Users\Humberto\Desktop\Documentos\";
                var name = dataDocumentos.Rows[e.RowIndex][4].ToString();              
                var data = (byte[])dataDocumentos.Rows[e.RowIndex][2];
                var extn = dataDocumentos.Rows[e.RowIndex][3].ToString();
                var rutaCompleta = ruta + name;
                var newFileName = rutaCompleta.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                System.IO.File.WriteAllBytes(newFileName, data);
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(newFileName)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Atencion");
            }
        }
    }
}
