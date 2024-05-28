<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDuracion = New System.Windows.Forms.TextBox()
        Me.TextBoxGenero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.DuracionTotal = New System.Windows.Forms.Label()
        Me.Promedio = New System.Windows.Forms.Label()
        Me.PromedioTerror = New System.Windows.Forms.Label()
        Me.CantidadDrama = New System.Windows.Forms.Label()
        Me.DuracionTotalResultado = New System.Windows.Forms.Label()
        Me.PromedioResultado = New System.Windows.Forms.Label()
        Me.CantidadDramaResultado = New System.Windows.Forms.Label()
        Me.PromedioTerrorResultado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Controls.Add(Me.TextBoxDuracion)
        Me.GroupBox1.Controls.Add(Me.TextBoxGenero)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese pelicula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PromedioTerrorResultado)
        Me.GroupBox2.Controls.Add(Me.CantidadDramaResultado)
        Me.GroupBox2.Controls.Add(Me.PromedioResultado)
        Me.GroupBox2.Controls.Add(Me.DuracionTotalResultado)
        Me.GroupBox2.Controls.Add(Me.PromedioTerror)
        Me.GroupBox2.Controls.Add(Me.CantidadDrama)
        Me.GroupBox2.Controls.Add(Me.Promedio)
        Me.GroupBox2.Controls.Add(Me.DuracionTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 221)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadisticas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(262, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 452)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Duracion:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(9, 46)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxNombre.TabIndex = 3
        '
        'TextBoxDuracion
        '
        Me.TextBoxDuracion.Location = New System.Drawing.Point(9, 134)
        Me.TextBoxDuracion.Name = "TextBoxDuracion"
        Me.TextBoxDuracion.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxDuracion.TabIndex = 7
        '
        'TextBoxGenero
        '
        Me.TextBoxGenero.Location = New System.Drawing.Point(6, 91)
        Me.TextBoxGenero.Name = "TextBoxGenero"
        Me.TextBoxGenero.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxGenero.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Genero:"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(9, 170)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(216, 26)
        Me.ButtonAgregar.TabIndex = 3
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'DuracionTotal
        '
        Me.DuracionTotal.AutoSize = True
        Me.DuracionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DuracionTotal.Location = New System.Drawing.Point(6, 29)
        Me.DuracionTotal.Name = "DuracionTotal"
        Me.DuracionTotal.Size = New System.Drawing.Size(107, 16)
        Me.DuracionTotal.TabIndex = 3
        Me.DuracionTotal.Text = "Duracion total:"
        '
        'Promedio
        '
        Me.Promedio.AutoSize = True
        Me.Promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promedio.Location = New System.Drawing.Point(6, 72)
        Me.Promedio.Name = "Promedio"
        Me.Promedio.Size = New System.Drawing.Size(78, 16)
        Me.Promedio.TabIndex = 4
        Me.Promedio.Text = "Promedio:"
        '
        'PromedioTerror
        '
        Me.PromedioTerror.AutoSize = True
        Me.PromedioTerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromedioTerror.Location = New System.Drawing.Point(6, 158)
        Me.PromedioTerror.Name = "PromedioTerror"
        Me.PromedioTerror.Size = New System.Drawing.Size(125, 16)
        Me.PromedioTerror.TabIndex = 6
        Me.PromedioTerror.Text = "Promedio Terror:"
        '
        'CantidadDrama
        '
        Me.CantidadDrama.AutoSize = True
        Me.CantidadDrama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadDrama.Location = New System.Drawing.Point(6, 115)
        Me.CantidadDrama.Name = "CantidadDrama"
        Me.CantidadDrama.Size = New System.Drawing.Size(123, 16)
        Me.CantidadDrama.TabIndex = 5
        Me.CantidadDrama.Text = "Cantidad Drama:"
        '
        'DuracionTotalResultado
        '
        Me.DuracionTotalResultado.AutoSize = True
        Me.DuracionTotalResultado.Location = New System.Drawing.Point(141, 32)
        Me.DuracionTotalResultado.Name = "DuracionTotalResultado"
        Me.DuracionTotalResultado.Size = New System.Drawing.Size(28, 13)
        Me.DuracionTotalResultado.TabIndex = 3
        Me.DuracionTotalResultado.Text = "0.00"
        '
        'PromedioResultado
        '
        Me.PromedioResultado.AutoSize = True
        Me.PromedioResultado.Location = New System.Drawing.Point(141, 75)
        Me.PromedioResultado.Name = "PromedioResultado"
        Me.PromedioResultado.Size = New System.Drawing.Size(28, 13)
        Me.PromedioResultado.TabIndex = 7
        Me.PromedioResultado.Text = "0.00"
        '
        'CantidadDramaResultado
        '
        Me.CantidadDramaResultado.AutoSize = True
        Me.CantidadDramaResultado.Location = New System.Drawing.Point(141, 117)
        Me.CantidadDramaResultado.Name = "CantidadDramaResultado"
        Me.CantidadDramaResultado.Size = New System.Drawing.Size(13, 13)
        Me.CantidadDramaResultado.TabIndex = 8
        Me.CantidadDramaResultado.Text = "0"
        '
        'PromedioTerrorResultado
        '
        Me.PromedioTerrorResultado.AutoSize = True
        Me.PromedioTerrorResultado.Location = New System.Drawing.Point(141, 161)
        Me.PromedioTerrorResultado.Name = "PromedioTerrorResultado"
        Me.PromedioTerrorResultado.Size = New System.Drawing.Size(28, 13)
        Me.PromedioTerrorResultado.TabIndex = 9
        Me.PromedioTerrorResultado.Text = "0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 477)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBoxDuracion As TextBox
    Friend WithEvents TextBoxGenero As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PromedioTerrorResultado As Label
    Friend WithEvents CantidadDramaResultado As Label
    Friend WithEvents PromedioResultado As Label
    Friend WithEvents DuracionTotalResultado As Label
    Friend WithEvents PromedioTerror As Label
    Friend WithEvents CantidadDrama As Label
    Friend WithEvents Promedio As Label
    Friend WithEvents DuracionTotal As Label
End Class
