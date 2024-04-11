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
        Me.ProductLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ProductTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.AddProductBtn = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.ProductsGridView = New System.Windows.Forms.DataGridView()
        Me.ProductColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProductsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductLabel
        '
        Me.ProductLabel.AutoSize = True
        Me.ProductLabel.Location = New System.Drawing.Point(29, 84)
        Me.ProductLabel.Name = "ProductLabel"
        Me.ProductLabel.Size = New System.Drawing.Size(50, 13)
        Me.ProductLabel.TabIndex = 0
        Me.ProductLabel.Text = "Producto"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(29, 120)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(37, 13)
        Me.PriceLabel.TabIndex = 1
        Me.PriceLabel.Text = "Precio"
        '
        'ProductTextBox
        '
        Me.ProductTextBox.Location = New System.Drawing.Point(103, 81)
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.Size = New System.Drawing.Size(219, 20)
        Me.ProductTextBox.TabIndex = 2
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(103, 113)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(219, 20)
        Me.PriceTextBox.TabIndex = 3
        '
        'AddProductBtn
        '
        Me.AddProductBtn.Location = New System.Drawing.Point(126, 160)
        Me.AddProductBtn.Name = "AddProductBtn"
        Me.AddProductBtn.Size = New System.Drawing.Size(171, 29)
        Me.AddProductBtn.TabIndex = 4
        Me.AddProductBtn.Text = "Agregar"
        Me.AddProductBtn.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(29, 277)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(34, 13)
        Me.TotalLabel.TabIndex = 5
        Me.TotalLabel.Text = "Total:"
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceLabel.Location = New System.Drawing.Point(282, 275)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(15, 16)
        Me.TotalPriceLabel.TabIndex = 6
        Me.TotalPriceLabel.Text = "0"
        '
        'ProductsGridView
        '
        Me.ProductsGridView.AllowUserToAddRows = False
        Me.ProductsGridView.AllowUserToDeleteRows = False
        Me.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductColumn, Me.PriceColumn})
        Me.ProductsGridView.Location = New System.Drawing.Point(364, 12)
        Me.ProductsGridView.Name = "ProductsGridView"
        Me.ProductsGridView.ReadOnly = True
        Me.ProductsGridView.Size = New System.Drawing.Size(356, 421)
        Me.ProductsGridView.TabIndex = 7
        '
        'ProductColumn
        '
        Me.ProductColumn.HeaderText = "Producto"
        Me.ProductColumn.Name = "ProductColumn"
        Me.ProductColumn.ReadOnly = True
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Precio"
        Me.PriceColumn.Name = "PriceColumn"
        Me.PriceColumn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 445)
        Me.Controls.Add(Me.ProductsGridView)
        Me.Controls.Add(Me.TotalPriceLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.AddProductBtn)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.ProductTextBox)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.ProductLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents ProductTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents AddProductBtn As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents ProductsGridView As DataGridView
    Friend WithEvents ProductColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
End Class
