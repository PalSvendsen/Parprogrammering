namespace Parprogrammering4
{
    class Program
    {
        public static void Main()
        {
            Customer customer = new Customer("Marius", 29, 600000);
            var carslist = new List<Cars>()
            {
            new Cars("Nissan R34 Skyline", 1998, "XT7964", 201000, 500000),
            new Cars("Toyota Corolla", 2009, "BJG8743", 10000, 30000),
            new Cars("Honda Civic", 2005, "AR1294", 50000, 50000),
            new Cars("Bugatti Chiron", 2013, "XR4863", 45000, 50000000),
            };
            Console.WriteLine("Bilforretning: ");
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Se Alle biler");
            Console.WriteLine("2. Velg årstall");
            Console.WriteLine("3. Velg Kilometerstand");
            Console.WriteLine("4. Kjøp bil");
            Console.WriteLine("5. Har ikke lyst på bil, er fattig");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    viewAll(carslist);
                    break;
                case "2":
                    year(carslist);
                    break;
                case "3":
                    kilometers(carslist);
                    break;
                case "4":
                    buyCars(carslist, customer);
                    break;
                case "5":
                    leave();
                    break;
            }
        }
        public static void viewAll(List<Cars> Kar)
        {
            Console.WriteLine("Bilene tilgjengelig er: ");
            foreach (var car in Kar)
            {
                Console.WriteLine($"{car.Brand} Årsmodell: {car.ModelYear} Licenseplate: {car.Licenseplate} KM Kjørt {car.Kilomters}, pris: {car.Price}");
            }
        }

        public static void year(List<Cars> list)
        {
            var sortedCars = list.OrderBy(car => car.ModelYear);
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"-{car.ModelYear}, Brand: {car.Brand}");
            }
        }

        public static void kilometers(List<Cars> list)
        {
            var sortedCars = list.OrderBy(car => car.Kilomters);
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"-{car.Kilomters}, Brand: {car.Brand}");
            }
        }
        //List<Order> SortedList = objListOrder.OrderBy(o=>o.OrderDate).ToList();
        public static void leave()
        {
            Environment.Exit(0);
        }

        public static void buyCars(List<Cars> carsList, Customer customer)
        {
            Console.WriteLine("Bilene tilgjengelig er: ");
            for (int i = 0; i < carsList.Count; i++)
            {
                var car = carsList[i];
                Console.WriteLine($"{i + 1}. {car.Brand} Årsmodell: {car.ModelYear} Licenseplate: {car.Licenseplate} KM Kjørt {car.Kilomters}, pris: {car.Price}");
            }

            Console.WriteLine("Velg bil ved å skrive inn nummeret:");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int selectedCarIndex) && selectedCarIndex >= 1 && selectedCarIndex <= carsList.Count)
            {
                // Adjusting the index to match the list index (0-based)
                selectedCarIndex--;

                var selectedCar = carsList[selectedCarIndex];

                if (customer.BuyCar(selectedCar.Price))
                {
                    Console.WriteLine($"Gratulerer, du har kjøpt en {selectedCar.Brand}!");
                    // Remove the purchased car from the list
                    carsList.RemoveAt(selectedCarIndex);
                }
                else
                {
                    Console.WriteLine("Beklager, du har ikke nok penger til å kjøpe denne bilen.");
                }
            }
            else
            {
                Console.WriteLine("Ugyldig valg. Vennligst velg et gyldig nummer.");
            }
        }
    }
}


// Create a list of parts.
//List<Part> parts = new List<Part>();

// Add parts to the list.
//parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
//parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
//parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
//parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
//parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
//parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });
