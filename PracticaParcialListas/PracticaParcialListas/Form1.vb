Imports EmpresaServices.Containers
Imports EmpresaServices.Models

Public Class Form1

#Region "Dependencias"
    Private listadoClientes As New ClientesLista
#End Region

#Region "Inicializacion"
    Private Sub updateGrid()
        DataGridView1.DataSource = listadoClientes.GetClientes()
    End Sub
#End Region

#Region "Acciones"
    Private Sub ActualizarEstadisticas()
        Dim promedio As Double = listadoClientes.PromedioEdad()
        PromedioEdadResultado.Text = promedio.ToString("#0.00")

        Dim clientesEnBaires As Long = listadoClientes.clientesPorCiudad("BUENOS AIRES")
        ClientesBsAsResultado.Text = clientesEnBaires

        Dim clienteMasJoven As Cliente = listadoClientes.MasJoven()
        ClienteMasJovenResultado.Text = clienteMasJoven.ToString

        Dim clienteMasViejo As Cliente = listadoClientes.MasViejo()
        ClienteMasViejoResultado.Text = clienteMasViejo.ToString

        Dim planLite As Integer = listadoClientes.ClientePorPlan("Lite")
        Dim planBasic As Integer = listadoClientes.ClientePorPlan("Basic")
        Dim planPro As Integer = listadoClientes.ClientePorPlan("Pro")

        LiteResultado.Text = planLite.ToString
        BasicResultado.Text = planBasic.ToString
        ProResultado.Text = planPro.ToString
    End Sub
#End Region

#Region "Eventos"
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try

            'logica para agregar:
            'Capturamos los valores
            Dim DNI As Long
            If Not Long.TryParse(TextBoxDNI.Text, DNI) Then
                MessageBox.Show("El DNI debe ser un número.")
                Return
            End If

            Dim nombre As String = TextBoxNombre.Text
            Dim apellido As String = TextBoxApellido.Text
            Dim localidad As String = TextBoxLocalidad.Text
            Dim tipo As New TipoPlan(ComboBoxPlan.Text)
            Dim edad As Integer
            If Not Integer.TryParse(TextBoxEdad.Text, edad) Then
                MessageBox.Show("La edad debe ser un número.")
                Return
            End If

            'Creamos el cliente con la informacion
            Dim nuevoCliente = New Cliente(DNI, nombre, apellido, localidad, tipo, edad)

            'Agregamos el cliente al listado
            Dim seAgrego = Me.listadoClientes.agregarCliente(nuevoCliente)

            If seAgrego Then
                'Si se agrega correctamente
                MessageBox.Show("Cliente agregado exitosamente.")
                ActualizarEstadisticas()

                'Actualizamos TextBoxs y combobox
                TextBoxDNI.Text = ""
                TextBoxNombre.Text = ""
                TextBoxApellido.Text = ""
                TextBoxLocalidad.Text = ""
                TextBoxEdad.Text = ""
                ComboBoxPlan.Text = "Lite"
                Me.updateGrid()
            Else
                'Si no se agrega correctamente
                MessageBox.Show("DNI existente, no se agrega cliente.")
            End If

        Catch ex As Exception
            'en caso de que haya errores
            MessageBox.Show("Ha habido un error al agregar cliente.")
        End Try
    End Sub

#End Region

End Class
