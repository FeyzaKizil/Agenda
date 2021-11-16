using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ShowNote : UserControl
    {
        public ShowNote()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            AddNote nextForm = new AddNote();
            nextForm.txt_id.Text = lbl_id.Text;
            nextForm.ShowDialog();
            lbl_title.Text = nextForm.txt_title.Text;
            lbl_content.Text = nextForm.txt_content.Text;

        }
    }
}
