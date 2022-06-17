using App.Attributes;
using App.Interfaces;

namespace App.Entities
{
    [Author("Author123")]
    public class User : IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}