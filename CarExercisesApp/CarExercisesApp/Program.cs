namespace CarExercisesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car(12345);
            car1.setModel("A5");
            Console.WriteLine("Model: " + car1.getModel());

            Car car2 = new Car("x6", 333221);
            Car.setBrand("BMW");
            Console.WriteLine("Brand: " + car2.getBrand());




        }
    }
}