﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingScoring.DomainModels
{
    [Table("EvaluationForms")]
    public class EvaluationForm 
    {
        [Key]
        public int EvaluationFormId { get; set; }
        [Required]
        public string EvaluationFormCode { get; set; }

        [Required]
        [MaxLength(150)]
        public string EvaluationFormName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }

        // Relationship
        public int AcademicYearId { get; set; } 
        public AcademicYear AcademicYear { get; set; } 

        public ICollection<TrainingDirectory> TrainingDirectories { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
