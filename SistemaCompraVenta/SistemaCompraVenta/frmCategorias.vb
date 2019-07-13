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
        If String.IsNullOrEmpty(txtBuscarCategoria.Text) Then
            Me.Listar()
        Else
            Me.Buscar(txtBuscarCategoria.Text)
        End If
    End Sub

    Private Sub TxtBuscarCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscarCategoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnBuscarCategoria.PerformClick()
        End If
    End Sub
End Class