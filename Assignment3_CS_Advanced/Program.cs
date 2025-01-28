using System.Collections;
using Assignment3_CS_Advanced.HashTable;
namespace Assignment3_CS_Advanced
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region 1-Hashtable
            //Write a Report about all Collections Given in the Session and Compare
            //[Structure, Time Complexity, and Business Case With Implemented Examples
            //in Separates Project at the Same Solution]

            // 1) Hashtable 
            // -- its store key value pair 
            // -- is data structure 
            // -- in namespace  => System.Collection
            // -- Time Complexity = O(1)
            // -- is divided into small collection called Buckets and Item stored into Buckets
            // -- Prevents repetition by using GetHashCode() and Equality
            // -- Keys must be unique, and null is allowed for values but not keys.

            // Example:
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Eman", 123);
            //hashtable.Add("Amira", 456);
            //hashtable.Add("Khalid", 789);

            //foreach(DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}

            // Example : Business Case
            //Hashtable hashtable = new Hashtable(new StringEqualityCompare1());
            //hashtable.Add("Eman", new Employee(101, "Eman", 2000));
            //hashtable.Add("Amira", new Employee(102, "Amira", 3000));
            //hashtable.Add("Mohamed", new Employee(103, "Mohamed", 6000));
            ////hashtable.Add("mohamed", new Employee(103, "Mohamed", 6000));


            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}
            #endregion
            #endregion
        }


    }
}
