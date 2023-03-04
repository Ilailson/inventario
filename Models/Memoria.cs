using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.Models
{
    [Table("memoria")]
    public class Memoria
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
    }
}
