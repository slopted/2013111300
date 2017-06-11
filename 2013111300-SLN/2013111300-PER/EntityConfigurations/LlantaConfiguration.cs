﻿using _2013111300_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300_PER.EntityConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            ToTable("Llantas")
                .HasKey(c => c.LlantaId);

            Property(v => v.NumSerie)
                    .IsRequired()
                    .HasMaxLength(100);
        }

    }
}
