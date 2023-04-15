namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_jop
    {
        [Key]
        public int id_jop { get; set; }

        [StringLength(50)]
        public string jop_name { get; set; }
    }
}
