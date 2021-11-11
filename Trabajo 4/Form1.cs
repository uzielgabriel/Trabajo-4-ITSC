using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_4
{
    public partial class Form1 : Form
    {

        Seguimiento Lista { get; set; } = new Seguimiento();

        Usuario us { get; set; } = new Usuario();

        public Form1()
        {
            InitializeComponent();
            Dt.DataSource = Lista.Datable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            us.Ejercicio = txtEjercicio.Text;
            us.Semana = Convert.ToInt32(txtSemana.Text);
            us.Peso = Convert.ToInt32(txtPeso.Text);

            if (!Lista.UpdatePersona(us))
            {
                txtPeso.Focus();
                txtPeso.SelectAll();
                lblerror.Text = "Persona no válida";
            }
            else
            {
                limpiar();
            }


        }

        private void limpiar()
        {
            txtEjercicio.Text = "";
            txtPeso.Text = "";
            txtSemana.Text = "";
            txtSemana.Focus();
            lblerror.Text = "";
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (Lista.BorrarLinea(us))
            {
                limpiar();
            }
            else
            {
                lblerror.Text = "El contenido" + us.IdOrden + " no se pudo borrar.";

            }

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Lista.Borrar(us);
            us = new Usuario();
        }
    }

}


