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
                else if (isSpelnionyWarunekTrojkata(value, b, c))
                    a = value;
                else // nie jest spełniony warunek trójkąta
                    throw new ArgumentException("nie spełniony warunek trójkąta przy próbie zmiany A"); 
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
                else if (isSpelnionyWarunekTrojkata(a, value, c))
                    b = value;
                else // nie jest spełniony warunek trójkąta
                    throw new ArgumentException("nie spełniony warunek trójkąta przy próbie zmiany B");
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
                else if (isSpelnionyWarunekTrojkata(a, b, value))
                    c = value;
                else // nie jest spełniony warunek trójkąta
                    throw new ArgumentException("nie spełniony warunek trójkąta przy próbie zmiany C");
            }
        }

        private bool isSpelnionyWarunekTrojkata(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true; 
            }
        }


        // drugi krok opisanie procesu budowy obiektu (konstruktory)

        public Trojkat() // konstruktor domyślny 
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new  ArgumentOutOfRangeException("boki muszą być dodatnie");

            if (!isSpelnionyWarunekTrojkata(a, b, c))
                throw new ArgumentException("nie spełniony warunek trójkąta");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        // tekstowa prezentacja obiektu 
        public override string ToString()
        {
            return $"Trójkąt(a: {a}, b: {b}, c: {c})";
        }

        // właściwości i metody

        public double GetObwod()
        {
            return a + b + c;
        }
        

        public double Obwod => a + b + c;

        public double GetPole()  // Java Style 
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

