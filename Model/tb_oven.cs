namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_oven
    {
        [Key]
        public int id_oven { get; set; }

        [StringLength(50)]
        public string ove_name { get; set; }
    }
}
