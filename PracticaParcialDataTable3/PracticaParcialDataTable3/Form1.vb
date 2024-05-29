'Una vinoteca solicita un programa, para poder contabilizar varias cosas de sus productos.
'Cada producto tiene
'Marca
'Descripcion
'Capacidad
'EnvaseTipo
'Procentaje de alcohol
'______________________________
'Se pide que el programa:
'   -Cuente la cantidad de vinos en botella.
'   -Muestre la bebida con mayor porcentaje de alcohol
'   -Cuente cuantos productos tenemos de la marca "Quilmes"
Public Class Form1

#Region "Dependencias"
    Private dtBebidas As DataTable
#End Region

#Region "Inicializacion"
    Private Sub IniciarDataTable()
        Dim dt As New DataTable()
        dt.Columns.Add("Marca")
        dt.Columns.Add("Descripcion")
        dt.Columns.Add("Capacidad")
        dt.Columns.Add("TipoEnvase")
        dt.Columns.Add("PorcentajeAlcohol")
        'Agregamos las columnas, para obtener el modelo de la Data Table'

        Me.SetDTBebidas(dt)
        'Seteamos la dataTable'
    End Sub
#End Region

#Region "Acciones"

    Private Sub Limpiar()
        TextBoxMarca.Text = String.Empty
        TextBoxProducto.Text = String.Empty
        TextBoxCapacidad.Text = String.Empty
        ComboBoxTipoEnvase.Text = String.Empty
        TextBoxPorcentaje.Text = String.Empty
    End Sub
    Private Sub SetDTBebidas(dt As DataTable)
        Me.dtBebidas = dt
        'Relacionamos el dtBebidas con dt'
        DataGridView1.DataSource = dt
        'Asignamos la Data Table al DataGridView1'
    End Sub

    Private Sub RecargarInformacion()
        'Funcion de recarga de informacion del group'
        Dim contadorVinoBotella As Long = 0 'Va a contabilizar la cantida de vino y botellas'
        Dim productosQuilmes As Long = 0 'Contabiliza la cantidad de productos Quilmes'
        Dim BebidaMasFuerte As String = "" 'Aqui se concatena la info de los renglones, para mostrar la bebida mas fuerte'
        Dim porcentajeAlto As Double = 0 'Variable auxiliar, para utilizar en busqueda de porcentajes'

        For Each renglon As DataRow In dtBebidas.Rows

            Dim marcaProducto As String = renglon("Marca").ToString()

            Dim descripcionProducto As String = renglon("Descripcion").ToString()

            Dim tipoDeEnvase As String = renglon("TipoEnvase").ToString()

            Dim porcentajeAlc As Double = Convert.ToDouble(renglon("PorcentajeAlcohol"))

            If tipoDeEnvase.ToUpper() = "BOTELLA" AndAlso descripcionProducto.IndexOf("vino", StringComparison.OrdinalIgnoreCase) >= 0 Then
                contadorVinoBotella += 1

            End If

            If marcaProducto.ToUpper() = "QUILMES" Then
                productosQuilmes += 1

            End If

            If porcentajeAlto = 0 Or porcentajeAlto < porcentajeAlc Then
                porcentajeAlto = porcentajeAlc
                BebidaMasFuerte = descripcionProducto & vbCrLf & "Marca: " & marcaProducto & vbCrLf & "Graduación alcohólica: " & porcentajeAlto.ToString() & "%."
            End If

        Next

        VinoEmbotelladoResultado.Text = contadorVinoBotella.ToString()
        ProductosQuilmesResultado.Text = productosQuilmes.ToString()
        BebidaFuerteResultado.Text = BebidaMasFuerte
    End Sub

#End Region

#Region "Eventos"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarDataTable()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            Dim marca As String = TextBoxMarca.Text
            Dim producto As String = TextBoxProducto.Text
            Dim capacidad = Double.Parse(TextBoxCapacidad.Text)
            Dim envaseTipo As String = ComboBoxTipoEnvase.Text
            Dim porcentaje = Double.Parse(TextBoxPorcentaje.Text)

            dtBebidas.Rows.Add(marca, producto, capacidad, envaseTipo, porcentaje)
            Limpiar()
            RecargarInformacion()
        Catch ex As Exception
            MessageBox.Show("Ha habido un error.")
            Limpiar()
        End Try

    End Sub
#End Region

End Class
