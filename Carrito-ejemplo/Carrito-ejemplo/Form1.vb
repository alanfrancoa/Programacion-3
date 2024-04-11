Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProductsGridView.Rows.Add("hola", "0")
        'Agregamos un registro al ProductsGrid View, cuando se inicialice el Form'

    End Sub
    'Funcion para agregar productos al ProductsGridView, sumar precio de Products y mostrar sumatoria en TotalPriceLabel'
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click

        'Agregamos en una variable el contenido de ProductTextBox'
        Dim product As String = ProductTextBox.Text

        'Validacion de PriceTextBox, como numero entero.'
        Try

            'Capturo el valor de PriceTextBox en variable'
            Dim price As Integer = PriceTextBox.Text
            'En caso de ser Integer, se agregará a ProductsGridView'
            Me.ProductsGridView.Rows.Add(product, price)

        Catch ex As Exception

            'Si falla, enviaremos un MessageBox, de esta manera el programa no romperá al ingresar formatos no válidos'
            MessageBox.Show("El precio debe ser un número entero.")

        End Try

        'Limpiamos el contenido de los TextBox'
        Me.ProductTextBox.Text = ""
        Me.PriceTextBox.Text = ""

        'Creamos acumulador'
        Dim totalPrice As Integer = 0

        'Iteramos en las filas de nuestro ProductsGridView'
        For Each entry As DataGridViewRow In Me.ProductsGridView.Rows

            'Acumulamos el valor que tenemos en la columna PriceColumns'
            totalPrice += entry.Cells("PriceColumn").Value

        Next

        'Asignamos el valor del acumulador en el label TotalPriceLabel'
        TotalPriceLabel.Text = totalPrice

    End Sub
End Class
