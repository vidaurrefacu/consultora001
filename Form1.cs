using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultora2_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstEmpresas.Items.Add(txtEmpresa.Text);
            txtEmpresa.Clear();
        }

        private void lstEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
            
            private void btnEmpresa_Click(object sender, EventArgs e)
        {
            lstEmpresas.Items.Add(txtEmpresa.Text);
            txtEmpresa.Clear();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            lstEmpleados.Items.Add(txtEmpleado.Text);
            txtEmpleado.Clear();
        }

        private void btnNovedad_Click(object sender, EventArgs e)
        {
            lstNovedades.Items.Add(txtNovedad.Text + " - Pendiente");
            txtNovedad.Clear();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "RESUMEN GENERAL" +
                "\nEmpresas: " + lstEmpresas.Items.Count +
                "\nEmpleados: " + lstEmpleados.Items.Count +
                "\nNovedades: " + lstNovedades.Items.Count
            );
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpListados_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lstEmpresas.SelectedItem != null)
            {
                lstEmpresas.Items.Remove(lstEmpresas.SelectedItem);
            }

            else if (lstEmpleados.SelectedItem != null)
            {
                lstEmpleados.Items.Remove(lstEmpleados.SelectedItem);
            }

            else if (lstNovedades.SelectedItem != null)
            {
                lstNovedades.Items.Remove(lstNovedades.SelectedItem);
            }

            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar.");
            }
        }
    }
}

