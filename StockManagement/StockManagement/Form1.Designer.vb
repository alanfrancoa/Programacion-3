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
        Me.ComboBProdType = New System.Windows.Forms.ComboBox()
        Me.ComboBUnit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductNameTxt = New System.Windows.Forms.TextBox()
        Me.ProductBrandTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductSizeTxt = New System.Windows.Forms.TextBox()
        Me.StockTxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonFood = New System.Windows.Forms.Button()
        Me.ButtonDrinks = New System.Windows.Forms.Button()
        Me.ButtonOther = New System.Windows.Forms.Button()
        Me.ButtonSeeAll = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBProdTypeEdited = New System.Windows.Forms.ComboBox()
        Me.ComboBUnitEdited = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductNameEditedTxt = New System.Windows.Forms.TextBox()
        Me.BrandEditedTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SizeEditedTxt = New System.Windows.Forms.TextBox()
        Me.StockEditedTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.IdToSearchTxt = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelStockSearched = New System.Windows.Forms.Label()
        Me.LabelProductTSearched = New System.Windows.Forms.Label()
        Me.LabelSizeSearched = New System.Windows.Forms.Label()
        Me.LabelBrandSearched = New System.Windows.Forms.Label()
        Me.LabelProductSearched = New System.Windows.Forms.Label()
        Me.LabelIDSearched = New System.Windows.Forms.Label()
        Me.LabelUnitSearched = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.IdEditedTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBProdType)
        Me.GroupBox1.Controls.Add(Me.ComboBUnit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ProductNameTxt)
        Me.GroupBox1.Controls.Add(Me.ProductBrandTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProductSizeTxt)
        Me.GroupBox1.Controls.Add(Me.StockTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 325)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a Product"
        '
        'ComboBProdType
        '
        Me.ComboBProdType.FormattingEnabled = True
        Me.ComboBProdType.Items.AddRange(New Object() {"Food", "Drinks", "Other"})
        Me.ComboBProdType.Location = New System.Drawing.Point(41, 195)
        Me.ComboBProdType.Name = "ComboBProdType"
        Me.ComboBProdType.Size = New System.Drawing.Size(408, 21)
        Me.ComboBProdType.TabIndex = 11
        '
        'ComboBUnit
        '
        Me.ComboBUnit.FormattingEnabled = True
        Me.ComboBUnit.Items.AddRange(New Object() {"cm", "m", "l", "cc", "kg", "gr"})
        Me.ComboBUnit.Location = New System.Drawing.Point(41, 154)
        Me.ComboBUnit.Name = "ComboBUnit"
        Me.ComboBUnit.Size = New System.Drawing.Size(408, 21)
        Me.ComboBUnit.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Product Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Brand"
        '
        'ProductNameTxt
        '
        Me.ProductNameTxt.Location = New System.Drawing.Point(41, 31)
        Me.ProductNameTxt.Name = "ProductNameTxt"
        Me.ProductNameTxt.Size = New System.Drawing.Size(407, 20)
        Me.ProductNameTxt.TabIndex = 5
        '
        'ProductBrandTxt
        '
        Me.ProductBrandTxt.Location = New System.Drawing.Point(41, 76)
        Me.ProductBrandTxt.Name = "ProductBrandTxt"
        Me.ProductBrandTxt.Size = New System.Drawing.Size(407, 20)
        Me.ProductBrandTxt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Stock"
        '
        'ProductSizeTxt
        '
        Me.ProductSizeTxt.Location = New System.Drawing.Point(41, 115)
        Me.ProductSizeTxt.Name = "ProductSizeTxt"
        Me.ProductSizeTxt.Size = New System.Drawing.Size(407, 20)
        Me.ProductSizeTxt.TabIndex = 1
        '
        'StockTxt
        '
        Me.StockTxt.Location = New System.Drawing.Point(41, 235)
        Me.StockTxt.Name = "StockTxt"
        Me.StockTxt.Size = New System.Drawing.Size(407, 20)
        Me.StockTxt.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(515, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(619, 606)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonSeeAll)
        Me.GroupBox3.Controls.Add(Me.ButtonOther)
        Me.GroupBox3.Controls.Add(Me.ButtonDrinks)
        Me.GroupBox3.Controls.Add(Me.ButtonFood)
        Me.GroupBox3.Location = New System.Drawing.Point(515, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(619, 98)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Category"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonFood
        '
        Me.ButtonFood.Location = New System.Drawing.Point(25, 38)
        Me.ButtonFood.Name = "ButtonFood"
        Me.ButtonFood.Size = New System.Drawing.Size(111, 39)
        Me.ButtonFood.TabIndex = 0
        Me.ButtonFood.Text = "Food"
        Me.ButtonFood.UseVisualStyleBackColor = True
        '
        'ButtonDrinks
        '
        Me.ButtonDrinks.Location = New System.Drawing.Point(181, 38)
        Me.ButtonDrinks.Name = "ButtonDrinks"
        Me.ButtonDrinks.Size = New System.Drawing.Size(111, 39)
        Me.ButtonDrinks.TabIndex = 1
        Me.ButtonDrinks.Text = "Drinks"
        Me.ButtonDrinks.UseVisualStyleBackColor = True
        '
        'ButtonOther
        '
        Me.ButtonOther.Location = New System.Drawing.Point(332, 38)
        Me.ButtonOther.Name = "ButtonOther"
        Me.ButtonOther.Size = New System.Drawing.Size(111, 39)
        Me.ButtonOther.TabIndex = 2
        Me.ButtonOther.Text = "Other"
        Me.ButtonOther.UseVisualStyleBackColor = True
        '
        'ButtonSeeAll
        '
        Me.ButtonSeeAll.Location = New System.Drawing.Point(483, 38)
        Me.ButtonSeeAll.Name = "ButtonSeeAll"
        Me.ButtonSeeAll.Size = New System.Drawing.Size(111, 39)
        Me.ButtonSeeAll.TabIndex = 3
        Me.ButtonSeeAll.Text = "See All"
        Me.ButtonSeeAll.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.IdEditedTxt)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ComboBProdTypeEdited)
        Me.GroupBox2.Controls.Add(Me.ComboBUnitEdited)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ProductNameEditedTxt)
        Me.GroupBox2.Controls.Add(Me.BrandEditedTxt)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.SizeEditedTxt)
        Me.GroupBox2.Controls.Add(Me.StockEditedTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 379)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit Product:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBProdTypeEdited
        '
        Me.ComboBProdTypeEdited.FormattingEnabled = True
        Me.ComboBProdTypeEdited.Items.AddRange(New Object() {"Food", "Drinks", "Other"})
        Me.ComboBProdTypeEdited.Location = New System.Drawing.Point(41, 239)
        Me.ComboBProdTypeEdited.Name = "ComboBProdTypeEdited"
        Me.ComboBProdTypeEdited.Size = New System.Drawing.Size(408, 21)
        Me.ComboBProdTypeEdited.TabIndex = 11
        '
        'ComboBUnitEdited
        '
        Me.ComboBUnitEdited.FormattingEnabled = True
        Me.ComboBUnitEdited.Items.AddRange(New Object() {"cm", "m", "l", "cc", "kg", "gr"})
        Me.ComboBUnitEdited.Location = New System.Drawing.Point(41, 198)
        Me.ComboBUnitEdited.Name = "ComboBUnitEdited"
        Me.ComboBUnitEdited.Size = New System.Drawing.Size(408, 21)
        Me.ComboBUnitEdited.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Product Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Unit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Product Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Brand"
        '
        'ProductNameEditedTxt
        '
        Me.ProductNameEditedTxt.Location = New System.Drawing.Point(41, 75)
        Me.ProductNameEditedTxt.Name = "ProductNameEditedTxt"
        Me.ProductNameEditedTxt.Size = New System.Drawing.Size(407, 20)
        Me.ProductNameEditedTxt.TabIndex = 5
        '
        'BrandEditedTxt
        '
        Me.BrandEditedTxt.Location = New System.Drawing.Point(41, 120)
        Me.BrandEditedTxt.Name = "BrandEditedTxt"
        Me.BrandEditedTxt.Size = New System.Drawing.Size(407, 20)
        Me.BrandEditedTxt.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Size"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Stock"
        '
        'SizeEditedTxt
        '
        Me.SizeEditedTxt.Location = New System.Drawing.Point(41, 159)
        Me.SizeEditedTxt.Name = "SizeEditedTxt"
        Me.SizeEditedTxt.Size = New System.Drawing.Size(407, 20)
        Me.SizeEditedTxt.TabIndex = 1
        '
        'StockEditedTxt
        '
        Me.StockEditedTxt.Location = New System.Drawing.Point(41, 279)
        Me.StockEditedTxt.Name = "StockEditedTxt"
        Me.StockEditedTxt.Size = New System.Drawing.Size(407, 20)
        Me.StockEditedTxt.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.IdToSearchTxt)
        Me.GroupBox4.Location = New System.Drawing.Point(1144, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 315)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelUnitSearched)
        Me.GroupBox5.Controls.Add(Me.LabelStockSearched)
        Me.GroupBox5.Controls.Add(Me.LabelProductTSearched)
        Me.GroupBox5.Controls.Add(Me.LabelSizeSearched)
        Me.GroupBox5.Controls.Add(Me.LabelBrandSearched)
        Me.GroupBox5.Controls.Add(Me.LabelProductSearched)
        Me.GroupBox5.Controls.Add(Me.LabelIDSearched)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(1144, 343)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 379)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Result"
        '
        'IdToSearchTxt
        '
        Me.IdToSearchTxt.Location = New System.Drawing.Point(23, 101)
        Me.IdToSearchTxt.Name = "IdToSearchTxt"
        Me.IdToSearchTxt.Size = New System.Drawing.Size(189, 20)
        Me.IdToSearchTxt.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Product Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Brand:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Stock:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Product Type:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(20, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 16)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Size:"
        '
        'LabelStockSearched
        '
        Me.LabelStockSearched.AutoSize = True
        Me.LabelStockSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStockSearched.Location = New System.Drawing.Point(168, 264)
        Me.LabelStockSearched.Name = "LabelStockSearched"
        Me.LabelStockSearched.Size = New System.Drawing.Size(15, 15)
        Me.LabelStockSearched.TabIndex = 23
        Me.LabelStockSearched.Text = "0"
        '
        'LabelProductTSearched
        '
        Me.LabelProductTSearched.AutoSize = True
        Me.LabelProductTSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductTSearched.Location = New System.Drawing.Point(135, 225)
        Me.LabelProductTSearched.Name = "LabelProductTSearched"
        Me.LabelProductTSearched.Size = New System.Drawing.Size(12, 15)
        Me.LabelProductTSearched.TabIndex = 22
        Me.LabelProductTSearched.Text = "-"
        '
        'LabelSizeSearched
        '
        Me.LabelSizeSearched.AutoSize = True
        Me.LabelSizeSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSizeSearched.Location = New System.Drawing.Point(168, 187)
        Me.LabelSizeSearched.Name = "LabelSizeSearched"
        Me.LabelSizeSearched.Size = New System.Drawing.Size(15, 15)
        Me.LabelSizeSearched.TabIndex = 21
        Me.LabelSizeSearched.Text = "0"
        '
        'LabelBrandSearched
        '
        Me.LabelBrandSearched.AutoSize = True
        Me.LabelBrandSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBrandSearched.Location = New System.Drawing.Point(135, 144)
        Me.LabelBrandSearched.Name = "LabelBrandSearched"
        Me.LabelBrandSearched.Size = New System.Drawing.Size(12, 15)
        Me.LabelBrandSearched.TabIndex = 20
        Me.LabelBrandSearched.Text = "-"
        '
        'LabelProductSearched
        '
        Me.LabelProductSearched.AutoSize = True
        Me.LabelProductSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductSearched.Location = New System.Drawing.Point(135, 105)
        Me.LabelProductSearched.Name = "LabelProductSearched"
        Me.LabelProductSearched.Size = New System.Drawing.Size(12, 15)
        Me.LabelProductSearched.TabIndex = 19
        Me.LabelProductSearched.Text = "-"
        '
        'LabelIDSearched
        '
        Me.LabelIDSearched.AutoSize = True
        Me.LabelIDSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDSearched.Location = New System.Drawing.Point(168, 67)
        Me.LabelIDSearched.Name = "LabelIDSearched"
        Me.LabelIDSearched.Size = New System.Drawing.Size(15, 15)
        Me.LabelIDSearched.TabIndex = 18
        Me.LabelIDSearched.Text = "0"
        '
        'LabelUnitSearched
        '
        Me.LabelUnitSearched.AutoSize = True
        Me.LabelUnitSearched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitSearched.Location = New System.Drawing.Point(187, 187)
        Me.LabelUnitSearched.Name = "LabelUnitSearched"
        Me.LabelUnitSearched.Size = New System.Drawing.Size(27, 15)
        Me.LabelUnitSearched.TabIndex = 24
        Me.LabelUnitSearched.Text = "unit"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 82)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 16)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "ID"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(36, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 16)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "ID"
        '
        'IdEditedTxt
        '
        Me.IdEditedTxt.Location = New System.Drawing.Point(39, 37)
        Me.IdEditedTxt.Name = "IdEditedTxt"
        Me.IdEditedTxt.Size = New System.Drawing.Size(407, 20)
        Me.IdEditedTxt.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 758)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBProdType As ComboBox
    Friend WithEvents ComboBUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductNameTxt As TextBox
    Friend WithEvents ProductBrandTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductSizeTxt As TextBox
    Friend WithEvents StockTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonSeeAll As Button
    Friend WithEvents ButtonOther As Button
    Friend WithEvents ButtonDrinks As Button
    Friend WithEvents ButtonFood As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBProdTypeEdited As ComboBox
    Friend WithEvents ComboBUnitEdited As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ProductNameEditedTxt As TextBox
    Friend WithEvents BrandEditedTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SizeEditedTxt As TextBox
    Friend WithEvents StockEditedTxt As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents IdToSearchTxt As TextBox
    Friend WithEvents LabelStockSearched As Label
    Friend WithEvents LabelProductTSearched As Label
    Friend WithEvents LabelSizeSearched As Label
    Friend WithEvents LabelBrandSearched As Label
    Friend WithEvents LabelProductSearched As Label
    Friend WithEvents LabelIDSearched As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelUnitSearched As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents IdEditedTxt As TextBox
End Class
