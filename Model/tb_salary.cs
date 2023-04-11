namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_salary
    {
        [Key]
        public int id_s { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public int? id_cu { get; set; }

        public double? exch { get; set; }

        public double? total { get; set; }

        [StringLength(100)]
        public string explan { get; set; }

        [StringLength(10)]
        public string em_count { get; set; }

        public int? id_week { get; set; }
    }
}
