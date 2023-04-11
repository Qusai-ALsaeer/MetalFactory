namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_payment
    {
        [Key]
        public int id_pay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? pay_date { get; set; }

        public int? id_cur { get; set; }

        public double? pay_exch { get; set; }

        public int? pay_debit { get; set; }

        public int? pay_credit { get; set; }

        [StringLength(100)]
        public string explan { get; set; }

        public double? pay_amount { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
