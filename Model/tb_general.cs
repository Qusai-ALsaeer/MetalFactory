namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_general
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public double? credit { get; set; }

        public double? debit { get; set; }

        public int? id_cur { get; set; }

        public int? mother_num { get; set; }
        public int? motion_num { get; set; }
        public int? gen_num { get; set; }

        public int? account { get; set; }

        [StringLength(100)]
        public string explan { get; set; }

        [StringLength(50)]
        public string past_date { get; set; }

        public bool? g_check { get; set; }

        public bool? transfer { get; set; }
    }
}
