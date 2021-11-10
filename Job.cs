using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsRequirement
{
    class Job
    {

        string role;
        string skillSet;
        string employmentType;
        string location;
        int minExperience;
        double salary;

        public Job(string role, string skillSet, string employmentType, string location, int minExperience, double salary)
        {
            this.Role = role;
            this.SkillSet = skillSet;
            this.EmploymentType = employmentType;
            this.Location = location;
            this.MinExperience = minExperience;
            this.Salary = salary;
        }

        public string Role { get => role; set => role = value; }
        public string SkillSet { get => skillSet; set => skillSet = value; }
        public string EmploymentType { get => employmentType; set => employmentType = value; }
        public string Location { get => location; set => location = value; }
        public int MinExperience { get => minExperience; set => minExperience = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return string.Format("{0,15} {1,15} {2,15} {3,15} {4,15} {5,15} ", Role, SkillSet, EmploymentType, Location, MinExperience, Salary);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
