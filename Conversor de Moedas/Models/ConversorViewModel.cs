using Microsoft.AspNetCore.WebUtilities;

namespace Conversor_de_Moedas.Models
{
    public class ConversorViewModel
    {
        double moeda, moeda1, resultado; 
        public decimal Moeda { get; set; }
        public decimal Moeda1 { get; set; }
        public decimal Resultado { get; set; }
    }
}
