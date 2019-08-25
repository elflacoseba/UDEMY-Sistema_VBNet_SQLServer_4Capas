<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorias
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
        Me.TabControlCategorias = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlGrilla = New System.Windows.Forms.Panel()
        Me.dgvListadoCategorias = New System.Windows.Forms.DataGridView()
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pnlBuscador = New System.Windows.Forms.Panel()
        Me.lblBuscarCategoria = New System.Windows.Forms.Label()
        Me.btnBuscarCategoria = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.chkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.lblTotalCategorias = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.gbxDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCategoriaNombre = New System.Windows.Forms.Label()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.TabControlCategorias.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlGrilla.SuspendLayout()
        CType(Me.dgvListadoCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscador.SuspendLayout()
        Me.pnlPie.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbxDatosCategoria.SuspendLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlCategorias
        '
        Me.TabControlCategorias.Controls.Add(Me.TabPage1)
        Me.TabControlCategorias.Controls.Add(Me.TabPage2)
        Me.TabControlCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlCategorias.Location = New System.Drawing.Point(0, 0)
        Me.TabControlCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControlCategorias.Name = "TabControlCategorias"
        Me.TabControlCategorias.SelectedIndex = 0
        Me.TabControlCategorias.Size = New System.Drawing.Size(680, 409)
        Me.TabControlCategorias.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlGrilla)
        Me.TabPage1.Controls.Add(Me.pnlBuscador)
        Me.TabPage1.Controls.Add(Me.pnlPie)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(672, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlGrilla
        '
        Me.pnlGrilla.Controls.Add(Me.dgvListadoCategorias)
        Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrilla.Location = New System.Drawing.Point(2, 57)
        Me.pnlGrilla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlGrilla.Name = "pnlGrilla"
        Me.pnlGrilla.Size = New System.Drawing.Size(668, 289)
        Me.pnlGrilla.TabIndex = 1
        '
        'dgvListadoCategorias
        '
        Me.dgvListadoCategorias.AllowUserToAddRows = False
        Me.dgvListadoCategorias.AllowUserToDeleteRows = False
        Me.dgvListadoCategorias.AllowUserToOrderColumns = True
        Me.dgvListadoCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar})
        Me.dgvListadoCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoCategorias.Location = New System.Drawing.Point(0, 0)
        Me.dgvListadoCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvListadoCategorias.Name = "dgvListadoCategorias"
        Me.dgvListadoCategorias.ReadOnly = True
        Me.dgvListadoCategorias.RowHeadersWidth = 51
        Me.dgvListadoCategorias.RowTemplate.Height = 24
        Me.dgvListadoCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoCategorias.Size = New System.Drawing.Size(668, 289)
        Me.dgvListadoCategorias.TabIndex = 2
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
        'pnlBuscador
        '
        Me.pnlBuscador.Controls.Add(Me.lblBuscarCategoria)
        Me.pnlBuscador.Controls.Add(Me.btnBuscarCategoria)
        Me.pnlBuscador.Controls.Add(Me.txtBuscar)
        Me.pnlBuscador.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBuscador.Location = New System.Drawing.Point(2, 2)
        Me.pnlBuscador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlBuscador.Name = "pnlBuscador"
        Me.pnlBuscador.Size = New System.Drawing.Size(668, 55)
        Me.pnlBuscador.TabIndex = 2
        '
        'lblBuscarCategoria
        '
        Me.lblBuscarCategoria.AutoSize = True
        Me.lblBuscarCategoria.Location = New System.Drawing.Point(30, 8)
        Me.lblBuscarCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBuscarCategoria.Name = "lblBuscarCategoria"
        Me.lblBuscarCategoria.Size = New System.Drawing.Size(90, 13)
        Me.lblBuscarCategoria.TabIndex = 2
        Me.lblBuscarCategoria.Text = "Buscar Categoría"
        '
        'btnBuscarCategoria
        '
        Me.btnBuscarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarCategoria.Location = New System.Drawing.Point(589, 24)
        Me.btnBuscarCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscarCategoria.Name = "btnBuscarCategoria"
        Me.btnBuscarCategoria.Size = New System.Drawing.Size(75, 19)
        Me.btnBuscarCategoria.TabIndex = 1
        Me.btnBuscarCategoria.Text = "Buscar"
        Me.btnBuscarCategoria.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(30, 24)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(555, 20)
        Me.txtBuscar.TabIndex = 0
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
        Me.pnlPie.Location = New System.Drawing.Point(2, 346)
        Me.pnlPie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(668, 35)
        Me.pnlPie.TabIndex = 0
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Location = New System.Drawing.Point(359, 6)
        Me.btnDesactivar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(75, 19)
        Me.btnDesactivar.TabIndex = 4
        Me.btnDesactivar.Text = "Desactivar"
        Me.btnDesactivar.UseVisualStyleBackColor = True
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(250, 6)
        Me.btnActivar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(75, 19)
        Me.btnActivar.TabIndex = 3
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(142, 6)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.chkSeleccionar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSeleccionar.Name = "chkSeleccionar"
        Me.chkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.chkSeleccionar.TabIndex = 1
        Me.chkSeleccionar.Text = "Seleccionar"
        Me.chkSeleccionar.UseVisualStyleBackColor = True
        '
        'lblTotalCategorias
        '
        Me.lblTotalCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCategorias.Location = New System.Drawing.Point(491, 11)
        Me.lblTotalCategorias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCategorias.Name = "lblTotalCategorias"
        Me.lblTotalCategorias.Size = New System.Drawing.Size(173, 14)
        Me.lblTotalCategorias.TabIndex = 0
        Me.lblTotalCategorias.Text = "Total de registros:"
        Me.lblTotalCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.btnCancelar)
        Me.TabPage2.Controls.Add(Me.btnInsertar)
        Me.TabPage2.Controls.Add(Me.gbxDatosCategoria)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(672, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(184, 204)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 19)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(374, 204)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 19)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(184, 204)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 19)
        Me.btnInsertar.TabIndex = 1
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'gbxDatosCategoria
        '
        Me.gbxDatosCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatosCategoria.Controls.Add(Me.cmbCategoria)
        Me.gbxDatosCategoria.Controls.Add(Me.lblCategoria)
        Me.gbxDatosCategoria.Controls.Add(Me.txtDescripcion)
        Me.gbxDatosCategoria.Controls.Add(Me.txtNombre)
        Me.gbxDatosCategoria.Controls.Add(Me.txtID)
        Me.gbxDatosCategoria.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosCategoria.Controls.Add(Me.lblCategoriaNombre)
        Me.gbxDatosCategoria.Location = New System.Drawing.Point(30, 8)
        Me.gbxDatosCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxDatosCategoria.Name = "gbxDatosCategoria"
        Me.gbxDatosCategoria.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxDatosCategoria.Size = New System.Drawing.Size(614, 192)
        Me.gbxDatosCategoria.TabIndex = 0
        Me.gbxDatosCategoria.TabStop = False
        Me.gbxDatosCategoria.Text = "Datos de la Categoría"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(154, 104)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(266, 66)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(154, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(266, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Location = New System.Drawing.Point(535, 0)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(77, 104)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(75, 19)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCategoriaNombre
        '
        Me.lblCategoriaNombre.Location = New System.Drawing.Point(77, 68)
        Me.lblCategoriaNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoriaNombre.Name = "lblCategoriaNombre"
        Me.lblCategoriaNombre.Size = New System.Drawing.Size(73, 18)
        Me.lblCategoriaNombre.TabIndex = 0
        Me.lblCategoriaNombre.Text = "(*) Nombre:"
        Me.lblCategoriaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(76, 35)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(73, 18)
        Me.lblCategoria.TabIndex = 3
        Me.lblCategoria.Text = "(*) Categoría:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(154, 35)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(266, 21)
        Me.cmbCategoria.TabIndex = 4
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 409)
        Me.Controls.Add(Me.TabControlCategorias)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCategorias"
        Me.Text = "Categorías"
        Me.TabControlCategorias.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlGrilla.ResumeLayout(False)
        CType(Me.dgvListadoCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscador.ResumeLayout(False)
        Me.pnlBuscador.PerformLayout()
        Me.pnlPie.ResumeLayout(False)
        Me.pnlPie.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gbxDatosCategoria.ResumeLayout(False)
        Me.gbxDatosCategoria.PerformLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlCategorias As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnlGrilla As Panel
    Friend WithEvents pnlPie As Panel
    Friend WithEvents lblTotalCategorias As Label
    Friend WithEvents pnlBuscador As Panel
    Friend WithEvents dgvListadoCategorias As DataGridView
    Friend WithEvents colSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents lblBuscarCategoria As Label
    Friend WithEvents btnBuscarCategoria As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents gbxDatosCategoria As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCategoriaNombre As Label
    Friend WithEvents epError As ErrorProvider
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnActivar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents chkSeleccionar As CheckBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents lblCategoria As Label
End Class
