namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_purchases
    {
        [Key]
        public int id_inv { get; set; }

        [StringLength(10)]
        public string inv_date { get; set; }

        public int? id_cur { get; set; }

        public double? inv_total { get; set; }

        [StringLength(100)]
        public string inv_explan { get; set; }

        public int? ac_debit { get; set; }

        public int? ac_credit { get; set; }

        [StringLength(50)]
        public string card_name { get; set; }

        public int? num_weight { get; set; }

        public int? num_cou { get; set; }

        public double? inv_discount { get; set; }

        public double? inv_net { get; set; }

        [StringLength(100)]
        public string note { get; set; }
    }
}
