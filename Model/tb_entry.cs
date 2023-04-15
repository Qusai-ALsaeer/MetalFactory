namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_entry
    {
        [Key]
        public int id_ent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public int? id_cu { get; set; }

        [StringLength(100)]
        public string explan { get; set; }

        public double? c_total { get; set; }

        public double? d_total { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
