using System;

class Program
{
    static void Main(string[] args)
    {
        char[] A = { '1', '2', '3', '4', 'a', 'c', 'd' };
        char[] B = { '2', '4', 'e', 'f', 'c' };

        char[] kesisim_kumesi = Kesisim(A, B);

        if (kesisim_kumesi.Length > 0)
        {
            Console.Write("Kesişim kümesi: { ");
            foreach (char eleman in kesisim_kumesi)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("Kesişim kümesi bulunamadı.");
        }
    }

    static char[] Kesisim(char[] A, char[] B)
    {
        char[] kesisim_kumesi = new char[Math.Min(A.Length, B.Length)];
        int k = 0;

        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < B.Length; j++)
            {
                if (A[i] == B[j])
                {
                    kesisim_kumesi[k++] = A[i];
                    break; // Kesişim elemanlarını bir kez eklemek için
                }
            }
        }

        Array.Resize(ref kesisim_kumesi, k);
        return kesisim_kumesi;
    }
}
