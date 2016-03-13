using System;

    class QuadraticEquation
    {
        static void Main()
        {
		Console.Write("Enter coefficient a = ");
		double a = double.Parse(Console.ReadLine());
		Console.Write("Enter coefficient b = ");
		double b = double.Parse(Console.ReadLine());
		Console.Write("Enter coefficient c = ");
		double c = double.Parse(Console.ReadLine());
		
		double discriminant = (b*b)-(4*a*c);
		double x1,x2;
        		
		if (discriminant==0)
		{
			x1=x2=-b/(2*a);
            Console.WriteLine(" Root of the quadratic equation is x1=x2={0}",x1);
		} else  {
			if 	(discriminant>0)
			{
                x1 = (-b + Math.Sqrt(discriminant))/(2*a);
                x2 = (-b - Math.Sqrt(discriminant))/(2*a);
			    Console.WriteLine(" Roots of the quadratic equation are x1={0} and x2 = {1}",x1,x2);
		    } else {
			    Console.WriteLine("There are no real roots!");
		            }
			
		        }
	        }
     }
    

