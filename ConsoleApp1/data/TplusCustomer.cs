using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.data;

public partial class TplusCustomer
{
    public TplusCustomer(long id)
    {
        Id = id;
    }
    public long Id { get; set; }

    [MaxLength(10)]
    public string Nationalcode { get; set; } = "کد ملی";
    public string Storename { get; set; } = "نام فروشگاه";

    [MaxLength(11)]
    public string Nationalid { get; set; } = "شناسه ملی";
}
