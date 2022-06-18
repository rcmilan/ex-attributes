namespace App.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class NotInheritedAttribute : Attribute
    {
    }
}
