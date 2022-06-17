using App.Interfaces;

namespace App.Entities
{
    public class User : IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
