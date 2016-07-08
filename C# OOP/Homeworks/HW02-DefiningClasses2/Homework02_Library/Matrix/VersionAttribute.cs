
namespace Homework02_Library.Matrix
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttribute()
        {
            this.Major = 0;
            this.Minor = 0;
        }
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return $"Version {this.Major}.{this.Minor}";
        }
    }
}
