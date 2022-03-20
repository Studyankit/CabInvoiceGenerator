using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator");
InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
double fare = invoiceGenerator.CalculateFare(5.0, 5);
Console.WriteLine($"Fare : {fare}");
Console.ReadLine();
