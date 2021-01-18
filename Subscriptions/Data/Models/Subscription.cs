using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace  Subscriptions.Data.Models
{
   
    [Table("subscription")]
    public class Subscription
    {
      
        [Column("id", TypeName = "serial")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Column("visor_id", TypeName= "integer")]
        public int? VisorId { get; set; }

        
        [ForeignKey("VisorId")]
        public virtual Visor Visor { get; set; }

     
        [Column("last_day", TypeName = "integer")]
        public int Last_Day { get; set; }


         [Column("price", TypeName = "integer")]
        public int Price { get; set; }


        [Column("team_id", TypeName= "integer")]
        public int? TeamId { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }
    }


}
