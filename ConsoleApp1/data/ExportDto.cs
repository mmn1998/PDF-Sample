
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.data
{
    public class ExportDto
    {
        [Display(Name = "نام")]
        public string? Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string? Familyname { get; set; }
        [Display(Name = "کد ملی")]
        public string? Nationalcode { get; set; }
        [Display(Name = "نام و نام خانوادگی مدیر عامل")]
        public string? Ceoname { get; set; }
        [Display(Name = "شماره ثبت")]
        public string? Registrationnumber { get; set; }
        [Display(Name = "شناسه ملی")]
        public string? Nationalid { get; set; }
        [Display(Name = "نام فروشگاه")]
        public string? StoreName { get; set; }
        [Display(Name = "شماره موبایل")]
        public string? Mobilenumber { get; set; } 
        public string? Validity { get; set; }  
        public string? PurchaseVolume { get; set; }
        public string? Customergrade { get; set; }
        public string? Referencenationalcode { get; set; }
        public string? Statusid { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? CreateDate { get; set; }
        public string? Description { get; set; }
    }
}
