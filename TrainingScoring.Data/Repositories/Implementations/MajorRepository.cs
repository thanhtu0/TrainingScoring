﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingScoring.Data.Repositories.Interfaces;
using TrainingScoring.DomainModels;

namespace TrainingScoring.Data.Repositories.Implementations
{
    public class MajorRepository : Repository<Major>, IMajorRepository
    {
        private readonly TrainingScoingDBContext _context;
        public MajorRepository(TrainingScoingDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
