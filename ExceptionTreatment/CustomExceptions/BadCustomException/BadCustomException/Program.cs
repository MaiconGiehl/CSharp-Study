using System;
using Course.Entities;
public class ProcessFIle
{
    public static void Main(string[] args)
    {
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Check-in date (dd/m//yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());

        Console.Write("Check-out date (dd/m//yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
        } 
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/m//yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/m//yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            string error = reservation.UpdateDates(checkIn, checkOut);
            if (error != null)
            {
                Console.WriteLine("Error in reservation: " + error);
            }
            else
            {
                Console.WriteLine("Reservation: " + reservation);
            }
            
        }
    }
}