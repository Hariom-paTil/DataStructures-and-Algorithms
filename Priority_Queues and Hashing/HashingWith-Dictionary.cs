using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Priority_Queues_and_Hashing
{

    //What is Hashing in C# ?
    //
    public class HashingWith_Dictionary
    {
        public void WorkingOf_Dictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Add
            students.Add(101, "Hariom");
            students.Add(102, "Rahul");

            // Insert using []
            students[103] = "Aman";

            // Update
            students[103] = "Rohit";

            // ContainsKey
            Console.WriteLine(students.ContainsKey(101));

            // ContainsValue
            Console.WriteLine(students.ContainsValue("Rahul"));

            // TryGetValue
            if (students.TryGetValue(102, out string name))
            {
                Console.WriteLine(name);
            }

            // Count
            Console.WriteLine(students.Count);

            // Print
            foreach (var item in students)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            // Remove
            students.Remove(101);

            // Clear
            students.Clear();

            Console.WriteLine(students.Count);
        }
    }
}
