'Crear un programa que almacene peliculas
'Con nombre
'Genero
'Duracion
'-----------------------------------------
'El programa debe mostrar un datagridView, con las peliculas ingresadas

'-Debe mostrar la sumatoria de todas las duraciones
'-Promedio de duracion
'-Cuantas peliculas de drama, se ingresaron.
'-Debe mostrar promedio de peliculas de terror.
Public Class Form1

#Region "Dependencias"
    Dim dtPeliculas As New DataTable 'Creamos dataTable'
#End Region

#Region "Inicializar"

    Private Sub InicializarDataTable() 'Inicializamos el dataTable, definiendo sus columnas'
        Dim dt As New DataTable
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Genero")
        dt.Columns.Add("Duracion")
        Me.SetDtPeliculas(dt)
    End Sub

#End Region

#Region "Acciones"
    Private Sub SetDtPeliculas(dt As DataTable)
        Me.dtPeliculas = dt 'Enlazamos dtPeliculas con dt'
        DataGridView1.DataSource = dt 'Asignamos dt, al DataGridView'
    End Sub

    Private Sub RecargarEstadisticas()
        Dim acumulador = 0
        Dim contadorDrama = 0
        Dim acumuladorTerror = 0
        Dim contadorTerror = 0

        For Each renglon As DataRow In dtPeliculas.Rows
            'Por cada renglon en dtPeliculas'
            acumulador += renglon("Duracion")
            Dim genero As String = renglon("Genero")
            'acumulamos la duracion y capturamos el genero, para realizar las verificaciones'

            If genero.ToUpper() = "DRAMA" Then
                'Si genero es drama'
                contadorDrama += 1
                'Sumamos 1 a nuestro ContadorDrama'
            End If

            If genero.ToUpper() = "TERROR" Then
                'Si genero es terror'
                acumuladorTerror += renglon("Duracion")
                contadorTerror += 1
                'Acumulamos la duracion y sumamos 1 al ContadorTerror'
            End If

        Next

        DuracionTotalResultado.Text = acumulador.ToString("#0.00")
        'Mostramos resultado de sumatoria de duraciones, en label de Resultado'

        Dim promedio = acumulador / dtPeliculas.Rows.Count
        PromedioResultado.Text = promedio.ToString("#0.00")
        'Mostramos promedio de tiempo de peliculas, en label de Promedio'

        CantidadDramaResultado.Text = contadorDrama.ToString()
        'Mostramos cantidad Drama en label Cant Dramas'


        If contadorTerror > 0 Then
            'Primero nos fijamos que contador no sea 0, para no hacer una division con 0'
            Dim promedioTerror = acumuladorTerror / contadorTerror
            PromedioTerrorResultado.Text = promedioTerror.ToString("#0.00")
            'Ya verificado, se calcula el promedio y se muestra en un label'
        Else
            PromedioTerrorResultado.Text = "0.00"
            'En caso de que sea 0, simplemente mostramos el texto y no dividimos.'
        End If
    End Sub


#End Region

#Region "Eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()
        'Inicializamos el dataTable cuando se cargue el Form'
    End Sub
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        'Agregamos los valores de los textBox, en variables'
        Dim nombre = TextBoxNombre.Text
        Dim genero = TextBoxGenero.Text
        Dim duracion = Double.Parse(TextBoxDuracion.Text)

        'Con las variables como parametros, agregamos una fila al DataTable'
        Me.dtPeliculas.Rows.Add(nombre, genero, duracion)

        RecargarEstadisticas()

    End Sub
#End Region

End Class
