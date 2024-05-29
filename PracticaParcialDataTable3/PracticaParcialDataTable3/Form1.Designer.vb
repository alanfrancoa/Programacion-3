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
        Me.ComboBoxTipoEnvase = New System.Windows.Forms.ComboBox()
        Me.TextBoxPorcentaje = New System.Windows.Forms.TextBox()
        Me.TextBoxCapacidad = New System.Windows.Forms.TextBox()
        Me.TextBoxProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BebidaFuerteResultado = New System.Windows.Forms.Label()
        Me.ProductosQuilmesResultado = New System.Windows.Forms.Label()
        Me.VinoEmbotelladoResultado = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipoEnvase)
        Me.GroupBox1.Controls.Add(Me.TextBoxPorcentaje)
        Me.GroupBox1.Controls.Add(Me.TextBoxCapacidad)
        Me.GroupBox1.Controls.Add(Me.TextBoxProducto)
        Me.GroupBox1.Controls.Add(Me.TextBoxMarca)
        Me.GroupBox1.Controls.Add(Me.ButtonAdd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso productos"
        '
        'ComboBoxTipoEnvase
        '
        Me.ComboBoxTipoEnvase.FormattingEnabled = True
        Me.ComboBoxTipoEnvase.Items.AddRange(New Object() {"Botella", "Porron", "Lata", "Damajuana", "Pack"})
        Me.ComboBoxTipoEnvase.Location = New System.Drawing.Point(35, 155)
        Me.ComboBoxTipoEnvase.Name = "ComboBoxTipoEnvase"
        Me.ComboBoxTipoEnvase.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxTipoEnvase.TabIndex = 3
        Me.ComboBoxTipoEnvase.Text = "Botella"
        '
        'TextBoxPorcentaje
        '
        Me.TextBoxPorcentaje.Location = New System.Drawing.Point(35, 200)
        Me.TextBoxPorcentaje.Name = "TextBoxPorcentaje"
        Me.TextBoxPorcentaje.Size = New System.Drawing.Size(221, 20)
        Me.TextBoxPorcentaje.TabIndex = 11
        '
        'TextBoxCapacidad
        '
        Me.TextBoxCapacidad.Location = New System.Drawing.Point(35, 114)
        Me.TextBoxCapacidad.Name = "TextBoxCapacidad"
        Me.TextBoxCapacidad.Size = New System.Drawing.Size(221, 20)
        Me.TextBoxCapacidad.TabIndex = 9
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.Location = New System.Drawing.Point(35, 71)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.Size = New System.Drawing.Size(221, 20)
        Me.TextBoxProducto.TabIndex = 8
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(35, 32)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(221, 20)
        Me.TextBoxMarca.TabIndex = 3
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(35, 226)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(182, 33)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "Ingresar"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Porcentaje de Alcohol"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de Envase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Capacidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Marca"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BebidaFuerteResultado)
        Me.GroupBox2.Controls.Add(Me.ProductosQuilmesResultado)
        Me.GroupBox2.Controls.Add(Me.VinoEmbotelladoResultado)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'BebidaFuerteResultado
        '
        Me.BebidaFuerteResultado.AutoSize = True
        Me.BebidaFuerteResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BebidaFuerteResultado.Location = New System.Drawing.Point(97, 139)
        Me.BebidaFuerteResultado.Name = "BebidaFuerteResultado"
        Me.BebidaFuerteResultado.Size = New System.Drawing.Size(0, 13)
        Me.BebidaFuerteResultado.TabIndex = 16
        '
        'ProductosQuilmesResultado
        '
        Me.ProductosQuilmesResultado.AutoSize = True
        Me.ProductosQuilmesResultado.Location = New System.Drawing.Point(217, 70)
        Me.ProductosQuilmesResultado.Name = "ProductosQuilmesResultado"
        Me.ProductosQuilmesResultado.Size = New System.Drawing.Size(13, 13)
        Me.ProductosQuilmesResultado.TabIndex = 15
        Me.ProductosQuilmesResultado.Text = "0"
        '
        'VinoEmbotelladoResultado
        '
        Me.VinoEmbotelladoResultado.AutoSize = True
        Me.VinoEmbotelladoResultado.Location = New System.Drawing.Point(217, 29)
        Me.VinoEmbotelladoResultado.Name = "VinoEmbotelladoResultado"
        Me.VinoEmbotelladoResultado.Size = New System.Drawing.Size(13, 13)
        Me.VinoEmbotelladoResultado.TabIndex = 3
        Me.VinoEmbotelladoResultado.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bebida mas fuerte"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Productos Marca Quilmes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Vinos embotellados"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(329, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(472, 489)
        Me.DataGridView1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 523)
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
    Friend WithEvents TextBoxCapacidad As TextBox
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents TextBoxMarca As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxTipoEnvase As ComboBox
    Friend WithEvents TextBoxPorcentaje As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BebidaFuerteResultado As Label
    Friend WithEvents ProductosQuilmesResultado As Label
    Friend WithEvents VinoEmbotelladoResultado As Label
End Class
