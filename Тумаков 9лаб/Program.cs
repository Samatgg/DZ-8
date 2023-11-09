using System;
using System.Collections.Generic;

namespace Тумаков_9лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упр 9.1 - Создать конструкторы для баланса,типа банк.счета
            Console.WriteLine("Упр 9.1 - Создать конструкторы для баланса,типа банк.счета\n");
            BankAccount firstAccount = new BankAccount(BankType.Зарплатный,26000);
            BankAccount secondAccount = new BankAccount(BankType.Сберегательный,12000);
            BankAccount thirdAccount = new BankAccount(BankType.Общий,2000);
            firstAccount.Print();
            secondAccount.Print();
            thirdAccount.Print();


            // Упр 9.2 - При изменении баланса счета создается новый объект класса BankTransaction
            Console.WriteLine("\nУпр 9.2 - При изменении баланса счета создается новый объект класса BankTransaction\n");
            BankAccount account = new BankAccount();
            account.DepositMoney(1000);
            account.WithdrawMoney(784);
            /*foreach (BankTransaction transaction in accountt.history())
            {
                Console.WriteLine("Когда: {0}, Рублей: {1}", transaction.TransactionDateTime, transaction.Amount);
            }
            */


            // Упр 9.3 - Создать метод Dispose, который данные о проводках из очереди запишет в файл.
            Console.WriteLine("\nУпр 9.3 - Создать метод Dispose, который данные о проводках из очереди запишет в файл.\n");
            BankAccount fifthAccount = new BankAccount();
            fifthAccount.DepositMoney(1000);
            fifthAccount.WithdrawMoney(200);
            fifthAccount.Dispose();


            // Дз 9.1 - параметры конструктора – название и автор песни, указатель на предыдущую песню,В методе Main
            // создать объект mySong.
            Console.WriteLine("\nДз 9.1 - параметры конструктора – название и автор песни, указатель на предыдущую песню,в методе Main создать объект mySong.");
            List<Song> songs = new List<Song>();
            Song mySong = new Song();
            Song s1 = new Song("Пополам","MACAN");
            Song s2 = new Song("KARI", "BigBabyTape");
            Song s3 = new Song("Раньше", "Jamik", s2);
            Song s4 = new Song("Патрон", "Miyagi", s3);
            string first = s1.PrintTitle();
            string second = s2.PrintTitle();
            string third = s3.PrintTitle();
            string fourth = s4.PrintTitle();
            songs.Add(s1);
            songs.Add(s2);
            songs.Add(s3);
            songs.Add(s4);          
            bool equal = s1.Equals(s2);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine("1 и 2 песня совпадает?\nОтвет: " + equal);
        }
    }
}
