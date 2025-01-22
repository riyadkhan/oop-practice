namespace Practice03
{
    public class Vehicle
    {
        public Guid Id { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public int NumberOfSeat { get; private set; }
        public float RentAmount { get; private set; }
        public List<DateTime> BookedDate { get; set; }

        public Vehicle(string brand, string model, string type, int numberOfSeat, float rentAmount)
        {
            Id = Guid.NewGuid();
            Brand = brand;
            Model = model;
            Type = type;
            NumberOfSeat = numberOfSeat;
            RentAmount = rentAmount;
            BookedDate = new List<DateTime>();
        }

        public void RentCar(DateTime startDate, DateTime endDate)
        {
            if (!IsCarAvailable(startDate, endDate))
            {
                throw new Exception("Car is not available");
            }
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                BookedDate.Add(date);
            }
        }

        public void SendToMaintenance(DateTime startDate, DateTime endDate)
        {
            if (!IsCarAvailable(startDate, endDate))
            {
                throw new Exception("Car is not available");
            }
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                BookedDate.Add(date);
            }
        }

        public bool IsCarAvailable(DateTime startDate, DateTime endDate)
        {
            List<DateTime> requiredDates = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                requiredDates.Add(date);
            }

            if (BookedDate.Intersect(requiredDates).Count() > 0)
            {
                return false;
            }
            return true;
        }
    }
}
