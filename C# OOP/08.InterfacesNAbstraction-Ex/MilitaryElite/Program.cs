namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var soldiers = new List<Soldier>();

            var soldier = Console.ReadLine();

            while (soldier != "End")
            {
                var soldierArgs = soldier
                    .Split();

                var soldierType = soldierArgs[0];
                var id = soldierArgs[1];
                var firstName = soldierArgs[2];
                var lastName = soldierArgs[3];

                if (soldierType == "Private")
                {
                    var salary = decimal.Parse(soldierArgs[4]);

                    var @private = new Private(
                        id,
                        firstName,
                        lastName,
                        salary);

                    soldiers.Add(@private);
                }

                else if (soldierType == "Spy")
                {
                    var codeNumber = int.Parse(soldierArgs[4]);

                    var spy = new Spy(
                        id,
                        firstName,
                        lastName,
                        codeNumber);

                    soldiers.Add(spy);
                }

                else if (soldierType == "LieutenantGeneral")
                {
                    var salary = decimal.Parse(soldierArgs[4]);

                    var ids = soldierArgs
                        .Skip(5)
                        .ToList();

                    var privates = GetPrivates(ids, soldiers);

                    var general = new LieutenantGeneral(
                        id,
                        firstName,
                        lastName,
                        salary,
                        privates);

                    soldiers.Add(general);
                }

                else if (soldierType == "Engineer")
                {
                    var salary = decimal.Parse(soldierArgs[4]);

                    var corps = soldierArgs[5];

                    var repairArgs = soldierArgs
                        .Skip(6)
                        .ToList();

                    var repairs = GetRepairs(repairArgs);

                    try
                    {
                        var engineer = new Engineer(
                            id,
                            firstName,
                            lastName,
                            salary,
                            corps,
                            repairs);

                        soldiers.Add(engineer);
                    }

                    catch (Exception)
                    {
                    }
                }

                else if (soldierType == "Commando")
                {
                    var salary = decimal.Parse(soldierArgs[4]);

                    var corps = soldierArgs[5];

                    var missionArgs = soldierArgs
                        .Skip(6)
                        .ToList();

                    var missions = GetMissions(missionArgs);

                    try
                    {
                        var commando = new Commando(
                            id,
                            firstName,
                            lastName,
                            salary,
                            corps,
                            missions);

                        soldiers.Add(commando);
                    }

                    catch (Exception)
                    {
                    }
                }

                soldier = Console.ReadLine();
            }

            foreach (var soldierObject in soldiers)
            {
                Console.WriteLine(soldierObject);
            }
        }

        private static List<Mission> GetMissions(List<string> missionArgs)
        {
            var missions = new List<Mission>();

            for (int i = 0; i < missionArgs.Count; i += 2)
            {
                var codeName = missionArgs[i];
                var state = missionArgs[i + 1];

                try
                {
                    var mission = new Mission(codeName, state);

                    missions.Add(mission);
                }

                catch (Exception)
                {
                }
            }

            return missions;
        }

        private static List<Repair> GetRepairs(List<string> repairArgs)
        {
            var repairs = new List<Repair>();

            for (int i = 0; i < repairArgs.Count; i += 2)
            {
                var partName = repairArgs[i];
                var hoursWorked = int.Parse(repairArgs[i + 1]);

                var repair = new Repair(partName, hoursWorked);

                repairs.Add(repair);
            }

            return repairs;
        }

        private static List<Private> GetPrivates(List<string> ids, List<Soldier> soldiers)
        {
            var privates = new List<Private>();

            var filteredSoldiers = soldiers
                .Where(x => x.GetType().Name == nameof(Private))
                .ToList();

            foreach (var id in ids)
            {
                if (soldiers.Select(x => x.Id).Contains(id))
                {
                    var @private = (Private)soldiers
                        .FirstOrDefault(x => x.Id == id);
                    privates.Add(@private);
                }
            }

            return privates;
        }
    }
}