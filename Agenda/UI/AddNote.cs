using Core.businessLogicService;
using Core.database;
using Core.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddNote : Form
    {
        NoteService service = new NoteService();
        int result = 0;
        public AddNote()
        {
            InitializeComponent();
        }
        private void AddNote_Load(object sender, EventArgs e)
        {
            readNote();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0 )      //default id = 0, id must not be 0
            {               
                if(service.checkId(Convert.ToInt32(txt_id.Text)) > 0) //if == 0 means new id
                {
                    MessageBox.Show("This id is already recorded. Try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    result = service.addNote(new Note()
                    {
                        id = Convert.ToInt32(txt_id.Text),
                        title = txt_title.Text,
                        content = txt_content.Text,
                        date = Convert.ToDateTime(dateTimePicker1.Value)
                    });

                    if (result == 1)
                    {
                        MessageBox.Show("New note succesfully added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                
            }
            else
            {
                result = service.update(new Note()
                {
                    id = Convert.ToInt32(txt_id.Text),
                    title = txt_title.Text,
                    content = txt_content.Text,
                    date = Convert.ToDateTime(dateTimePicker1.Value)
                });
                if (result == 1)
                {
                    MessageBox.Show("New note succesfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void readNote()
        {
            if (Convert.ToInt32(txt_id.Text) > 0)
            {
                DataTable dt = service.read(Convert.ToInt32(txt_id.Text));
                txt_title.Text = dt.Rows[0]["id"].ToString();
                txt_content.Text = dt.Rows[0]["content"].ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {               
                result = service.delete(Convert.ToInt32(txt_id.Text));
                if (result == 1)
                {
                    MessageBox.Show("New note succesfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
