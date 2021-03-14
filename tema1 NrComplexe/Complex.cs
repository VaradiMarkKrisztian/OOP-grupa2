using System;
using System.Text.RegularExpressions;
namespace tema1_NrComplexe
{
    internal class Complex
    {
        private double re;
        private double im;

        public Complex(double re) : this(re, 0)
        {

        }


        // TODO: parsing pe string pentru a scoate partea reala si partea imaginara
        // probabil ca s-ar putea face cu expresii regulare. 
        //DONE
        public Complex(string v)
        {
            v = Regex.Replace(v, @"/s+", "");
            Regex ParteaReala = new Regex(@"^[\+-]?\d*(?!i)"); // +/- A 
            //se asigura de faptul ca partea reala nu este urmata de i
            if (ParteaReala.IsMatch(v))
            {
                MatchCollection matches = ParteaReala.Matches(v);
                if (matches[0].ToString().Length != 0 || matches[0].ToString() == "+" || matches[0].ToString() == "-")
                //verifica daca A=0 sau incepe cu un semn, astfel partea reala o sa fie 0, altfel i se atribuie valoarea din string
                {
                    this.re = double.Parse(matches[0].ToString());
                }
                else this.re = 0;
            }
            Regex ParteaImaginara = new Regex(@"[\+-]?\d*(?=i)"); // +/- B i
            //se asigura de faptul ca partea imaginara este urmata de i
            if (ParteaImaginara.IsMatch(v))
            {
                MatchCollection matches = ParteaImaginara.Matches(v);
                if (matches[0].ToString().Length != 0 || matches[v.Length].ToString() != "i")
                //verifica daca exista B!=0 si daca il are pe i la sfarsit
                {
                    this.im = double.Parse(matches[0].ToString());
                }
            }
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative. DONE
        public override string ToString()
        {
            this.re = double.Parse(re.ToString());
            this.im = double.Parse(im.ToString());
            string rezultat = "";
            if (re > 0 || re < 0)
            {
                if (im > 0)
                    rezultat = "(" + re + "+" + im + "i" + ")";
                if (im == 0)
                    rezultat = "(" + re + ")";
                if (im < 0)
                    rezultat = "(" + re + im + "i" + ")";
            }

            if (re == 0)
            {
                if (im > 0 || im < 0)
                    rezultat = "(" + im + "i" + ")";
                if (im == 0)
                    rezultat = "( )";
            }
            return rezultat;
        }

        public Complex Add(Complex c2)
        {
            Complex suma = new Complex(re + c2.re, im + c2.im);
            return suma;
        }


        // TODO done
        public Complex Multiply(Complex c2)
        {
            Complex mult = new Complex(re * c2.re, im * c2.im);
            return mult;
        }


        // TODO done
        public Complex Subtract(Complex c2)
        {
            Complex diff = new Complex(re - c2.re, im - c2.im);
            return diff;
        }


        // TODO DONE
        public double Real
        {
            get
            {
                return re;
            }
        }
        public double Imag
        {
            get
            {
                return im;
            }
        }
        public double Modul(Complex c)
        {
            //formula radical din re^2 + im^2
            double SumaPuterilor = Math.Pow(re, 2) + Math.Pow(im, 2);
            return Math.Sqrt(SumaPuterilor);
        }
        public double Argument(Complex c)
        {
            // unghiul tangenta pentru b/a
            return Math.Atan(im / re);
        }

        public static Complex operator+(Complex c1, Complex c2)
        {
            //double RE = c1.re + c2.re;
            //double IM = c1.im + c2.im;
            //string RezultatInmultire = RE + "," + IM;
            return new Complex(c1.re + c2.re, c1.im + c2.im);
        }
        public static Complex operator-(Complex c1, Complex c2)
        {
            return new Complex(c1.re - c2.re, c1.im - c2.im);
        }
        public static Complex operator*(Complex c1, Complex c2)
        {
            
            return new Complex(c1.re * c2.re, c1.im * c2.im);
        }

        // TODO
        // orice alte operatii pe care le cunoasteti cu operatii complexe. 
    }
}