namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_user
    {
        [Key]
        public int id_user { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(20)]
        public string user_type { get; set; }
    }
}
