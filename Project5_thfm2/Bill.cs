//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project5_thfm2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int Bill_Id { get; set; }
        public Nullable<int> CompanyType_Id { get; set; }
        public string CompanyName { get; set; }
        public string Contact_Firstname { get; set; }
        public string Contact_Lastname { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Tex { get; set; }
        public Nullable<int> Rate { get; set; }
        public string Price { get; set; }
        public string Address_1 { get; set; }
        public string Township_1 { get; set; }
        public string Amphoe_1 { get; set; }
        public string Province_1 { get; set; }
        public string ZipCode_1 { get; set; }
        public string AddressSend { get; set; }
        public string TownshipSend { get; set; }
        public string AmphoeSend { get; set; }
        public string ProvinceSend { get; set; }
        public string ZipCodeSend { get; set; }
        public Nullable<int> BillType_Id { get; set; }
        public Nullable<int> Register_Id { get; set; }
        public Nullable<int> Login_Id { get; set; }
        public Nullable<int> chk { get; set; }
        public string Contact_Email { get; set; }
    
        public virtual BillType BillType { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public virtual Login Login { get; set; }
        public virtual Rate Rate1 { get; set; }
        public virtual Register Register { get; set; }
    }
}
