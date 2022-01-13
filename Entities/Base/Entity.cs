using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Entities.Base
{
    public class Entity
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
    }
}
