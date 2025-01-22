using Practice03;

var car = new Vehicle("Toyota", "2020", "Sedan", 4, 5500);

car.RentCar(new DateTime(2025, 01, 10), new DateTime(2025, 01, 12));

bool isCarAvailable = car.IsCarAvailable(new DateTime(2025, 01, 11), new DateTime(2025, 01, 12));

Console.WriteLine($"IsCarAvailable: {isCarAvailable}");


car.RentCar(new DateTime(2025, 01, 12), new DateTime(2025, 01, 15));