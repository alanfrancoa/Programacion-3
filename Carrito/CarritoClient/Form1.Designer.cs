namespace CarritoClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.detailLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.idCartTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // detailTextBox
            // 
            this.detailTextBox.Location = new System.Drawing.Point(132, 98);
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(206, 22);
            this.detailTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(132, 126);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(206, 22);
            this.priceTextBox.TabIndex = 1;
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(52, 104);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(42, 16);
            this.detailLabel.TabIndex = 2;
            this.detailLabel.Text = "Detail";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(52, 132);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(55, 171);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(283, 46);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(381, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(339, 609);
            this.dataGridView.TabIndex = 5;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.totalLabel.Location = new System.Drawing.Point(804, 108);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(148, 46);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "TOTAL";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(793, 233);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "ID";
            // 
            // idCartTextBox
            // 
            this.idCartTextBox.Location = new System.Drawing.Point(833, 230);
            this.idCartTextBox.Name = "idCartTextBox";
            this.idCartTextBox.Size = new System.Drawing.Size(119, 22);
            this.idCartTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(787, 272);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 46);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 621);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idCartTextBox);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.detailTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox idCartTextBox;
        private System.Windows.Forms.Button addButton;
    }
}

