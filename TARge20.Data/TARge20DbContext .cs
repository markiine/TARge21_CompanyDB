using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
        public DbSet<BranchOffice> BranchOffices { get; set; }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<DataSystem> DataSystems { get; set; }
        public DbSet<HealthInspection> HealthInspections { get; set; }
        public DbSet<ItemsToRent> ItemsToRents { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Vacation> Vacations { get; set; }

    }
}