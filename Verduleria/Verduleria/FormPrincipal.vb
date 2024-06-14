Imports System.Configuration

Public Class FormPrincipal

    Private ventanaNueva As NuevaVentana

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Cuando demos click en el striptmenu a la opcion -> Salir'
        Me.Close()
        'Cerramos el Form Principal'
    End Sub

    Private Sub AltasDeVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasDeVerdurasToolStripMenuItem.Click
        'Cuando demos click en el striptmenu a la opcion -> Maestro -> Alta Verduras'
        Dim formu As New FormularioAlta
        'Creamos un nuevo objeto de tipo FormularioAlta.'

        formu.MdiParent = Me
        'El padre de este formulario, es Me (o This -> El formularioPrincipal -> EL OBJETO QUE EJECUTA EL METODO)'
        'Hay que configurar el formPrincipal para que sea MDI Container'

        formu.WindowState = FormWindowState.Maximized 'o 2, es lo mismo.'
        'El form Se abre maximizado'

        formu.Show()
        'Mostramos el formulario'
        'Queda contenida dentro del FormularioPrincipal '
    End Sub

    Private Sub ListadoVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoVerdurasToolStripMenuItem.Click
        'Cuando demos click en el striptmenu a la opcion -> Ver Informes -> Ver Listado de Verduras'

        Dim formu As New FormularioListado
        'Creamos un nuevo objeto de tipo FormularioAlta.'

        formu.Show()
        'Mostramos el formulario'
        'Se va a mostrar como una ventana aparte del formPrincipal, por no estar en el MDI.'
    End Sub

    Private Sub NuevaVentanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentanaToolStripMenuItem.Click
        'Cuando demos click en el striptmenu a la opcion -> Ver Informes -> Nueva Ventana'
        'Va a mostrar la ventana unicamente una sola vez, cuando la cerremos, no se podra volver a abrir.'

        If ventanaNueva Is Nothing Then
            'Si la ventana no existe'
            ventanaNueva = New NuevaVentana
            'Creamos un nuevo objeto de tipo Nueva Ventana.'
            ventanaNueva.MdiParent = Me
        End If

        ventanaNueva.Show()
        'Muestra el Formulario'

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'al hacer click en el boton de Login'
        Dim contrase = ConfigurationManager.AppSettings("contrasena")
        'Se almacena en contrase, la posicion contrasena de App.Config'
        Dim mensaje = "Contrasena Incorrecta"
        'Se almacena el texto para el label del progress bar en una variable auxiliar.'
        If TextBox2.Text = contrase Then
            'MenuStrip1.Visible = True
            'Panel1.Visible = False
            'Dim form As New ProgressBar
            'form.Show()
            mensaje = "Cargando..."
            'si la password es correcta se modifica el texto del progress bar'
            LabelErrors.Text = mensaje
            'Se asigna el mensaje al label'
            Timerprogress.Enabled = True
            'Se activa el timer'

        Else 'Si hay errores en la contrasena del textbox'
            LabelErrors.Text = mensaje
            'se asigna el valor de mensaje al label'
            LabelErrors.Visible = True
            'Se establece el label visible'
        End If


    End Sub

    Private Sub Timerprogress_Tick(sender As Object, e As EventArgs) Handles Timerprogress.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            'Si la progress bar llega al su maximo'
            Panel1.Hide()
            'se oculta panel de login'
            MenuStrip1.Visible = True
            'se muentra el menu stript'
        Else
            'Caso contrario'
            Dim nuevoValor = ProgressBar1.Value + 10
            'Suma diez'
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
            'Se establece el techo'
            LabelErrors.Visible = True
            'Label de errores visible mientras esta en proceso.'

        End If
    End Sub

    Private Sub CambiarFondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFondoToolStripMenuItem.Click
        'Cuando den click en el StripMenu a Maestro -> Cambiar Fondo'
        OpenFileDialog1.ShowDialog()
        'LLama a la ventana de subida de archivos'
        Dim rutaArchivo = OpenFileDialog1.FileName
        ''Ruta y nombre del archivo que yo elegi'
        ''MessageBox.Show(rutaArchivo)
        'Muestra ruta en un messageBox'
        Dim imagenFondo = Image.FromFile(rutaArchivo)
        'Creamos el objeto imagen, el metodo Image.FromFile, nos crea la imagen dada una ruta.'
        Me.BackgroundImage = imagenFondo
        'Con la imagen convertida a objeto, podemos establecerla de fondo, por ejemplo.'
        ''Me.BackgroundImageLayout = ImageLayout.Center
        ''Podemos centrar la imagen.'
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'En el evento de formLoad'
        Dim CambiaFondo = ConfigurationManager.AppSettings("cambia-fondo")
        'Traemos la configuracion'
        If CambiaFondo <> "S" Then
            'Si su valor es distinto a si'
            CambiarFondoToolStripMenuItem.Visible = False
            'Ocultamos nuestro Item para cambio de fondo de pantalla.'
        End If

    End Sub
End Class
