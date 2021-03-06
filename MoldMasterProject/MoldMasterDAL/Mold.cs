//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Mold
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mold()
        {
            this.MaintenancePlans = new HashSet<MaintenancePlan>();
            this.MoldJournals = new HashSet<MoldJournal>();
            this.MoldMachines = new HashSet<MoldMachine>();
            this.MoldSetups = new HashSet<MoldSetup>();
            this.MoldTransfers = new HashSet<MoldTransfer>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public int ModelID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DatePurchased { get; set; }
        public Nullable<System.DateTime> DateRetired { get; set; }
        public string ProducerName { get; set; }
        public Nullable<System.DateTime> DateOrdered { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public Nullable<decimal> PricePurchased { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePlan> MaintenancePlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoldJournal> MoldJournals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoldMachine> MoldMachines { get; set; }
        public virtual MoldModel MoldModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoldSetup> MoldSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoldTransfer> MoldTransfers { get; set; }
    }
}
