using System;

namespace _02.Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            while (true)
            {
                var state = Console.ReadLine();

                if (state == "collapse") { break; }

                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, string.Empty);

                    if (fiction.Length == 1)
                    {
                        state = state.Replace(fiction, string.Empty);

                        break;
                    }

                    fiction = fiction.Substring(1, fiction.Length - 2);
                }

                Console.WriteLine(state.Length == 0 ? "(void)" : state.Trim());
            }
        }
    }
}
