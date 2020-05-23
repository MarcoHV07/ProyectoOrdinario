namespace MaquinaTortillera
{
    partial class frmDatosMaquinaTortillera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamañoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KilosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.txtEstado = new MetroFramework.Controls.MetroTextBox();
            this.txtMasaU = new MetroFramework.Controls.MetroTextBox();
            this.txtKilos = new MetroFramework.Controls.MetroTextBox();
            this.txtSabor = new MetroFramework.Controls.MetroTextBox();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.lblMasaU = new MetroFramework.Controls.MetroLabel();
            this.lblKilos = new MetroFramework.Controls.MetroLabel();
            this.lblSabor = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtNotas = new MetroFramework.Controls.MetroTextBox();
            this.lblNotas = new MetroFramework.Controls.MetroLabel();
            this.txtTipo = new MetroFramework.Controls.MetroTextBox();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.txtMasaNueva = new MetroFramework.Controls.MetroTextBox();
            this.lblMasaNueva = new MetroFramework.Controls.MetroLabel();
            this.txtTamaño = new MetroFramework.Controls.MetroTextBox();
            this.lblTamaño = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btbEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.TamañoDataGridViewTextBoxColumn,
            this.TipoDataGridViewTextBoxColumn,
            this.MasaNDataGridViewTextBoxColumn,
            this.SaborDataGridViewTextBoxColumn,
            this.KilosDataGridViewTextBoxColumn,
            this.MasaUDataGridViewTextBoxColumn,
            this.EstadoDataGridViewTextBoxColumn,
            this.NotasDataGridViewTextBoxColumn,
            this.imageUrlDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(715, 57);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(487, 339);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TamañoDataGridViewTextBoxColumn
            // 
            this.TamañoDataGridViewTextBoxColumn.DataPropertyName = "Tamaño";
            this.TamañoDataGridViewTextBoxColumn.HeaderText = "Tamaño";
            this.TamañoDataGridViewTextBoxColumn.Name = "TamañoDataGridViewTextBoxColumn";
            // 
            // TipoDataGridViewTextBoxColumn
            // 
            this.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn";
            // 
            // MasaNDataGridViewTextBoxColumn
            // 
            this.MasaNDataGridViewTextBoxColumn.DataPropertyName = "MasaN";
            this.MasaNDataGridViewTextBoxColumn.HeaderText = "MasaN";
            this.MasaNDataGridViewTextBoxColumn.Name = "MasaNDataGridViewTextBoxColumn";
            // 
            // SaborDataGridViewTextBoxColumn
            // 
            this.SaborDataGridViewTextBoxColumn.DataPropertyName = "Sabor";
            this.SaborDataGridViewTextBoxColumn.HeaderText = "Sabor";
            this.SaborDataGridViewTextBoxColumn.Name = "SaborDataGridViewTextBoxColumn";
            // 
            // KilosDataGridViewTextBoxColumn
            // 
            this.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos";
            this.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos";
            this.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn";
            // 
            // MasaUDataGridViewTextBoxColumn
            // 
            this.MasaUDataGridViewTextBoxColumn.DataPropertyName = "MasaU";
            this.MasaUDataGridViewTextBoxColumn.HeaderText = "MasaU";
            this.MasaUDataGridViewTextBoxColumn.Name = "MasaUDataGridViewTextBoxColumn";
            // 
            // EstadoDataGridViewTextBoxColumn
            // 
            this.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn";
            // 
            // NotasDataGridViewTextBoxColumn
            // 
            this.NotasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.NotasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.NotasDataGridViewTextBoxColumn.Name = "NotasDataGridViewTextBoxColumn";
            // 
            // imageUrlDataGridViewTextBoxColumn
            // 
            this.imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            this.imageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            this.imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MaquinaTortillera.data.Product);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.pctFoto);
            this.pnlDatos.Controls.Add(this.txtEstado);
            this.pnlDatos.Controls.Add(this.txtMasaU);
            this.pnlDatos.Controls.Add(this.txtKilos);
            this.pnlDatos.Controls.Add(this.txtSabor);
            this.pnlDatos.Controls.Add(this.lblEstado);
            this.pnlDatos.Controls.Add(this.lblMasaU);
            this.pnlDatos.Controls.Add(this.lblKilos);
            this.pnlDatos.Controls.Add(this.lblSabor);
            this.pnlDatos.Controls.Add(this.txtNotas);
            this.pnlDatos.Controls.Add(this.lblNotas);
            this.pnlDatos.Controls.Add(this.txtTipo);
            this.pnlDatos.Controls.Add(this.lblTipo);
            this.pnlDatos.Controls.Add(this.txtMasaNueva);
            this.pnlDatos.Controls.Add(this.lblMasaNueva);
            this.pnlDatos.Controls.Add(this.txtTamaño);
            this.pnlDatos.Controls.Add(this.lblTamaño);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(23, 57);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(637, 339);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatos_Paint);
            // 
            // pctFoto
            // 
            this.pctFoto.Location = new System.Drawing.Point(3, 3);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(196, 240);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 24;
            this.pctFoto.TabStop = false;
            // 
            // txtEstado
            // 
            // 
            // 
            // 
            this.txtEstado.CustomButton.Image = null;
            this.txtEstado.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtEstado.CustomButton.Name = "";
            this.txtEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEstado.CustomButton.TabIndex = 1;
            this.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstado.CustomButton.UseSelectable = true;
            this.txtEstado.CustomButton.Visible = false;
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Estado", true));
            this.txtEstado.Lines = new string[0];
            this.txtEstado.Location = new System.Drawing.Point(534, 237);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.ShortcutsEnabled = true;
            this.txtEstado.Size = new System.Drawing.Size(96, 23);
            this.txtEstado.TabIndex = 22;
            this.txtEstado.UseSelectable = true;
            this.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.txtEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMasaU
            // 
            // 
            // 
            // 
            this.txtMasaU.CustomButton.Image = null;
            this.txtMasaU.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtMasaU.CustomButton.Name = "";
            this.txtMasaU.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMasaU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasaU.CustomButton.TabIndex = 1;
            this.txtMasaU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasaU.CustomButton.UseSelectable = true;
            this.txtMasaU.CustomButton.Visible = false;
            this.txtMasaU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MasaU", true));
            this.txtMasaU.Lines = new string[0];
            this.txtMasaU.Location = new System.Drawing.Point(534, 207);
            this.txtMasaU.MaxLength = 32767;
            this.txtMasaU.Name = "txtMasaU";
            this.txtMasaU.PasswordChar = '\0';
            this.txtMasaU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasaU.SelectedText = "";
            this.txtMasaU.SelectionLength = 0;
            this.txtMasaU.SelectionStart = 0;
            this.txtMasaU.ShortcutsEnabled = true;
            this.txtMasaU.Size = new System.Drawing.Size(96, 23);
            this.txtMasaU.TabIndex = 21;
            this.txtMasaU.UseSelectable = true;
            this.txtMasaU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasaU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKilos
            // 
            // 
            // 
            // 
            this.txtKilos.CustomButton.Image = null;
            this.txtKilos.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtKilos.CustomButton.Name = "";
            this.txtKilos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKilos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKilos.CustomButton.TabIndex = 1;
            this.txtKilos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKilos.CustomButton.UseSelectable = true;
            this.txtKilos.CustomButton.Visible = false;
            this.txtKilos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Kilos", true));
            this.txtKilos.Lines = new string[0];
            this.txtKilos.Location = new System.Drawing.Point(534, 176);
            this.txtKilos.MaxLength = 32767;
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.PasswordChar = '\0';
            this.txtKilos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKilos.SelectedText = "";
            this.txtKilos.SelectionLength = 0;
            this.txtKilos.SelectionStart = 0;
            this.txtKilos.ShortcutsEnabled = true;
            this.txtKilos.Size = new System.Drawing.Size(96, 23);
            this.txtKilos.TabIndex = 20;
            this.txtKilos.UseSelectable = true;
            this.txtKilos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKilos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSabor
            // 
            // 
            // 
            // 
            this.txtSabor.CustomButton.Image = null;
            this.txtSabor.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtSabor.CustomButton.Name = "";
            this.txtSabor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSabor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSabor.CustomButton.TabIndex = 1;
            this.txtSabor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSabor.CustomButton.UseSelectable = true;
            this.txtSabor.CustomButton.Visible = false;
            this.txtSabor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Sabor", true));
            this.txtSabor.Lines = new string[0];
            this.txtSabor.Location = new System.Drawing.Point(534, 147);
            this.txtSabor.MaxLength = 32767;
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.PasswordChar = '\0';
            this.txtSabor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSabor.SelectedText = "";
            this.txtSabor.SelectionLength = 0;
            this.txtSabor.SelectionStart = 0;
            this.txtSabor.ShortcutsEnabled = true;
            this.txtSabor.Size = new System.Drawing.Size(96, 23);
            this.txtSabor.TabIndex = 19;
            this.txtSabor.UseSelectable = true;
            this.txtSabor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSabor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(263, 241);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(119, 19);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado del pedido:";
            // 
            // lblMasaU
            // 
            this.lblMasaU.AutoSize = true;
            this.lblMasaU.Location = new System.Drawing.Point(264, 211);
            this.lblMasaU.Name = "lblMasaU";
            this.lblMasaU.Size = new System.Drawing.Size(95, 19);
            this.lblMasaU.TabIndex = 17;
            this.lblMasaU.Text = "Masa utilizada:";
            this.lblMasaU.Click += new System.EventHandler(this.lblRiego_Click);
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(263, 180);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(42, 19);
            this.lblKilos.TabIndex = 16;
            this.lblKilos.Text = "Kilos: ";
            this.lblKilos.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(263, 147);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(52, 19);
            this.lblSabor.TabIndex = 15;
            this.lblSabor.Text = "Sabor: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 437);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 26);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtNotas
            // 
            // 
            // 
            // 
            this.txtNotas.CustomButton.Image = null;
            this.txtNotas.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNotas.CustomButton.Name = "";
            this.txtNotas.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtNotas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotas.CustomButton.TabIndex = 1;
            this.txtNotas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotas.CustomButton.UseSelectable = true;
            this.txtNotas.CustomButton.Visible = false;
            this.txtNotas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Notas", true));
            this.txtNotas.Lines = new string[0];
            this.txtNotas.Location = new System.Drawing.Point(447, 266);
            this.txtNotas.MaxLength = 32767;
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.PasswordChar = '\0';
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotas.SelectedText = "";
            this.txtNotas.SelectionLength = 0;
            this.txtNotas.SelectionStart = 0;
            this.txtNotas.ShortcutsEnabled = true;
            this.txtNotas.Size = new System.Drawing.Size(183, 67);
            this.txtNotas.TabIndex = 11;
            this.txtNotas.UseSelectable = true;
            this.txtNotas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNotas.Click += new System.EventHandler(this.txtNotas_Click);
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(272, 297);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(118, 19);
            this.lblNotas.TabIndex = 10;
            this.lblNotas.Text = "Notas adicionales: ";
            // 
            // txtTipo
            // 
            // 
            // 
            // 
            this.txtTipo.CustomButton.Image = null;
            this.txtTipo.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtTipo.CustomButton.Name = "";
            this.txtTipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipo.CustomButton.TabIndex = 1;
            this.txtTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipo.CustomButton.UseSelectable = true;
            this.txtTipo.CustomButton.Visible = false;
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Tipo", true));
            this.txtTipo.Lines = new string[0];
            this.txtTipo.Location = new System.Drawing.Point(534, 120);
            this.txtTipo.MaxLength = 32767;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipo.SelectedText = "";
            this.txtTipo.SelectionLength = 0;
            this.txtTipo.SelectionStart = 0;
            this.txtTipo.ShortcutsEnabled = true;
            this.txtTipo.Size = new System.Drawing.Size(96, 23);
            this.txtTipo.TabIndex = 9;
            this.txtTipo.UseSelectable = true;
            this.txtTipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipo.Click += new System.EventHandler(this.txtTipo_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(264, 119);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(80, 19);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Harina/Maiz";
            // 
            // txtMasaNueva
            // 
            // 
            // 
            // 
            this.txtMasaNueva.CustomButton.Image = null;
            this.txtMasaNueva.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtMasaNueva.CustomButton.Name = "";
            this.txtMasaNueva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMasaNueva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasaNueva.CustomButton.TabIndex = 1;
            this.txtMasaNueva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasaNueva.CustomButton.UseSelectable = true;
            this.txtMasaNueva.CustomButton.Visible = false;
            this.txtMasaNueva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MasaN", true));
            this.txtMasaNueva.Lines = new string[0];
            this.txtMasaNueva.Location = new System.Drawing.Point(534, 91);
            this.txtMasaNueva.MaxLength = 32767;
            this.txtMasaNueva.Name = "txtMasaNueva";
            this.txtMasaNueva.PasswordChar = '\0';
            this.txtMasaNueva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasaNueva.SelectedText = "";
            this.txtMasaNueva.SelectionLength = 0;
            this.txtMasaNueva.SelectionStart = 0;
            this.txtMasaNueva.ShortcutsEnabled = true;
            this.txtMasaNueva.Size = new System.Drawing.Size(96, 23);
            this.txtMasaNueva.TabIndex = 7;
            this.txtMasaNueva.UseSelectable = true;
            this.txtMasaNueva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasaNueva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMasaNueva
            // 
            this.lblMasaNueva.AutoSize = true;
            this.lblMasaNueva.Location = new System.Drawing.Point(264, 91);
            this.lblMasaNueva.Name = "lblMasaNueva";
            this.lblMasaNueva.Size = new System.Drawing.Size(81, 19);
            this.lblMasaNueva.TabIndex = 6;
            this.lblMasaNueva.Text = "Masa nueva:";
            // 
            // txtTamaño
            // 
            // 
            // 
            // 
            this.txtTamaño.CustomButton.Image = null;
            this.txtTamaño.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtTamaño.CustomButton.Name = "";
            this.txtTamaño.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTamaño.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTamaño.CustomButton.TabIndex = 1;
            this.txtTamaño.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTamaño.CustomButton.UseSelectable = true;
            this.txtTamaño.CustomButton.Visible = false;
            this.txtTamaño.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Tamaño", true));
            this.txtTamaño.Lines = new string[0];
            this.txtTamaño.Location = new System.Drawing.Point(534, 55);
            this.txtTamaño.MaxLength = 32767;
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.PasswordChar = '\0';
            this.txtTamaño.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTamaño.SelectedText = "";
            this.txtTamaño.SelectionLength = 0;
            this.txtTamaño.SelectionStart = 0;
            this.txtTamaño.ShortcutsEnabled = true;
            this.txtTamaño.Size = new System.Drawing.Size(96, 23);
            this.txtTamaño.TabIndex = 5;
            this.txtTamaño.UseSelectable = true;
            this.txtTamaño.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTamaño.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(264, 62);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(58, 19);
            this.lblTamaño.TabIndex = 4;
            this.lblTamaño.Text = "Tamaño:";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(534, 26);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(96, 23);
            this.txtId.TabIndex = 3;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(263, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(66, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID Pedido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 408);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 26);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(256, 408);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(26, 440);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btbEliminar
            // 
            this.btbEliminar.Location = new System.Drawing.Point(140, 408);
            this.btbEliminar.Name = "btbEliminar";
            this.btbEliminar.Size = new System.Drawing.Size(96, 23);
            this.btbEliminar.TabIndex = 3;
            this.btbEliminar.Text = "Eliminar";
            this.btbEliminar.UseSelectable = true;
            this.btbEliminar.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // frmDatosMaquinaTortillera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 468);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btbEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmDatosMaquinaTortillera";
            this.Text = "Datos de \'Tortilleria Panchito\'";
            this.Load += new System.EventHandler(this.FrmDatosMaquinaTortillera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtNotas;
        private MetroFramework.Controls.MetroLabel lblNotas;
        private MetroFramework.Controls.MetroTextBox txtTipo;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private MetroFramework.Controls.MetroTextBox txtMasaNueva;
        private MetroFramework.Controls.MetroLabel lblMasaNueva;
        private MetroFramework.Controls.MetroTextBox txtTamaño;
        private MetroFramework.Controls.MetroLabel lblTamaño;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btbEliminar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblKilos;
        private MetroFramework.Controls.MetroLabel lblSabor;
        private MetroFramework.Controls.MetroTextBox txtEstado;
        private MetroFramework.Controls.MetroTextBox txtMasaU;
        private MetroFramework.Controls.MetroTextBox txtKilos;
        private MetroFramework.Controls.MetroTextBox txtSabor;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private MetroFramework.Controls.MetroLabel lblMasaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamañoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KilosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.PictureBox pctFoto;
    }
}

