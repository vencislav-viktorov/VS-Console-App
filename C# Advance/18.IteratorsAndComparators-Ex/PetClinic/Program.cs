namespace PetClinic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            var pets = new List<Pet>();
            var clinics = new List<Clinic>();

            for (int i = 0; i < linesCount; i++)
            {
                var commandArg = Console.ReadLine()
                    .Split();

                var command = commandArg[0];

                if (command == "Create")
                {
                    var typeObject = commandArg[1];

                    if (typeObject == "Pet")
                    {
                        var name = commandArg[2];
                        var age = int.Parse(commandArg[3]);
                        var kind = commandArg[4];

                        var pet = new Pet(name, age, kind);
                        pets.Add(pet);
                    }

                    else if (typeObject == "Clinic")
                    {
                        var name = commandArg[2];
                        var rooms = int.Parse(commandArg[3]);

                        try
                        {
                            var clinic = new Clinic(name, rooms);
                            clinics.Add(clinic);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                else if (command == "HasEmptyRooms")
                {
                    var clinicName = commandArg[1];

                    var clinic = clinics
                        .FirstOrDefault(x => x.Name == clinicName);

                    if (clinic != null)
                    {
                        Console.WriteLine(clinic.HasEmptyRooms());
                    }
                }

                else if (command == "Release")
                {
                    var clinicName = commandArg[1];

                    var clinic = clinics
                        .FirstOrDefault(x => x.Name == clinicName);

                    if (clinic != null)
                    {
                        Console.WriteLine(clinic.Release());
                    }
                }

                else if (command == "Add")
                {
                    var petNames = commandArg[1];
                    var clinicName = commandArg[2];

                    var pet = pets
                        .FirstOrDefault(x => x.Name == petNames);

                    var clinic = clinics
                        .FirstOrDefault(x => x.Name == clinicName);

                    if (pet != null && clinic != null)
                    {
                        Console.WriteLine(clinic.AddPet(pet));
                    }
                }

                else if (command == "Print")
                {
                    var clinicName = commandArg[1];

                    var clinic = clinics
                        .FirstOrDefault(x => x.Name == clinicName);
                    
                    if (commandArg.Length == 2)
                    {
                        Console.WriteLine(clinic);
                    }

                    else
                    {
                        var roomNumber = int.Parse(commandArg[2]);

                        Console.WriteLine(clinic.GetPet(roomNumber));
                    }
                }
            }
        }
    }
}