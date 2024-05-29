Public Class Form1
    'Crear un programa que almacene clientes de una empresa con distintos de planes (Lite, Basic, Pro)
    'DNI
    '-Nombre
    '-Apellido
    '-Localidad
    '-Edad
    '-Plan (Lite, Basic, Pro)
    '-----------------------------------------
    'El programa debe mostrar un datagridView, con los clientes ingresados

    '-Debe calcular promedio de edad de clientes.✅
    '-Mostrar Cantidad de clientes en Buenos Aires. ✅
    '-Cliente mas joven ✅
    '-Cliente mas viejo ✅
    '-Cantidad de usuarios con cada plan ✅


#Region "Dependencias"
    Private dtClientes As DataTable
#End Region

#Region "Inicializacion"
    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("DNI")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Localidad")
        dt.Columns.Add("Edad")
        dt.Columns.Add("Plan")

        Me.SetDtClientes(dt)
    End Sub
#End Region

#Region "Acciones"
    Private Sub SetDtClientes(dt As DataTable)
        Me.dtClientes = dt
        DataGridView1.DataSource = dt
    End Sub

    Private Sub RecargarEstadisticas()
        Dim acumulador As Integer = 0
        Dim clientesBaires As Integer = 0
        Dim planLite As Integer = 0
        Dim planBasic As Integer = 0
        Dim planPro As Integer = 0
        Dim edadMinima As Integer = 0
        Dim edadMaxima As Integer = 0

        Dim nombreJoven As String = ""
        Dim nombreViejo As String = ""

        For Each renglon As DataRow In dtClientes.Rows
            acumulador += renglon("Edad")

            Dim ciudad As String = renglon("Localidad")
            If ciudad.ToUpper() = "BUENOS AIRES" Then
                clientesBaires += 1
            End If

            Dim plan As String = renglon("Plan")

            If plan = "Lite" Then
                planLite += 1
            ElseIf plan = "Basic" Then
                planBasic += 1
            ElseIf plan = "Pro" Then
                planPro += 1
            End If

            If edadMinima = 0 Or edadMinima > renglon("Edad") Then
                edadMinima = renglon("Edad")
                nombreJoven = renglon("Nombre") + " " + renglon("Apellido") + "(" + renglon("Edad") + ")."
            End If

            If edadMaxima = 0 Or edadMaxima < renglon("Edad") Then
                edadMaxima = renglon("Edad")
                nombreViejo = renglon("Nombre") + " " + renglon("Apellido") + "(" + renglon("Edad") + ")."
            End If

        Next

        'Mostramos Promedio de edades, primero verificamos si hay div por 0
        If dtClientes.Rows.Count > 0 Then
            Dim promedio As Double = acumulador / dtClientes.Rows.Count
            PromedioResultado.Text = promedio.ToString("#0.00")
        Else
            PromedioResultado.Text = "0.00"
        End If

        'Mostramos clientes en Buenos Aires
        ClientesBsAsResultado.Text = clientesBaires.ToString()

        'Mostramos cliente mas joven
        ClienteJovenResultado.Text = nombreJoven

        'Mostramos cliente mas viejo
        ClienteViejoResultado.Text = nombreViejo

        'Mostramos clientes por plan:
        LiteResultado.Text = planLite.ToString()
        BasicResultado.Text = planBasic.ToString()
        ProResultado.Text = planPro.ToString()
    End Sub
#End Region

#Region "Eventos"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim ClienteDNI = Integer.Parse(TextBoxDNI.Text)
        Dim ClienteNombre = TextBoxNombre.Text
        Dim ClienteApellido = TextBoxApellido.Text
        Dim ClienteLocalidad = TextBoxLocalidad.Text
        Dim ClienteEdad = Integer.Parse(TextBoxEdad.Text)
        Dim ClienteTipo = ComboBoxPlanes.Text

        Me.dtClientes.Rows.Add(ClienteDNI, ClienteNombre, ClienteApellido, ClienteLocalidad, ClienteEdad, ClienteTipo)

        RecargarEstadisticas()
    End Sub



#End Region
End Class
