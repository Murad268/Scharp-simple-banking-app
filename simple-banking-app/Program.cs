using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_banking_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string login = "Murad98";
            string password = "12345";
            double balance = 10000.00;

            Console.WriteLine("logininizi daxil edin");
            string InputLogin = Console.ReadLine();
            Console.WriteLine("şifrənizi daxil edin");
            string InputPassword = Console.ReadLine();
            Console.Clear();
            if (login == InputLogin && password == InputPassword)
            {
                BalanceActions:
                Console.WriteLine($"Hesabınız: {balance} AZN - çıxarış etmək üçün 1, balansı artırmaq üçün 2 düyməsini seçin, cışış etmık üçün 3");
                var selectedAction = Console.ReadLine();

                if (int.TryParse(selectedAction, out int action))
                {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("Çıxarış miqdarını daxil edin");
                            double withdrawalBalance = Convert.ToDouble(Console.ReadLine());
                          
                            if (withdrawalBalance > balance)
                            {
                                Console.WriteLine("Hesabınızda kifayət qədər məbləğ yoxdur");
                                Console.Clear();
                                goto BalanceActions;
                            }
                            else
                            {
                                balance -= withdrawalBalance;
                                Console.WriteLine($"Hesabınızdan çıxarış: {withdrawalBalance} AZN. Qalıq məbləğ {balance}");
                                Console.Clear();
                                goto BalanceActions;
                            }

                        case 2:
                            Console.WriteLine("Mədaxil miqdarını daxil edin");
                            double additionBalance = Convert.ToDouble(Console.ReadLine());
                            balance += additionBalance;
                            Console.WriteLine($"Hesabınıza əlavə edildi: {additionBalance} AZN. Qalıq məbləğ {balance}");
                            Console.Clear();
                            goto BalanceActions;
                        case 3:
                            Console.WriteLine("İstifadəçi hesabından çıxış");
                            Console.Clear();
                            goto Start;
                        default:
                            Console.WriteLine("Yanlış əməliyyat");
                            Console.Clear();
                            goto BalanceActions;
                    }
                } else
                {
                    Console.WriteLine("Yanlış əməliyyat");
                    Console.Clear();
                    goto BalanceActions;
                }

            }
            else
            {
                Console.WriteLine("belə bir istifadəçi mövcud deyil");
            
                goto Start;
            }
   
        }
    }
}
