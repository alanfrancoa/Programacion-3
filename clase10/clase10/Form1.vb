Public Class Form1

#Region "Dependencias"
    Private dtPersonas As DataTable
#End Region

#Region "Inicializar"
    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Edad", GetType(Integer))
        Me.SetDtPersonas(dt)
    End Sub

#End Region

#Region "Acciones"
    Private Sub SetDtPersonas(dt As DataTable)
        Me.dtPersonas = dt
        DataGridView1.DataSource = dt
        'Apuntamos el DataTable al source del DataGridView1'
    End Sub

    Private Sub RecargarPromedio()
        Dim acumulador As Double = 0
        Dim acumuladorM As Double = 0
        Dim contadorM As Integer = 0

        For Each renglon As DataRow In dtPersonas.Rows

            acumulador += renglon("Edad")
            Dim nombre As String = renglon("Nombre")

            'nombre toma el valor del renglon Nombre'
            If nombre.ToUpper().StartsWith("M") Then
                acumuladorM += renglon("Edad")
                contadorM += 1
            End If
            'En caso de que Nombre empiece con M, lo acumula e incrementa el contadorM'

            Dim promedio = acumulador / dtPersonas.Rows.Count
            'Para todo elemento que sea parte de la coleccion, count nos va a dar la cantidad de elementos.'

            Label6.Text = promedio.ToString("#0.00")
            'Asignamos el valor de promedio en el label del Form. ToString 0.00, nos da los primeros dos digitos despues de la coma.'

            If contadorM > 0 Then
                Dim promedioM = acumuladorM / contadorM
                Label7.Text = promedioM.ToString("#0.00")
            Else
                Label7.Text = "0.00"
            End If

        Next
    End Sub


#End Region

#Region "Eventos"

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        InicializarDataTable()
        Me.dtPersonas.Rows.Add("Juan", "Gomez", 44)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombre = TextBox1.Text
        Dim apellido = TextBox2.Text
        Dim edad = Integer.Parse(TextBox3.Text)
        'Captura los valores de los textbox, en el ultimo lo convierte a Entero'

        Me.dtPersonas.Rows.Add(nombre, apellido, edad)
        'Agrega una fila en el data table, con las variables'

        RecargarPromedio()
        'Llamo a la funcion de muestra de promedios'

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()
    End Sub
    'Cuando se carga el form, inicializa data table'


#End Region

End Class
