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
    public partial class SkipToDate : Form
    {
        public SkipToDate()
        {
            InitializeComponent();
        }

        public int continueOrNot = 0;
        public DateTime date = DateTime.Now;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_okey_Click(object sender, EventArgs e)
        {
            continueOrNot = 1;
            date = Convert.ToDateTime(dateTimePicker1.Value);
            Close();
        }
    }
}
