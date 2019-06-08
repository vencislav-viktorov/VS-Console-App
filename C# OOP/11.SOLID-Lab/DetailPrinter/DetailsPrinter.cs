namespace DetailPrinter
{
    using System.Text;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private readonly IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public string PrintDetails()
        {
            var sb = new StringBuilder();

            foreach (Employee employee in this.employees)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString();
        }
    }
}