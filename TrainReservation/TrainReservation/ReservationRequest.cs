namespace TrainReservationKata
{
    public class ReservationRequest
    {
        public string TrainId { get; set; }
        public int SeatCount { get; set; }

        public ReservationRequest(string trainId, int seatCount)
        {
            TrainId = trainId;
            SeatCount = seatCount;
        }
    }
}