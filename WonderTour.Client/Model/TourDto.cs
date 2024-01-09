namespace WonderTour.Client.Model
{
    public class TourDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsAdded { get; set; }
    }
}
