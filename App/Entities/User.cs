using App.Attributes;
using App.Interfaces;

namespace App.Entities
{
    [Author("Author123")]
    public class User : Base, IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override void BaseMethod() // possui apenas InheritedAttribute
        {
            base.BaseMethod();
        }
    }
}