using System;
using System.Collections.Generic;

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
			string[] arrstr = {"Tim", "martin", "nikki", "sara", "chuck", "bob", "mich", "john"};
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

			// just print 
			userInfo(arrstr);
			castingTest();

        }

		public static void userInfo(string[] names){
			List<string> flavors = new List<string> {"Vanilla","Choco", "Strawberrry", "Cream", "Blueberry", "rocky road"};
			Dictionary<string, string> profile = new Dictionary<string, string>{};
			Random rnd = new Random();
			foreach (var name in names){
				profile.Add(name, flavors[rnd.Next(0, flavors.Count)]);
			}

			foreach(var person in profile){
				Console.WriteLine(person.Key + "--" + person.Value);
			}

		}

		public static void castingTest(){
			// testing the ability to do safe casting
			// create empty list, add values, loop through list (use type inference), add all values that are int
			List<object> lst = new List<object>();
			int intSum = 0;
			lst.Add(7);
			lst.Add(28);
			lst.Add(-1);
			lst.Add(true);
			lst.Add("chair");

			for (int i=0; i < lst.Count; i++){
				Console.WriteLine(lst);
				if (lst[i] is int){
					intSum = intSum + (int)lst[i];
				}
			}
			Console.WriteLine(intSum + "-- Sum of the ints");
		}
    }
}
