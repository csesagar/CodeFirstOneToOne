using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithEFCF6.Models
{
    public class Spouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, ForeignKey("Player")]
        public int PlayerId { get; set; }
        public string SpouseName { get; set; }
        public string SpouseProfession { get; set; }
        public Player Player { get; set; }     //scalar property for navigation to Player
    }
}