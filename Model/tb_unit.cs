namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_unit
    {
        [Key]
        public int id_unit { get; set; }

        [StringLength(50)]
        public string u_name { get; set; }
    }
}
