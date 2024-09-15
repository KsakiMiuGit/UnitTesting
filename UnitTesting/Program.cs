using System.Xml.Serialization;
using UnitTesting;

var converter = new CurrencyConverter();
Console.WriteLine("How much PLN do you want to convert?");
string? input = Console.ReadLine();
decimal.TryParse(input, out decimal amount);

if (amount >= 0)
{

    decimal euroAmount = converter.PLNToEuro(amount);
    decimal usdAmount = converter.PLNToUsd(amount);
    decimal gbpAmount = converter.PLNToGbp(amount);
    decimal jpyAmount = converter.PLNToJpy(amount);

    Console.WriteLine($"{amount} PLN = {converter.PLNToEuro(amount)} EUR");
    Console.WriteLine($"{amount} PLN = {converter.PLNToUsd(amount)} USD");
    Console.WriteLine($"{amount} PLN = {converter.PLNToGbp(amount)} GBP");
    Console.WriteLine($"{amount} PLN = {converter.PLNToJpy(amount)} JPY");

    using (var dbContext = new AplicationDbContext())
    {
        var record = new CurrencyConversion
        {
            Amount = amount,
            EuroAmount = euroAmount,
            UsdAmount = usdAmount,
            GbpAmount = gbpAmount,
            JpyAmount = jpyAmount,
            Timestamp = DateTime.Now
        };

        dbContext.CurrencyConversions.Add(record);
        dbContext.SaveChanges();
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a non-negative decimal number.");
}
string choice;
do
{
    Console.WriteLine("What you want to do with database? (read, update, delete)");
    Console.WriteLine("If u want to leave press x");
    choice = Console.ReadLine();
    if (choice == "read")
    {
        using (var dbContext = new AplicationDbContext())
        {
            var records = dbContext.CurrencyConversions.ToList();
            foreach (var rec in records)
            {
                Console.WriteLine($"Id: {rec.Id}, Amount: {rec.Amount}, Euro: {rec.EuroAmount}, USD: {rec.UsdAmount}, GBP: {rec.GbpAmount}, JPY: {rec.JpyAmount}, Timestamp: {rec.Timestamp}");
            }
        }
    }
    else if (choice == "update")
    {
        Console.WriteLine("Which record do you want to update?");
        int recordId = int.Parse(Console.ReadLine());
        using (var dbContext = new AplicationDbContext())
        {
            var record = dbContext.CurrencyConversions.FirstOrDefault(r => r.Id == recordId);
            if (record != null)
            {
                Console.WriteLine("Enter new amount (PLN):");
                decimal newAmount = decimal.Parse(Console.ReadLine());

                record.Amount = newAmount;
                record.EuroAmount = converter.PLNToEuro(newAmount);
                record.UsdAmount = converter.PLNToUsd(newAmount);
                record.GbpAmount = converter.PLNToGbp(newAmount);
                record.JpyAmount = converter.PLNToJpy(newAmount);
                record.Timestamp = DateTime.Now;

                dbContext.SaveChanges();
                Console.WriteLine("Record updated successfully.");
            }
            else
            {
                Console.WriteLine("Record not found.");
            }

        }
    }
    else if(choice == "delete")
    {
        Console.WriteLine("Which record do you want to delete? (Enter record Id)");
        int recordId = int.Parse(Console.ReadLine());

        using (var dbContext = new AplicationDbContext())
        {
            var record = dbContext.CurrencyConversions.FirstOrDefault(r => r.Id == recordId);
            if (record != null)
            {
                dbContext.CurrencyConversions.Remove(record);
                dbContext.SaveChanges();
                Console.WriteLine("Record deleted successfully.");
            }
            else
            {
                Console.WriteLine("Record not found.");
            }
        }
    }
}while (choice != "x" );