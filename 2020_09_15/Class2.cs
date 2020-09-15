using _2020_09_14;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_15
{
    class AccontManager
    {
        List<BankAccount> banks = new List<BankAccount>();
        BankAccount bank = new BankAccount();

        private int SelectAcc()
        {
            Console.Clear();
            for(int i =0; i < banks.Count; i++)     //계좌 목록 출력
            {
                Console.WriteLine($"{i+1}번 계좌 이름:{banks[i].Name}, 계좌:{banks[i].AccNum}, 잔액:{banks[i].Balance}");
            }

            Console.Write("계좌를 선택하세요: ");
            int temp = 0;
            if(int.TryParse(Console.ReadLine(),out temp))
            {
                if(temp > banks.Count || temp < 1)
                {
                    Console.WriteLine("입력이 잘못되었습니다.");
                    return -1;
                }
                return temp-1;
            }
            Console.WriteLine("입력이 잘못되었습니다.");
            return -1;
        }

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

            bank = new BankAccount(accNum,accName);
            banks.Add(bank);
        }
        public void Deposit() //2. 입금
        {
            Console.Clear();
            if(banks.Count == 0)        //계설된 계좌 없음
            {
                Console.WriteLine("계설된 계좌가 없습니다.");
                return;
            }
            int index = SelectAcc();
            if (index == -1) return; 
            Console.Write("입금하실 금액:");
            int money = int.Parse(Console.ReadLine());
            banks[index].InputMoney(money);
        }
        public void Withdraw() //3. 출금
        {
            Console.Clear();
            if (banks.Count == 0)       //계설된 계좌 없음
            {
                Console.WriteLine("계설된 계좌가 없습니다.");
                return;
            }
            int index = SelectAcc();
            if (index == -1) return;
            Console.Write("출금하실 금액:");
            int money = int.Parse(Console.ReadLine());
            banks[index].OutputMoney(money);
        }

        public void Balanceinquiry()
        {
            Console.Clear();
            if (banks.Count == 0)        //계설된 계좌 없음
            {
                Console.WriteLine("계설된 계좌가 없습니다.");
                return;
            }
            for (int i = 0; i < banks.Count; i++)     //계좌 목록 출력
            {
                Console.WriteLine($"{i + 1}번 계좌 이름:{banks[i].Name}, 계좌:{banks[i].AccNum}, 잔액:{banks[i].Balance}");
            }
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
            }
        }
    }
}
