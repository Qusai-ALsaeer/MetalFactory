namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_week
    {
        [Key]
        public int id_week { get; set; }

        [StringLength(50)]
        public string we_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? from_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? to_date { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
