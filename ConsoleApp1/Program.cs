
//string name1 = "Amiraslan";
//string surname1 = "Miriyev";
//int age1 = 33;

//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;

//string name3 = "Elmir";
//string surname3 = "Qafarzade";
//int age3 = 21;

//Console.WriteLine($"{name2} {surname2} {age2}");

//var stu1 = new
//{
//    name = "Amiraslan",
//    surname = "Miriyev",
//    age = 33

//};

//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22

//};

//var stu3 = new
//{
//    name = "Elmir",
//    surname = "Qafarzade",
//    age = 21

//};

//Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age);
//Console.WriteLine($"{stu1.name} {stu1.surname} {stu1.age} ");

using consoleapp1;
using ConsoleApp1;

Student stu1 = new Student();
stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.adress = "Ehmedli";

//Console.WriteLine(stu1.name);


Student stu2 = new Student();
stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 70;
stu2.adress = "Xetai";

//string fullName = stu2.name + " " + stu2.surname;
////Console.WriteLine(fullName);
///

Student stu3 = new()
{
    name = "Sirac",
    surname = "Memmedov",
    age = 22

};

//Console.WriteLine(stu3.GetFullName());
//Console.WriteLine(stu2.GetFullName());

//var result = stu2.GetFullDatas();
//Console.WriteLine(result);

//Student[] Students = { stu1, stu2, stu3 };

//foreach (var stu in Students)
//{
//    Console.WriteLine(stu.GetFullDatas());
//}



//Student[] Students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas ,int age)
//{
//    Student foundStudent = new();

//    foreach (var item in datas)
//    {
//        if (item.age == age)
//        {
//            foundStudent=item;
//            break;
//        }
//    }
//    return foundStudent;
//}

//var result = GetByAge(Students,24);
//Console.WriteLine(result.GetFullDatas());


//Student GetByAge(Student[] datas, int age)
//{
//    var result = datas.FirstOrDefault(m => m.age == age);
//    return result != null ? result : new();

//}
//var result = GetByAge(Students, 25);
//Console.WriteLine(result.GetFullDatas());

//int a = 7;
//Console.WriteLine(a==5 ? a: "deyil");

//Student GetByAge(Student[] datas, int age)
//{
//    return datas.FirstOrDefault(m => m.age == age);
//}
//var result = GetByAge(Students, 23);
//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("data notfound");
//}


//Book book = new Book("Leyli Mecnun","Nizami");
//Console.WriteLine(book.name + " " +book.author);

Book book = new("Elmir");