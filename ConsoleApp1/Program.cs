using System;

namespace CselllTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList line = new StudentList();

            
            line.AddFront(20); 
            line.AddFront(10); 
            line.AddEnd(30);   
            line.AddEnd(40);   
            line.Reverse();    
            line.Remove(20);   

            
            line.Print();
        }
    }
}