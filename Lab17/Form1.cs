using System.Numerics;

namespace Lab17
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Додавання комплексних чисел
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Complex complex1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                Complex complex2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
                Complex sumComplex = (Complex)complex1.Add(complex2);
                textBox5.Text = sumComplex.Real + " + " + sumComplex.Imaginary + "i";
            }
            catch { MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        //Віднімання комплексних чисел
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Complex complex1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                Complex complex2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
                Complex subComplex = (Complex)complex1.Subtract(complex2);
                textBox5.Text = subComplex.Real + " + " + subComplex.Imaginary + "i";
            }
            catch
            { MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        //Множенння комплексних чисел
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Complex complex1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                Complex complex2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
                Complex mulComplex = (Complex)complex1.Multiply(complex2);
                textBox5.Text = mulComplex.Real + " + " + mulComplex.Imaginary + "i";
            }


            catch
            { MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        //Ділення комплексних чисел
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Complex complex1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                Complex complex2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
                Complex divComplex = (Complex)complex1.Divide(complex2);
                textBox5.Text = divComplex.Real + " + " + divComplex.Imaginary + "i";
            }
            catch
            { MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        //Додавання дробів
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Rational rational1 = new Rational(int.Parse(textBox10.Text), int.Parse(textBox9.Text));
                Rational rational2 = new Rational(int.Parse(textBox8.Text), int.Parse(textBox7.Text));
                Rational sumRatinal = (Rational)rational1.Add(rational2);
                textBox6.Text = sumRatinal.Numerator + "/" + sumRatinal.Denominator;
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Віднімання дробів
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Rational rational1 = new Rational(int.Parse(textBox10.Text), int.Parse(textBox9.Text));
                Rational rational2 = new Rational(int.Parse(textBox8.Text), int.Parse(textBox7.Text));
                Rational subRatinal = (Rational)rational1.Subtract(rational2);
                textBox6.Text = subRatinal.Numerator + "/" + subRatinal.Denominator;
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Множення дробів
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Rational rational1 = new Rational(int.Parse(textBox10.Text), int.Parse(textBox9.Text));
                Rational rational2 = new Rational(int.Parse(textBox8.Text), int.Parse(textBox7.Text));
                Rational mulRatinal = (Rational)rational1.Multiply(rational2);
                textBox6.Text = mulRatinal.Numerator + "/" + mulRatinal.Denominator;
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Ділення дробів
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Rational rational1 = new Rational(int.Parse(textBox10.Text), int.Parse(textBox9.Text));
                Rational rational2 = new Rational(int.Parse(textBox8.Text), int.Parse(textBox7.Text));
                Rational divRatinal = (Rational)rational1.Divide(rational2);
                textBox6.Text = divRatinal.Numerator + "/" + divRatinal.Denominator;
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

