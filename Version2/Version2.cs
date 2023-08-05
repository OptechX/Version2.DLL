using System;
namespace Version2
{
    public class Version2 : IComparable<Version2>
    {
        public int Major { get; }
        public int Minor { get; }
        public int Build { get; }
        public int Revision1 { get; }
        public int Revision2 { get; }

        public Version2(int major, int minor, int build, int revision1, int revision2)
        {
            Major = major;
            Minor = minor;
            Build = build;
            Revision1 = revision1;
            Revision2 = revision2;
        }

        public int CompareTo(Version2 other)
        {
            if (other is null)
                return 1;

            if (Major != other.Major)
                return Major.CompareTo(other.Major);

            if (Minor != other.Minor)
                return Minor.CompareTo(other.Minor);

            if (Build != other.Build)
                return Build.CompareTo(other.Build);

            if (Revision1 != other.Revision1)
                return Revision1.CompareTo(other.Revision1);

            return Revision2.CompareTo(other.Revision2);
        }

        public override string ToString()
        {
            return $"{Major}.{Minor}.{Build}.{Revision1}.{Revision2}";
        }
    }
}

