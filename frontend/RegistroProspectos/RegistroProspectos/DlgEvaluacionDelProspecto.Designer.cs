namespace RegistroProspectos
{
    partial class DlgEvaluacionDelProspecto
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
            this.label12 = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.dgvProspectos = new System.Windows.Forms.DataGridView();
            this.nombreProspecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRfc = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbSegundoAp = new System.Windows.Forms.TextBox();
            this.tbPirmerAp = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProspectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 78;
            this.label12.Text = "Observaciones:";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservaciones.Location = new System.Drawing.Point(142, 337);
            this.tbObservaciones.MaxLength = 100;
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(209, 67);
            this.tbObservaciones.TabIndex = 77;
            // 
            // dgvProspectos
            // 
            this.dgvProspectos.AllowUserToAddRows = false;
            this.dgvProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProspectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProspecto,
            this.primerAp,
            this.segundoAp,
            this.estatus});
            this.dgvProspectos.Location = new System.Drawing.Point(357, 77);
            this.dgvProspectos.Name = "dgvProspectos";
            this.dgvProspectos.ReadOnly = true;
            this.dgvProspectos.RowTemplate.Height = 25;
            this.dgvProspectos.Size = new System.Drawing.Size(489, 472);
            this.dgvProspectos.TabIndex = 76;
            this.dgvProspectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProspectos_CellClick);
            // 
            // nombreProspecto
            // 
            this.nombreProspecto.HeaderText = "Nombre del prospecto";
            this.nombreProspecto.Name = "nombreProspecto";
            this.nombreProspecto.ReadOnly = true;
            this.nombreProspecto.Width = 150;
            // 
            // primerAp
            // 
            this.primerAp.HeaderText = "Primer apellido";
            this.primerAp.Name = "primerAp";
            this.primerAp.ReadOnly = true;
            // 
            // segundoAp
            // 
            this.segundoAp.HeaderText = "Segundo apellido";
            this.segundoAp.Name = "segundoAp";
            this.segundoAp.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(270, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 37);
            this.label10.TabIndex = 75;
            this.label10.Text = "Evaluacion del prospecto";
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.extension});
            this.dgvDocumentos.Location = new System.Drawing.Point(7, 431);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowTemplate.Height = 25;
            this.dgvDocumentos.Size = new System.Drawing.Size(344, 118);
            this.dgvDocumentos.TabIndex = 74;
            this.dgvDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del documento";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // extension
            // 
            this.extension.HeaderText = "Extensión";
            this.extension.Name = "extension";
            this.extension.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 73;
            this.label11.Text = "Documentos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "RFC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 71;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 70;
            this.label7.Text = "Código postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "Colonia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Segundo apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Primer apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre del prospecto:";
            // 
            // tbRfc
            // 
            this.tbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRfc.Enabled = false;
            this.tbRfc.Location = new System.Drawing.Point(142, 308);
            this.tbRfc.MaxLength = 13;
            this.tbRfc.Name = "tbRfc";
            this.tbRfc.Size = new System.Drawing.Size(209, 23);
            this.tbRfc.TabIndex = 63;
            // 
            // tbTelefono
            // 
            this.tbTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTelefono.Enabled = false;
            this.tbTelefono.Location = new System.Drawing.Point(142, 280);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(209, 23);
            this.tbTelefono.TabIndex = 62;
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigoPostal.Enabled = false;
            this.tbCodigoPostal.Location = new System.Drawing.Point(142, 251);
            this.tbCodigoPostal.MaxLength = 10;
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(209, 23);
            this.tbCodigoPostal.TabIndex = 61;
            // 
            // tbColonia
            // 
            this.tbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbColonia.Enabled = false;
            this.tbColonia.Location = new System.Drawing.Point(142, 222);
            this.tbColonia.MaxLength = 100;
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.Size = new System.Drawing.Size(209, 23);
            this.tbColonia.TabIndex = 60;
            // 
            // tbNumero
            // 
            this.tbNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(142, 193);
            this.tbNumero.MaxLength = 8;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(209, 23);
            this.tbNumero.TabIndex = 59;
            // 
            // tbCalle
            // 
            this.tbCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCalle.Enabled = false;
            this.tbCalle.Location = new System.Drawing.Point(142, 164);
            this.tbCalle.MaxLength = 100;
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(209, 23);
            this.tbCalle.TabIndex = 58;
            // 
            // tbSegundoAp
            // 
            this.tbSegundoAp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSegundoAp.Enabled = false;
            this.tbSegundoAp.Location = new System.Drawing.Point(142, 135);
            this.tbSegundoAp.MaxLength = 30;
            this.tbSegundoAp.Name = "tbSegundoAp";
            this.tbSegundoAp.Size = new System.Drawing.Size(209, 23);
            this.tbSegundoAp.TabIndex = 57;
            // 
            // tbPirmerAp
            // 
            this.tbPirmerAp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPirmerAp.Enabled = false;
            this.tbPirmerAp.Location = new System.Drawing.Point(142, 106);
            this.tbPirmerAp.MaxLength = 30;
            this.tbPirmerAp.Name = "tbPirmerAp";
            this.tbPirmerAp.Size = new System.Drawing.Size(209, 23);
            this.tbPirmerAp.TabIndex = 56;
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(142, 77);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(209, 23);
            this.tbNombre.TabIndex = 55;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(153, 564);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 23);
            this.btnSalir.TabIndex = 79;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.BackColor = System.Drawing.Color.White;
            this.btnAutorizar.Location = new System.Drawing.Point(340, 564);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(163, 23);
            this.btnAutorizar.TabIndex = 80;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.White;
            this.btnRechazar.Location = new System.Drawing.Point(532, 564);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(163, 23);
            this.btnRechazar.TabIndex = 81;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // DlgEvaluacionDelProspecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 609);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.dgvProspectos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.label11);
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
            this.Name = "DlgEvaluacionDelProspecto";
            this.Text = "DlgEvaluacionDelProspecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProspectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label12;
        private TextBox tbObservaciones;
        private DataGridView dgvProspectos;
        private DataGridViewTextBoxColumn nombreProspecto;
        private DataGridViewTextBoxColumn primerAp;
        private DataGridViewTextBoxColumn segundoAp;
        private DataGridViewTextBoxColumn estatus;
        private Label label10;
        private DataGridView dgvDocumentos;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn extension;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbRfc;
        private TextBox tbTelefono;
        private TextBox tbCodigoPostal;
        private TextBox tbColonia;
        private TextBox tbNumero;
        private TextBox tbCalle;
        private TextBox tbSegundoAp;
        private TextBox tbPirmerAp;
        private TextBox tbNombre;
        private Button btnSalir;
        private Button btnAutorizar;
        private Button btnRechazar;
    }
}