﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Compra
    {

        [Key]
        public int NumFatura { get; set; }
        
        public DateTime DataCompra { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("Computador")]
        public int ComputadorFK { get; set; }
        public virtual Computador Computador { get; set; }

        
    }
}