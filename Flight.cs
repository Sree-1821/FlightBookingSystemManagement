//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int FlightNo { get; set; }
        public string FlightId { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string Destination { get; set; }
        public System.DateTime Arrival { get; set; }
        public System.DateTime Departure { get; set; }
        public Nullable<int> TotalSeats { get; set; }
        public Nullable<double> Fare { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Cancelled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}