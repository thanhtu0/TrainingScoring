﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingScoring.DomainModels
{
    public enum StudentGender
    {
        Male,       // 0
        Female      // 1
    }
    public enum Classmittee
    {
        Class_Monitor,  // 0
        Vice_Monitor,   // 1
        Secretary       // 2
    }
    [Table("Students")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public Classmittee IsClassmittee { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public StudentGender Gender { get; set; }

        public string Province { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //
        [ForeignKey("GradeId")]
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
        //
        public ICollection<Score> Scores { get; set; }
    }
}
