int numberStops = int.Parse(Console.ReadLine());
int currentPassengers = 0;

List<int> passengersPerStop = new List<int>();

while (numberStops-- > 0)
{
    
    string[] input = Console.ReadLine().Split();
    int passengersGettingOut = int.Parse(input[0]);
    int passengersGettingIn = int.Parse(input[1]);

    // Update passengers count decreasing those getting out and increasing those getting in
    currentPassengers += passengersGettingIn;
    currentPassengers -= passengersGettingOut;

    // Add the current number of passengers to the list
    // The max number of passengers its the maximum number of passengers for the tram
    passengersPerStop.Add(currentPassengers);


}


Console.WriteLine(passengersPerStop.Max());
