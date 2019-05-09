using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTask1.Models
{
    public partial class Phone
    {
        public long Id { get; set; }
        public string Type { get; set; }
        [StringLength(50)]
        public string Number { get; set; }
        public long? PersonID { get; set; }

        [ForeignKey("PersonID")]
        [InverseProperty("Phone")]
        public virtual Person Person { get; set; }
    }
}