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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelPromedioCarritoP = New System.Windows.Forms.Label()
        Me.LabelPromedioCarrito = New System.Windows.Forms.Label()
        Me.LabelTotalCarritoP = New System.Windows.Forms.Label()
        Me.LabelTotalCarrito = New System.Windows.Forms.Label()
        Me.LabelPromedio = New System.Windows.Forms.Label()
        Me.LabelTotalProdP = New System.Windows.Forms.Label()
        Me.LabelPromedioP = New System.Windows.Forms.Label()
        Me.LabelTotalProd = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(338, 8)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(428, 655)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAdd)
        Me.GroupBox1.Controls.Add(Me.LabelPrecio)
        Me.GroupBox1.Controls.Add(Me.LabelNombre)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBox1.Controls.Add(Me.TextBoxProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 316)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(27, 201)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(263, 26)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "Agregar"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Location = New System.Drawing.Point(10, 105)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LabelPrecio.TabIndex = 3
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(10, 50)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(50, 13)
        Me.LabelNombre.TabIndex = 2
        Me.LabelNombre.Text = "Producto"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(10, 121)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(311, 20)
        Me.TextBoxPrecio.TabIndex = 1
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.Location = New System.Drawing.Point(10, 66)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.Size = New System.Drawing.Size(311, 20)
        Me.TextBoxProducto.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPromedioCarritoP)
        Me.GroupBox2.Controls.Add(Me.LabelPromedioCarrito)
        Me.GroupBox2.Controls.Add(Me.LabelTotalCarritoP)
        Me.GroupBox2.Controls.Add(Me.LabelTotalCarrito)
        Me.GroupBox2.Controls.Add(Me.LabelPromedio)
        Me.GroupBox2.Controls.Add(Me.LabelTotalProdP)
        Me.GroupBox2.Controls.Add(Me.LabelPromedioP)
        Me.GroupBox2.Controls.Add(Me.LabelTotalProd)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 316)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'LabelPromedioCarritoP
        '
        Me.LabelPromedioCarritoP.AutoSize = True
        Me.LabelPromedioCarritoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPromedioCarritoP.Location = New System.Drawing.Point(249, 223)
        Me.LabelPromedioCarritoP.Name = "LabelPromedioCarritoP"
        Me.LabelPromedioCarritoP.Size = New System.Drawing.Size(40, 20)
        Me.LabelPromedioCarritoP.TabIndex = 7
        Me.LabelPromedioCarritoP.Text = "0.00"
        '
        'LabelPromedioCarrito
        '
        Me.LabelPromedioCarrito.AutoSize = True
        Me.LabelPromedioCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPromedioCarrito.Location = New System.Drawing.Point(249, 170)
        Me.LabelPromedioCarrito.Name = "LabelPromedioCarrito"
        Me.LabelPromedioCarrito.Size = New System.Drawing.Size(40, 20)
        Me.LabelPromedioCarrito.TabIndex = 6
        Me.LabelPromedioCarrito.Text = "0.00"
        '
        'LabelTotalCarritoP
        '
        Me.LabelTotalCarritoP.AutoSize = True
        Me.LabelTotalCarritoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalCarritoP.Location = New System.Drawing.Point(250, 117)
        Me.LabelTotalCarritoP.Name = "LabelTotalCarritoP"
        Me.LabelTotalCarritoP.Size = New System.Drawing.Size(40, 20)
        Me.LabelTotalCarritoP.TabIndex = 5
        Me.LabelTotalCarritoP.Text = "0.00"
        '
        'LabelTotalCarrito
        '
        Me.LabelTotalCarrito.AutoSize = True
        Me.LabelTotalCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalCarrito.Location = New System.Drawing.Point(250, 65)
        Me.LabelTotalCarrito.Name = "LabelTotalCarrito"
        Me.LabelTotalCarrito.Size = New System.Drawing.Size(40, 20)
        Me.LabelTotalCarrito.TabIndex = 4
        Me.LabelTotalCarrito.Text = "0.00"
        '
        'LabelPromedio
        '
        Me.LabelPromedio.AutoSize = True
        Me.LabelPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPromedio.Location = New System.Drawing.Point(10, 170)
        Me.LabelPromedio.Name = "LabelPromedio"
        Me.LabelPromedio.Size = New System.Drawing.Size(199, 20)
        Me.LabelPromedio.TabIndex = 3
        Me.LabelPromedio.Text = "Promedio de productos:"
        '
        'LabelTotalProdP
        '
        Me.LabelTotalProdP.AutoSize = True
        Me.LabelTotalProdP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalProdP.Location = New System.Drawing.Point(10, 117)
        Me.LabelTotalProdP.Name = "LabelTotalProdP"
        Me.LabelTotalProdP.Size = New System.Drawing.Size(155, 20)
        Me.LabelTotalProdP.TabIndex = 2
        Me.LabelTotalProdP.Text = "Total productos P:"
        '
        'LabelPromedioP
        '
        Me.LabelPromedioP.AutoSize = True
        Me.LabelPromedioP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPromedioP.Location = New System.Drawing.Point(9, 223)
        Me.LabelPromedioP.Name = "LabelPromedioP"
        Me.LabelPromedioP.Size = New System.Drawing.Size(215, 20)
        Me.LabelPromedioP.TabIndex = 1
        Me.LabelPromedioP.Text = "Promedio de productos P:"
        '
        'LabelTotalProd
        '
        Me.LabelTotalProd.AutoSize = True
        Me.LabelTotalProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalProd.Location = New System.Drawing.Point(10, 65)
        Me.LabelTotalProd.Name = "LabelTotalProd"
        Me.LabelTotalProd.Size = New System.Drawing.Size(140, 20)
        Me.LabelTotalProd.TabIndex = 0
        Me.LabelTotalProd.Text = "Total Productos:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 671)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelPromedio As Label
    Friend WithEvents LabelTotalProdP As Label
    Friend WithEvents LabelPromedioP As Label
    Friend WithEvents LabelTotalProd As Label
    Friend WithEvents LabelPromedioCarritoP As Label
    Friend WithEvents LabelPromedioCarrito As Label
    Friend WithEvents LabelTotalCarritoP As Label
    Friend WithEvents LabelTotalCarrito As Label
End Class
