namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_account
    {
        [Key]
        public int id_ac { get; set; }

        public int? ac_num { get; set; }

        public int? ac_level { get; set; }

        [StringLength(50)]
        public string ac_name { get; set; }

        public bool? ac_type { get; set; }

        public int? ac_fnum { get; set; }

        public int? ac_open { get; set; }

        public int? ac_final { get; set; }

        public int? ac_cu { get; set; }
    }
}
