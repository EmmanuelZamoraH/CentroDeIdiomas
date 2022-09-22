
namespace CentroDeIdiomas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnRentar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCatalgo = new System.Windows.Forms.Button();
            btnRentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CentroDeIdiomas.Properties.Resources.cent_idiomas_somb;
            this.pictureBox1.Location = new System.Drawing.Point(150, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCatalgo
            // 
            this.btnCatalgo.BackColor = System.Drawing.Color.White;
            this.btnCatalgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatalgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalgo.FlatAppearance.BorderSize = 2;
            this.btnCatalgo.Location = new System.Drawing.Point(165, 380);
            this.btnCatalgo.Name = "btnCatalgo";
            this.btnCatalgo.Size = new System.Drawing.Size(138, 49);
            this.btnCatalgo.TabIndex = 1;
            this.btnCatalgo.Text = "Catalogo Libros";
            this.btnCatalgo.UseVisualStyleBackColor = false;
            this.btnCatalgo.Click += new System.EventHandler(this.btnCatalgo_Click);
            // 
            // btnRentar
            // 
            btnRentar.BackColor = System.Drawing.Color.White;
            btnRentar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRentar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            btnRentar.FlatAppearance.BorderSize = 2;
            btnRentar.Image = ((System.Drawing.Image)(resources.GetObject("btnRentar.Image")));
            btnRentar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnRentar.Location = new System.Drawing.Point(165, 303);
            btnRentar.Name = "btnRentar";
            btnRentar.Size = new System.Drawing.Size(138, 49);
            btnRentar.TabIndex = 0;
            btnRentar.Text = "Rentar Libro";
            btnRentar.UseVisualStyleBackColor = false;
            btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(481, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCatalgo);
            this.Controls.Add(btnRentar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCatalgo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

