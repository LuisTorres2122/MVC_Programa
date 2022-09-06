using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            dgv_tabla.DataSource = navegador1.refrescartabla(dgv_tabla.Tag.ToString());
        }

        void cargardatos()
        {
            dgv_tabla.DataSource = navegador1.refrescartabla(dgv_tabla.Tag.ToString());
        }

        private void navegador1_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

    }
}
