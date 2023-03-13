using System;

namespace Delivery{
    class Grabfood{
        static void Main(string[] args){

            Console.Write("Please Enter Your Day of week : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Please Enter your current time : ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Please Enter your order : ");
            string order = (Console.ReadLine());

            int BF = 5;
            int WS = 2;
            int CF = 3;

            switch(order) {
            case "Breakfast Set":

                while(BF > 0){
                   Console.Write("Your Order is Correct!");
                   BF -= 1;
                   return Console.Write("Please Enter your order : ");
            string order = (Console.ReadLine());
                   
                }
                
                break;
            case "Weekend Set":
                

                break;
            case "Coffee":
                

                break;    
            default:
                Console.WriteLine("incorrect");
                break;


            

            }
        }
    }
}