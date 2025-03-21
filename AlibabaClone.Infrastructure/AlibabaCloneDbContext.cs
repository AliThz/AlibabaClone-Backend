using AlibabaClone.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure
{
    public class AlibabaCloneDbContext : DbContext
    {
        #region [ - Ctor - ]
        public AlibabaCloneDbContext(DbContextOptions<AlibabaCloneDbContext> options) : base(options) { }
        #endregion

        #region [ - DbSets - ]

        #region [ - Account - ]
        public DbSet<Domain.Aggregates.AccountsAggregates.Account> Accounts { get; set; }
        public DbSet<Domain.Aggregates.AccountsAggregates.AccountRole> AccountRoles { get; set; }
        public DbSet<Domain.Aggregates.AccountsAggregates.Gender> Genders { get; set; }
        public DbSet<Domain.Aggregates.AccountsAggregates.Person> People { get; set; }
        public DbSet<Domain.Aggregates.AccountsAggregates.Role> Roles { get; set; }
        #endregion

        #region [ - Company - ]
        public DbSet<Domain.Aggregates.CompanyAggregates.Company> Companies { get; set; }
        #endregion

        #region [ - Location - ]
        public DbSet<Domain.Aggregates.LocationAggregates.City> Cities { get; set; }
        public DbSet<Domain.Aggregates.LocationAggregates.Location> Locations { get; set; }
        public DbSet<Domain.Aggregates.LocationAggregates.LocationType> LocationTypes { get; set; }
        #endregion

        #region [ - Transaction - ]
        public DbSet<Domain.Aggregates.TransactionAggregates.Transaction> Transactions { get; set; }
        public DbSet<Domain.Aggregates.TransactionAggregates.Coupon> Coupons { get; set; }
        #endregion

        #region [ - Transportation - ]
        public DbSet<Domain.Aggregates.TransportationAggregates.Ticket> Tickets { get; set; }
        public DbSet<Domain.Aggregates.TransportationAggregates.TicketStatus> TicketStatuses { get; set; }
        public DbSet<Domain.Aggregates.TransportationAggregates.Transportation> Transportations { get; set; }
        #endregion

        #region [ - Vehicle - ]
        public DbSet<Domain.Aggregates.VehicleAggregates.Seat> Seats { get; set; }
        public DbSet<Domain.Aggregates.VehicleAggregates.Vehicle> Vehicles { get; set; }
        public DbSet<Domain.Aggregates.VehicleAggregates.VehicleType> VehicleTypes { get; set; }
        #endregion

        #endregion

        #region [ - Methods - ]

        #region [ - OnModelCreating(ModelBuilder modelBuilder) - ]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlibabaCloneDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region [ - OnConfiguring(DbContextOptionsBuilder optionsBuilder) - ]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        #endregion

        #endregion
    }
}
