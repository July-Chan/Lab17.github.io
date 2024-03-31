using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public abstract class Pair
    {// Арифметичні операції
        public abstract Pair Add(Pair other);
        public abstract Pair Subtract(Pair other);
        public abstract Pair Multiply(Pair other);
        public abstract Pair Divide(Pair other);

    }

    public class Complex : Pair
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override Pair Add(Pair other)//Додавання
        {
            if (other is Complex)
            {
                Complex c = (Complex)other;
                return new Complex(Real + c.Real, Imaginary + c.Imaginary);
            }
            throw new ArgumentException("Неможливо додавати комплексне число до іншого типу.");
        }

        public override Pair Subtract(Pair other)//Віднімання
        {
            if (other is Complex)
            {
                Complex c = (Complex)other;
                return new Complex(Real - c.Real, Imaginary - c.Imaginary);
            }
            throw new ArgumentException("Неможливо віднімати комплексне число від іншого типу.");
        }

        public override Pair Multiply(Pair other)//Множення
        {
            if (other is Complex)
            {
                Complex c = (Complex)other;
                return new Complex(Real * c.Real - Imaginary * c.Imaginary, Real * c.Imaginary + Imaginary * c.Real);
            }
            throw new NotImplementedException("Неможливо множити комплексне число на інший тип.");
        }

        public override Pair Divide(Pair other)//Ділення
        {
            if (other is Complex)
            {
                Complex c = (Complex)other;
                double denominator = c.Real * c.Real + c.Imaginary * c.Imaginary;
                if (denominator != 0)
                {
                    double realPart = (Real * c.Real + Imaginary * c.Imaginary) / denominator;
                    double imaginaryPart = (Imaginary * c.Real - Real * c.Imaginary) / denominator;
                    return new Complex(realPart, imaginaryPart);
                }
                throw new DivideByZeroException("Ділення на нуль.");
            }
            throw new ArgumentException("Неможливо ділити комплексне число на інший тип.");
        }

    }

    public class Rational : Pair
    {
        public int Numerator {  get; }
        public int Denominator { get; }

        public Rational(int numerator, int denominator)
        {
            if(denominator==0)
                throw new ArgumentException("Знаменник не може бути нулем.");
            Numerator = numerator;
            Denominator = denominator;
        }

        // Метод для спрощення дробу
        private Rational Simplify(int numerator, int denominator)
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            int newNumerator = numerator / gcd;
            int newDenominator = denominator / gcd;
            if (newDenominator < 0)
            {
                newNumerator = -newNumerator;
                newDenominator = -newDenominator;
            }
            return new Rational(newNumerator, newDenominator);
        }
        // Метод для знаходження найбільшого спільного дільника
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public override Pair Add(Pair other)//Додавання
        {
            if (other is Rational)
            {
                Rational r = (Rational)other;
                int newNumerator = Numerator * r.Denominator + r.Numerator * Denominator;
                int newDenominator = Denominator * r.Denominator;
                return Simplify(newNumerator, newDenominator);
            }
            throw new ArgumentException("Неможливо додавати раціональний дріб до іншого типу.");
        }
        public override Pair Subtract(Pair other)//Віднімання
        {
            if (other is Rational)
            {
                Rational r = (Rational)other;
                int newNumerator = Numerator * r.Denominator - r.Numerator * Denominator;
                int newDenominator = Denominator * r.Denominator;
                return Simplify(newNumerator, newDenominator);
            }
            throw new ArgumentException("Неможливо віднімати раціональний дріб від іншого типу.");
        }

        public override Pair Multiply(Pair other)//Множення
        {
            if (other is Rational)
            {
                Rational r = (Rational)other;
                int newNumerator = Numerator * r.Numerator;
                int newDenominator = Denominator * r.Denominator;
                return Simplify(newNumerator, newDenominator);
            }
            throw new ArgumentException("Неможливо множити раціональний дріб на інший тип.");
        }

        public override Pair Divide(Pair other)//Ділення
        {
            if (other is Rational)
            {
                Rational r = (Rational)other;
                if (r.Numerator != 0)
                {
                    int newNumerator = Numerator * r.Denominator;
                    int newDenominator = Denominator * r.Numerator;
                    return Simplify(newNumerator, newDenominator);
                }
                throw new DivideByZeroException("Ділення на нуль.");
            }
            throw new ArgumentException("Неможливо ділити раціональний дріб на інший тип.");
        }


    }
}


