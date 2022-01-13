using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JalgrattaEksamMVC.Models
{
    public class Eksam
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Eesnimi { get; set; }
        [StringLength(30)]
        [Required]
        public string Perekonnanimi { get; set; }
        [Range(-1,10)]
        public int Teooria { get; set; } = -1;
        public int Slaalom { get; set; } = -1;
        public int Ring { get; set; } = -1;
        public int Tänav { get; set; } = -1;
        public int Luba { get; set; } = -1;
    }
}
