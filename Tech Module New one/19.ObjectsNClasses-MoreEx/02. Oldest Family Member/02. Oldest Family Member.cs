using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            List<Member> members = new List<Member>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] currentMember = Console.ReadLine()
                    .Split();

                string name = currentMember[0];

                int age = int.Parse(currentMember[1]);

                Member member = new Member(name, age);

                members.Add(member);
            }

            var oldestMember = members.OrderByDescending(x => x.Age).First();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
