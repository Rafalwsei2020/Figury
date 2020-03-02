using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // definiujemy dane obiektu- pola obiektu (fields)
     private  double a; // this.a
        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość A musi być dodatnia"); 
                else
                    a = value;
            }
        }

     private double b;  //this.b
        public double B
        {
            get => b; 
            set

            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość B musi być dodatnia");
                else
                    b = value;
            }
        }
   private double c;  // thos.c   

        public double C
        {
            get => c;
            set

            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość C musi być dodatnia");
                else
                    c = value;
            }
        }



        // drugi krok opisanie procesu budowy obiektu (konstruktory)

        public Trojkat() // konstruktor domyślny 
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {
            if (a + b <= c || a + c <= a || b + c <= a)
            {
                throw new ArgumentException("niespełniony warunek trójkąta"); 

            }
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override string ToString()
        {
            return $"Trójkąt(a: {a}, b: {b}, c: {c})";
        }

        public double GetObwod()
        {
            return a + b + c;
        }
        

        public double Obwod => a + b + c;

        public double GetPole()
        {
            var p = 0.5 * GetObwod(); 
            var s = Math.Sqrt(p * (p-a) *(p-b) * (p-c) );
            return s; 
        }

        public double Pole
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s; 
            }
        }
        

    }

}

