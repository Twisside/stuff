namespace Class_exampl
{
    public class Car
    {
        private static string brand = "mazda";
        private static string model = "mx-5";
        private static int year = 1993;
        private static string colour = "red";

        private string licence_plate = "mzdfl";
        private int hp = 180;
        private int milliadge = 15000;
        private int transmission = 0; // 0 - mechanical, 1 - automatic
        private static float speed = 0;

        public void Details()
        {
            Console.WriteLine(Car.brand, Car.model, Car.year, Car.colour);
        }

        public void Motion(float speed)
        {
            Car.speed = Convert.ToSingle(Console.ReadLine());
        }
    }
}
