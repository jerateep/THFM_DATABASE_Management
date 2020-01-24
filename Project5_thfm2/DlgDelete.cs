using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project5_thfm2
{
    public partial class DlgDelete : Form
    {
        Entities db = new Entities();
        public int _RegId { get; set; }
        public string _UserName { get; set; }
        public string _Regname { get; set; }
        string strEvent = "";
        public DlgDelete()
        {
            InitializeComponent();
        }
        private void DlgDelete_Load(object sender, EventArgs e)
        {
            lblUser.Text = _UserName;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("ขอเหตุผล");
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure to delete {0}?", _RegId), "Confirm.",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    strEvent = _UserName + " ลบ เพราะ " + textBox1.Text +"("+ _Regname + ")";
                    EventLog();
                    var del = (from c in db.Registers
                               where c.Register_Id == _RegId
                               select c).FirstOrDefault();
                    if (del != null)
                    {
                        db.Registers.Remove(del);
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        public void EventLog()
        {
            db.Event_Log.Add(new Event_Log()
            {
                @event = strEvent,
                date = DateTime.Now,
                user = _UserName
            });
            db.SaveChanges();
        }

    }
}
