namespace pryTeatro
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
            label1 = new Label();
            cboZona = new ComboBox();
            cboFila = new ComboBox();
            cboAsiento = new ComboBox();
            optQuenaken = new RadioButton();
            optOnas = new RadioButton();
            optTobas = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSeleccionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Teatro";
            // 
            // cboZona
            // 
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(194, 58);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(121, 23);
            cboZona.TabIndex = 1;
            cboZona.SelectedIndexChanged += cboZona_SelectedIndexChanged;
            // 
            // cboFila
            // 
            cboFila.FormattingEnabled = true;
            cboFila.Location = new Point(391, 58);
            cboFila.Name = "cboFila";
            cboFila.Size = new Size(121, 23);
            cboFila.TabIndex = 2;
            cboFila.SelectedIndexChanged += cboFila_SelectedIndexChanged;
            // 
            // cboAsiento
            // 
            cboAsiento.FormattingEnabled = true;
            cboAsiento.Location = new Point(557, 58);
            cboAsiento.Name = "cboAsiento";
            cboAsiento.Size = new Size(121, 23);
            cboAsiento.TabIndex = 3;
            // 
            // optQuenaken
            // 
            optQuenaken.AutoSize = true;
            optQuenaken.Location = new Point(22, 62);
            optQuenaken.Name = "optQuenaken";
            optQuenaken.Size = new Size(110, 19);
            optQuenaken.TabIndex = 4;
            optQuenaken.TabStop = true;
            optQuenaken.Text = "Local Quenaken";
            optQuenaken.UseVisualStyleBackColor = true;
            optQuenaken.CheckedChanged += optQuenaken_CheckedChanged;
            // 
            // optOnas
            // 
            optOnas.AutoSize = true;
            optOnas.Location = new Point(22, 116);
            optOnas.Name = "optOnas";
            optOnas.Size = new Size(83, 19);
            optOnas.TabIndex = 5;
            optOnas.TabStop = true;
            optOnas.Text = "Local Onas";
            optOnas.UseVisualStyleBackColor = true;
            optOnas.CheckedChanged += optOnas_CheckedChanged;
            // 
            // optTobas
            // 
            optTobas.AutoSize = true;
            optTobas.Location = new Point(22, 182);
            optTobas.Name = "optTobas";
            optTobas.Size = new Size(86, 19);
            optTobas.TabIndex = 6;
            optTobas.TabStop = true;
            optTobas.Text = "Local Tobas";
            optTobas.UseVisualStyleBackColor = true;
            optTobas.CheckedChanged += optTobas_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 21);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 7;
            label2.Text = "Zona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 21);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 8;
            label3.Text = "Fila";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 21);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Asiento";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(591, 161);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(87, 25);
            btnSeleccionar.TabIndex = 10;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 237);
            Controls.Add(btnSeleccionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(optTobas);
            Controls.Add(optOnas);
            Controls.Add(optQuenaken);
            Controls.Add(cboAsiento);
            Controls.Add(cboFila);
            Controls.Add(cboZona);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Venta de Entradas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboZona;
        private ComboBox cboFila;
        private ComboBox cboAsiento;
        private RadioButton optQuenaken;
        private RadioButton optOnas;
        private RadioButton optTobas;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSeleccionar;
    }
}
