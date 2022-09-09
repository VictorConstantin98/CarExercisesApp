using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercisesApp
{
    internal class Car
    {
        private const int codCalculSerieMotor = 5;
        private static string codSerieSasiu;
        private static string brand;

        private readonly long serieSasiu;
        private readonly long serieMotor;
        private string model;
        private string color;

        //Constructor implicit
        public Car(int serieSasiu)
        {
            this.serieSasiu = serieSasiu;
            this.serieMotor = initCodSerieMotor();
        }
        //Constructor explicit partial
        public Car(string model, long serieSasiu)
        {
            this.model = model;
            this.serieSasiu = serieSasiu;
        }
        //Constructor explicit
        public Car(long serieSasiu, long serieMotor, string model, string color)
        {
            this.serieSasiu=serieSasiu;
            this.serieMotor = initCodSerieMotor();
            this.model=model;
            this.color=color;
        }
        //Setter & getter model
        public string getModel()
        {
            return this.model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        //Setter & getter brand
        public string getBrand()
        {
            return Car.brand;
        }
        public static void setBrand(string brand)
        {
            Car.brand = brand;
        }
        //Metoda 
        private long initCodSerieMotor()
        {
            return serieSasiu * codCalculSerieMotor;
        }
        
       
    }
}
