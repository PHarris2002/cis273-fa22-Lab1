using System;
namespace Polynomial
{
	public class Polynomial
	{

		private LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		public int Degree => NumberOfTerms == 0 ? 0: terms.First.Value.Power;

		public Polynomial()
		{
			terms = new LinkedList<Term>();
		}

		//TODO
		public void AddTerm(double coeff, int power)
		{
			var currentNode = terms.First;
			while(currentNode != null)
			{
				//check for matching power
				if(power == currentNode.Value.Power)
				{
					currentNode.Value.Coefficient += coeff;
					return;
				}
                //check for lesser power

				if (power > currentNode.Value.Power)
				{
					var newTerm = new Term(power, coeff);
					terms.AddBefore(currentNode, newTerm);
					return;
				}

                currentNode = currentNode.Next;
			}

			// Add new term to end of list
			terms.AddLast(new Term(power, coeff));
		}

		//TODO
		public override string ToString()
		{
			string result = "";
			foreach(var term in terms)
			{
				result += term.ToString() + " + ";
			}

			return result;
		}

		public static Polynomial Add(Polynomial p1, Polynomial p2)
		{
			Polynomial sum = new Polynomial();
			// add all the terms from p1 to sum
			foreach(var term in p1.terms)
			{
				sum.AddTerm(term.Coefficient, term.Power);
			}

            // add all the terms from p2 to sum
            foreach (var term in p2.terms)
            {
                sum.AddTerm(term.Coefficient, term.Power);
            }

            return sum;
		}

        public static Polynomial Subtract(Polynomial p1, Polynomial p2)
        {
            Polynomial difference = new Polynomial();
            //Use AddTerm and Negate here

            return difference;
        }

		public static Polynomial Negate(Polynomial p)
        {
            Polynomial inverse = new Polynomial();
            
			foreach(var term in p.terms)
			{
				inverse.AddTerm(term.Coefficient * -1, term.Power);
			}

            return inverse;
        }

        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
            Polynomial product = new Polynomial();
            //Do the work; use for loop for this

            return product;
        }
    }
}

