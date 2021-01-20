using System;

namespace PersonalRegister_Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalRegister register = new PersonalRegister();
            register.AddEmployeeName("Joe");
            register.AddEmployeeSalary(200.0f);
   
        }
    }
}
