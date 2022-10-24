
namespace CentroDeIdiomas
{
    partial class Rentar
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
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumControl = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(12, 335);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersWidth = 62;
            this.dgvRegistro.RowTemplate.Height = 28;
            this.dgvRegistro.Size = new System.Drawing.Size(998, 212);
            this.dgvRegistro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero De Control:";
            // 
            // txtNumControl
            // 
            this.txtNumControl.Location = new System.Drawing.Point(442, 73);
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.Size = new System.Drawing.Size(292, 26);
            this.txtNumControl.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(442, 116);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(292, 26);
            this.txtNombreAlumno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Del Alumno:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(442, 249);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(292, 26);
            this.dtpFecha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha De Renta:";
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "1"});
            this.cbCarrera.Location = new System.Drawing.Point(442, 162);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(292, 28);
            this.cbCarrera.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Carrera:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CentroDeIdiomas.Properties.Resources.regresar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 51);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(502, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 33);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Libro:";
            // 
            // cbLibro
            // 
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Items.AddRange(new object[] {
            "1"});
            this.cbLibro.Location = new System.Drawing.Point(442, 206);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(292, 28);
            this.cbLibro.TabIndex = 16;
            // 
            // Rentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLibro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Rentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentar Libro";
            this.Load += new System.EventHandler(this.Rentar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumControl;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLibro;
    }
}