Public Class Form1
#Region "Actions"

#End Region

#Region "Events"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Add product to list'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Take values from textbox'
        Dim name = ProductNameTxt.Text
        Dim brand = ProductBrandTxt.Text

        'Take values from ComboBox'
        Dim unit = ComboBUnit.Text
        Dim productType = ComboBProdType.Text


        'Create a variable size, to save the parsed textBox'
        Dim size As Decimal
        If Decimal.TryParse(ProductSizeTxt.Text, size) Then
            ' Value became decimal succesfully.
        Else
            MessageBox.Show("Por favor, introduce un número decimal válido.")
        End If


        'Create a variable called stock, to save the parsed StockTxt TextBox'
        Dim stock As Long
        If Long.TryParse(StockTxt.Text, stock) Then
            'parsed to Long successfully.
        Else
            MessageBox.Show("Por favor, introduce un número entero válido.")
        End If




    End Sub
#End Region

End Class
