namespace ManMonth_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Man.NewMan")]
    public partial class NewMan
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string NewTitle { get; set; }

        [StringLength(45)]
        public string NewContent { get; set; }

        [StringLength(45)]
        public string NewLevel { get; set; }

        [StringLength(45)]
        public string NewWriter { get; set; }
    }
}
