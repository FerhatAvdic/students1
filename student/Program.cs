using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{


    class students
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private int yearOfStudy { get; set; }
        public int YearOfStudy
        {
            get { return yearOfStudy; }
            set { yearOfStudy = value; }
        }

        public void printInfo()
        {
            System.Console.WriteLine(name + " " + surname + " " + age + " " + department + " " + yearOfStudy);
        }
    }

    class undergraduate : students
    {
        private int projectGrade;
        public int ProjectGrade
        {
            get { return projectGrade; }
            set { projectGrade = value; }
        }
        public undergraduate() : base() { }
    }

    class master : students
    {
        private string masterWorkType;
        public string MasterWorkType
        {
            get { return masterWorkType; }
            set { masterWorkType = value; }
        }
        private int masterWorkGrade;
        public int MasterWorkGrade
        {
            get { return masterWorkGrade; }
            set { masterWorkGrade = value; }
        }

        public master() : base() { }
    }

    class pHd : students
    {
        private int dissertationGrade;
        public int DissertationGrade
        {
            get { return dissertationGrade; }
            set { dissertationGrade = value; }
        }
        public pHd() : base() { }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
