namespace DocumentConverterForms.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string ProfileKey { get; set; }
        public ExcelParseSettings ExcelParseSettings { get; set; }
        public FileConversionSettings FileConversionSettings { get; set; }
    }
}