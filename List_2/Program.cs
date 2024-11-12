using System;

namespace List_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             MyLinkedList list = new MyLinkedList();
                    list.Add(1);
                    list.Add(2);
                    list.Add(2);
                    list.Add(2);
                    list.Add(5);
            
                    Console.WriteLine("Asl ro'yxat");
                    list.Chop_et();
                    
                    //list.Alishtirish();
                    list.Remove(2);
            
                    list.Chop_et();
        }
    }
}
