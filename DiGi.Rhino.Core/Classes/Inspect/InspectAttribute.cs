using System;

namespace DiGi.Rhino.Core.Classes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class InspectAttribute : Attribute
    {
        public string Name { get; }
        public string Nickname { get; }
        public string Description { get; }

        public InspectAttribute(string name, string nickname, string description)
        {
            Name = name;
            Nickname = nickname;
            Description = description;
        }
    }
}
