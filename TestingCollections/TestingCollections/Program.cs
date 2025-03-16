namespace TestingCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Queue<string> strQueue = new Queue<string>();
            strQueue.Enqueue("This is a test.");
            Console.WriteLine("Add something to the queue: ");
            strQueue.Enqueue(Console.ReadLine());
            strQueue.Enqueue("Terraria is a great game.");
            strQueue.Enqueue("Roblox sucks.");
            strQueue.Enqueue("Cats are my favorite animal.");
            Console.WriteLine($"There are {strQueue.Count()} items in the queue.");
            if (strQueue.Contains("Cats"))
            {
                Console.WriteLine("Queue contains cats.");
            }
            strQueue.Dequeue();
            Console.WriteLine($"Queue now contains {strQueue.Count()} items.");
            foreach (string str in strQueue)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Stack<string> strStack = new Stack<string>();
            strStack.Push("Cats");
            strStack.Push("Lynxes");
            strStack.Push("Libras");
            strStack.Push("Lions");
            strStack.Push("Dogs");
            Console.WriteLine($"There are {strStack.Count()} items in the stack.");
            if (strStack.Contains("Dogs"))
            {
                Console.WriteLine("Dogs suck. No more dogs in stack.");
                strStack.Pop();
            }
            Console.WriteLine($"There are {strStack.Count()} items in the stack.");
            foreach(string str in strStack)
            {
                Console.WriteLine(str);
            }
            LinkedList<string> strLinkedList = new LinkedList<string>();
            strLinkedList.AddLast("Sorrowful");
            strLinkedList.AddLast("Depressed");
            strLinkedList.AddLast("Unenthusiastic");
            strLinkedList.AddLast("Meloncholic");
            strLinkedList.AddLast("Pitiful");
            Console.WriteLine($"The first node in the linked list is {strLinkedList.First()} and the last node is {strLinkedList.Last()}.");
            strLinkedList.AddBefore(strLinkedList.Find("Meloncholic"), "Saturated");
            strLinkedList.Remove("Depressed");
            Console.WriteLine($"There are {strLinkedList.Count()} nodes in the list.");
            foreach (string node  in strLinkedList)
            {
                Console.WriteLine(node);
            }
            Dictionary<string, string> strDictionary = new Dictionary<string, string>();
            strDictionary.Add("Orange", "Cat");
            strDictionary.Add("Tabby", "Cat");
            strDictionary.Add("Tuxedo", "Cat");
            strDictionary.Add("Great Dane", "Dog");
            strDictionary.Add("Poodle", "Dog");
            foreach (string key in strDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string value in strDictionary.Values)
            {
                Console.WriteLine(value);
            }
            foreach (KeyValuePair<string, string> pair in strDictionary)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
            strDictionary.Remove("Poodle");
            Console.WriteLine($"There are {strDictionary.Count()} pairs in the dictionary.");
            HashSet<string> strHashSet = new HashSet<string>();
            strHashSet.Add("Mopping");
            strHashSet.Add("Scrubbing");
            strHashSet.Add("Blasting");
            strHashSet.Add("Washing");
            strHashSet.Add("Wiping");
            HashSet<string> similarHash = new HashSet<string>();
            similarHash.Add("Cleaning");
            similarHash.Add("Baking");
            similarHash.Add("Cooking");
            similarHash.Add("Making");
            similarHash.Add("Yelling");
            HashSet<string> thirdHash = new HashSet<string>();
            thirdHash.Add("Cleaning");
            thirdHash.Add("Scrubbing");
            thirdHash.Add("IDK");
            thirdHash.Add("What");
            thirdHash.Add("Else");
            strHashSet.UnionWith(similarHash);
            strHashSet.UnionWith(thirdHash);
            foreach (string str in strHashSet)
            {
                Console.WriteLine(str);
            }
        }
    }
}
