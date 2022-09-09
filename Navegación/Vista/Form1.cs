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
      
    public partial class Form1 : Form
    {
        CControlador cn = new CControlador();
        public Form1()
        {
            InitializeComponent();
        }

        bool opcion;
        //si opcion es true será insercion
        //si opcion es false será actualizacion

        
       


        private void button4_Click(object sender, EventArgs e)
        {

            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opcion = true;
            cn.limpiar(this);
            cn.activar(this);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            if(opcion == true)//Insercion
            {
                cn.ingresar(textbox, dgv_tabla);
                MessageBox.Show("Dato agregado");
            }
            else if( opcion == false)
            {
                cn.actualizar(textbox, dgv_tabla);
                MessageBox.Show("Dato actualizado");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
            cn.desactivar(this);
        }

        

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.llenartxt(textbox, dgv_tabla);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opcion = false;
            TextBox[] textbox = { textBox1, textBox2 };
            cn.activar(this);
            cn.enfocar(textbox);
            

        }
    }
}
