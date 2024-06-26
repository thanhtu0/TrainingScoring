﻿using Microsoft.EntityFrameworkCore;
using TrainingScoring.Data.Repositories.Interfaces;
using TrainingScoring.DomainModels;

namespace TrainingScoring.Data.Repositories.Implementations
{
    public class AcademicYearRepository : Repository<AcademicYear>, IAcademicYearRepository
    {
        private readonly TrainingScoingDBContext _context;
        public AcademicYearRepository(TrainingScoingDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
