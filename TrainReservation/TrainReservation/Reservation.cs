using System.Collections.Generic;

namespace TrainReservationKata
{
    public class Reservation
    {
        public string TrainId { get; set; }
        public string BookingId { get; set; }
        public List<Seat> Seats { get; set; }

        public Reservation(string trainId, string bookingId, List<Seat> seats)
        {
            TrainId = trainId;
            BookingId = bookingId;
            Seats = seats;
        }
    }
}
