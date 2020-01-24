using Microsoft.Office.Interop.Excel;
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
    public partial class frmMain : Form
    {
        Entities db = new Entities();
        public string _UserName { get; set; }
        public int _Loginid { get; set; }
        string strEvent = "";
        string searchValue = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = _UserName;
            ListAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        public void SelectData()
        {
            int rowIndex = -1;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        gridView.CurrentCell = gridView.Rows[rowIndex].Cells[0];
                        gridView.Rows[gridView.CurrentCell.RowIndex].Selected = true;

                        break;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void SearchData()
        {
            string strKeyword = this.txtSearch.Text;
            var ds = (from c in db.Reports
                      where 
                            c.Firstname == strKeyword ||
                            c.Lastname == strKeyword ||
                            c.Email == strKeyword ||
                            c.Phone == strKeyword ||
                            c.ClassroomDay1_Name == strKeyword ||
                            c.ClassroomDay2_Name == strKeyword ||
                            c.CompanyType_Name == strKeyword ||
                            c.CompanyName == strKeyword
                      select c
                      ).ToList();
            if (ds.Count > 0)
            {
                this.gridView.DataSource = ds;
            }
            else
            {
                ListAll();
            }
        }

        public void ListAll()
        {
            var ds = (from c in db.Reports
                      select new
                      {
                          c.Register_Id,
                          c.Titlename,
                          c.Firstname,
                          c.Lastname,
                          c.Position,
                          c.Email,
                          c.Phone,
                          c.ClassroomDay1_Name,
                          c.ClassroomDay2_Name,
                          c.CompanyType_Name,
                          c.CompanyName,
                          c.Tex,
                          c.Address_1,
                          c.Township_1,
                          c.Amphoe_1,
                          c.Province_1,
                          c.ZipCode_1,
                          c.Contact_Firstname,
                          c.Contact_Lastname,
                          c.AddressSend,
                          c.TownshipSend,
                          c.AmphoeSend,
                          c.ProvinceSend,
                          c.ZipCodeSend,
                          c.Tel,
                          c.Fax,
                          c.BillType_Name,
                          c.Rate,
                          c.Price,
                          c.StatusPay_Name,
                          c.DateRegister,
                          c.l_Firstname,
                          c.l_Lastname,
                          c.l_Email,
                      }).ToList();
            if (ds.Count > 0)
            {
                this.gridView.DataSource = ds;
                searchValue = lblRegId.Text;
                SelectData();
            }
        }

        private void gridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strRegId = gridView.CurrentRow.Cells[0].Value.ToString();
            this.lblRegId.Text = strRegId;
        }

        private void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            string strRegId = gridView.CurrentRow.Cells[0].Value.ToString();
            this.lblRegId.Text = strRegId;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            strEvent = lblUser.Text +" Export data to excel";
            try
            {
                Microsoft.Office.Interop.Excel._Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;
                ws.Cells[1, 1] = "เลขที่ใบสมัคร";
                ws.Cells[1, 2] = "คำนำหน้า";
                ws.Cells[1, 3] = "ชื่อ";
                ws.Cells[1, 4] = "สกุล";
                ws.Cells[1, 5] = "ตำแหน่ง";
                ws.Cells[1, 6] = "เมล์";
                ws.Cells[1, 7] = "เบอร์โทรศัพท์";
                ws.Cells[1, 8] = "สำรองที่นั่งวันที่ 1";
                ws.Cells[1, 9] = "สำรองที่นั่งวันที่ 2";
                ws.Cells[1, 10] = "วันที่สมัคร";
                ws.Cells[1, 11] = "ประเภทหน่วยงาน";
                ws.Cells[1, 12] = "ชื่อหน่วยงาน";
                ws.Cells[1, 13] = "ชื่อผู้ประสานงาน";
                ws.Cells[1, 14] = "นามสกุลผู้ประสานงาน";
                ws.Cells[1, 15] = "อีเมล์ประสานงาน";
                ws.Cells[1, 16] = "เบอร์โทรศัพท์";
                ws.Cells[1, 17] = "โทรสาร";
                ws.Cells[1, 18] = "เลขประจำตัวผู้เสียภาษี";
                ws.Cells[1, 19] = "อัตราลดหย่อนภาษี (%)";
                ws.Cells[1, 20] = "เงินต้องชำระ";
                ws.Cells[1, 21] = "ที่อยู่ออกใบกำกับ";
                ws.Cells[1, 22] = "ตำบล";
                ws.Cells[1, 23] = "อำเภอ";
                ws.Cells[1, 24] = "จังหวัด";
                ws.Cells[1, 25] = "รหัสไปรษณีย์";
                ws.Cells[1, 26] = "ที่อยู่จัดส่งเอกสาร";
                ws.Cells[1, 27] = "ตำบล";
                ws.Cells[1, 28] = "อำเภอ";
                ws.Cells[1, 29] = "จังหวัด";
                ws.Cells[1, 30] = "รหัสไปรษณีย์";
                ws.Cells[1, 31] = "รูปแบบการออกใบกำกับภาษี";
                ws.Cells[1, 32] = "ชื่อผู้ทำรายการสมัคร";
                ws.Cells[1, 33] = "นามสกุลผู้ทำรายการสมัคร";
                ws.Cells[1, 34] = "อีเมล์ผู้ทำรายการสมัคร";
                ws.Cells[1, 35] = "สถานะ";
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 35; j++)
                    {
                        ws.Cells[i + 2, j + 1] = "'"+gridView.Rows[i].Cells[j].Value;
                    }
                }
                EventLog();
            }
            catch (Exception ex)
            {
                string text = ex + "";
            }
        }

        public void EventLog()
        {
            db.Event_Log.Add(new Event_Log()
            {
                @event = strEvent,
                date = DateTime.Now,
                user = lblUser.Text               
            });
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dlgDel = new DlgDelete();
                dlgDel._RegId = Convert.ToInt32(lblRegId.Text);
                dlgDel._Regname = gridView.CurrentRow.Cells[1].Value.ToString() + " " + gridView.CurrentRow.Cells[2].Value.ToString();
                dlgDel._UserName = lblUser.Text;
                dlgDel.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("เลือกข้อมูล");
            }
            ListAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dlgUpdate = new DlgUpdate();
                dlgUpdate._RegId = Convert.ToInt32(lblRegId.Text);
                dlgUpdate._UserName = lblUser.Text;
                dlgUpdate.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("เลือกข้อมูล");
            }
            ListAll();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var DlgAdd = new DlgAdd();
            //DlgAdd._RegId = Convert.ToInt32(lblRegId.Text);
            DlgAdd._UserName = lblUser.Text;
            DlgAdd._Loginid = _Loginid;
            DlgAdd.ShowDialog();
            ListAll();
        }
    }
}
