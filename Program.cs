using System;

namespace _2_collectionspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			// create an array to hold integer values 0-9
			int[] int1 = new int[10];
			for (int x=0; x<10; x++){
				int1[x]=x;
				Console.WriteLine(int1[x]);
			}
			// create a array of the names time,  martin, nikki sara
			string[] arrstr = {"Tim", "martin", "nikki", "sara"};
			foreach(string str in arrstr ){
				Console.WriteLine(str);
			}

			// create an array of 10 that alternates between true and false values, starting with true
			bool[] arrBool = new bool[10];
			bool val = true;
			for (int i=0; i < arrBool.Length; i++){
				if (i%2==0){
					val = true;
				} else {
					val = false;
				}
				arrBool[i] = val;
				Console.WriteLine(arrBool[i] + "-- " + i);
			}
        }
    }
}
