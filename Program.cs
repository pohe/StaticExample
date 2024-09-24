
// ListMethods test
List<int> aList = new List<int> { 23, 86, 51, 11, 39 };
//ListMethods listMethodsObject = new ListMethods();

int smallest = ListMethods.FindSmallestNumber(aList);
Console.WriteLine($"The smallest number in the list is : {smallest}");

int average = ListMethods.FindAverage(aList);
Console.WriteLine($"The average of the list is : {average}");

Car c1 = new Car("121212", 1200);
Car c2 = new Car("232323", 3400);
string c1LicensePLate = c1.LicensePlate;
Car.PrintUsageStatistics();

