using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.Models
{
    [Table("monitor")]
    public class Monitore
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
    }
}
