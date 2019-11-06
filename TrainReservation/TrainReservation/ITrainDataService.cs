using System.Collections.Generic;

namespace TrainReservationKata
{
    public interface ITrainDataService
    {

        //{"seats": {	"1A": 	{"booking_reference": "",
        //        "seat_number": "1",
        //        "coach": "A"},
        //    "2A": 	{"booking_reference": "",
        //        "seat_number": "2",
        //        "coach": "A"}}}
        object GetTrainInformation(string trainId);
    }
}