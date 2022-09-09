using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;
using Modelo;

namespace Controlador
{
    public class CControlador
    {
        Sentencias sn = new Sentencias();
        
        
        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            OdbcDataAdapter dt = sn.llenartabla(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;

            
        }

        public void limpiar(Control control)//Funcion para limpiar Componentes
        {
            foreach(var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedItem = 0;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Checked = false;
                }
            }
        }

        public void activar(Control control)//Funcion para Activar componentes
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = true;
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = true;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Enabled = true;
                }
            }
        }
        

        public void desactivar(Control control)//Funcion para Desactivar componentes
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = false;
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = false;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Enabled = false;
                }
            }
        }

        public void enfocar(TextBox[] textbox)
        {
            textbox[0].Enabled = false;
            textbox[1].Focus();
        }

        public void llenartxt(TextBox[] textbox, DataGridView tabla)//Llena los textbox con datos del datagriedview

        {

            for (int x = 0; x < tabla.ColumnCount; x++)
            {
                textbox[x].Text = tabla.CurrentRow.Cells[x].Value.ToString();
            }

        }

        public void ingresar(TextBox[] textbox, DataGridView tabla)
        {
            string dato = " ";
            string tipo = " ";
            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString()  ;
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo +=  textbox[x].Tag.ToString() + ",";
                }

            }

            sn.insertar(dato, tipo, tabla.Tag.ToString());

            
        }

        public void actualizar(TextBox[] textbox, DataGridView tabla)
        {
            string dato = " ";
            string condicion = "("+textbox[0].Tag.ToString()+" = '"+ textbox[0].Text+"')";
            
            for (int x = 1; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '"+ textbox[x].Text+"' ";
                    
                }
                else if (x == 1)
                {
                    dato += "SET " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }
                else
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }
                
            }

            sn.actualizar(dato, condicion, tabla.Tag.ToString());


        }

    }
}
