namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_currency
    {
        [Key]
        public int id_cu { get; set; }

        [StringLength(30)]
        public string cu_name { get; set; }

        [StringLength(10)]
        public string cu_sym { get; set; }

        [StringLength(10)]
        public string cu_part { get; set; }

        [StringLength(10)]
        public string cu_iso { get; set; }
    }
}
