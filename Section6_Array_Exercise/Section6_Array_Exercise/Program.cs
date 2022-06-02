using System;
using System.Globalization;

namespace Section6_Array_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            The owner of a boarding house has ten rooms to rent to students,
            //            These rooms are identified by the numbers 0 to 9.
            //            When a student wants to rent a room, you have to register the name
            //            and email of this student.
            //            Make a program that starts with all ten empty rooms, and then
            //            read a number N representing the number of students who are going to
            //            (N can be from 1 to 10). Then record the rent of
            //            N students.For each rental record, enter the name and email address of the
            //            and email address of the student, as well as which of the rooms he chose(from 0 to 9).Suppose
            //            a vacant room is chosen.At the end, your program should print
            //            a report of all the boarding house occupancies, in room order
            //            as in the example.

            Room[] rooms = new Room[10];

            Console.Write("How many rooms will be rented? ");
            int qty = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < qty; i++)
            {
                Console.WriteLine("\nRent #{0}", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int number = int.Parse(Console.ReadLine());

                rooms[number] = new Room { Name = name, Email = email };
            }


            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int j = 0; j < rooms.Length; j++)
            {
                if (rooms[j] != null)
                    Console.WriteLine("{0}: {1}", j, rooms[j]);
            }
        }
    }
}
