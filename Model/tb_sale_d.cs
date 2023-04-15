namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_sale_d
    {
        [Key]
        public int id_sal_d { get; set; }

        [StringLength(10)]
        public string ser_num { get; set; }

        public int? id_sal { get; set; }

        public int? id_mat { get; set; }

        public double? quntity { get; set; }

        public int? id_un { get; set; }

        public double? price { get; set; }

        public double? discount { get; set; }

        public double? net { get; set; }
    }
}
