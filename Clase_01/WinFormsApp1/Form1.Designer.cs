﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formTitulo = new Label();
            labelNumeroA = new Label();
            labelNumeroB = new Label();
            labelResultado = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSumar = new Button();
            historialDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historialDataGridView).BeginInit();
            SuspendLayout();
            // 
            // formTitulo
            // 
            formTitulo.AutoSize = true;
            formTitulo.Font = new Font("Segoe UI", 30F);
            formTitulo.Location = new Point(41, 9);
            formTitulo.Name = "formTitulo";
            formTitulo.Size = new Size(285, 67);
            formTitulo.TabIndex = 0;
            formTitulo.Text = "Calculadora";
            // 
            // labelNumeroA
            // 
            labelNumeroA.AutoSize = true;
            labelNumeroA.Font = new Font("Segoe UI", 15F);
            labelNumeroA.Location = new Point(41, 129);
            labelNumeroA.Name = "labelNumeroA";
            labelNumeroA.Size = new Size(130, 35);
            labelNumeroA.TabIndex = 1;
            labelNumeroA.Text = "Numero A";
            // 
            // labelNumeroB
            // 
            labelNumeroB.AutoSize = true;
            labelNumeroB.Font = new Font("Segoe UI", 15F);
            labelNumeroB.Location = new Point(41, 181);
            labelNumeroB.Name = "labelNumeroB";
            labelNumeroB.Size = new Size(128, 35);
            labelNumeroB.TabIndex = 3;
            labelNumeroB.Text = "Numero B";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 35F);
            labelResultado.Location = new Point(41, 389);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(344, 78);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "RESULTADO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 20F);
            btnSumar.Location = new Point(157, 269);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(140, 53);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // historialDataGridView
            // 
            historialDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historialDataGridView.Location = new Point(456, 11);
            historialDataGridView.Name = "historialDataGridView";
            historialDataGridView.RowHeadersWidth = 51;
            historialDataGridView.Size = new Size(219, 488);
            historialDataGridView.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 507);
            Controls.Add(historialDataGridView);
            Controls.Add(btnSumar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelNumeroB);
            Controls.Add(labelResultado);
            Controls.Add(labelNumeroA);
            Controls.Add(formTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)historialDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formTitulo;
        private Label labelNumeroA;
        private Label labelNumeroB;
        private Label labelResultado;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSumar;
        private DataGridView historialDataGridView;
    }
}
