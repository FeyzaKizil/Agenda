using Core.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.businessLogicService
{
    public class NoteService : BaseService<Note>
    {
        database.Agenda db;
        object obj;
        public NoteService()
        {
            db = new database.Agenda();
        }
        public int addNote(Note data)
        {
            cmd = new System.Data.SqlClient.SqlCommand("insert into Note values (@id,@title,@content,@date)");
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = data.id;
            cmd.Parameters.Add("@title", System.Data.SqlDbType.NVarChar).Value = data.title;
            cmd.Parameters.Add("@content", System.Data.SqlDbType.NVarChar).Value = data.content;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = data.date;
            result = db.addEditDelete(cmd);
            return result;
        }

        public int update(Note data)
        {
            cmd = new System.Data.SqlClient.SqlCommand("update Note set title=@title,content=@content,date=@date where id=@id");
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = data.id;
            cmd.Parameters.Add("@title", System.Data.SqlDbType.NVarChar).Value = data.title;
            cmd.Parameters.Add("@content", System.Data.SqlDbType.NVarChar).Value = data.content;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = data.date;
            result = db.addEditDelete(cmd);
            return result;
        }

        public DataTable read(int id)
        {
            cmd = new System.Data.SqlClient.SqlCommand("select id,title,content from Note where id=@id");
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            DataTable dt = db.showTable(cmd);
            return dt;
        }

        public DataTable betweenData(string date1, string date2)
        {
            cmd = new System.Data.SqlClient.SqlCommand("select id, title, content,date from Note where date between '" + date1 
                + " 00:00:00'" + " and '" + date2 + " 23:59:59' order by date");
            DataTable dt = db.showTable(cmd);
            return dt;
        }

        public int delete(int id)
        {
            cmd = new System.Data.SqlClient.SqlCommand("delete from Note where @id=id");
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            result = db.addEditDelete(cmd);
            return result;
        }

        public int checkId(int id)
        {
            cmd = new System.Data.SqlClient.SqlCommand("select id from Note where id=@id");
            cmd.Parameters.Add("@id", System    .Data.SqlDbType.Int).Value = id;
            obj = db.checkId(cmd);
            return obj == null ? 0 : (int)obj;
        }
       
    }
}
