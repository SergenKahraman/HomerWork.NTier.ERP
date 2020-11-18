﻿using HomeWork.NTier.ERP.Data.Entities.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.NTier.ERP.Data.Entities
{
    public class Employee : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EmployeeID")]
        public override int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        [ForeignKey(nameof(ReportsTo))] //TODO: burası önemli aşağıdaki entity normalde Employee1 diye geliyordu ama biz onu Manager yaptık ve onun ReportsTon daki Employee olduğunu belirttik ForeignKey olarak işaretledik
        public virtual Employee Manager { get; set; }
    }
}
