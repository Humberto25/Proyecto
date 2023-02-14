using RegistroProspectos.Clases;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RegistroProspectos
{
    public partial class DlgEvaluacionDelProspecto : Form
    {
        DataTable dataProspectos = new DataTable();
        DataTable dataDocumentos = new DataTable();
        int id=0;
        int rowIndex = 0;
        public DlgEvaluacionDelProspecto()
        {
            InitializeComponent();
            CGetProspectos prospectos = new CGetProspectos();

            dataProspectos = prospectos.getProspectosEvaluar();
            foreach (DataRow row in dataProspectos.Rows)
            {
                dgvProspectos.Rows.Add(row[1], row[2], row[3], row[10]);
            }
        }

        private void dgvProspectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDocumentos.Rows.Clear();
            rowIndex = e.RowIndex;
            tbNombre.Text = dataProspectos.Rows[e.RowIndex][1].ToString();
            tbPirmerAp.Text = dataProspectos.Rows[e.RowIndex][2].ToString();
            tbSegundoAp.Text = dataProspectos.Rows[e.RowIndex][3].ToString();
            tbCalle.Text = dataProspectos.Rows[e.RowIndex][4].ToString();
            tbNumero.Text = dataProspectos.Rows[e.RowIndex][5].ToString();
            tbColonia.Text = dataProspectos.Rows[e.RowIndex][6].ToString();
            tbCodigoPostal.Text = dataProspectos.Rows[e.RowIndex][7].ToString();
            tbTelefono.Text = dataProspectos.Rows[e.RowIndex][8].ToString();
            tbRfc.Text = dataProspectos.Rows[e.RowIndex][9].ToString();
            tbObservaciones.Text = dataProspectos.Rows[e.RowIndex][11].ToString();
            CGetProspectos prospectos = new CGetProspectos();
            id = (int)dataProspectos.Rows[e.RowIndex][0];
            dataDocumentos = prospectos.getDocumentos(id);
            foreach (DataRow row in dataDocumentos.Rows)
            {
                dgvDocumentos.Rows.Add(row[4], row[3]);
            }
        }

        private void dgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion");
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbNombre.Text))
            {
                CUpdateProspecto updateProspecto = new CUpdateProspecto();
                int respuesta = updateProspecto.updateProspecto(id, "Autorizado", "");
                if (respuesta == 1)
                {
                    MessageBox.Show("Prospecto autorizado", "Atencion");
                    limpiar();
                    dgvProspectos.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un prospecto para poder autorizarlo", "Atencion");
            }
        }
        public void limpiar()
        {
            tbNombre.Text = "";
            tbPirmerAp.Text = "";
            tbSegundoAp.Text = "";
            tbCalle.Text = "";
            tbNumero.Text = "";
            tbColonia.Text = "";
            tbCodigoPostal.Text = "";
            tbTelefono.Text = "";
            tbRfc.Text = "";
            tbObservaciones.Text = "";
            dgvDocumentos.Rows.Clear();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombre.Text))
            {
                if(!string.IsNullOrEmpty(tbObservaciones.Text))
                {
                    CUpdateProspecto updateProspecto = new CUpdateProspecto();
                    int respuesta = updateProspecto.updateProspecto(id, "Rechazado", tbObservaciones.Text);
                    if (respuesta == 1)
                    {
                        MessageBox.Show("Prospecto rechazado", "Atencion");
                        limpiar();
                        dgvProspectos.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Debe de dejar la observacion del porque rechazo el prospecto", "Atencion");
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un prospecto para poder rechazarlo", "Atencion");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
