namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_motion
    {
        [Key]
        public int id_mo { get; set; }

        [StringLength(50)]
        public string mo_name { get; set; }
    }
}
