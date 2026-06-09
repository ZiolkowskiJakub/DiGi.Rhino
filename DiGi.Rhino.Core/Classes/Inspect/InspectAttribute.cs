using System;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Attribute used to mark methods for inspection purposes, providing metadata such as name, nickname, and description.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class InspectAttribute : Attribute
    {
        /// <summary>
        /// Gets the formal name associated with the inspected method.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the nickname or short name associated with the inspected method.
        /// </summary>
        public string Nickname { get; }

        /// <summary>
        /// Gets the detailed description of the inspected method.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InspectAttribute"/> class.
        /// </summary>
        /// <param name="name">The formal name of the inspection.</param>
        /// <param name="nickname">The nickname of the inspection.</param>
        /// <param name="description">The description of the inspection.</param>
        public InspectAttribute(string name, string nickname, string description)
        {
            Name = name;
            Nickname = nickname;
            Description = description;
        }
    }
}