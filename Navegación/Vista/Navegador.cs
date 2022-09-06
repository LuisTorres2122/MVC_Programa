using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;


namespace Vista
{
    public partial class Navegador : UserControl
    {
        CControlador cn = new CControlador();
        public Navegador()
        {
            InitializeComponent();
        }

        public DataTable refrescartabla(string tabla) 
        { 
            DataTable dt = cn.llenartabla(tabla);
            return dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }
    }
}
