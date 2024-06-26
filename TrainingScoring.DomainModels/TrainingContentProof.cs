﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingScoring.DomainModels
{
    [Table("TrainingContentProofs")]
    public class TrainingContentProof 
    {
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        

        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }
        //Relationship
        [ForeignKey("TrainingContentId")]
        public int TrainingContentId { get; set; }

        [ForeignKey("ProofId")]
        public int ProofId { get; set; }

        public TrainingContent TrainingContent  { get; set; }
        public Proof Proof { get; set; }
    }
}
