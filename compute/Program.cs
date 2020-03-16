using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compute
{
    class Program
    {
        static void Main(string[] args)
        {
        L2:
            Console.WriteLine("请选择要输入的数值类型");
            Console.WriteLine("1. 数值");
            Console.WriteLine("2. 字符串");
            int choose = Int32.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("请输入要操作的数");
                int x = Int32.Parse(Console.ReadLine());
                int y = Int32.Parse(Console.ReadLine());

                compute compute = new compute();
                Console.WriteLine("请选择要进行的运算操作");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("5. 判断两个数是否相等");
                int c = Int32.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine(compute.Addition(x, y));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(compute.Subtraction(x, y));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(compute.Multiplication(x, y));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(compute.Division(x, y));
                            break;
                        }
                    case 5:
                        {
                            if (compute.Equals(x, y))
                                Console.WriteLine(x + "等于" + y);
                            Console.WriteLine(x + "不等于" + y);
                            break;
                        }
                }
            }
            else
            {
                if (choose == 2)
                {
                    compute compute = new compute();
                    Console.WriteLine("请选择要进行的运算操作");
                    Console.WriteLine("1. +");
                    Console.WriteLine("2. -");
                    int c = Int32.Parse(Console.ReadLine());
                    if (c==2)
                    {
                        Console.WriteLine("被减字符串必须包含所减字符串");
                    }
                    Console.WriteLine("请输入要操作的字符串");
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    switch (c)
                    {
                        case 1:
                            {
                                Console.WriteLine(compute.Addition(str1,str2));
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine(compute.Subtraction(str1,str2));
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("无此数值类型的计算");
                    goto L2;
                }
            }
        }
    }
    /// <summary>
    /// 计算类
    /// </summary>
    class compute
    {
        /// <summary>
        /// 加法函数
        /// </summary>
        /// <param name="x">加数</param>
        /// <param name="y">加数</param>
       public float Addition(int x,int y)
        {
            return x + y;
        }
        public string Addition(string x,string y)
        {

            return (x+y);
        }
        /// <summary>
        /// 除法函数
        /// </summary>
        /// <param name="x">被除数</param>
        /// <param name="y">除数</param>
        /// <returns></returns>
        public float Division(int x,int y)
        {
            try
            {
                return x / y;
            }
            catch
            {
                Console.WriteLine("除数不能为0");
                return 0;
            }
        }
        /// <summary>
        /// 减法函数
        /// </summary>
        /// <param name="x">被减数</param>
        /// <param name="y">减数</param>
        /// <returns></returns>
        public float Subtraction(int x,int y)
        {
            return x - y;
        }
        public string Subtraction(string x,string y)
        {
            x = x.Replace(y,"");
            return x;
        }
        /// <summary>
        /// 乘法函数
        /// </summary>
        /// <param name="x">乘数</param>
        /// <param name="y">乘数</param>
        /// <returns></returns>
        public float Multiplication(int x, int y)
        {
            return x * y;
        }
        bool equals(int x,int y)
        {
            return (x==y ? true : false);
            
        }
    }
}
