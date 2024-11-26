using HomeWork._13;


internal class Program
{
    private static void Main(string[] args)
    {
        Building building = new Building("Промышленная 32", 100, 200, 3);//создание объекта класса базового
        Console.WriteLine(building.Print());

        MultiBuilding multibuilding = new MultiBuilding("Промышленная 32", 100, 200, 3, 2);
        Console.WriteLine(multibuilding.Print());

    }
}


























