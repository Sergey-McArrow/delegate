using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {

        delegate void GetMessage();
        delegate int Operation(int x, int y);
        delegate void MessageHandler(string message);
        delegate int Oper(int x, int y);
        delegate void factor(int j);
        delegate void Hello();


        static void Main(string[] args)
        {
            //GetMessage message;
            //if (DateTime.Now.Hour < 12)
            //{
            //    message = GoogMorning;
            //}
            //else
            //    message = GoodEvening;
            //message.Invoke();

            //var operation = new Operation(Add);
            //operation += Muliply;
            //operation += Minus;
            //int res = operation.Invoke(4, 9);
            ////Console.WriteLine(operation.Invoke(43,67));
            //Console.WriteLine(res);

            //var account = new Account(100);
            //account.RegisterHandler(new Account.AccountStateHandler(Result));
            //account.WithDraw(10);

            //    factor factor = Factorial;


            //    factor += delegate (int j)
            //{
            //    for (int i = 1; i <= 3; i++)
            //    {
            //        j = j * i;
            //        Console.WriteLine(j);
            //    }
            //};

            //    factor(1);

            //Show("Hello", delegate (string mes)
            //    {
            //        Console.WriteLine(mes);
            //    });

            //Show("Hello", MyFunc);

            //Oper op = delegate (int x, int y)
            //{
            //    return x + y;
            //};
            //var temp = op(5, 5);
            //Console.WriteLine(temp);

            Oper op = (x, y) => x + y; 
                
            var temp = op(5, 5);
            Console.WriteLine(temp);

            Hello hello = () => Console.WriteLine("Hello");
            hello();
            hello = () => Show();
            hello();

            //end of Main
        }

        private static void Show()
        {
            Console.WriteLine("Hell0");
        }
        private static void MyFunc(string mes)
        {
            Console.WriteLine(mes);
        }

        private static void Show(string message, MessageHandler handler)
        {
            handler(message);
        }

        private static void Result(string message)
        {
            Console.WriteLine(message);
        }

        private static void Factorial(int j)
        {
            for (int i = 1; i <= 3; i++)
            {
                j = j * i;
                Console.WriteLine(j);
            }
        }

        private static void GoogMorning()
        {
            Console.WriteLine("Good morning!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good evening!");
        }
        private static void ShowMessage(GetMessage getMessage)
        {
            getMessage.Invoke();
        }

        private static int Add(int x, int y)
        {
            Console.WriteLine("Add");
            return x + y;
        }
        private static int Minus(int x, int y)
        {
            Console.WriteLine("Minus");
            return x - y;
        }
        private static int Muliply(int x, int y)
        {
            Console.WriteLine("Multiply");
            return x * y;

        }

        private bool Login(string login, string pass, GetMessage loadData)
        {
            if (login == "admin" && pass == "admin")
            {
                loadData.Invoke();
                return true;
            }
            else
                return false;
        }
    }
}
