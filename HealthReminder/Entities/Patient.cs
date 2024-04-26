﻿using System.ComponentModel.DataAnnotations;

namespace HealthReminder.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender {  get; set; }
        public string PhoneNumber { get; set; }
        public bool PreExistingCondition {  get; set; }
        public DateTime TimeLimit { get; set; }
        public int DrugId { get; set; }
        public Drug Drug { get; set; }  
    }
}