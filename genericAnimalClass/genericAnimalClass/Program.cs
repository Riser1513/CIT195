namespace genericAnimalClass
{
    internal class Program
    {
        public class Animal < T >
        {
            public T data;
            public Animal(T data)
            {
                this.data = data;
            }
            public T getAnimal()
            {
                return data;
            }
        }
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Horse");
            Animal<string> animalHabitat = new Animal<string>("Plains");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> avgLifespan = new Animal<int>(30);
            Console.WriteLine($"The animal's name is {animalName.getAnimal()}, and it lives in the {animalHabitat.getAnimal()}. Its endangerment status is {endangered.getAnimal()}, and its extinction status is {extinct.getAnimal()}. They have an average lifespan of {avgLifespan.getAnimal()}");
        }
    }
}
