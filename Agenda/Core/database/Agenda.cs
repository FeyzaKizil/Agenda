using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.database
{
    public class Agenda : Base
    {

        SqlConnection con;
        object returnObject;
        SqlDataAdapter adapter = new SqlDataAdapter();

        int returnInt;

        public Agenda()
        {
            con = new SqlConnection("data source=MYLOVE\\SQLEXPRESS01; initial catalog=Agenda; user Id=sa; password=1234;");
        }

        public void connectionSet()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            else
                con.Open();
        }

        public int addEditDelete(SqlCommand _cmd)
        {
            myTryCatch(() =>
            {
                _cmd.Connection = con;
                connectionSet();
                returnInt = _cmd.ExecuteNonQuery();
            }, () => 
            {
                connectionSet();
            });
            return returnInt;
        }

        public object checkId(SqlCommand _cmd)
        {
            myTryCatch(() =>
            {
                _cmd.Connection = con;
                connectionSet();
                returnObject = _cmd.ExecuteScalar();
            }, () =>
            {
                connectionSet();
            });
            return returnObject;
        }

        public DataTable showTable(SqlCommand _cmd)
        {
            DataTable dTable = new DataTable();

            myTryCatch(() =>
            {                
                _cmd.Connection = con;
                adapter.SelectCommand = _cmd;
                adapter.Fill(dTable);
            }, () =>
            {
                connectionSet();
            });
            return (dTable);
        }

    }
}
