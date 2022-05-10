using System;
using System.Collections.Generic;

namespace Reservation_vols_version2_withEF.Models
{
    public partial class VwTicket
    {
        public int? Clientid { get; set; }
        public string? Clientfirstname { get; set; }
        public string? Clientlastname { get; set; }
        public string? Clientaddress { get; set; }
        public DateTime? Clientbirthdate { get; set; }
        public string? Clientphone { get; set; }
        public int? Passengerid { get; set; }
        public string? Passengerfirstname { get; set; }
        public string? Passengerlastname { get; set; }
        public string? Passengeraddress { get; set; }
        public DateTime? Passengerbirthdate { get; set; }
        public string? Passengerphone { get; set; }
        public int? Flightid { get; set; }
        public bool? Isopen { get; set; }
        public DateTime? DateDeparture { get; set; }
        public DateTime? DateArrival { get; set; }
        public int? AirportDepartureId { get; set; }
        public int? AirportArrivalId { get; set; }
    }
}
