﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TrainingScoring.DomainModels;

namespace TrainingScoring.WebUI.Models
{
    public class TrainingContentViewModel
    {
        public int EvaluationFormId { get; set; }
        public int TrainingDirectoryId { get; set; }
        public int TrainingContentId { get; set; }
        [DisplayName("Vị trí")]
        [Required(ErrorMessage = "{0} bắt buộc khác 0")]
        public int Order { get; set; }
        [DisplayName("Tên danh mục rèn luyện")]
        [Required(ErrorMessage = "{0} bắt buộc phải có")]
        public string TrainingContentName { get; set; }
        public bool IsProof { get; set; }
        public int MaxScore { get; set; }
        public TypeofScoreContent TypeofScore { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public IEnumerable<TrainingDetail> TrainingDetails { get; set; }
        // Phương thức chuyển đổi từ ViewModel sang Domain Model
        public TrainingContent ToTrainingContent()
        {
            return new TrainingContent
            {
                TrainingDirectoryId = this.TrainingDirectoryId,
                TrainingContentId = this.TrainingContentId,
                Order = this.Order,
                TrainingContentName = this.TrainingContentName,
                IsProof = this.IsProof,
                MaxScore = this.MaxScore,
                TypeofScore = this.TypeofScore,
                CreateAt = CreateAt,
                DeletedAt = DeletedAt
            };
        }
    }
}
