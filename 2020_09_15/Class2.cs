using _2020_09_14;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_15
{
    class AccontManager 
    {
        List<BankAccount> banks = new List<BankAccount>();
        BankAccount bank = new BankAccount();

        public void PrintMenu()
        {
            Console.WriteLine("\n---Menu------------");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
        }
        public void MakeAccount() //1. 계좌 개설
        {
            Console.Clear();
            Console.Write("계좌번호: ");
            string accNum = Console.ReadLine();
            Console.Write("예금주명:");
            string accName = Console.ReadLine();

            BankAccount account = new BankAccount(accNum, accName);
            banks.Add(account);
        }
        public void Deposit() //2. 입금
        {
            Console.Clear();
            Console.Write("입금하실 금액:");
            int money = int.Parse(Console.ReadLine());
        }
        public void Withdraw() //3. 출금
        {
            Console.Clear();
        }

        public void Balanceinquiry()
        {
            Console.Clear();
        }

        public void End()
        {
            Console.Clear();

        }
    }

    class Class2
    {
        static void Main()
        {
            System.Windows.Forms.MessageBox.Show("hello","title", System.Windows.Forms.MessageBoxButtons.YesNo);
            AccontManager manager = new AccontManager();
            int choice = 0;
            Console.WriteLine(manager.ToString());
            
            while (true)
            {
                manager.PrintMenu();
                Console.Write("선택:");
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        manager.MakeAccount(); break;
                    case 2:
                        manager.Deposit(); break;
                    case 3:
                        manager.Withdraw(); break;
                    case 4:
                        manager.Balanceinquiry(); break;
                    case 5:
                        manager.End(); return;
                    default:
                        Console.WriteLine("다시 선택하세요");break;
                }
                bank.PrintAccInfo();
            }
        }
    }
}
