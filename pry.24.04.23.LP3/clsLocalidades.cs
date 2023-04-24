using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace pry._24._04._23.LP3
{
    public class clsLocalidades
    {
        DataSet DS;
        String Tabla = "Localidades";


        public clsLocalidades()
       {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=CLIMA.mdb";
                cnn.Open();
                DS = new DataSet();
                // tabla de Localidades
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = Tabla;
                OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                DA.Fill(DS, Tabla);
                DataColumn[] pk = new DataColumn[1];
                pk[0] = DS.Tables[Tabla].Columns["Localidades"];
                DS.Tables[Tabla].PrimaryKey = pk;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
                cnn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Test"+ e);
            }


        }
        public DataTable GetLocalidades()
        {
            if (DS != null && DS.Tables.Count == 1)
            {
                return DS.Tables["Localidades"];
            }
            return null;
        }

        public void Dispose()
        {
            DS.Dispose();
        }

    }


}
