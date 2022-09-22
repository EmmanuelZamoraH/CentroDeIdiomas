
namespace CentroDeIdiomas
{
    partial class Catalogo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarLi = new System.Windows.Forms.Button();
            this.btnModificarLi = new System.Windows.Forms.Button();
            this.btnEliminarLi = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregarLi
            // 
            this.btnAgregarLi.BackColor = System.Drawing.Color.White;
            this.btnAgregarLi.Location = new System.Drawing.Point(273, 183);
            this.btnAgregarLi.Name = "btnAgregarLi";
            this.btnAgregarLi.Size = new System.Drawing.Size(88, 39);
            this.btnAgregarLi.TabIndex = 1;
            this.btnAgregarLi.Text = "Agregar";
            this.btnAgregarLi.UseVisualStyleBackColor = false;
            // 
            // btnModificarLi
            // 
            this.btnModificarLi.BackColor = System.Drawing.Color.White;
            this.btnModificarLi.Location = new System.Drawing.Point(377, 183);
            this.btnModificarLi.Name = "btnModificarLi";
            this.btnModificarLi.Size = new System.Drawing.Size(85, 39);
            this.btnModificarLi.TabIndex = 2;
            this.btnModificarLi.Text = "Modificar";
            this.btnModificarLi.UseVisualStyleBackColor = false;
            // 
            // btnEliminarLi
            // 
            this.btnEliminarLi.BackColor = System.Drawing.Color.White;
            this.btnEliminarLi.Location = new System.Drawing.Point(478, 183);
            this.btnEliminarLi.Name = "btnEliminarLi";
            this.btnEliminarLi.Size = new System.Drawing.Size(85, 39);
            this.btnEliminarLi.TabIndex = 3;
            this.btnEliminarLi.Text = "Eliminar";
            this.btnEliminarLi.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::CentroDeIdiomas.Properties.Resources.regresar;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 51);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarLi);
            this.Controls.Add(this.btnModificarLi);
            this.Controls.Add(this.btnAgregarLi);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo De Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarLi;
        private System.Windows.Forms.Button btnModificarLi;
        private System.Windows.Forms.Button btnEliminarLi;
        private System.Windows.Forms.Button btnRegresar;
    }
}