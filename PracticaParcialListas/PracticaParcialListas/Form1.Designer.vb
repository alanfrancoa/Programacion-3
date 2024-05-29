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
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ComboBoxPlan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEdad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxLocalidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProResultado = New System.Windows.Forms.Label()
        Me.BasicResultado = New System.Windows.Forms.Label()
        Me.LiteResultado = New System.Windows.Forms.Label()
        Me.ClienteMasViejoResultado = New System.Windows.Forms.Label()
        Me.ClienteMasJovenResultado = New System.Windows.Forms.Label()
        Me.ClientesBsAsResultado = New System.Windows.Forms.Label()
        Me.PromedioEdadResultado = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDNI)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPlan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxEdad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso Clientes"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(6, 273)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(346, 38)
        Me.ButtonAgregar.TabIndex = 10
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ComboBoxPlan
        '
        Me.ComboBoxPlan.FormattingEnabled = True
        Me.ComboBoxPlan.Items.AddRange(New Object() {"Lite", "Basic", "Pro"})
        Me.ComboBoxPlan.Location = New System.Drawing.Point(6, 234)
        Me.ComboBoxPlan.Name = "ComboBoxPlan"
        Me.ComboBoxPlan.Size = New System.Drawing.Size(346, 21)
        Me.ComboBoxPlan.TabIndex = 9
        Me.ComboBoxPlan.Text = "Lite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Plan:"
        '
        'TextBoxEdad
        '
        Me.TextBoxEdad.Location = New System.Drawing.Point(6, 195)
        Me.TextBoxEdad.Name = "TextBoxEdad"
        Me.TextBoxEdad.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxEdad.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Edad:"
        '
        'TextBoxLocalidad
        '
        Me.TextBoxLocalidad.Location = New System.Drawing.Point(6, 156)
        Me.TextBoxLocalidad.Name = "TextBoxLocalidad"
        Me.TextBoxLocalidad.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxLocalidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Localidad:"
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(6, 117)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(6, 78)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProResultado)
        Me.GroupBox2.Controls.Add(Me.BasicResultado)
        Me.GroupBox2.Controls.Add(Me.LiteResultado)
        Me.GroupBox2.Controls.Add(Me.ClienteMasViejoResultado)
        Me.GroupBox2.Controls.Add(Me.ClienteMasJovenResultado)
        Me.GroupBox2.Controls.Add(Me.ClientesBsAsResultado)
        Me.GroupBox2.Controls.Add(Me.PromedioEdadResultado)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 280)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadisticas"
        '
        'ProResultado
        '
        Me.ProResultado.AutoSize = True
        Me.ProResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProResultado.Location = New System.Drawing.Point(246, 232)
        Me.ProResultado.Name = "ProResultado"
        Me.ProResultado.Size = New System.Drawing.Size(14, 16)
        Me.ProResultado.TabIndex = 14
        Me.ProResultado.Text = "0"
        '
        'BasicResultado
        '
        Me.BasicResultado.AutoSize = True
        Me.BasicResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicResultado.Location = New System.Drawing.Point(171, 232)
        Me.BasicResultado.Name = "BasicResultado"
        Me.BasicResultado.Size = New System.Drawing.Size(14, 16)
        Me.BasicResultado.TabIndex = 13
        Me.BasicResultado.Text = "0"
        '
        'LiteResultado
        '
        Me.LiteResultado.AutoSize = True
        Me.LiteResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiteResultado.Location = New System.Drawing.Point(81, 232)
        Me.LiteResultado.Name = "LiteResultado"
        Me.LiteResultado.Size = New System.Drawing.Size(14, 16)
        Me.LiteResultado.TabIndex = 12
        Me.LiteResultado.Text = "0"
        '
        'ClienteMasViejoResultado
        '
        Me.ClienteMasViejoResultado.AutoSize = True
        Me.ClienteMasViejoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteMasViejoResultado.Location = New System.Drawing.Point(184, 138)
        Me.ClienteMasViejoResultado.Name = "ClienteMasViejoResultado"
        Me.ClienteMasViejoResultado.Size = New System.Drawing.Size(0, 16)
        Me.ClienteMasViejoResultado.TabIndex = 11
        '
        'ClienteMasJovenResultado
        '
        Me.ClienteMasJovenResultado.AutoSize = True
        Me.ClienteMasJovenResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteMasJovenResultado.Location = New System.Drawing.Point(184, 103)
        Me.ClienteMasJovenResultado.Name = "ClienteMasJovenResultado"
        Me.ClienteMasJovenResultado.Size = New System.Drawing.Size(0, 16)
        Me.ClienteMasJovenResultado.TabIndex = 10
        '
        'ClientesBsAsResultado
        '
        Me.ClientesBsAsResultado.AutoSize = True
        Me.ClientesBsAsResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesBsAsResultado.Location = New System.Drawing.Point(251, 71)
        Me.ClientesBsAsResultado.Name = "ClientesBsAsResultado"
        Me.ClientesBsAsResultado.Size = New System.Drawing.Size(14, 16)
        Me.ClientesBsAsResultado.TabIndex = 9
        Me.ClientesBsAsResultado.Text = "0"
        '
        'PromedioEdadResultado
        '
        Me.PromedioEdadResultado.AutoSize = True
        Me.PromedioEdadResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromedioEdadResultado.Location = New System.Drawing.Point(251, 35)
        Me.PromedioEdadResultado.Name = "PromedioEdadResultado"
        Me.PromedioEdadResultado.Size = New System.Drawing.Size(31, 16)
        Me.PromedioEdadResultado.TabIndex = 8
        Me.PromedioEdadResultado.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(229, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Pro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(139, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Basic"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(63, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Lite"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Cliente mas joven:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cliente mas viejo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Clientes en Buenos Aires:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Promedio edad:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(399, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 603)
        Me.DataGridView1.TabIndex = 2
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(6, 39)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxDNI.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "DNI:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 626)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxLocalidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ComboBoxPlan As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ProResultado As Label
    Friend WithEvents BasicResultado As Label
    Friend WithEvents LiteResultado As Label
    Friend WithEvents ClienteMasViejoResultado As Label
    Friend WithEvents ClienteMasJovenResultado As Label
    Friend WithEvents ClientesBsAsResultado As Label
    Friend WithEvents PromedioEdadResultado As Label
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents Label20 As Label
End Class
