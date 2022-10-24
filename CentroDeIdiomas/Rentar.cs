using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeIdiomas.Models;


namespace CentroDeIdiomas
{
    public partial class Rentar : Form
    {
        public Rentar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form regresar = new Inicio();
            this.Hide();
            regresar.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rentar_Load(object sender, EventArgs e)
        {
            using (CentIdiomassEntities1 db = new CentIdiomassEntities1())
            {
                var lst = from d in db.REGISTRO
                          select d;
                dgvRegistro.DataSource = lst.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (CentIdiomassEntities1 db = new CentIdiomassEntities1())
            {
                REGISTRO oRegistro = new REGISTRO();
                oRegistro.NUM_CONTROL = txtNumControl.Text;
                oRegistro.Nombre_Alumno = txtNombreAlumno.Text;
                //oRegistro.IdCarrera = cbCarrera.SelectedIndex;
                //oRegistro.IdLibro = cbLibro.SelectedIndex;
                oRegistro.Fecha = dtpFecha.Value;

                db.REGISTRO.Add(oRegistro);
                db.SaveChanges();
            }
        }
    }
}
