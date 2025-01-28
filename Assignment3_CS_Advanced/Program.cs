using System.Collections;
using Assignment3_CS_Advanced.Genaruc_Collection_Dictionary;
using Assignment3_CS_Advanced.HashList;
using Assignment3_CS_Advanced.HashTable;
using Assignment3_CS_Advanced.Sorted_Dictionary;
namespace Assignment3_CS_Advanced
{

    internal class Program
    {
        static List<List<string>> GroupAnagrams(string[] words)
        {
            
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                
                char[] sortedChars = word.ToCharArray();
                Array.Sort(sortedChars);
                string sortedKey = new string(sortedChars);

               
                if (!anagramGroups.ContainsKey(sortedKey))
                {
                    List<string> newGroup = new List<string>();
                    anagramGroups[sortedKey] = newGroup;
                }
                anagramGroups[sortedKey].Add(word);
            }

           
            List<List<string>> result = new List<List<string>>(anagramGroups.Values);
            return result;
        }

        static bool ContainsDuplicates(int[] array)
        {
            
            HashSet<int> seen = new HashSet<int>();

           
            foreach (int num in array)
            {
               
                if (seen.Contains(num))
                {
                    return true;
                }

             
                seen.Add(num);
            }

            
            return false;
        }

        static List<int> FindMissingNumbers(int[] array, int N)
        {
            List<int> missingNumbers = new List<int>();

            bool[] seen = new bool[N + 1]; 

            foreach (int num in array)
            {
                seen[num] = true;
            }

            for (int i = 1; i <= N; i++)
            {
                if (!seen[i])
                {
                    missingNumbers.Add(i);
                }
            }

            return missingNumbers;
        }
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

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("A", 6);
            //hashtable.Add("B", 5);
            //hashtable.Add("C", 8);
            //hashtable.Add("D", 2);

            //string highestKey = null;
            //int highestValue = int.MinValue;
            //foreach (DictionaryEntry entry in hashtable)
            //{

            //    if((int)entry.Value>highestValue)
            //    {
            //        highestValue = (int)entry.Value;
            //        highestKey = (string)entry.Key;
            //    }

            //}

            //Console.WriteLine($"Key with the highest value: {highestKey}, Value: {highestValue}");

            #endregion

            #region Q3_Part2
            //You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue

            //    Hashtable hashtable = new Hashtable();
            //    hashtable.Add("A", 6);
            //    hashtable.Add("B", 5);
            //    hashtable.Add("C", 8);
            //    hashtable.Add("D", 2);

            //    // Ask the user to enter the target value
            //    Console.Write("Enter the target value: ");
            //    int targetValue;
            //    if (!int.TryParse(Console.ReadLine(), out targetValue))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        return;
            //    }

            //    // Find all keys associated with the target value
            //    ArrayList matchingKeys = new ArrayList();
            //    foreach (DictionaryEntry entry in hashtable)
            //    {
            //        if ((int)entry.Value == targetValue)
            //        {
            //            matchingKeys.Add(entry.Key);
            //        }
            //    }

            //    // Display the result
            //    if (matchingKeys.Count > 0)
            //    {
            //        Console.WriteLine($"Keys associated with value {targetValue}:");
            //        foreach (var key in matchingKeys)
            //        {
            //            Console.WriteLine(key);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"No keys are associated with the value {targetValue}.");
            //    }
            //}



            #endregion

            #region Q4-Part2
           
            string[] words = { "listen", "silent", "enlist", "rat", "tar", "art", "hello", "olleh" };

            
            List<List<string>> groupedAnagrams = GroupAnagrams(words);

         
            Console.WriteLine("Grouped Anagrams:");
            foreach (List<string> group in groupedAnagrams)
            {
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            }
            #endregion

            #region Q5_Part2
            //Given an array of integers, check if the array contains any duplicates.
            int[] array = { 1, 2, 3, 4, 5, 2 };

            
            bool hasDuplicates = ContainsDuplicates(array);

            Console.WriteLine($"Array contains duplicates: {hasDuplicates}");


            #endregion

            #region  Q6-Part2
            SortedDictionary< int , String> NoteBook = new SortedDictionary<int, String>();
            NoteBook.Add(12,"Eman");
            NoteBook.Add(13,"Amira");
            NoteBook.Add(14,"Khalid");


            foreach (KeyValuePair<int, String> pair in NoteBook)
            {
                if (NoteBook.ContainsKey(pair.Key))
                {
                    Console.WriteLine(NoteBook[pair.Key]);
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }


            foreach (KeyValuePair<int, String> pair in NoteBook)
            {
                if (NoteBook.ContainsKey(pair.Key))
                {
                   Console.WriteLine( NoteBook[pair.Key]);
                }
                else
                {
                   Console.WriteLine( "Student not found.");
                }
            }




            foreach (KeyValuePair<int, String> pair in NoteBook)
            {
                if (NoteBook.ContainsKey(pair.Key))
                {
                    NoteBook.Remove(pair.Key);
                    Console.WriteLine($"Removed student with ID: {pair.Key}");
                }
                else
                {
                    Console.WriteLine($"No student found with ID {pair.Key}.");
                }
            }

            foreach (KeyValuePair<int, String> pair in NoteBook)
            {
                Console.WriteLine($"{pair.Key} :: {pair.Value}");
            }
            #endregion

            #region Q7_Part2
            //Create an employee directory where employee IDs (int) are keys and employee names (string) are values.
            //Use a SortedList to manage and retrieve employees in order of their IDs.
            //SortedList<int, string> employee = new SortedList<int, string>();
            //employee.Add(1, "Ahmed");
            //employee.Add(2, "Omar");
            //employee.Add(3, "Eman");

            //foreach(KeyValuePair<int, String> pair in employee)
            //{
            //    Console.WriteLine($"{employee.Key} :: {employee.Value}");
            //}

            #endregion

            #region Q8_Part2
            //Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
            int[] arr = { 1, 2, 4, 6, 7, 8 };

            int N = 8;

            List<int> missingNumbers = FindMissingNumbers(arr, N);

            Console.WriteLine("Missing Numbers:");
            foreach (var number in missingNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region 
            #endregion

            #region 
            #endregion
            #endregion
        }
    }
}


