using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.求最低的和他所在的原始位置
            /* int[] user = new int[] { 18, 25, 7, 36, 13, 2, 89, 63 };
             int min = user[0];
             int add = 0;
             for (int i = 0; i < user.Length; i++)
             {
                 if (min > user[i])
                 {
                     min = user[i];
                     add = i;
                 }
             }
             Console.WriteLine("最低的积分是:{0}",min);
             Console.WriteLine("他的原始位置是:{0}",add);*/
            #endregion

            #region 3.输入10个数,判断最大最小,以及和还有平均值
            /*int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            int max = num[0];
            int min = num[0];
            int he = 0;
            int avg = 0;
            for (int i = 0; i < num.Length; i++)
            {
                he = he + num[i];
                if (max < num[i])
                {
                    max = num[i];
                }
                if (min > num[i])
                {
                    min = num[i];
                }
            }
            avg = he / num.Length;
            Console.WriteLine("最大值是:{0},最小值是:{1},和是:{2},平均数是:{3}",max,min,he,avg);*/
            #endregion

            #region 4.foreach遍历输出
            /*  string[] score = new string[4] { "语文", "数学", "自然", "社会" };
              foreach (string[] item in score)
              {
                  Console.WriteLine(item);
              }*/
            #endregion

            #region 5.将一个字符串输出加上"|"
            /* string[] star = new string[5] { "梅西", "卡卡", "C罗", "罗纳尔多", "贝克汉姆" };
             foreach (string item in star)
             {
                 Console.Write(item+"|");
             }*/
            #endregion

            #region 6.用for和foreach语句遍历二维数组
            /*   int[,] arr = new int[3, 4] { { 11, 12, 13, 14 }, { 21,22,23,24 }, { 31, 32, 33,34 } };
               foreach (int item in arr)
               {
                   Console.WriteLine(item);
               }
               for (int i = 0; i < 3; i++) {
                   for (int j = 0; j < 4; j++)
                   {
                       Console.WriteLine(arr[i,j]);
                   }
               }*/
            #endregion

            #region 7.商店
            /*  string[][] shop = new string[3][];
              shop[0] =new string[]{ "耐克","阿迪达斯","北极人","优衣库"};
              shop[1] = new string[] { "安踏", "李宁", "特步", "双星","回力" };
              shop[2] = new string[] { "小肥羊", "顺风肥牛", "港式餐厅" };

              foreach (string[] item in shop)
              {
                  foreach (string item1 in item)
                  {
                      Console.WriteLine(item1);
                  }
              }*/

            #endregion

            #region 9.成绩排序
            /* int[] score = new int[10] { 88, 87, 94, 95, 86, 89, 91, 99, 90, 85 };
             Console.WriteLine("排序前:");
             for (int i = 0; i < score.Length; i++)
             {
                 Console.Write(score[i]+" ");    
             }

             Array.Sort(score);
             Array.Reverse(score);
             Console.Write("排序后:");
             for (int i = 0; i < score.Length; i++)
             {
                 Console.Write(score[i]+" ");
             }

             int[] newScore = new int[10];
             for (int i = 0; i < score.Length; i++)
             {
                 newScore[i] = score[i];
             }

             for (int i = 0; i < newScore.Length; i++)
             {
                 Console.WriteLine(newScore[i]);
             }*/
            #endregion

            #region 10.反转
            string[] str1 = new string[] { "the", "sky", "is", "blue" };
            Array.Reverse(str1);
            foreach (string item in str1)
            {
                Console.Write(item+" ");
            }
            #endregion
        }
    }
}
