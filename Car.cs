using System;

namespace FutureSkill{
  class Car{
      //public คือ สามารถเข้าถึงได้ทุกที่
      //protected คือ สามารถเข้าถึงได้ใน class และ class ที่เป็นลูกของ class นั้น
      //private คือ สามารถเข้าถึงได้ใน class นั้นเท่านั้น
      //โดย default คือ private
      public string color = "red";
      public string model = "BMW";
      public int speedCheck(){
        return 200;
      }
      
    }
}