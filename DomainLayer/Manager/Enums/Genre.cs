using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Manager.Enums {
    public enum Genre {
        Action,
        Comedy,
        Drama,
        [EnumDescription("Sci-Fi")]
        [EnumDescription("SciFi")]
        SciFi,
        Thriller,
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
    internal sealed class EnumDescriptionAttribute : Attribute {
        public string Description { get; }

        public EnumDescriptionAttribute(string description) {
            Description = description;
        }
    }
}
