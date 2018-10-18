using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // int sum = 0;
            // for ( int i =0; i<6; i++)
            // {
            //     sum += i;
            // }
            // Console.WriteLine("Sum is " + sum);

            // int i = 1;
            // while (i<6){
            //     sum+=i;
            //     i++;
            // }

            //max number in array
            // int [] x = {9, 13, 4, 12 ,3};
            // int largest = x[0];

            // for ( int i =0; i < x.Length; i++ ){
            //      if(largest < x[i]){
            //          largest = x[i];
            //      }
            // } Console.WriteLine(largest);
            //find mean/median/mode/sum for various arrays

            int largest = mynums[0];
            foreach( int currentNum in mynums){
                if(largest < currentNum){
                    largest = currentNum;
                }
            }

        }
    }
}
