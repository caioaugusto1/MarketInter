﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inter.Core.App.ViewModel
{
    public class AccomodationViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Identifier")]
        [MaxLength(15, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Identifier")]
        public string Identifier { get; set; }

        [Required(ErrorMessage = "Address")]
        [MaxLength(50, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "ContactName")]
        [MaxLength(15, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "ContactNumber")]
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "ContactNumber")]
        [MaxLength(7, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Number Of Places")]
        public string NumberOfPlaces { get; set; }

        [Required(ErrorMessage = "Available")]
        [DisplayName("Available")]
        public bool Available { get; set; }
        
        public virtual List<CulturalExchangeViewModel> CulturalExchangeViewModel { get; set; }

        public int EnviromentId { get; set; }

        public virtual EnvironmentViewModel EnvironmentViewModel { get; set; }
    }
}
