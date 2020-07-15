using System;
using Microsoft.EntityFrameworkCore;
using MultipleDbRepoLab.Repositories.Entities;

namespace MultipleDbRepoLab.Repositories.EfCoreContext
{
    public class MyTestContext : DbContext
    {
        public MyTestContext()
        {
        }

        public MyTestContext(DbContextOptions<MyTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Data> Data { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            modelBuilder.Entity<Data>(entity =>
                                      {
                                          entity.HasNoKey();

                                          entity.Property(e => e.ByLocationId)
                                                .IsRequired()
                                                .HasMaxLength(10)
                                                .IsFixedLength();

                                          entity.Property(e => e.ByLotNumber)
                                                .IsRequired()
                                                .HasMaxLength(10)
                                                .IsFixedLength();

                                          entity.Property(e => e.IndividuallySet)
                                                .IsRequired()
                                                .HasMaxLength(50);

                                          entity.Property(e => e.MethodCode)
                                                .IsRequired()
                                                .HasMaxLength(50);

                                          entity.Property(e => e.ProductCode)
                                                .IsRequired()
                                                .HasMaxLength(50);
                                      });
            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}