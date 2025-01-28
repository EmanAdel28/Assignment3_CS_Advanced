using System.Collections;
using Assignment3_CS_Advanced.Genaruc_Collection_Dictionary;
using Assignment3_CS_Advanced.HashList;
using Assignment3_CS_Advanced.HashTable;
using Assignment3_CS_Advanced.Sorted_Dictionary;
namespace Assignment3_CS_Advanced
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Write a Report about all Collections Given in the Session and Compare
            //[Structure, Time Complexity, and Business Case With Implemented Examples
            //in Separates Project at the Same Solution]

            #region 1-Hashtable

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

            #region 2-Dictionary

            // -- its store key value pair 
            // --  Backed by a hash table internally.
            // -- in namespace  => System.Collection.Generic
            // -- Time Complexity = O(1)
            // -- A generic key-value pair collection with type safety.
            // -- is divided into small collection called Buckets and Item stored into Buckets
            // -- Prevents repetition by using GetHashCode() and Equality
            // -- Keys must be unique, and null is allowed for values but not keys.

            //Dictionary<String , int> NoteBook = new Dictionary<String , int>(new GenericStringEqualityComparer());
            //NoteBook.Add("Eman", 123);
            //NoteBook.Add("Amira", 456);
            //NoteBook.Add("Khalid", 789);
            ////NoteBook.Add("khalid", 789);

            //foreach(KeyValuePair<String , int> pair in NoteBook)
            //{
            //    Console.WriteLine($"{pair.Key} :: {pair.Value}");
            //}

            #endregion

            #region 3-SortedDictionary
            // Sorted Data Asc by default
            // Work with algorithm Binary Search Tree
            // Time Complexity => O(log n ) 
            // -- in namespace  => System.Collection.Generic
            // -- A generic key-value pair collection with type safety.

            //SortedDictionary<String, int> NoteBook = new SortedDictionary<String, int>(new StringSortedDec());
            //NoteBook.Add("Eman", 123);
            //NoteBook.Add("Amira", 456);
            //NoteBook.Add("Khalid", 789);

            //foreach (KeyValuePair<String, int> pair in NoteBook)
            //{
            //    Console.WriteLine($"{pair.Key} :: {pair.Value}");
            //}


            #endregion

            #region 4-SortedDictionary
            // Sorted Data Asc by default
            // Work with algorithm 2 Array
            // Time Complexity => O(log n )  in Search and retrieve
            // Time Complexity => O(1)  in Insertion and Remove
            // -- in namespace  => System.Collection.Generic
            // -- A generic key-value pair collection with type safety.

            //SortedList<String , int> NoteBook = new SortedList<String , int>(new StringSortedDec());
            //NoteBook.Add("Eman", 123);
            //NoteBook.Add("Amira", 456);
            //NoteBook.Add("Khalid", 789);

            //foreach (KeyValuePair<String, int> pair in NoteBook)
            //{
            //    Console.WriteLine($"{pair.Key} :: {pair.Value}");
            //}


            #endregion

            #region 5- HashSet
            // Work with Hashtable internal
            // A generic collection of unique elements with no specific order.
            // Backed by a hash table.
            // Namespace: System.Collections.Generic
            // Time Complexity => O(1)

            //HashSet<Movies> list = new HashSet<Movies>();
            //list.Add(new Movies(101, "Animation", 200));
            //list.Add(new Movies(102, "Harry Poter", 300));
            //list.Add(new Movies(103, "Avatar", 150));
            //list.Add(new Movies(103, "Avatar", 150));

            //foreach(Movies e in list)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            #endregion
            #endregion

            #region Part02
            #region Q1-Part2
            //Given an array of integers, count the frequency of each element using a hash table.

            //int[] Array = { 1, 2, 3, 1, 4, 3, 5, 6, 4, 7, 8 };

            //Hashtable Frequency = new Hashtable();

            //foreach(int num in Array)
            //{
            //    if(Frequency.ContainsKey(num))
            //    {
            //        Frequency[num] = (int)Frequency[num] + 1;
            //    }
            //    else
            //    {
            //        Frequency[num] = 1;
            //    }
            //}

            //foreach (DictionaryEntry entry in Frequency)
            //{
            //    Console.WriteLine($"Element: {entry.Key} ::Frequency : {entry.Value}");
            //}
            #endregion

            #region Q2_Part2
            //You have a hashtable where its values are integers, find the key associated with the highest value.

            Hashtable hashtable = new Hashtable();
            hashtable.Add("A", 6);
            hashtable.Add("B", 5);
            hashtable.Add("C", 8);
            hashtable.Add("D", 2);

            string highestKey = null;
            int highestValue = int.MinValue;
            foreach (DictionaryEntry entry in hashtable)
            {
                
                if((int)entry.Value>highestValue)
                {
                    highestValue = (int)entry.Value;
                    highestKey = (string)entry.Key;
                }
                
            }

            Console.WriteLine($"Key with the highest value: {highestKey}, Value: {highestValue}");

            #endregion

            #region
            #endregion
            #endregion
        }


    }
}
