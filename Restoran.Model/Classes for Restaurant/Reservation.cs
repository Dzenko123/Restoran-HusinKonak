﻿namespace Restoran.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfGuests { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<TableReservation> TableReservations { get; set; }
    }
}
