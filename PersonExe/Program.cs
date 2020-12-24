using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonExe
{
    class Program
    {
      

        static void Main(string[] args)
        {
            IPersonService personService =
            NinjectInstanceFactory.GetInstance<IPersonService>();

            Console.WriteLine("Menu \n" +
                    "1-)List Of Person \n" +
                    "2-)Add New Person \n" +
                    "3-)Update a Person \n" +
                    "4-)Delete a Person \n" +
                    "5-)Exit");

            string choice = null;

            while (choice != "5")
            {
                Console.Write("Please select a choice: ");
                choice = Console.ReadLine();
            

            switch (choice)
            {
                case "1":
                    personService.List();
                    break;

                case "2":
                    Console.Write("Please enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter your surname: ");
                    string surname = Console.ReadLine();

                    personService.AddPerson(name,surname);
                    break;

                case "3":
                    Console.Write("Please enter the id of the person which you want to update: ");
                    string id = Console.ReadLine();
                    Console.Write("Please enter the name: ");
                    string updatedName = Console.ReadLine();
                    Console.Write("Please enter the surname: ");
                    string updatedSurname = Console.ReadLine();
                    personService.UpdatePerson(Convert.ToInt32(id),updatedName, updatedSurname);
                    break;

                case "4":
                    Console.WriteLine("Please enter the id of the person which you want to delete: ");
                    string deleteId = Console.ReadLine();
                    personService.DeletePerson(Convert.ToInt32(deleteId));
                   break;

                case "5":
                    break;

                default:
                    Console.WriteLine("No choice has been selected.");
                    break;
            }
            }
        }
    }
}