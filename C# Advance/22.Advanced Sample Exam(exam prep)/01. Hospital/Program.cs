using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentRoomsAndPatients = new Dictionary<string, Dictionary<int, List<string>>>();

            var departmentAndPatients = new Dictionary<string, List<string>>();

            var doctorAndPatients = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Output")
                {
                    break;
                }

                var splitedInput = input
                    .Split();

                var department = splitedInput[0];

                var doctor = splitedInput[1] +
                    " " + splitedInput[2];

                var patient = splitedInput[3];

                if (!doctorAndPatients.ContainsKey(doctor))
                {
                    doctorAndPatients.Add(doctor, new List<string>());
                }

                doctorAndPatients[doctor].Add(patient);

                if (!departmentRoomsAndPatients.ContainsKey(department))
                {
                    departmentRoomsAndPatients.Add(department, new Dictionary<int, List<string>>());

                    for (int i = 1; i <= 20; i++)
                    {
                        departmentRoomsAndPatients[department].Add(i, new List<string>());
                    }
                }

                for (int i = 1; i <= 20; i++)
                {
                    if (departmentRoomsAndPatients[department][i].Count < 3)
                    {
                        departmentRoomsAndPatients[department][i].Add(patient);
                        break;
                    }
                }

                if (!departmentAndPatients.ContainsKey(department))
                {
                    departmentAndPatients.Add(department, new List<string>());
                }

                departmentAndPatients[department].Add(patient);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var splitedInput = input.Split();

                if (splitedInput.Length == 1)
                {
                    foreach (var currentPatient in departmentAndPatients[input])
                    {
                        Console.WriteLine(currentPatient);
                    }

                    continue;
                }

                if (char.IsDigit(splitedInput[1][0]))
                {
                    var currentDepartment = splitedInput[0];

                    var currentRoom = int.Parse(splitedInput[1]);

                    foreach (var currentPatient in departmentRoomsAndPatients[currentDepartment][currentRoom]
                        .OrderBy(x => x))
                    {
                        Console.WriteLine(currentPatient);
                    }
                }

                else
                {
                    var doctorName = splitedInput[0] +
                        " " + splitedInput[1];

                    foreach (var currentPatient in doctorAndPatients[doctorName]
                        .OrderBy(x => x))
                    {
                        Console.WriteLine(currentPatient);
                    }
                }
            }
        }
    }
}