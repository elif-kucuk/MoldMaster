﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoldMasterDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MoldMasterEntities : DbContext
    {
        public MoldMasterEntities()
            : base("name=MoldMasterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MaintenancePlan> MaintenancePlans { get; set; }
        public virtual DbSet<MoldJournal> MoldJournals { get; set; }
        public virtual DbSet<MoldMachine> MoldMachines { get; set; }
        public virtual DbSet<MoldModel> MoldModels { get; set; }
        public virtual DbSet<Mold> Molds { get; set; }
        public virtual DbSet<MoldSetup> MoldSetups { get; set; }
        public virtual DbSet<MoldTransfer> MoldTransfers { get; set; }
        public virtual DbSet<MoldType> MoldTypes { get; set; }
        public virtual DbSet<WorkCenter> WorkCenters { get; set; }
    }
}
