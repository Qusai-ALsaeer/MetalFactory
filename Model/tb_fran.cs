namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_fran
    {
        [Key]
        public int id_farn { get; set; }

        [StringLength(50)]
        public string far_name { get; set; }
        public int id_Acco { get; set; }

    }
}
