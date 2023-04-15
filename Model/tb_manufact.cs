namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_manufact
    {
        [Key]
        public int id_maunf { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public int? sup_name { get; set; }

        public int? oven { get; set; }

        public int? ovener { get; set; }

        [StringLength(10)]
        public string num_card { get; set; }

        public int? car { get; set; }

        public double? quntity { get; set; }

        public double? price { get; set; }

        public double? total { get; set; }

        public double? note { get; set; }
    }
}
