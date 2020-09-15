using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    public class BankAccount
    {
        private bool overdraftfee = false;
        private static double interest = 0.2;      //이자율
        private string accNum = "Not AccNum";                      //계좌번호
        private string name = "Not name";                         //예금주명
        private int balance = 0;

        #region property
        //접근 및 조건
        public bool OverdraftFee 
        {
            get => overdraftfee;
            set => overdraftfee = value;
        }

        public int Balance    //읽기전용속성                      
        { 
            get => balance; 
        }
        public string AccNum { get => accNum; set => accNum = value; }
        public string Name   { get => name; set => name = value; }
        public static double Interset { get => interest; }

        #endregion
        #region ctor
        public BankAccount()
        {
            balance = 10;
        }

        public BankAccount(int balance)
        {
            this.balance = balance;
            balance = 10;
        }
        public BankAccount(string accNum, string name)
        {
            this.accNum = accNum;
            this.name = name;
            balance = 10;
        }
        public BankAccount(string accNum, string name,int balance)
        {
            this.balance = balance;
            this.accNum = accNum;
            this.name = name;
            balance = 10;
        }
        #endregion
        #region method
        public void OutputMoney(int amount)
        {
            if (balance > amount || overdraftfee)
            {
                this.balance = this.balance - amount;
                Console.WriteLine($"{name}의 계좌 {accNum} 에서 {amount.ToString("c")} 원만큼 출금이 있습니다.\n 잔액은 {Balance.ToString("c")}원 입니다.");//원표시
                return;
            }
            Console.WriteLine("잔액이 부족합니다");
        }

        public void InputMoney(int amount)
        {
            this.balance = this.balance + amount;
            Console.WriteLine($"{name}의 계좌 {accNum} 에서 {amount.ToString("c")} 원만큼 입금이 있습니다.\n 잔액은 {Balance.ToString("c")}원 입니다.");
        }

        public void AddInterest()
        {
            balance += (int)(Balance * interest);
            Console.WriteLine($"{name}의 계좌 {accNum} 에서 {interest*100}% 의이자를 받았습니다.\n 잔액은 {Balance.ToString("c")}원 입니다.");
        }
        
        public void PrintAccInfo()
        {
            Console.WriteLine($"예금주명:{Name}, 계좌번호:{accNum}, 잔액:{balance.ToString("c")}");
        }
        #endregion
    }


    public class Pa
    {
        static void Main()
        {
            BankAccount bank1 = new BankAccount("11-11-11", "사람1");

            bank1.InputMoney(20000);
            bank1.OutputMoney(1000);
            bank1.AddInterest();

            bank1.Name = "개똥이";
            bank1.AccNum = "22-22-22";

            bank1.PrintAccInfo();

            BankAccount bank2 = new BankAccount("33-33-33", "사람2");
            bank2.Name = "싸람2";
            bank2.PrintAccInfo();


            bank2.InputMoney(1000);
            bank2.OutputMoney(100);
        }
    }
} 
