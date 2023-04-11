namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_category
    {
        [Key]
        public int id_cat { get; set; }

        [StringLength(50)]
        public string cat_name { get; set; }
    }
}
