<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.gbxDatosArticulo = New System.Windows.Forms.GroupBox()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblCategoriaNombre = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.chkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.lblTotalCategorias = New System.Windows.Forms.Label()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.lblBuscarArticulo = New System.Windows.Forms.Label()
        Me.btnBuscarArticulo = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.pnlBuscador = New System.Windows.Forms.Panel()
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvListadoArticulos = New System.Windows.Forms.DataGridView()
        Me.pnlGrilla = New System.Windows.Forms.Panel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControlArticulos = New System.Windows.Forms.TabControl()
        Me.OpenFileDialogIMG = New System.Windows.Forms.OpenFileDialog()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosArticulo.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.pnlPie.SuspendLayout()
        Me.pnlBuscador.SuspendLayout()
        CType(Me.dgvListadoArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrilla.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControlArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(154, 221)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(266, 66)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(154, 113)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(266, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Location = New System.Drawing.Point(864, 0)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(77, 221)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(75, 19)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(375, 325)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 19)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(553, 325)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 19)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(375, 325)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 19)
        Me.btnInsertar.TabIndex = 1
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'gbxDatosArticulo
        '
        Me.gbxDatosArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatosArticulo.Controls.Add(Me.txtStock)
        Me.gbxDatosArticulo.Controls.Add(Me.lblStock)
        Me.gbxDatosArticulo.Controls.Add(Me.txtPrecioVenta)
        Me.gbxDatosArticulo.Controls.Add(Me.lblPrecioVenta)
        Me.gbxDatosArticulo.Controls.Add(Me.txtCodigo)
        Me.gbxDatosArticulo.Controls.Add(Me.Label1)
        Me.gbxDatosArticulo.Controls.Add(Me.picImagen)
        Me.gbxDatosArticulo.Controls.Add(Me.btnCargarImagen)
        Me.gbxDatosArticulo.Controls.Add(Me.txtImagen)
        Me.gbxDatosArticulo.Controls.Add(Me.lblImagen)
        Me.gbxDatosArticulo.Controls.Add(Me.cmbCategorias)
        Me.gbxDatosArticulo.Controls.Add(Me.lblCategoria)
        Me.gbxDatosArticulo.Controls.Add(Me.txtDescripcion)
        Me.gbxDatosArticulo.Controls.Add(Me.txtNombre)
        Me.gbxDatosArticulo.Controls.Add(Me.txtID)
        Me.gbxDatosArticulo.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosArticulo.Controls.Add(Me.lblCategoriaNombre)
        Me.gbxDatosArticulo.Location = New System.Drawing.Point(30, 8)
        Me.gbxDatosArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDatosArticulo.Name = "gbxDatosArticulo"
        Me.gbxDatosArticulo.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDatosArticulo.Size = New System.Drawing.Size(943, 313)
        Me.gbxDatosArticulo.TabIndex = 0
        Me.gbxDatosArticulo.TabStop = False
        Me.gbxDatosArticulo.Text = "Datos del Artículo"
        '
        'picImagen
        '
        Me.picImagen.Location = New System.Drawing.Point(523, 77)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(266, 210)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImagen.TabIndex = 8
        Me.picImagen.TabStop = False
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Location = New System.Drawing.Point(793, 39)
        Me.btnCargarImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(75, 20)
        Me.btnCargarImagen.TabIndex = 7
        Me.btnCargarImagen.Text = "Cargar"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(523, 39)
        Me.txtImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImagen.MaxLength = 50
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.ReadOnly = True
        Me.txtImagen.Size = New System.Drawing.Size(266, 20)
        Me.txtImagen.TabIndex = 6
        '
        'lblImagen
        '
        Me.lblImagen.Location = New System.Drawing.Point(446, 39)
        Me.lblImagen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(73, 18)
        Me.lblImagen.TabIndex = 5
        Me.lblImagen.Text = "Imagen:"
        Me.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCategorias
        '
        Me.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(154, 38)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(266, 21)
        Me.cmbCategorias.TabIndex = 4
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(74, 38)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(73, 18)
        Me.lblCategoria.TabIndex = 3
        Me.lblCategoria.Text = "(*) Categoría:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCategoriaNombre
        '
        Me.lblCategoriaNombre.Location = New System.Drawing.Point(77, 113)
        Me.lblCategoriaNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoriaNombre.Name = "lblCategoriaNombre"
        Me.lblCategoriaNombre.Size = New System.Drawing.Size(73, 18)
        Me.lblCategoriaNombre.TabIndex = 0
        Me.lblCategoriaNombre.Text = "(*) Nombre:"
        Me.lblCategoriaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.btnCancelar)
        Me.TabPage2.Controls.Add(Me.btnInsertar)
        Me.TabPage2.Controls.Add(Me.gbxDatosArticulo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1000, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Location = New System.Drawing.Point(359, 6)
        Me.btnDesactivar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(75, 19)
        Me.btnDesactivar.TabIndex = 4
        Me.btnDesactivar.Text = "Desactivar"
        Me.btnDesactivar.UseVisualStyleBackColor = True
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(250, 6)
        Me.btnActivar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(75, 19)
        Me.btnActivar.TabIndex = 3
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(142, 6)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 19)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'chkSeleccionar
        '
        Me.chkSeleccionar.AutoSize = True
        Me.chkSeleccionar.Location = New System.Drawing.Point(10, 8)
        Me.chkSeleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSeleccionar.Name = "chkSeleccionar"
        Me.chkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.chkSeleccionar.TabIndex = 1
        Me.chkSeleccionar.Text = "Seleccionar"
        Me.chkSeleccionar.UseVisualStyleBackColor = True
        '
        'lblTotalCategorias
        '
        Me.lblTotalCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCategorias.Location = New System.Drawing.Point(819, 11)
        Me.lblTotalCategorias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCategorias.Name = "lblTotalCategorias"
        Me.lblTotalCategorias.Size = New System.Drawing.Size(173, 14)
        Me.lblTotalCategorias.TabIndex = 0
        Me.lblTotalCategorias.Text = "Total de registros:"
        Me.lblTotalCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPie
        '
        Me.pnlPie.BackColor = System.Drawing.Color.Transparent
        Me.pnlPie.Controls.Add(Me.btnDesactivar)
        Me.pnlPie.Controls.Add(Me.btnActivar)
        Me.pnlPie.Controls.Add(Me.btnEliminar)
        Me.pnlPie.Controls.Add(Me.chkSeleccionar)
        Me.pnlPie.Controls.Add(Me.lblTotalCategorias)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.Location = New System.Drawing.Point(2, 387)
        Me.pnlPie.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(996, 35)
        Me.pnlPie.TabIndex = 0
        '
        'lblBuscarArticulo
        '
        Me.lblBuscarArticulo.AutoSize = True
        Me.lblBuscarArticulo.Location = New System.Drawing.Point(30, 8)
        Me.lblBuscarArticulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBuscarArticulo.Name = "lblBuscarArticulo"
        Me.lblBuscarArticulo.Size = New System.Drawing.Size(80, 13)
        Me.lblBuscarArticulo.TabIndex = 2
        Me.lblBuscarArticulo.Text = "Buscar Artículo"
        '
        'btnBuscarArticulo
        '
        Me.btnBuscarArticulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarArticulo.Location = New System.Drawing.Point(917, 24)
        Me.btnBuscarArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarArticulo.Name = "btnBuscarArticulo"
        Me.btnBuscarArticulo.Size = New System.Drawing.Size(75, 19)
        Me.btnBuscarArticulo.TabIndex = 1
        Me.btnBuscarArticulo.Text = "Buscar"
        Me.btnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(30, 24)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(883, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'pnlBuscador
        '
        Me.pnlBuscador.Controls.Add(Me.lblBuscarArticulo)
        Me.pnlBuscador.Controls.Add(Me.btnBuscarArticulo)
        Me.pnlBuscador.Controls.Add(Me.txtBuscar)
        Me.pnlBuscador.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBuscador.Location = New System.Drawing.Point(2, 2)
        Me.pnlBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBuscador.Name = "pnlBuscador"
        Me.pnlBuscador.Size = New System.Drawing.Size(996, 55)
        Me.pnlBuscador.TabIndex = 2
        '
        'colSeleccionar
        '
        Me.colSeleccionar.Frozen = True
        Me.colSeleccionar.HeaderText = "Seleccionar"
        Me.colSeleccionar.MinimumWidth = 6
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.ReadOnly = True
        Me.colSeleccionar.Width = 125
        '
        'dgvListadoArticulos
        '
        Me.dgvListadoArticulos.AllowUserToAddRows = False
        Me.dgvListadoArticulos.AllowUserToDeleteRows = False
        Me.dgvListadoArticulos.AllowUserToOrderColumns = True
        Me.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar})
        Me.dgvListadoArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoArticulos.Location = New System.Drawing.Point(0, 0)
        Me.dgvListadoArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListadoArticulos.Name = "dgvListadoArticulos"
        Me.dgvListadoArticulos.ReadOnly = True
        Me.dgvListadoArticulos.RowHeadersWidth = 51
        Me.dgvListadoArticulos.RowTemplate.Height = 24
        Me.dgvListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoArticulos.Size = New System.Drawing.Size(996, 330)
        Me.dgvListadoArticulos.TabIndex = 2
        '
        'pnlGrilla
        '
        Me.pnlGrilla.Controls.Add(Me.dgvListadoArticulos)
        Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrilla.Location = New System.Drawing.Point(2, 57)
        Me.pnlGrilla.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGrilla.Name = "pnlGrilla"
        Me.pnlGrilla.Size = New System.Drawing.Size(996, 330)
        Me.pnlGrilla.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlGrilla)
        Me.TabPage1.Controls.Add(Me.pnlBuscador)
        Me.TabPage1.Controls.Add(Me.pnlPie)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControlArticulos
        '
        Me.TabControlArticulos.Controls.Add(Me.TabPage1)
        Me.TabControlArticulos.Controls.Add(Me.TabPage2)
        Me.TabControlArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlArticulos.Location = New System.Drawing.Point(0, 0)
        Me.TabControlArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlArticulos.Name = "TabControlArticulos"
        Me.TabControlArticulos.SelectedIndex = 0
        Me.TabControlArticulos.Size = New System.Drawing.Size(1008, 450)
        Me.TabControlArticulos.TabIndex = 1
        '
        'OpenFileDialogIMG
        '
        Me.OpenFileDialogIMG.FileName = "OpenFileDialog1"
        Me.OpenFileDialogIMG.Filter = "Imágenes (*.jpg, *jpeg, *.png) | *.jpg; *.jpeg; *.png"
        Me.OpenFileDialogIMG.Title = "Seleccionar imagen"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(154, 77)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(266, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(77, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(154, 148)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStock.MaxLength = 10
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(266, 20)
        Me.txtStock.TabIndex = 3
        '
        'lblStock
        '
        Me.lblStock.Location = New System.Drawing.Point(77, 148)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(73, 18)
        Me.lblStock.TabIndex = 13
        Me.lblStock.Text = "(*) Stock:"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(154, 184)
        Me.txtPrecioVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioVenta.MaxLength = 20
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(266, 20)
        Me.txtPrecioVenta.TabIndex = 4
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.Location = New System.Drawing.Point(40, 184)
        Me.lblPrecioVenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(107, 18)
        Me.lblPrecioVenta.TabIndex = 11
        Me.lblPrecioVenta.Text = "(*) Precio de Venta:"
        Me.lblPrecioVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1008, 450)
        Me.Controls.Add(Me.TabControlArticulos)
        Me.Name = "frmArticulos"
        Me.Text = "Artículos"
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosArticulo.ResumeLayout(False)
        Me.gbxDatosArticulo.PerformLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.pnlPie.ResumeLayout(False)
        Me.pnlPie.PerformLayout()
        Me.pnlBuscador.ResumeLayout(False)
        Me.pnlBuscador.PerformLayout()
        CType(Me.dgvListadoArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrilla.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControlArticulos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents epError As ErrorProvider
    Friend WithEvents TabControlArticulos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnlGrilla As Panel
    Friend WithEvents dgvListadoArticulos As DataGridView
    Friend WithEvents colSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents pnlBuscador As Panel
    Friend WithEvents lblBuscarArticulo As Label
    Friend WithEvents btnBuscarArticulo As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents pnlPie As Panel
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnActivar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents chkSeleccionar As CheckBox
    Friend WithEvents lblTotalCategorias As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents gbxDatosArticulo As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCategoriaNombre As Label
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents picImagen As PictureBox
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents txtImagen As TextBox
    Friend WithEvents lblImagen As Label
    Friend WithEvents OpenFileDialogIMG As OpenFileDialog
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents lblPrecioVenta As Label
End Class
