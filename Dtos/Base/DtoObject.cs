using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Dtos.Base
{
    public class DtoObject
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
