using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;

namespace pry._24._04._23.LP3
{
    public class clsTemperaturas
    {
        private string Cadena = "";
        private OleDbCommand Comando;
        private OleDbConnection Conexion;
        private OleDbDataAdapter adaptador;
        private DataTable Tabla;


        public clsTemperaturas()
        {
            Cadena = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=CLIMA.mdb";
            Conexion = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Temperaturas";

            adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            adaptador.Fill(Tabla);


        }
        public DataTable getAll()
        {
            return Tabla;
        }


    }

}