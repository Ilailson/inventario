using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.Models
{
    [Table("sala")]
    public class Sala
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
    }
}
