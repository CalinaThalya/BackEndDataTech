using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDataTech.Models
{
    [Table("tb_cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}