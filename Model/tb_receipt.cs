namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_receipt
    {
        [Key]
        public int id_rec { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rec_date { get; set; }

        public int? id_cur { get; set; }

        public double? exch { get; set; }

        public int? rec_debit { get; set; }

        public int? rec_credit { get; set; }

        [StringLength(100)]
        public string explane { get; set; }

        public double? amount { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
