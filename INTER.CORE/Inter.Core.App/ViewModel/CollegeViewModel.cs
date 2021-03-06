﻿using Inter.Core.App.Enumerables;
using Inter.Core.App.ViewModel.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inter.Core.App.ViewModel
{
    public class CollegeViewModel : BaseViewModel
    {
        public CollegeViewModel()
        {
            ValidationResult = new List<ValidationResult>();
        }

        [Required(ErrorMessage = "Name")]
        [MaxLength(50, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address")]
        [MaxLength(50, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City")]
        [MaxLength(50, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country")]
        [MaxLength(50, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone Number")]
        [MaxLength(20, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Contac tName")]
        [MaxLength(50, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Email")]
        [MaxLength(40, ErrorMessage = "Max {0} caracteres")]
        [EmailAddress(ErrorMessage = "Min um E-mail válido")]
        [DisplayName("Email")]
        public string Email { get; set; }

        public virtual List<CollegeTimeViewModel> CollegeTimeViewModel { get; set; }
    }

    public class CollegeTimeViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Time, ErrorMessage = "Incorrect Time")]
        [Required(ErrorMessage = "Start Time")]
        public TimeSpan StartTime { get; set; }

        [Display(Name = "Finish Time")]
        [DataType(DataType.Time, ErrorMessage = "Incorrect Time")]
        [Required(ErrorMessage = "Finish Time")]
        public TimeSpan FinishTime { get; set; }

        [Display(Name = "Days of Week")]
        [Required(ErrorMessage = "Days of Week")]
        public int DaysOfWeek { get; set; }

        public string TimeForWeek { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [Display(Name = "Period Time")]
        [Required(ErrorMessage = "Period Time")]
        public PeriodClass Period { get; set; }

        [Display(Name = "Total Price")]
        [Required(ErrorMessage = "Total Price")]
        public decimal Price { get; set; }

        [Display(Name = "Book Price")]
        [Required(ErrorMessage = "Book Price")]
        public decimal BookPrice { get; set; }

        [Display(Name = "Exam Price")]
        [Required(ErrorMessage = "Exam Price")]
        public decimal ExamPrice { get; set; }

        [Display(Name = "Insurance Price")]
        [Required(ErrorMessage = "Insurance Price")]
        public decimal InsurancePrice { get; set; }

        [Display(Name = "Accomodation Price")]
        [Required(ErrorMessage = "Accomodation Price")]
        public decimal AccomodationPrice { get; set; }

        [Display(Name = "Net Price")]
        [Required(ErrorMessage = "Net Price")]
        public decimal NetPrice { get; set; }

        [Display(Name = "Gross Price")]
        [Required(ErrorMessage = "Gross Price")]
        public decimal GrossPrice { get; set; }

        [Display(Name = "Renew Price")]
        [Required(ErrorMessage = "Renew Price")]
        public decimal RenewPrice { get; set; }

        [Display(Name = "Percentage Price")]
        [Required(ErrorMessage = "Percentage Price")]
        public int PercentagePrice { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        public Guid CollegeId { get; set; }

        public virtual CollegeViewModel College { get; set; }
    }

}
