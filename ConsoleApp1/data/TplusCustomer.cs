using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.data
{
    public partial class TplusCustomer
    {
        public TplusCustomer()
        {
            TplusRequesthistories = new HashSet<TplusRequesthistory>();
            TplusCustomerreasons = new HashSet<TplusCustomerreason>();
            TplusRequests = new HashSet<TplusRequest>();
            TplusUsers = new HashSet<TplusUser>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public long? Customertype { get; set; }
        public string? Name { get; set; }
        public string? Familyname { get; set; }

        [MaxLength(10)]
        public string Nationalcode { get; set; } = "";
        public string Storename { get; set; } = "";

        [MaxLength(11)]
        public string? Mobilenumber { get; set; }
        public string? Customergrade { get; set; }
        public string? Companyname { get; set; }
        public string? Ceoname { get; set; }
        public string? Registrationnumber { get; set; }

        [MaxLength(11)]
        public string Nationalid { get; set; } = "";
        public bool? Isactive { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool Iscurrent { get; set; }
        public decimal? Userid { get; set; }
        public long? Entrytype { get; set; }
        public decimal? Statustype { get; set; }
        public string? PurchaseVolume { get; set; }
        public string? Validity { get; set; }
        public string? Description { get; set; }
        public string? TrackingCode { get; set; }
        public string? ReferenceNationalCode { get; set; }

        public virtual TplusUser? User { get; set; }
        public virtual ICollection<TplusRequesthistory> TplusRequesthistories { get; set; }
        public virtual ICollection<TplusRequest> TplusRequests { get; set; }
        public virtual ICollection<TplusUser> TplusUsers { get; set; }
        public virtual ICollection<TplusCustomerreason> TplusCustomerreasons { get; set; }
    }
    public partial class TplusCustomerreason
    {
        public TplusCustomerreason()
        {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public decimal? Customerid { get; set; }
        public long Reasonid { get; set; }
        public string? Title { get; set; }

        public virtual TplusCustomer? Customer { get; set; }
    }
    public partial class TplusPlan
    {
        public TplusPlan()
        {
            TplusRequesthistories = new HashSet<TplusRequesthistory>();
            TplusRequests = new HashSet<TplusRequest>();
            TplusPlanDetails = new HashSet<TplusPlanDetails>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string? Title { get; set; }
        public bool IsActicve { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TplusRequesthistory> TplusRequesthistories { get; set; }
        public virtual ICollection<TplusRequest> TplusRequests { get; set; }
        public virtual ICollection<TplusPlanDetails> TplusPlanDetails { get; set; }
    }
    public class TplusPlanDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string? Title { get; set; }
        public string URL { get; set; }
        public string Logo { get; set; }
        public string LatinTitle { get; set; }
        public decimal PlanId { get; set; }
        public virtual TplusPlan? Plan { get; set; }
    }
    public partial class TplusBranch
    {
        public TplusBranch()
        {
            TplusRequesthistories = new HashSet<TplusRequesthistory>();
            TplusRequests = new HashSet<TplusRequest>();
            TplusUsers = new HashSet<TplusUser>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? Branchcode { get; set; }
        public decimal? Provinceid { get; set; }
        public string? Username { get; set; }
        public string? Phone { get; set; }
        public decimal? Supervisionid { get; set; }

        public virtual TplusProvince? Province { get; set; }
        public virtual TplusSupervision? Supervision { get; set; }
        public virtual ICollection<TplusRequesthistory> TplusRequesthistories { get; set; }
        public virtual ICollection<TplusRequest> TplusRequests { get; set; }
        public virtual ICollection<TplusUser> TplusUsers { get; set; }
    }
    public partial class TplusRequest
    {
        public TplusRequest()
        {
            TplusRequesthistories = new HashSet<TplusRequesthistory>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public decimal? Planid { get; set; }
        public decimal? Customerid { get; set; }
        public DateTime? Insertdate { get; set; }
        public decimal? Insertuser { get; set; }
        public DateTime? Modifydate { get; set; }
        public decimal? Modifyuser { get; set; }
        public decimal? Statusid { get; set; }
        public decimal? Branchid { get; set; }
        public string? Trackingcode { get; set; }
        public decimal? Loanamount { get; set; }
        public decimal? Depositamount { get; set; }
        public DateTime? Requestdate { get; set; }
        public string? Description { get; set; }
        public decimal? SupervisionId { get; set; }

        public virtual TplusBranch? Branch { get; set; }
        public virtual TplusSupervision? Supervision { get; set; }
        public virtual TplusCustomer? Customer { get; set; }
        public virtual TplusUser? InsertuserNavigation { get; set; }
        public virtual TplusPlan? Plan { get; set; }
        public virtual TplusRequeststatus? Status { get; set; }
        public virtual ICollection<TplusRequesthistory> TplusRequesthistories { get; set; }
    }
    public partial class TplusRequesthistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public decimal? Planid { get; set; }
        public decimal? Customerid { get; set; }
        public DateTime? Insertdate { get; set; }
        public decimal? Insertuser { get; set; }
        public DateTime? Modifydate { get; set; }
        public decimal? Modifyuser { get; set; }
        public decimal? Statusid { get; set; }
        public decimal? Branchid { get; set; }
        public string? Trackingcode { get; set; }
        public decimal? Loanamount { get; set; }
        public decimal? Depositamount { get; set; }
        public DateTime? Requestdate { get; set; }
        public string? Description { get; set; }
        public decimal? Requestid { get; set; }
        public DateTime? Historyinsertdate { get; set; }

        public virtual TplusBranch? Branch { get; set; }
        public virtual TplusCustomer? Customer { get; set; }
        public virtual TplusUser? InsertuserNavigation { get; set; }
        public virtual TplusPlan? Plan { get; set; }
        public virtual TplusRequest? Request { get; set; }
        public virtual TplusRequeststatus? Status { get; set; }
    }
    public partial class TplusSupervision
    {
        public TplusSupervision()
        {
            TplusBranches = new HashSet<TplusBranch>();
            TplusRequests = new HashSet<TplusRequest>();
        }

        public decimal Id { get; set; }
        public string? Title { get; set; }
        public decimal? Provinceid { get; set; }

        public virtual TplusProvince? Province { get; set; }
        public virtual ICollection<TplusBranch> TplusBranches { get; set; }
        public virtual ICollection<TplusRequest> TplusRequests { get; set; }
    }
    public partial class TplusUser
    {
        public TplusUser()
        {
            TplusCustomers = new HashSet<TplusCustomer>();
            TplusRequesthistories = new HashSet<TplusRequesthistory>();
            TplusRequests = new HashSet<TplusRequest>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public long? Role { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public decimal? Branchid { get; set; }
        public bool? Isfirsttime { get; set; }
        public decimal? Customerid { get; set; }

        public virtual TplusBranch? Branch { get; set; }
        public virtual TplusCustomer? Customer { get; set; }
        public virtual ICollection<TplusCustomer> TplusCustomers { get; set; }
        public virtual ICollection<TplusRequesthistory> TplusRequesthistories { get; set; }
        public virtual ICollection<TplusRequest> TplusRequests { get; set; }
    }
    public partial class TplusRequeststatus
    {
        public TplusRequeststatus()
        {
            TplusRequesthistories = new HashSet<TplusRequesthistory>();
            TplusRequests = new HashSet<TplusRequest>();
        }

        public decimal Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<TplusRequesthistory> TplusRequesthistories { get; set; }
        public virtual ICollection<TplusRequest> TplusRequests { get; set; }
    }
    public partial class TplusProvince
    {
        public TplusProvince()
        {
            TplusBranches = new HashSet<TplusBranch>();
            TplusCities = new HashSet<TplusCity>();
            TplusSupervisions = new HashSet<TplusSupervision>();
        }

        public decimal Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<TplusBranch> TplusBranches { get; set; }
        public virtual ICollection<TplusCity> TplusCities { get; set; }
        public virtual ICollection<TplusSupervision> TplusSupervisions { get; set; }
    }
    public partial class TplusCity
    {
        public decimal Id { get; set; }
        public string? Title { get; set; }
        public decimal? Provinceid { get; set; }

        public virtual TplusProvince? Province { get; set; }
    }
}
