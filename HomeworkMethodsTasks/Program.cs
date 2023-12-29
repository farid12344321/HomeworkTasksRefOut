using System;

namespace HomeworkMethodsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //FindSquare(out num);
            //Console.WriteLine(num);



            //int[] nums = { 2, 3, 4, 5,6 };
            //FindSquareArray(ref nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //string text = "   Hikmet Abbasov   ";
            //FindWrite(ref text);
            //Console.WriteLine(text);

        }


        //1 Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)
        static void FindSquare(out int num)
        {
            num = 5;
            num = num * num;
        }


        //2 Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod
        static void FindSquareArray(ref int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count++;
            }
            int[] datas = new int[count];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                datas[index++] = nums[i];
                datas[i] *= datas[i];
            }
            nums = datas;
        }


        //3 Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
        //Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər
        //"HikmətAbbasov" olmalıdır.
        static void FindWrite(ref string text)
        {
            string nn = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    nn += text[i];
                }
            }
            text=nn;
        }
    }
}
