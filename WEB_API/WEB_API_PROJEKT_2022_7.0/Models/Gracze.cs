using System.ComponentModel.DataAnnotations;

namespace WEB_API_PROJEKT_2022_7._0.Models
{
    // Used only for Mock_Service
    public class Gracze
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [Display(Name="Password")] 
        public string Haslo { get; set; }
        public decimal Cash { get; set; }
    }
}
