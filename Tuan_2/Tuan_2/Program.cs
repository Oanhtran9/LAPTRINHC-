namespace Tuan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho va ten: ");
            string hoten = Console.ReadLine();

            // bai1
            if (!string.IsNullOrWhiteSpace(hoten))
            {
                string name = hoten.Trim();
                string[] words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string result = "";
                for (int i = 0; i < words.Length; i++)
                {
                    string ten = words[i].ToLower();
                    ten = char.ToUpper(ten[0]) + ten.Substring(1).ToLower();
                    result += ten + " ";
                }

                Console.WriteLine("BAI 1--- Ho ten chuan hoa: " + result.Trim());
                Console.WriteLine("BAI 2--- So tu trong chuoi: " + result.Length);
            }

            //bai3
            if (hoten == null)
            {
                Console.WriteLine("Chuoi khong doi xung");
            }
            else
            {
                string p = hoten.Replace(" ", "").ToLower();
                bool doiXung = true;

                for (int i = 0; i < p.Length / 2; i++)
                {
                    if (p[i] != p[p.Length - 1 - i])
                    {
                        doiXung = false;
                        break;
                    }
                }

                if (doiXung)
                    Console.WriteLine("BAI 3-- Chuoi doi xung");
                else
                    Console.WriteLine("BAI 3-- Chuoi khong doi xung");
            }

            //bai4 
            Console.WriteLine("BAI 4 -- Nhap so phan tu: ");
            int spt = int.Parse(Console.ReadLine());
            if (spt <= 0)
            {
                Console.WriteLine("Màn rong");
                return;
            }
            int[] mang = new int[spt];
            int tong = 0;
            for (int i = 0; i < spt; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i) + " : ");
                mang[i] = int.Parse(Console.ReadLine());
                tong += mang[i];
            }
            Console.WriteLine("Tong cac phan tu trong mang: " + tong);

            //bai5
            int max = mang[0];
            for (int  i = 1;  i < spt;  i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            Console.WriteLine("BAI 5-- Phan tu lon nhat trong mang: " + max);

            //bai6
            int demsochan = 0;
            if (spt == 0)
            {
                Console.WriteLine("BAI 6-- Tong so phan tu trong mang: 0");
            }
            else
            {
                for (int i = 0; i < spt; i++)
                {
                    if (mang[i] % 2 == 0)
                        demsochan++;
                }
            }
            Console.WriteLine("BAI 6-- Tong so phan tu trong mang: " + demsochan);

            //bai7

            if (hoten == null)
            {
                Console.WriteLine("BAI 7-- Chuoi rong");
                return;
            }
            string[] tu = hoten.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (tu == null || tu.Length == 0)
            {
                Console.WriteLine("Mang rong.");
                return;
            }
            Console.WriteLine("BAI 7-- Cac tu trong mang:");
            for (int i = 0; i < tu.Length; i++)
            {
                Console.WriteLine(tu[i]);
            }

            //bai8
            
            string tudainhat = tu[0];
            for (int i = 1; i < tu.Length; i++)
            {
                if (tu[i].Length > tudainhat.Length)
                {
                    tudainhat = tu[i];
                }
            }
            Console.WriteLine("BAI 8-- Tu dai nhat trong chuoi: " + tudainhat);

            //bai9
            Console.WriteLine("BAI 9 -- Nhap so phan tu chuoi: ");
            spt = int.Parse(Console.ReadLine());
            if (spt <= 0)
            {
                Console.WriteLine("So chuoi khac null và rong: 0");
                return;
            }
            string[] chuoi9 = new string[spt];
            for (int i = 0; i < spt; i++)
            {
                Console.WriteLine("Nhap chuoi thu " + i + ": ");
                chuoi9[i] = Console.ReadLine();
            }
            if (chuoi9 == null || chuoi9.Length == 0)
            {
                Console.WriteLine("So chuoi khac null và rong: 0");
                return;
            }
            int dem = 0;
            for (int i = 0; i < spt; i++)
            {
                if (!string.IsNullOrWhiteSpace(chuoi9[i]))
                {
                    dem++;
                }
            }

            Console.WriteLine("So chuoi khac null và rong: " + dem);
        }
    }
}
