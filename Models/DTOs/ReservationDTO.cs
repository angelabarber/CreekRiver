namespace CreekRiver.Models.DTOs

{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }

        public string Status { get; set; }
    }
}