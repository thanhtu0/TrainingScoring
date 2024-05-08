﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingScoring.DomainModels
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int DepartmentId {  get; set; }
        [Required]
        [MaxLength(30)]
        public string DepartmentCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string DepartmentName { get; set; }

        //Realationship 
        public ICollection<Major> Majors { get; set; }
        public ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
