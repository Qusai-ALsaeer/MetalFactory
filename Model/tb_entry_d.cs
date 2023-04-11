namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_entry_d
    {
        [Key]
        public int id_dent { get; set; }

        public int? ser_num { get; set; }

        public int? id_ent { get; set; }

        public double? ent_credit { get; set; }

        public double? ent_debit { get; set; }

        public int? ac_credit { get; set; }

        public int? ac_debit { get; set; }

        [StringLength(100)]
        public string expaln { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
