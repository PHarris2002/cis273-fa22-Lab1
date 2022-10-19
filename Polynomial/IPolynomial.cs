using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    public interface IPolynomials<T>
    {
        void AddTerm(double coeff, int power);
        int NumberOfTerms { get; }
        int Degree { get; }
        Polynomial Add(Polynomial p1, Polynomial p2);
        Polynomial Subtract(Polynomial p1, Polynomial p2);
        Polynomial Negate(Polynomial p);
        Polynomial Multiply(Polynomial p1, Polynomial p2);

    }
}
