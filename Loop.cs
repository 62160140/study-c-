using System;

//linq คือ การเขียนคำสั่ง SQL ในภาษา C# และ VB.NET
namespace FutureSkill
{
    class Program
    {
      //out คือ การส่งค่าออกจาก method ไปใช้งานใน method อื่นๆ
      //ref คือ การส่งค่าออกจาก method ไปใช้งานใน method อื่นๆ และสามารถแก้ไขค่าได้
      static void Main(string[] args)
      {
        Car car1 = new Car();
        Console.WriteLine($"car1 color: {car1.color}");  
        Console.WriteLine($"car1 model: {car1.model}");
        Console.WriteLine($"car1 speed: {car1.speedCheck()}");
        Console.WriteLine("==================================");  

        Student myStudent = new Student();
        Console.WriteLine($"StudentId: {myStudent.StudentId}");
        Console.WriteLine($"StudentName: {myStudent.StudentName}");
        Console.WriteLine($"StudentGender: {myStudent.StudentGender}");
        Console.WriteLine($"StudentFaculty: {myStudent.StudentFaculty}");
        Console.WriteLine($"sumSummary: {myStudent.sumSummary(10,20)}");
      }

    
     
    }
}