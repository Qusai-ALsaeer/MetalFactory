namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_sales
    {
        [Key]
        public int id_sal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sal_date { get; set; }

        public int? id_cur { get; set; }

        public double? sal_total { get; set; }

        [StringLength(100)]
        public string explan { get; set; }

        public int? ac_debit { get; set; }

        public int? ac_credit { get; set; }

        [StringLength(10)]
        public string num_weight { get; set; }

        public double? discount { get; set; }

        public double? net { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
