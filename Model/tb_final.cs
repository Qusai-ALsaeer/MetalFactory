namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_final
    {
        [Key]
        public int id_fin { get; set; }

        [Required]
        [StringLength(20)]
        public string f_num { get; set; }

        [Required]
        [StringLength(50)]
        public string f_name { get; set; }
    }
}
