namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_item
    {
        [Key]
        public int id_it { get; set; }

        [StringLength(50)]
        public string it_name { get; set; }

        public int? cat_name { get; set; }

        public int id_cat { get; set; }

        public int? u_name { get; set; }
    }
}
