using System;

namespace BaiTapVeNha
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] a = new int[5, 5];
			int m, n, i, j;
			//nhập ma trận
			Console.Write("Nhap vao so hang: m = ");
			m = int.Parse(Console.ReadLine());
			//Nhap vao so cot
			Console.Write("Nhap vao so cot: n = ");
			n = int.Parse(Console.ReadLine());

			Console.WriteLine("Nhap vao ma tran: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    //Console.Write("\tPhan tu a[" + (i + 1) + "][" + (j + 1) + "] = ");
					Console.Write("\t Phan tu a[{0}][{1}] = ", i + 1, j + 1);
					a[i, j] = int.Parse(Console.ReadLine());
                }
            }
			//Hien thi ma tran
			Console.WriteLine("ma tran ban vua nhap la: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
					Console.Write(a[i, j] + "\t");
                }
				Console.WriteLine();
            }
			Console.ReadLine();
			int s=0;
			//tinh tong
			for(i = 0; i < m; i++) {
			for(j=0;j< n; j++)
                {
					s += a[i, j];
                }
			}
			Console.WriteLine("Tong cua mang la: ", +s);
        }
		
	}
}
