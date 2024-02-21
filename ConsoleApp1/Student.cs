


namespace ConsoleApp1
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;
        public string adress;
        public string phone ="12343234";


        public void ShowText()
        {
            string text = "Hello PB101";
            Console.WriteLine(text);
        }

        public string GetFullName()
        {
            return name + " " + surname;
        }

        public string GetFullDatas()
        {
            string fulldata = $"Name:{name}, Surname:{surname}, " +
                $"Age:{age}, Adress:{adress}, Phone:{phone}";
            return fulldata;
        }
        
        
    }
}
