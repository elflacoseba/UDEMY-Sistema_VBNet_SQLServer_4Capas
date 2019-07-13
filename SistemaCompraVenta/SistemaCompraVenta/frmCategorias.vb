Public Class frmCategorias

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles Me.Load
        Listar()
    End Sub

    Private Sub Formato()
        With dgvListadoCategorias
            .Columns(0).Visible = False
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).Width = 70
            .Columns(1).Width = 60
            .Columns(1).HeaderText = "ID"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).Width = 150
            .Columns(3).Width = 250
            .Columns(3).HeaderText = "Descripción"
            .Columns(4).Width = 84
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub Listar()
        Dim oNegCat As Negocios.Categorias
        Try
            oNegCat = New Negocios.Categorias
            dgvListadoCategorias.DataSource = oNegCat.Listar()
            lblTotalCategorias.Text = "Total de registros: " & dgvListadoCategorias.Rows.Count().ToString()
            Formato()
            Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegCat = Nothing
        End Try
    End Sub

    Private Sub Buscar(Valor As String)
        Dim oNegCat As Negocios.Categorias
        Try
            oNegCat = New Negocios.Categorias
            dgvListadoCategorias.DataSource = oNegCat.Buscar(Valor)
            lblTotalCategorias.Text = "Total de registros: " & dgvListadoCategorias.Rows.Count().ToString()
            Formato()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegCat = Nothing
        End Try
    End Sub

    Private Sub BtnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCategoria.Click
        If String.IsNullOrEmpty(txtBuscar.Text) Then
            Me.Listar()
        Else
            Me.Buscar(txtBuscar.Text)
        End If
    End Sub

    Private Sub TxtBuscarCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnBuscarCategoria.PerformClick()
        End If
    End Sub

    Private Sub Limpiar()
        txtID.Text = ""
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        btnInsertar.Visible = True
        btnActualizar.Visible = False
        txtBuscar.Text = ""
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If Me.ValidateChildren AndAlso Not String.IsNullOrEmpty(txtNombre.Text.Trim()) Then
            Dim oCat As Entidades.Categoria
            Dim oCatNego As Negocios.Categorias

            Try
                oCat = New Entidades.Categoria
                oCat.Nombre = txtNombre.Text
                oCat.Descripcion = txtDescripcion.Text

                oCatNego = New Negocios.Categorias

                If oCatNego.Insertar(oCat) Then
                    MsgBox("Se ha insertado correctamente la nueva Categoría.", vbOKOnly + vbInformation, "Registro correcto")
                    Me.Listar()
                Else
                    MsgBox("No se pudo insertar la Categoría.", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Catch ex As Exception
            Finally
                oCat = Nothing
                oCatNego = Nothing
            End Try

        Else
            MsgBox("Debe ingresar los datos obligatorios (*)", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Fanta ingresar datos")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Limpiar()
        TabControlCategorias.SelectedIndex = 0
        btnBuscarCategoria.PerformClick()
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Trim.Length > 0 Then
            epError.SetError(sender, "")
        Else
            epError.SetError(sender, "Ingrese el nombre de la Categoría. Este dato es obligatorio.")
        End If
    End Sub

    Private Sub DgvListadoCategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoCategorias.CellDoubleClick
        txtID.Text = dgvListadoCategorias.SelectedCells.Item(1).Value
        txtNombre.Text = dgvListadoCategorias.SelectedCells.Item(2).Value
        txtDescripcion.Text = dgvListadoCategorias.SelectedCells.Item(3).Value
        TabControlCategorias.SelectedIndex = 1
        btnInsertar.Visible = False
        btnActualizar.Visible = True
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.ValidateChildren AndAlso Not String.IsNullOrEmpty(txtNombre.Text.Trim()) AndAlso Not String.IsNullOrEmpty(txtID.Text) Then
            Dim oCat As Entidades.Categoria
            Dim oCatNego As Negocios.Categorias

            Try
                oCat = New Entidades.Categoria
                oCat.CategoriaID = txtID.Text
                oCat.Nombre = txtNombre.Text
                oCat.Descripcion = txtDescripcion.Text

                oCatNego = New Negocios.Categorias

                If oCatNego.Actualizar(oCat) Then
                    MsgBox("Se ha actualizado correctamente la Categoría.", vbOKOnly + vbInformation, "Actualización correcta")
                    Me.Listar()
                    TabControlCategorias.SelectedIndex = 0
                Else
                    MsgBox("No se pudo actualizar la Categoría.", vbOKOnly + vbCritical, "Actualización incorrecta")
                End If
            Catch ex As Exception
            Finally
                oCat = Nothing
                oCatNego = Nothing
            End Try

        Else
            MsgBox("Debe ingresar los datos obligatorios (*)", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Fanta ingresar datos")
        End If
    End Sub
End Class