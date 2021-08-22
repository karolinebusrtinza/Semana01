using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string dni = txtdni.Text;
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string email = txtemail.Text;
            string fecha = txtdate.Text;
            string departamento = txtdep.Text;
            dataGridView1.Rows.Add("", dni, nombre, apellido, direccion, telefono, email, fecha, departamento);

        }

        private void txtdep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
