﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models.TravelAgency
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public decimal Rating { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }

        public int VacationId { get; set; }
    }
}