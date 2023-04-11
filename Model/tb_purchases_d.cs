namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_purchases_d
    {
        [Key]
        public int id_inv_d { get; set; }

        public int? ser_num { get; set; }

        public int? id_p { get; set; }

        public int? id_mat { get; set; }

        [StringLength(100)]
        public string explan { get; set; }

        public double? quantity { get; set; }

        public int? id_un { get; set; }

        public double? price { get; set; }

        public double? total { get; set; }

        public double? discount { get; set; }

        public double? net { get; set; }
    }
}
