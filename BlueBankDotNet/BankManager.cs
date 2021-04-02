using BlueBankDotNet.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBankDotNet
{
    static class BankManager
    {
        public static void InitProgram()
        {
            int command = 5;
            Console.WriteLine("<<< ✤ BEM VINDO AO BANCO BLUE, SEU AZULZINHO ✤ >>>");
            Account account = CreateAccount();
            while (command != 0) {
                Console.WriteLine("<<< ✤ ESCOLHA ENTRE AS OPÇÕES: 1 - SAQUE | 2 - DEPÓSITO | 3 - CONSULTA SALDO | 4 - CONSULTA DADOS | 5 - ALTERA DADOS | 0 - SAIR ✤ >>>");
                command = Convert.ToInt32(Console.ReadLine());
                if (command == 1)
                {
                    Console.WriteLine("<<< ✤ DIGITE O VALOR DO SAQUE: ✤ >>>");
                    float value = float.Parse(Console.ReadLine());
                    Saque(account, value);
                } else if (command == 2)
                {
                    Console.WriteLine("<<< ✤ DIGITE O VALOR DO DEPÓSITO: ✤ >>>");
                    float value = float.Parse(Console.ReadLine());
                    Deposito(account, value);
                } else if (command == 3)
                {
                    ConsultaSaldo(account);
                } else if (command == 4)
                {
                    MostrarDados(account);
                } else if (command == 5)
                {
                    AlteraDados(account);
                } else if (command == 0)
                {
                    return;
                } else
                {
                    Console.WriteLine("<<< ✤ OPÇÃO INVÁLIDA! ✤ >>>");
                }


            }
        }

        public static Account CreateAccount()
        {
            float balance = 1000;

            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("O nome não pode estar vazio, digite um novo nome: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Digite sua senha: ");
            string password = Console.ReadLine();

            while (password.Length < 6)
            {
                Console.WriteLine("Sua senha deve ter, no mínimo 6 caracteres, digite uma nova senha: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Digite sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            while (age <= 14)
            {
                Console.WriteLine("Idade mínima de 15 anos, digite uma nova idade: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite seu endereço: ");
            string address = Console.ReadLine();

            while (address == "")
            {
                Console.WriteLine("Endereço inválido. Digite um novo endereço: ");
                address = Console.ReadLine();
            }

            Account account = new Account(name, password, age, address, balance);
            return account;
        }

        public static void Saque(Account account, float valorSaque)
        {
            if (account.Balance - valorSaque < -500.0)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            account.updateBalance(account.Balance - valorSaque);

        }
        public static void Deposito(Account account, float valorDeposito)
        {
            account.updateBalance(account.Balance + valorDeposito);
        }

        public static void ConsultaSaldo(Account account)
        {
            Console.WriteLine(account.Balance);
        }

        public static void AlteraDados(Account account)
        {
            Console.WriteLine("Qual dado você deseja alterar? Nome | Idade | Endereço");
            string option = Console.ReadLine();

            if (option == "Nome")
            {
                Console.WriteLine("Digite o novo nome: ");
                string newName = Console.ReadLine();
                account.updateName(newName);
            }
            else if (option == "Idade")
            {
                Console.WriteLine("Digite a nova idade: ");
                int newAge = Convert.ToInt32(Console.ReadLine());
                account.updateAge(newAge);
            }
            else if (option == "Endereço")
            {
                Console.WriteLine("Digite o novo endereço: ");
                string newAddress = Console.ReadLine();
                account.updateAddress(newAddress);
            }
        }

        public static void MostrarDados(Account account)
        {
            Console.WriteLine("Nome: "+account.Name);
            Console.WriteLine("Idade: "+account.Age);
            Console.WriteLine("Endereço: "+account.Address);
        }
    }
}
