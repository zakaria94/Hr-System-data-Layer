﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamplate.DAL.Enitity
{
    [Table("Employee")]
    public class Employee
    {
       
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        
        public float Salary { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; }

        public string Notes { get; set; }

        public string Email { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }

        public string CvUrl { get; set; }

        public string ImageUrl { get; set; }
    }
}
