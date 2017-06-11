using _2013111300_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300_PER.EntityConfigurations
{
    public class ParabrisasConfiguration : EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisasConfiguration()
        {
            ToTable("Parabrisas")
               .HasKey(c => c.ParabrisasId);

            Property(v => v.NumSerie)
                 .IsRequired()
                 .HasMaxLength(100);

        }

    }
}
