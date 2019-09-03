Public Class frmArticulos

    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = Application.StartupPath & "\"

    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        CargarComboCategorias()
    End Sub

    Private Sub Formato()
        dgvListadoArticulos.Columns(0).Visible = False
        btnEliminar.Visible = False
        btnActivar.Visible = False
        btnDesactivar.Visible = False
        chkSeleccionar.CheckState = False

        With dgvListadoArticulos
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).Width = 70
            .Columns(1).Width = 70
            .Columns(1).HeaderText = "ID"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).Visible = False
            .Columns(3).HeaderText = "Categoría"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Código"
            .Columns(4).Width = 80
            .Columns(5).HeaderText = "Artículo"
            .Columns(5).Width = 200
            .Columns(6).HeaderText = "Precio"
            .Columns(7).Width = 80
            .Columns(7).HeaderText = "Stock"
            .Columns(7).Width = 80
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).HeaderText = "Descripción"
            .Columns(8).Width = 250
            .Columns(9).HeaderText = "Estado"
            .Columns(9).Width = 80
        End With
    End Sub

    Private Sub Listar()
        Dim oNegArt As Negocios.Articulos
        Try
            oNegArt = New Negocios.Articulos
            dgvListadoArticulos.DataSource = oNegArt.Listar()
            lblTotalCategorias.Text = "Total de registros: " & dgvListadoArticulos.Rows.Count().ToString()
            Formato()
            Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegArt = Nothing
        End Try
    End Sub

    Private Sub Buscar(Valor As String)
        Dim oNegArt As Negocios.Articulos
        Try
            oNegArt = New Negocios.Articulos
            dgvListadoArticulos.DataSource = oNegArt.Buscar(Valor)
            lblTotalCategorias.Text = "Total de registros: " & dgvListadoArticulos.Rows.Count().ToString()
            Formato()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegArt = Nothing
        End Try
    End Sub

    Private Sub Limpiar()
        txtID.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtStock.Text = ""
        txtPrecioVenta.Text = ""
        txtDescripcion.Text = ""
        txtImagen.Text = ""
        picImagen.Image = Nothing
        btnInsertar.Visible = True
        btnActualizar.Visible = False
        txtBuscar.Text = ""
    End Sub

    Private Sub btnBuscarArticulo_Click(sender As Object, e As EventArgs) Handles btnBuscarArticulo.Click
        If String.IsNullOrEmpty(txtBuscar.Text) Then
            Me.Listar()
        Else
            Me.Buscar(txtBuscar.Text)
        End If
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnBuscarArticulo.PerformClick()
        End If
    End Sub

    Private Sub CargarComboCategorias()
        Dim oNegCat As Negocios.Categorias
        Try
            oNegCat = New Negocios.Categorias

            With cmbCategorias
                .DataSource = oNegCat.Listar(Entidades.Categoria.EstadoListarCategorias.Activas)
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
            End With

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar las categorías." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegCat = Nothing
        End Try
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        If OpenFileDialogIMG.ShowDialog() = DialogResult.OK Then
            picImagen.Image = Image.FromFile(OpenFileDialogIMG.FileName)
            RutaOrigen = OpenFileDialogIMG.FileName
            txtImagen.Text = OpenFileDialogIMG.FileName.Substring(OpenFileDialogIMG.FileName.LastIndexOf("\") + 1)
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If Me.ValidateChildren AndAlso Not String.IsNullOrEmpty(txtNombre.Text.Trim()) AndAlso cmbCategorias.SelectedIndex >= 0 AndAlso IsNumeric(txtStock.Text) AndAlso IsNumeric(txtPrecioVenta.Text) Then
            Dim oART As Entidades.Articulo
            Dim oARTNeg As Negocios.Articulos

            Try
                oART = New Entidades.Articulo
                oART.CategoriaID = cmbCategorias.SelectedValue
                oART.Codigo = txtCodigo.Text.Trim
                oART.Nombre = txtNombre.Text.Trim
                oART.Stock = txtStock.Text.Trim
                oART.PrecioVenta = txtPrecioVenta.Text.Trim
                oART.Descripcion = txtDescripcion.Text.Trim
                oART.Imagen = txtImagen.Text.Trim

                oARTNeg = New Negocios.Articulos

                If oARTNeg.Insertar(oART) Then
                    MsgBox("Se ha insertado correctamente el nuevo Artículo.", vbOKOnly + vbInformation, "Registro correcto")

                    'si tengo una imagen seleccionada
                    If Not String.IsNullOrEmpty(txtImagen.Text.Trim) Then
                        'armo la ruta de destino.
                        RutaDestino = Directorio & txtImagen.Text

                        'copio la imagen al directorio de destino.
                        FileCopy(RutaOrigen, RutaDestino)
                    End If


                    Me.Listar()
                Else
                    MsgBox("No se pudo insertar el Artículo.", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                oART = Nothing
                oARTNeg = Nothing
            End Try

        Else
            MsgBox("Debe ingresar los datos obligatorios (*)", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Fanta ingresar datos")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        TabControlArticulos.SelectedIndex = 0
    End Sub
End Class