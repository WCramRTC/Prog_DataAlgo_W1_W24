using System.Globalization;
using static System.Formats.Asn1.AsnWriter;

namespace Prog_DataAlgo_W1_W24
{
    internal class Program
    {

    public static string[] pacificNorthwestHikes = new string[] {
    "Mount Rainier National Park: Skyline Trail, Burroughs Mountain Trail, Wonderland Trail",
    "Olympic National Park: Hoh River Trail, Hurricane Ridge Trail, Ozette Loop",
    "North Cascades National Park: Maple Pass Loop, Heather Meadows Trail, Cascade Pass",
    "Mount Baker-Snoqualmie National Forest: Mount Baker Summit Trail, Heather Meadows Trail, Chain Lakes Loop",
    "Glacier Peak Wilderness: Pacific Crest Trail, Cutthroat Lake Trail, Suiattle River Trail",
    "Columbia River Gorge National Scenic Area: Multnomah Falls Trail, Wahkeena Falls Trail, Ponytail Falls Trail",
    "Mount Hood National Forest: Timberline Trail, Ramona Falls Trail, Zigzag Canyon Trail",
    "Willamette National Forest: McKenzie River Trail, Three Sisters Wilderness, Proxy Falls Trail",
    "Crater Lake National Park: Cleetwood Trail, Garfield Peak Trail, Watchman Peak Trail",
    "Oregon Coast: Cape Perpetua Scenic Area, Haystack Rock, Heceta Head Lighthouse"
};
        static string[] nameList = new string[] { "John", "Jane", "Bob", "Alice", "David", "Emily", "Michael", "Emma", "William", "Elizabeth" };



        static void Main(string[] args)
        {

            CustomList<string> list = new CustomList<string>();

            list.Add("Ronda"); // 0
            list.Add("Monika"); // 1
            list.Add("Henry"); // 2

            list.RemoveAt(1);

            list.DisplayInformation();

  

        } // main

        // Test Code
        public static void LinearCode()
        {
            // Linear Search
            // Search for a element in a collection
            // It starts at the first element
            // Goes one by one until it finds what it is looking for
            // Or until it reaches the end of the list

            //foreach (string name in nameList)
            //{
            //    Console.WriteLine(name);
            //}

            string nameToSearchFor = "Lhoucine";
            string description = $"Does the name {nameToSearchFor} exist in this list: ";
            // Act
            bool searchResult = ContainsName(nameList, nameToSearchFor);

            // Assert
            Console.WriteLine(description + searchResult);


            description = $"Where is {nameToSearchFor} on this list: ";
            // Act
            int indexResult = IndexOfName(nameList, nameToSearchFor);

            // Assert
            Console.WriteLine(description + indexResult);

            if (indexResult < 0)
            {
                Console.WriteLine("That name is not on the list");
            }

            // Student List
            List<Student> students = GenerateStudents(10);

            // Display the generated students
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Grade}");
            }

            List<Student> studentsWithGrades = AllStudentsWithAGradeHigherThan(students, 70);

            foreach (Student student in studentsWithGrades)
            {
                Console.WriteLine(student.Name);
            }

        }

        // Contains 
        public static bool ContainsName(string[] nameList, string searchKey)
        {
            // Loop through my collection
            foreach (string currentName in nameList)
            {
                // Compare the current element to our search key
                if (currentName == searchKey)
                {
                    // IF the element matches, return true
                    return true;
                }

            }

            // If it does not exist in the list, return false
            return false;

        }// ContainsName


        //// 2. Search for store by category - first store by index or -1 if not found
        public static int IndexOfName(string[] nameList, string searchKey){

            // Loop Through the array
            for (int i = 0; i < nameList.Length; i++)
            {
                // Compare the current item with the searchKey
                string currentName = nameList[i];
                if(currentName == searchKey)
                {
                    return i;
                }
            }
            return -1;
        }

        //// 3. Search for all stores of a category - List of ints
        //public static List<int> AllStoresOfACategory(string[] storeList, string searchKey);

        // Search for all student with a grade higher than 70
        public static List<Student> AllStudentsWithAGradeHigherThan(List<Student> list, int grade)
        {
            List<Student> tempList = new List<Student>();

            // Loop
            foreach (Student student in list)
            {
                // Compare
                bool higherThan = student.Grade > grade;

                // Respond
                if(higherThan)
                {
                    tempList.Add(student);
                }

            }

            // Return
            return tempList;
        }


        //// 4. Search for all stores on a floor - List of Stores
        //public static List<Store> AllStoresOnLevel(Store[] storeList, string searchKey);

        static List<Student> GenerateStudents(int numStudents)
        {
            List<Student> students = new List<Student>();
            Random random = new Random();

            for (int i = 0; i < numStudents; i++)
            {
                string name = GenerateName();
                int grade = random.Next(0, 101); // Generate random grade between 0 and 100
                students.Add(new Student(name, grade));
            }

            return students;
        }

        static string GenerateName()
        {
            // Code to generate a random name (you can replace this with your preferred method)
            string[] nameList = new string[] { "John", "Jane", "Bob", "Alice", "David", "Emily", "Michael", "Emma", "William", "Elizabeth" };
            int randomIndex = new Random().Next(nameList.Length);
            return nameList[randomIndex];
        }

    } // class

    class Student
    {
        public string Name
        { get; set; }
        public int Grade
        { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }

} // namespace
