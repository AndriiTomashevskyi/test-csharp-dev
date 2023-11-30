using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxCalculator.Domain.Models
{
    public class TaxBand
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Band name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Band name is 30 characters.")]
        public string BandName { get; set; }

        public int LowerLimit { get; set; }

        public int? UpperLimit { get; set; }

        public int TaxRate { get; set; }
    }
}