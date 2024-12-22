namespace Set3Ex15
{
    internal class Program
    {
        static void Print(int[] v,int length = -1)
        {
            if(length == -1)
            {
                length = v.Length;
            }
            Console.WriteLine(String.Join(" ", v[..length]));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vector: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(" "), int.Parse);

            Console.WriteLine("vector inainte de sortare: ");
            Print(v);

            int newLength = EliminareRepetitie(v);

            Console.WriteLine("Vector dupa sortare: ");
            Print(v,newLength);
        }

        static int EliminareRepetitie(int[] v)
        {
            Array.Sort(v);

            int indexElmUnic = 0;

            for(int i = 1; i < v.Length; i++)
            {
                if (v[i] != v[indexElmUnic])
                {
                    indexElmUnic++;
                    v[indexElmUnic] = v[i];
                }
            }

            return indexElmUnic + 1;
        } 
    }
}
