using App.Attributes;

namespace App.Entities
{
    public class Base
    {
        [Inherited]
        [NotInherited]
        public virtual void BaseMethod()
        {
            Console.WriteLine("BaseMethod");
        }
    }
}
