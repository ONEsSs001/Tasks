using System.Diagnostics.CodeAnalysis;

namespace Tasks._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            int[] transactions = [ 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 ];

            int sh = 0;
            int gm = 0;
            int shf = 0;
            int gmf = 0;


            foreach (var item in transactions)
            {
                if (item > 0)
                {
                    sh++;
                    shf += item;
                }
                else if (item < 0) {

                    gm++;
                    gmf += item;
                
                }

                

            }
            int sm = shf + gmf;

            Console.WriteLine($"Shetanebis raodenoba: {sh}, gamotanebis raodenoba: {gm}, Shetanii tanxa: {shf}, gamotanili tanxa: {-gmf}");
            Console.WriteLine(sm > 0 ? "angarishze tanxaa" : sm < 0 ? "angarishi minusshia" : "angarishis balansi nulia");
        }
    }
}
