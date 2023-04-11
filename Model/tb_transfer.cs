namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_transfer
    {
        [Key]
        public int id_bt { get; set; }

        [StringLength(50)]
        public string bt_name { get; set; }

        [StringLength(50)]
        public string bt_carname { get; set; }

        public int? id_inv { get; set; }

        [StringLength(50)]
        public string num_w { get; set; }

        public int? weight { get; set; }

        public double? bt_amount { get; set; }

        public double? bt_total { get; set; }

        public double? bt_discount { get; set; }

        public double? bt_net { get; set; }

        public int? id_cur { get; set; }

        [Column(TypeName = "date")]
        public DateTime? bt_date { get; set; }
    }
}
