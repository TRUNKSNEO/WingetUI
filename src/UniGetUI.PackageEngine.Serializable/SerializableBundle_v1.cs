namespace UniGetUI.PackageEngine.Classes.Serializable
{
    public class SerializableBundle_Data
    {
        public const double ExpectedVersion = 2.1;
    }

    public class SerializableBundle_v1
    {
        public double export_version { get; set; } = -1;
        public List<SerializablePackage_v1> packages { get; set; } = [];
        public string incompatible_packages_info { get; set; } = "Incompatible packages cannot be installed from WingetUI, but they have been listed here for logging purposes.";
        public List<SerializableIncompatiblePackage_v1> incompatible_packages { get; set; } = [];

    }
}
