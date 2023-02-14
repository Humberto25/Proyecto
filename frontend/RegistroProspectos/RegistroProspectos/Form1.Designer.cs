namespace RegistroProspectos
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
            this.btnEvaluacionProspecto = new System.Windows.Forms.Button();
            this.btnListProspectos = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPirmerAp = new System.Windows.Forms.TextBox();
            this.tbSegundoAp = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbRfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarDocs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvaluacionProspecto
            // 
            this.btnEvaluacionProspecto.BackColor = System.Drawing.Color.White;
            this.btnEvaluacionProspecto.Location = new System.Drawing.Point(679, 376);
            this.btnEvaluacionProspecto.Name = "btnEvaluacionProspecto";
            this.btnEvaluacionProspecto.Size = new System.Drawing.Size(170, 23);
            this.btnEvaluacionProspecto.TabIndex = 13;
            this.btnEvaluacionProspecto.Text = "Evaluacion del prospecto";
            this.btnEvaluacionProspecto.UseVisualStyleBackColor = false;
            this.btnEvaluacionProspecto.Click += new System.EventHandler(this.btnEvaluacionProspecto_Click);
            // 
            // btnListProspectos
            // 
            this.btnListProspectos.BackColor = System.Drawing.Color.White;
            this.btnListProspectos.Location = new System.Drawing.Point(490, 376);
            this.btnListProspectos.Name = "btnListProspectos";
            this.btnListProspectos.Size = new System.Drawing.Size(163, 23);
            this.btnListProspectos.TabIndex = 12;
            this.btnListProspectos.Text = "Listado de prospectos";
            this.btnListProspectos.UseVisualStyleBackColor = false;
            this.btnListProspectos.Click += new System.EventHandler(this.btnListProspectos_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(205, 65);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 23);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbPirmerAp
            // 
            this.tbPirmerAp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPirmerAp.Location = new System.Drawing.Point(205, 94);
            this.tbPirmerAp.MaxLength = 30;
            this.tbPirmerAp.Name = "tbPirmerAp";
            this.tbPirmerAp.Size = new System.Drawing.Size(160, 23);
            this.tbPirmerAp.TabIndex = 1;
            this.tbPirmerAp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPirmerAp_KeyPress);
            // 
            // tbSegundoAp
            // 
            this.tbSegundoAp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSegundoAp.Location = new System.Drawing.Point(205, 123);
            this.tbSegundoAp.MaxLength = 30;
            this.tbSegundoAp.Name = "tbSegundoAp";
            this.tbSegundoAp.Size = new System.Drawing.Size(160, 23);
            this.tbSegundoAp.TabIndex = 2;
            this.tbSegundoAp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSegundoAp_KeyPress);
            // 
            // tbCalle
            // 
            this.tbCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCalle.Location = new System.Drawing.Point(205, 152);
            this.tbCalle.MaxLength = 100;
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(160, 23);
            this.tbCalle.TabIndex = 3;
            // 
            // tbNumero
            // 
            this.tbNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumero.Location = new System.Drawing.Point(205, 181);
            this.tbNumero.MaxLength = 8;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(160, 23);
            this.tbNumero.TabIndex = 4;
            // 
            // tbColonia
            // 
            this.tbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbColonia.Location = new System.Drawing.Point(205, 210);
            this.tbColonia.MaxLength = 100;
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.Size = new System.Drawing.Size(160, 23);
            this.tbColonia.TabIndex = 5;
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigoPostal.Location = new System.Drawing.Point(205, 239);
            this.tbCodigoPostal.MaxLength = 10;
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(160, 23);
            this.tbCodigoPostal.TabIndex = 6;
            // 
            // tbTelefono
            // 
            this.tbTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTelefono.Location = new System.Drawing.Point(205, 268);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(160, 23);
            this.tbTelefono.TabIndex = 7;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbRfc
            // 
            this.tbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRfc.Location = new System.Drawing.Point(205, 297);
            this.tbRfc.MaxLength = 13;
            this.tbRfc.Name = "tbRfc";
            this.tbRfc.Size = new System.Drawing.Size(160, 23);
            this.tbRfc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre del prospecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Primer apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Segundo apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Calle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Colonia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Código postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Teléfono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "RFC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(260, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(307, 37);
            this.label10.TabIndex = 24;
            this.label10.Text = "Captura de prospectos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Documentos:";
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.extension,
            this.btndelete});
            this.dgvDocumentos.Location = new System.Drawing.Point(400, 94);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowTemplate.Height = 25;
            this.dgvDocumentos.Size = new System.Drawing.Size(494, 221);
            this.dgvDocumentos.TabIndex = 26;
            this.dgvDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del documento";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // extension
            // 
            this.extension.HeaderText = "Extensión";
            this.extension.Name = "extension";
            this.extension.ReadOnly = true;
            // 
            // btndelete
            // 
            this.btndelete.HeaderText = "Eliminar";
            this.btndelete.Name = "btndelete";
            this.btndelete.ReadOnly = true;
            this.btndelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btndelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseColumnTextForButtonValue = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(257, 376);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(170, 23);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(70, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarDocs
            // 
            this.btnBuscarDocs.BackColor = System.Drawing.Color.White;
            this.btnBuscarDocs.Location = new System.Drawing.Point(855, 64);
            this.btnBuscarDocs.Name = "btnBuscarDocs";
            this.btnBuscarDocs.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarDocs.TabIndex = 9;
            this.btnBuscarDocs.Text = "+";
            this.btnBuscarDocs.UseVisualStyleBackColor = false;
            this.btnBuscarDocs.Click += new System.EventHandler(this.btnBuscarDocs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 425);
            this.Controls.Add(this.btnBuscarDocs);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRfc);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCodigoPostal);
            this.Controls.Add(this.tbColonia);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.tbSegundoAp);
            this.Controls.Add(this.tbPirmerAp);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnEvaluacionProspecto);
            this.Controls.Add(this.btnListProspectos);
            this.Name = "Form1";
            this.Text = "Registro de prospectos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEvaluacionProspecto;
        private Button btnListProspectos;
        private TextBox tbNombre;
        private TextBox tbPirmerAp;
        private TextBox tbSegundoAp;
        private TextBox tbCalle;
        private TextBox tbNumero;
        private TextBox tbColonia;
        private TextBox tbCodigoPostal;
        private TextBox tbTelefono;
        private TextBox tbRfc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView dgvDocumentos;
        private Button btnEnviar;
        private Button btnSalir;
        private Button btnBuscarDocs;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn extension;
        private DataGridViewButtonColumn btndelete;
    }
}