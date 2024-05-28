Public Class Form1
#Region "Dependencias"
    Private dtProductos As DataTable
#End Region

#Region "Inicializar"
    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Producto")
        dt.Columns.Add("Precio")
        Me.SetDtProductos(dt)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()
    End Sub

#End Region

#Region "Acciones"
    Private Sub SetDtProductos(dt As DataTable)
        Me.dtProductos = dt 'Enlazamos dtProductos con DataTable'
        DataGridView1.DataSource = dt 'Asignamos el dt, como fuente del dataGridView'
    End Sub

    Private Sub RecargaPromedio()
        Dim acumulador As Double = 0
        Dim acumuladorP As Double = 0
        Dim contadorP As Integer = 0

        For Each renglon As DataRow In dtProductos.Rows
                acumulador += renglon("Precio")
                Dim producto As String = renglon("Producto")

                If producto.ToUpper().StartsWith("P") Then
                    acumuladorP += Convert.ToDouble(renglon("Precio"))
                    contadorP += 1
                End If
            Next

        LabelTotalCarrito.Text = acumulador.ToString("#0.00")

        Dim promedio = acumulador / dtProductos.Rows.Count
        LabelPromedioCarrito.Text = promedio.ToString("#0.00")

        LabelTotalCarritoP.Text = acumuladorP.ToString("#0.00")

        If contadorP > 0 Then
                Dim promedioP = acumuladorP / contadorP
            LabelPromedioCarritoP.Text = promedioP.ToString("#0.00")

        Else
            LabelPromedioCarritoP.Text = "0.00"
        End If

    End Sub

#End Region
#Region "Eventos"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim producto = TextBoxProducto.Text
        Dim precio = Double.Parse(TextBoxPrecio.Text)

        Me.dtProductos.Rows.Add(producto, precio)

        RecargaPromedio()
    End Sub
#End Region

End Class
