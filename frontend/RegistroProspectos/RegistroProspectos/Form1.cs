using RegistroProspectos.Clases;
using RegistroProspectos.Modelos;

namespace RegistroProspectos
{
    public partial class Form1 : Form
    {
        List<MdlRegistroDocumentos> lDocs = new List<MdlRegistroDocumentos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarDocs_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg=new OpenFileDialog();
            dlg.ShowDialog();
            if(dlg.FileName!="")
            {
                using (Stream stream = File.OpenRead(dlg.FileName))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    string extn = new FileInfo(dlg.FileName).Extension;
                    string name = new FileInfo(dlg.FileName).Name;
                    dgvDocumentos.Rows.Add(name, extn);
                    MdlRegistroDocumentos docs = new MdlRegistroDocumentos()
                    {
                        idProspecto = 0,
                        documento = buffer,
                        extension = extn,
                        nombreDocumento = name
                    };
                    lDocs.Add(docs);
                }

            }
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocumentos.Columns[e.ColumnIndex].HeaderText=="Eliminar")
            {
                dgvDocumentos.Rows.Remove(dgvDocumentos.Rows[e.RowIndex]);
                lDocs.RemoveAt(e.RowIndex);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbNombre.Text) && !string.IsNullOrEmpty(tbPirmerAp.Text) && !string.IsNullOrEmpty(tbCalle.Text) && !string.IsNullOrEmpty(tbNumero.Text) && !string.IsNullOrEmpty(tbColonia.Text) && !string.IsNullOrEmpty(tbCodigoPostal.Text) && !string.IsNullOrEmpty(tbTelefono.Text) && !string.IsNullOrEmpty(tbRfc.Text) && dgvDocumentos.Rows.Count!=0 && tbRfc.Text.Length == 13 && tbTelefono.Text.Length==10)
            {
                string segundoAp = "";
                if (!string.IsNullOrEmpty(tbSegundoAp.Text))
                {
                    segundoAp=tbSegundoAp.Text;
                }
                MdlRegistroProspectos infoProspectos = new MdlRegistroProspectos()
                {
                    nombreProspecto = tbNombre.Text,
                    primerAp = tbPirmerAp.Text,
                    segundoAp = segundoAp,
                    calle = tbCalle.Text,
                    numero = tbNumero.Text,
                    colonia = tbColonia.Text,
                    codigoPostal = Convert.ToInt32(tbCodigoPostal.Text),
                    telefono = tbTelefono.Text,
                    rfc = tbRfc.Text,
                    estatus ="Enviado",
                };
                CSaveRegistroProspecto saveProspecto = new CSaveRegistroProspecto();
                int respuesta=saveProspecto.saveProspecto(infoProspectos, lDocs);
                if(respuesta==1)
                {
                    limpiar();
                    MessageBox.Show("Prospecto registrado", "Atencion");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar campos faltantes", "Atencion");
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
            dgvDocumentos.Rows.Clear();
            lDocs.Clear();
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbPirmerAp_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tbSegundoAp_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombre.Text) || !string.IsNullOrEmpty(tbPirmerAp.Text) || !string.IsNullOrEmpty(tbSegundoAp.Text) || !string.IsNullOrEmpty(tbCalle.Text) || !string.IsNullOrEmpty(tbNumero.Text) || !string.IsNullOrEmpty(tbColonia.Text) || !string.IsNullOrEmpty(tbCodigoPostal.Text) || !string.IsNullOrEmpty(tbTelefono.Text) || !string.IsNullOrEmpty(tbRfc.Text) || dgvDocumentos.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Si desea salir perdera la informacion capturada, ¿Desea salir?", "Atencion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    limpiar();
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnListProspectos_Click(object sender, EventArgs e)
        {
            DlgListProspectos dlgListaProspectos = new DlgListProspectos();
            dlgListaProspectos.Show();
        }

        private void btnEvaluacionProspecto_Click(object sender, EventArgs e)
        {
            DlgEvaluacionDelProspecto dlgEvaluacion = new DlgEvaluacionDelProspecto();
            dlgEvaluacion.Show();
        }
    }
}