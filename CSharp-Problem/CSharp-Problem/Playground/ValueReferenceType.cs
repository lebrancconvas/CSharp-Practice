using System;
namespace CSharp_Problem.Playground
{
    public class ValueReferenceType
    {
        public ValueReferenceType()
        {
            // Value Data Type (Ex. Integer)
            int x = 1;
            int y = 1;
            int z = y;
            Console.WriteLine(x == y); // True
            Console.WriteLine(x == z); // True
            Console.WriteLine(y == z); // True 

            // Reference Data Type (Ex. Array)
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1, 2, 3 };
            int[] c = b;
            Console.WriteLine(a == b); // False 
            Console.WriteLine(a == c); // False 
            Console.WriteLine(b == c); // True 
        }
    }
}
