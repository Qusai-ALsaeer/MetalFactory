namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_supervisor
    {
        [Key]
        public int id_sup { get; set; }

        [StringLength(50)]
        public string sup_name { get; set; }

        [StringLength(50)]
        public string note { get; set; }
    }
}
