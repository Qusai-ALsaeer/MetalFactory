namespace Acco.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_car
    {
        [Key]
        public int id_car { get; set; }

        [StringLength(50)]
        public string car_name { get; set; }

        [StringLength(50)]
        public string car_num { get; set; }

        [StringLength(50)]
        public string car_space { get; set; }
    }
}
