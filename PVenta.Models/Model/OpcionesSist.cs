﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.Model
{
    [Table("OpcionesSist")]
    public class OpcionesSist
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("Descripcion", TypeName = "varchar")]
        [MaxLength(30)]
        [Required(ErrorMessage = "Descripción es requerida")]
        public string Descripcion { get; set; }

        public bool Inactivo { get; set; }
    }
}
