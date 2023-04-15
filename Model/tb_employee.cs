namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_employee
    {
        [Key]
        public int id_em { get; set; }

        [StringLength(50)]
        public string emp_name { get; set; }

        public int? jop { get; set; }

        public int? emp_sal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }
    }
}
