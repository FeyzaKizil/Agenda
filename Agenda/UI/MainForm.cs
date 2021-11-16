using Core.businessLogicService;
using Core.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        Agenda agenda = new Agenda();
        public MainForm()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            showNotes();
        }

        private void showNotes()
        {
            flowLayoutPanel1.Controls.Clear();
            NoteService service = new NoteService();
            string dateS1 = DateTime.ParseExact(lbl_date.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string dateS2 = DateTime.ParseExact(lbl_date.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

            DataTable dt = service.betweenData(dateS1, dateS2);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ShowNote note = new ShowNote();
                note.lbl_title.Text = dt.Rows[i]["title"].ToString();
                note.lbl_content.Text = dt.Rows[i]["content"].ToString();
                note.lbl_id.Text = dt.Rows[i]["id"].ToString();
                note.lbl_noteTime.Text = dt.Rows[i]["date"].ToString();
                flowLayoutPanel1.Controls.Add(note);
            }
        }
        private void btn_addNote_Click(object sender, EventArgs e)
        {
            new AddNote() { }.ShowDialog();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            lbl_date.Text = Convert.ToDateTime(lbl_date.Text).AddDays(1).ToString("yyyy-MM-dd") + " 00:00:00";
            showNotes();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            lbl_date.Text = Convert.ToDateTime(lbl_date.Text).AddDays(-1).ToString("yyyy-MM-dd") + " 00:00:00";
            showNotes();
        }

        private void btn_skipToDate_Click(object sender, EventArgs e)
        {
            SkipToDate nextForm = new SkipToDate();
            nextForm.ShowDialog();
            if (nextForm.continueOrNot == 1)
            {
                lbl_date.Text = nextForm.date.ToString("yyyy-MM-dd") + " 00:00:00";
                showNotes();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
