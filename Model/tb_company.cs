namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_company
    {
        [Key]
        [StringLength(50)]
        public string comp_name { get; set; }

        [StringLength(70)]
        public string address { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [Column(TypeName = "image")]
        public byte[] logo { get; set; }
    }
}
