using System.ComponentModel.DataAnnotations;

namespace UnitConverter.Models
{
    public class Menu
    {
        public string Angle { get; set; }
        public string Area { get; set; }
        [Display(Name = "Bits And Bytes")]
        public string BitsAndBytes { get; set; }
        public string Currency { get; set; }
        public string Density { get; set; }
        [Display(Name = "Electric Current")]
        public string ElectricCurrent { get; set; }
        public string Energy { get; set; }
        public string Force { get; set; }
        [Display(Name = "Fuel Consumption")]
        public string FuelConsumption { get; set; }
        public string Length { get; set; }
        public string Mass { get; set; }
        public string Power { get; set; }
        public string Pressure { get; set; }
        public string Speed { get; set; }
        public string Temperature { get; set; }
        public string Time { get; set; }
        public string Volume { get; set; }

    }
}
