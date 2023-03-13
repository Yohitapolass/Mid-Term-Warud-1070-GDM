using System;

namespace Delivery{
    class Grabfood{
        static void Main(string  [] args){

            Console.Write("Please Enter Your Day of week : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Please Enter your current time : ");
            int time = int.Parse(Console.ReadLine());

             //Console.Write("Please Enter your order : ");
            //string order = (Console.ReadLine());
            string order; 

            int BF = 5;
            int WS = 2;
            int CF = 3;

            while(day > 0 && time > 0 ){
                
                Console.Write("Please Enter your order : ");
                order = (Console.ReadLine());

                if(order == "Breakfast Set"){
                        Console.Write("Your Order is Correct!");
                        BF -= 1;
                }

                if(order == "Weekend Set"){
                        Console.Write("Your Order is Correct!");
                        BF -= 1;
                }

                if(order =="Coffee"){
                        Console.Write("Your Order is Correct!");
                        BF -= 1;
                }
            }}}}               
