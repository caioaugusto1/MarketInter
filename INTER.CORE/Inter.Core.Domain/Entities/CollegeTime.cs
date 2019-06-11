﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inter.Core.Domain.Entities
{
    public class CollegeTime
    {
        public int Id { get; set; }

        public string StartTime { get; set; }

        public string FinishTime { get; set; }

        public int DaysOfWeek { get; set; }

        public int TimeForWeek { get; set; }

        public string Period { get; set; }

        public decimal Price { get; set; }

        public decimal BookPrice { get; set; }

        public decimal ExamPrice { get; set; }

        public decimal InsurancePrice { get; set; }

        public decimal AccomodationPrice { get; set; }

        public int CollegeId { get; set; }

        public virtual College College { get; set; }

        public string Note { get; set; }
    }
}