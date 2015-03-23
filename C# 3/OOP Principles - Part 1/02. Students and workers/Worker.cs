using System;

namespace School
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        private const int weekDays = 7;

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid week salary");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid work hours per day");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / (weekDays * this.workHoursPerDay);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Money Per Hour: {0}", this.MoneyPerHour());
        }
    }
}