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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLocalidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEdad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPlanes = New System.Windows.Forms.ComboBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PromedioResultado = New System.Windows.Forms.Label()
        Me.ClientesBsAsResultado = New System.Windows.Forms.Label()
        Me.ClienteJovenResultado = New System.Windows.Forms.Label()
        Me.ClienteViejoResultado = New System.Windows.Forms.Label()
        Me.LiteResultado = New System.Windows.Forms.Label()
        Me.BasicResultado = New System.Windows.Forms.Label()
        Me.ProResultado = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDNI)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPlanes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxEdad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 324)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso Clientes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProResultado)
        Me.GroupBox2.Controls.Add(Me.BasicResultado)
        Me.GroupBox2.Controls.Add(Me.LiteResultado)
        Me.GroupBox2.Controls.Add(Me.ClienteViejoResultado)
        Me.GroupBox2.Controls.Add(Me.ClienteJovenResultado)
        Me.GroupBox2.Controls.Add(Me.ClientesBsAsResultado)
        Me.GroupBox2.Controls.Add(Me.PromedioResultado)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 310)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadisticas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(362, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(529, 640)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(6, 75)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxNombre.TabIndex = 1
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(6, 120)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'TextBoxLocalidad
        '
        Me.TextBoxLocalidad.Location = New System.Drawing.Point(6, 165)
        Me.TextBoxLocalidad.Name = "TextBoxLocalidad"
        Me.TextBoxLocalidad.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxLocalidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Localidad"
        '
        'TextBoxEdad
        '
        Me.TextBoxEdad.Location = New System.Drawing.Point(6, 209)
        Me.TextBoxEdad.Name = "TextBoxEdad"
        Me.TextBoxEdad.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxEdad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Plan"
        '
        'ComboBoxPlanes
        '
        Me.ComboBoxPlanes.FormattingEnabled = True
        Me.ComboBoxPlanes.Items.AddRange(New Object() {"Lite", "Basic", "Pro"})
        Me.ComboBoxPlanes.Location = New System.Drawing.Point(6, 251)
        Me.ComboBoxPlanes.Name = "ComboBoxPlanes"
        Me.ComboBoxPlanes.Size = New System.Drawing.Size(318, 21)
        Me.ComboBoxPlanes.TabIndex = 10
        Me.ComboBoxPlanes.Text = "Lite"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(6, 278)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(318, 40)
        Me.ButtonAgregar.TabIndex = 11
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Promedio Edad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Clientes en Buenos Aires:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cliente mas Viejo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Cliente mas Joven:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Lite"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(251, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Pro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(130, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Basic"
        '
        'PromedioResultado
        '
        Me.PromedioResultado.AutoSize = True
        Me.PromedioResultado.Location = New System.Drawing.Point(237, 37)
        Me.PromedioResultado.Name = "PromedioResultado"
        Me.PromedioResultado.Size = New System.Drawing.Size(28, 13)
        Me.PromedioResultado.TabIndex = 10
        Me.PromedioResultado.Text = "0.00"
        '
        'ClientesBsAsResultado
        '
        Me.ClientesBsAsResultado.AutoSize = True
        Me.ClientesBsAsResultado.Location = New System.Drawing.Point(237, 87)
        Me.ClientesBsAsResultado.Name = "ClientesBsAsResultado"
        Me.ClientesBsAsResultado.Size = New System.Drawing.Size(13, 13)
        Me.ClientesBsAsResultado.TabIndex = 11
        Me.ClientesBsAsResultado.Text = "0"
        '
        'ClienteJovenResultado
        '
        Me.ClienteJovenResultado.AutoSize = True
        Me.ClienteJovenResultado.Location = New System.Drawing.Point(177, 132)
        Me.ClienteJovenResultado.Name = "ClienteJovenResultado"
        Me.ClienteJovenResultado.Size = New System.Drawing.Size(0, 13)
        Me.ClienteJovenResultado.TabIndex = 12
        '
        'ClienteViejoResultado
        '
        Me.ClienteViejoResultado.AutoSize = True
        Me.ClienteViejoResultado.Location = New System.Drawing.Point(177, 182)
        Me.ClienteViejoResultado.Name = "ClienteViejoResultado"
        Me.ClienteViejoResultado.Size = New System.Drawing.Size(13, 13)
        Me.ClienteViejoResultado.TabIndex = 13
        Me.ClienteViejoResultado.Text = "0"
        '
        'LiteResultado
        '
        Me.LiteResultado.AutoSize = True
        Me.LiteResultado.Location = New System.Drawing.Point(44, 251)
        Me.LiteResultado.Name = "LiteResultado"
        Me.LiteResultado.Size = New System.Drawing.Size(13, 13)
        Me.LiteResultado.TabIndex = 14
        Me.LiteResultado.Text = "0"
        '
        'BasicResultado
        '
        Me.BasicResultado.AutoSize = True
        Me.BasicResultado.Location = New System.Drawing.Point(163, 251)
        Me.BasicResultado.Name = "BasicResultado"
        Me.BasicResultado.Size = New System.Drawing.Size(13, 13)
        Me.BasicResultado.TabIndex = 15
        Me.BasicResultado.Text = "0"
        '
        'ProResultado
        '
        Me.ProResultado.AutoSize = True
        Me.ProResultado.Location = New System.Drawing.Point(269, 251)
        Me.ProResultado.Name = "ProResultado"
        Me.ProResultado.Size = New System.Drawing.Size(13, 13)
        Me.ProResultado.TabIndex = 16
        Me.ProResultado.Text = "0"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(7, 34)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxDNI.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "DNI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 664)
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ComboBoxPlanes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxLocalidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProResultado As Label
    Friend WithEvents BasicResultado As Label
    Friend WithEvents LiteResultado As Label
    Friend WithEvents ClienteViejoResultado As Label
    Friend WithEvents ClienteJovenResultado As Label
    Friend WithEvents ClientesBsAsResultado As Label
    Friend WithEvents PromedioResultado As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents Label13 As Label
End Class
