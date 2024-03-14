using System.ComponentModel.DataAnnotations.Schema;

namespace RepasoCubos.Models
{
    [Table("CUBOS")]
    public class Marcas
    {
        [Column("MARCA")]
        public string Marca { get; set; }
    }
}
