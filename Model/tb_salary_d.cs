namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_salary_d
    {
        [Key]
        public int id_s_d { get; set; }

        public int? id_s { get; set; }

        public int? ser_num { get; set; }

        public int? id_em { get; set; }

        public int? id_job { get; set; }

        public double? salary { get; set; }

        public double? day_count { get; set; }

        public double? reward { get; set; }

        public double? discount { get; set; }

        public double? net { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
