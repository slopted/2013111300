﻿using _2013111300_ENT.Entities;
using _2013111300_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {


        public LlantaRepository(EnsambladoraDbContext context) : base(context)
        {
   
        }

    }
}
