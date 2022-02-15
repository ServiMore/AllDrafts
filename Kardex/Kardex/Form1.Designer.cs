namespace Kardex {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.kardexList = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.initial = new System.Windows.Forms.RadioButton();
            this.outcome = new System.Windows.Forms.RadioButton();
            this.income = new System.Windows.Forms.RadioButton();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialize = new System.Windows.Forms.Button();
            this.deserialize = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kardexList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.SuspendLayout();
            // 
            // kardexList
            // 
            this.kardexList.AllowUserToAddRows = false;
            this.kardexList.AllowUserToDeleteRows = false;
            this.kardexList.AllowUserToOrderColumns = true;
            this.kardexList.AllowUserToResizeColumns = false;
            this.kardexList.AllowUserToResizeRows = false;
            this.kardexList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kardexList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kardexList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kardexList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Concepto,
            this.Entrada,
            this.Salida,
            this.Existencia,
            this.CostoUnitario,
            this.CostoPromedio,
            this.Debe,
            this.Haber,
            this.Saldo});
            this.kardexList.Location = new System.Drawing.Point(12, 151);
            this.kardexList.Name = "kardexList";
            this.kardexList.ReadOnly = true;
            this.kardexList.Size = new System.Drawing.Size(1058, 287);
            this.kardexList.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(971, 85);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Agregar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(24, 57);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 2;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(260, 57);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 20);
            this.description.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.initial);
            this.groupBox1.Controls.Add(this.outcome);
            this.groupBox1.Controls.Add(this.income);
            this.groupBox1.Location = new System.Drawing.Point(396, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // initial
            // 
            this.initial.AutoSize = true;
            this.initial.Location = new System.Drawing.Point(18, 66);
            this.initial.Name = "initial";
            this.initial.Size = new System.Drawing.Size(101, 17);
            this.initial.TabIndex = 2;
            this.initial.TabStop = true;
            this.initial.Text = "Inventario inicial";
            this.initial.UseVisualStyleBackColor = true;
            // 
            // outcome
            // 
            this.outcome.AutoSize = true;
            this.outcome.Location = new System.Drawing.Point(18, 43);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(54, 17);
            this.outcome.TabIndex = 1;
            this.outcome.TabStop = true;
            this.outcome.Text = "Salida";
            this.outcome.UseVisualStyleBackColor = true;
            this.outcome.CheckedChanged += new System.EventHandler(this.outcome_CheckedChanged);
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Location = new System.Drawing.Point(18, 20);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(62, 17);
            this.income.TabIndex = 0;
            this.income.TabStop = true;
            this.income.Text = "Entrada";
            this.income.UseVisualStyleBackColor = true;
            this.income.CheckedChanged += new System.EventHandler(this.income_CheckedChanged);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(627, 85);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 20);
            this.quantity.TabIndex = 5;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(793, 88);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(120, 20);
            this.cost.TabIndex = 6;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.HeaderText = "Costo unitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // CostoPromedio
            // 
            this.CostoPromedio.HeaderText = "Costo promedio";
            this.CostoPromedio.Name = "CostoPromedio";
            this.CostoPromedio.ReadOnly = true;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Costo";
            // 
            // serialize
            // 
            this.serialize.Location = new System.Drawing.Point(971, 12);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(75, 23);
            this.serialize.TabIndex = 9;
            this.serialize.Text = "Guardar";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // deserialize
            // 
            this.deserialize.Location = new System.Drawing.Point(971, 41);
            this.deserialize.Name = "deserialize";
            this.deserialize.Size = new System.Drawing.Size(75, 23);
            this.deserialize.TabIndex = 10;
            this.deserialize.Text = "Abrir";
            this.deserialize.UseVisualStyleBackColor = true;
            this.deserialize.Click += new System.EventHandler(this.deserialize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "migui";
            this.openFileDialog1.FileName = "database.migui";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "migui";
            this.saveFileDialog1.FileName = "database.migui";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.deserialize);
            this.Controls.Add(this.serialize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.save);
            this.Controls.Add(this.kardexList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kardexList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kardexList;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton initial;
        private System.Windows.Forms.RadioButton outcome;
        private System.Windows.Forms.RadioButton income;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button serialize;
        private System.Windows.Forms.Button deserialize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

