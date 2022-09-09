using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace Modelo
{
   public class Sentencias
    {
        Conexion con = new Conexion();

        


        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            
            string sql = "insert into " + tabla + "("+ tipo +") values ("+ dato +")";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
            
        }

        public void actualizar(string dato, string condicion, string tabla)
        {

            string sql = "Update " + tabla + " "+dato +" where "+condicion;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();

        }

    }
}
