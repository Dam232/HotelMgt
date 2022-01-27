//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_webapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckIn()
        {
            this.CheckOuts = new HashSet<CheckOut>();
        }
    
        public int CheckInID { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<int> NumOfReservedDays { get; set; }
        public int CustomerID { get; set; }
        public int RoomNum { get; set; }
        public Nullable<int> NoAdults { get; set; }
        public Nullable<int> NoChildren { get; set; }
        public int PassportNo { get; set; }
        public Nullable<int> checkoutstatus { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
    }
}