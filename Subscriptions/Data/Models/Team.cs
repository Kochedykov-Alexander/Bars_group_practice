using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Subscriptions.Data.Models
{

    [Table("team")]
    public class Subscription
    {

        [Column("id", TypeName = "serial")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar(150)")]
        public string Name { get; set; }

        [Column("description", TypeName = "varchar(150)")]
        public string Description { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }


}
