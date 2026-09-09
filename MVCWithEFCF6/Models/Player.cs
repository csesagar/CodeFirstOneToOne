using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWithEFCF6.Models
{
    public class Player 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public Spouse Spouse { get; set; }     //scalar property for navigation to Player
    }
}