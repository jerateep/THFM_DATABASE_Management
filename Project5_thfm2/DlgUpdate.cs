using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project5_thfm2
{
    public partial class DlgUpdate : Form
    {
        Entities db = new Entities();
        public int _RegId { get; set; }
        public string _UserName { get; set; }
        string imgLoc = "";
        byte[] img = null;
        Boolean chkImage = false;
        public DlgUpdate()
        {
            InitializeComponent();
        }

        private void DlgUpdate_Load(object sender, EventArgs e)
        {
            txtRegId.Text = _RegId.ToString();
            LoadStatus();
            LoadCompanyTypes();
            LoadBillTypes();
            ClassroomDay1();
            ClassroomDay2();
            LoadImage();
            GetData();
        }

        public void LoadStatus()
        {
            var ds = (from T in db.StatusPays
                      select new
                      {
                          T.StatusPay_Id,
                          T.StatusPay_Name
                      }
                      ).ToList();
            cbStatus.DataSource = ds;
            cbStatus.DisplayMember = "StatusPay_Name";
            cbStatus.ValueMember = "StatusPay_Id";
        }
        public void LoadCompanyTypes()
        {
            var ds = (from T in db.CompanyTypes
                      select new
                      {
                          T.CompanyType_Id,
                          T.CompanyType_Name
                      }
                      ).ToList();
            cbCompanyType.DataSource = ds;
            cbCompanyType.DisplayMember = "CompanyType_Name";
            cbCompanyType.ValueMember = "CompanyType_Id";
        }
        public void LoadBillTypes()
        {
            var ds = (from T in db.BillTypes
                      select new
                      {
                          T.BillType_Id,
                          T.BillType_Name
                      }
                      ).ToList();
            cbBillType.DataSource = ds;
            cbBillType.DisplayMember = "BillType_Name";
            cbBillType.ValueMember = "BillType_Id";
        }
        public void ClassroomDay1()
        {
            var ds = (from T in db.ClassroomDay1
                      select new
                      {
                          T.ClassroomDay1_Id,
                          T.ClassroomDay1_Name
                      }
                      ).ToList();
            cbRoomD1.DataSource = ds;
            cbRoomD1.DisplayMember = "ClassroomDay1_Name";
            cbRoomD1.ValueMember = "ClassroomDay1_Id";
        }
        public void ClassroomDay2()
        {
            var ds = (from T in db.ClassroomDay2
                      select new
                      {
                          T.ClassroomDay2_Id,
                          T.ClassroomDay2_Name
                      }
                      ).ToList();
            cbRoomD2.DataSource = ds;
            cbRoomD2.DisplayMember = "ClassroomDay2_Name";
            cbRoomD2.ValueMember = "ClassroomDay2_Id";
        }
        public void GetData()
        {
            int a = Convert.ToInt32(txtRegId.Text);
            var ds = (from c in db.Reports
                      where c.Register_Id == a
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
                          c.Bill_Id
                      }).FirstOrDefault();
            if (ds != null)
            {
                this.txtRegId.Text = ds.Register_Id.ToString();
                this.txtTitleName.Text = ds.Titlename;
                this.txtFirstname.Text = ds.Firstname;
                this.txtLastname.Text = ds.Lastname;
                this.txtPosition.Text = ds.Position;
                this.txtEmail.Text = ds.Email;
                this.txtphone.Text = ds.Phone;
                this.cbRoomD1.Text = ds.ClassroomDay1_Name;
                this.cbRoomD2.Text = ds.ClassroomDay2_Name;

                this.cbCompanyType.Text = ds.CompanyType_Name;
                this.txtCompany.Text = ds.CompanyName;
                this.txtTex.Text = ds.Tex;
                this.txtAddress.Text = ds.Address_1;
                this.txtTownship.Text = ds.Township_1;
                this.txtAmphoe.Text = ds.Amphoe_1;
                this.txtProvince.Text = ds.Province_1;
                this.txtZip.Text = ds.ZipCode_1;

                this.txtFirstameC.Text = ds.Contact_Firstname;
                this.txtLastnameC.Text = ds.Contact_Lastname;
                this.txtAddress_S.Text = ds.AddressSend;
                this.txtTownship_S.Text = ds.TownshipSend;
                this.txtAmphoe_S.Text = ds.AmphoeSend;
                this.txtProvince_S.Text = ds.ProvinceSend;
                this.txtZip_S.Text = ds.ZipCodeSend;
                this.txtTelC.Text = ds.Tel;
                this.txtFax.Text = ds.Fax;

                this.cbBillType.Text = ds.BillType_Name;
                this.cbRate.Text = ds.Rate.ToString();
                this.txtPrice.Text = ds.Price;
                this.cbStatus.Text = ds.StatusPay_Name;

                this.Bill_Id.Text = ds.Bill_Id.ToString();
            }
        }
        public void LoadImage()
        {
            try
            {
                var first = db.Registers.FirstOrDefault(p => p.Register_Id == _RegId);
                if (first != null)
                {
                    using (var ms = new MemoryStream(first.img))
                    {
                        using (var image = Image.FromStream(ms))
                        {
                            picBill.Image = (Image)image.Clone();
                            chkImage = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                //picAsset.Image = null;
            }

        }
        public void ConvertImage()
        {
            try
            {
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                chkImage = false;
            }
            catch (Exception)
            {
                //return;
            }
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG File (*.jpg)|*.jpg|GIF File (*.gif)|*.gif|All File (*.*)|*.*";
                dlg.Title = "Select Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picBill.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConvertImage();
            var ds = (from c in db.Registers
                      where c.Register_Id == _RegId
                      select c).FirstOrDefault();
            if (ds != null)
            {
                ds.Titlename = this.txtTitleName.Text;
                ds.Firstname = this.txtFirstname.Text;
                ds.Lastname = this.txtLastname.Text;
                ds.Position = this.txtPosition.Text;
                ds.Email = this.txtEmail.Text;
                ds.Tel = this.txtphone.Text;
                ds.ClassroomDay1_Id = Convert.ToInt32(cbRoomD1.SelectedValue);
                ds.ClassroomDay2_Id = Convert.ToInt32(cbRoomD2.SelectedValue);
                ds.User_Edit = _UserName;
                ds.Edit_Date = DateTime.Now;
                ds.StatusPay_Id = Convert.ToInt32(cbStatus.SelectedValue);
                if (chkImage != true)
                {
                    ds.img = img;
                }
            }
            // Table Bills
            var Bill = (from b in db.Bills
                        where b.Register_Id == _RegId
                        select b).FirstOrDefault();
            if (Bill != null)
            {
                Bill.CompanyType_Id = Convert.ToInt32(cbCompanyType.SelectedValue);
                Bill.CompanyName = this.txtCompany.Text;
                Bill.Tex = txtTex.Text;
                Bill.Address_1 = this.txtAddress.Text;
                Bill.Township_1 = this.txtTownship.Text;
                Bill.Amphoe_1 = this.txtAmphoe.Text;
                Bill.Province_1 = this.txtProvince.Text;
                Bill.ZipCode_1 = this.txtZip.Text;

                Bill.Contact_Firstname = this.txtFirstameC.Text;
                Bill.Contact_Lastname = this.txtLastnameC.Text;
                Bill.Contact_Email = this.txtmailC.Text;
                Bill.Tel = this.txtTelC.Text;
                Bill.AddressSend = this.txtAddress_S.Text;
                Bill.TownshipSend = this.txtTownship_S.Text;
                Bill.AmphoeSend = this.txtAmphoe_S.Text;
                Bill.ProvinceSend = this.txtProvince_S.Text;
                Bill.ZipCodeSend = this.txtZip_S.Text;
                Bill.Fax = this.txtFax.Text;

                Bill.BillType_Id = Convert.ToInt32(cbBillType.SelectedValue);
                Bill.Rate = Convert.ToInt32(cbRate.Text);
                Bill.Price = this.txtPrice.Text;
                Bill.chk = 1;
            }
            db.SaveChanges();
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            GetData();
        }

        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //(ราคา * จำนวนคน) - ((ราคา * จำนวนคน) / 1.07) * อัตราภาษี)
            double _Rate = Convert.ToDouble(cbRate.Text);
            var SumMoney = (3000 * 1) - ((((3000 * 1) / 1.07) * _Rate) / 100);
            this.txtPrice.Text = SumMoney.ToString("#.##");
        }
    }
}
