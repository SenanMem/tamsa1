using Base;
using Employer;
using System;
using System.Collections.Generic;
using System.Text;
using _Worker;
using Exception_;

namespace Boss.az
{
    static class StaticHelper
    {
        public static int staticUserID { get; set; } = 1; 
        public static int staticCategoryID { get; set; } = 1; 

    }
    public class _Start
    {
        private StringBuilder login { get; set; } = new StringBuilder();
        private StringBuilder password { get; set; } = new StringBuilder();
        private DataBase Base = new DataBase();
        private string selection { get; set; }
        public void Start_()
        {
            while (true)
            {
                Console.WriteLine($"1. Sign up");
                Console.WriteLine($"2. Sign in");
                Console.WriteLine($"3. Info");
                Console.WriteLine($"4. Chat Bot");
                Console.WriteLine($"5. ADV(Advertising)");
                Console.Write($"Enter : ");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    StartSignUp();
                    StartSignIn();
                }
                else if (selection == "2")
                {
                    StartSignIn();
                }
                else if (selection == "3")
                {
                    StartInfo();
                }
                else if (selection == "4")
                {
                    StartChatBot();
                }
                else
                {
                    Error();
                    continue;
                }
            }
        }
        #region StartSignUp
        public void StartSignUp()
        {
            while (true)
            {
                Console.WriteLine($"1. Isci");
                Console.WriteLine($"2. Is veren");
                Console.Write("Enter the section : ");
                selection = Console.ReadLine();
                if (selection == "1" || selection == "2")
                {
                    login.Clear();
                    password.Clear();
                    Console.Write("Enter the name : ");
                    login.Append(Console.ReadLine());
                    Console.Write("Enter the password : ");
                    password.Append(Console.ReadLine());
                    if (MyExceptionClass.isValidName(login.ToString(), nameof(login)) && MyExceptionClass.isValidName(password.ToString(), nameof(password)))
                    {
                        if (selection == "1")
                        {
                            addWorker(login, password);
                            break;
                        }
                        else if (selection == "2")
                        {
                            addEmployer(login, password);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Login or password error");
                    }
                }
                else Error();
            }
        }
        public void addWorker(StringBuilder _login, StringBuilder _password)
        {
            Base.workers.Add(new Worker
            {
                ID = StaticHelper.staticUserID.ToString(),
                login = _login,
                password = _password,
            });
            StaticHelper.staticUserID++;
        }
        public void addEmployer(StringBuilder _login, StringBuilder _password)
        {
            Base.employers.Add(new _Employer
            {
                ID = StaticHelper.staticUserID.ToString(),
                login = _login,
                password = _password,
            });
            StaticHelper.staticUserID++;
        }
        #endregion
        #region StartSignIn

        public void StartSignIn()
        {

            while (true)
            {
                int i = 0;
                bool search = false;
                login.Clear();
                password.Clear();
                Console.Write("Enter login    : ");
                login.Append(Console.ReadLine());
                Console.Write("Enter password : ");
                password.Append(Console.ReadLine());
                foreach (var worker in Base.workers)
                {
                    if(login==worker.login && password == worker.password)
                    {
                        search = true;
                        StartWorker(i);
                        break;
                    }
                    i++;
                }
                if (!search)
                {
                    i = 0;
                    foreach (var employer in Base.employers)
                    {
                        if (login == employer.login && password == employer.password)
                        {
                            search = true;
                            StarEmployer();
                            break;
                        }
                        i++;
                    }
                }
                else if (!search)
                {
                    i = 0;
                    foreach (var admin in Base.admins)
                    {
                        if (login == admin.login && password == admin.password)
                        {
                            search = true;
                            StartAdmin();
                            break;
                        }
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine($"Login or password error!!!");
                    continue;
                }
                break;
            }
        }
        #region StartWorker
        public void StartWorker(int index)
        {
            while (true)
            {
                Console.WriteLine("1. Message box");
                Console.WriteLine("2. Look at your ads");
                Console.WriteLine("3. See job postings");
                Console.WriteLine("4. Create an ad");
                Console.Write("Enter : ");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    foreach(var keyValue in Base.workers[index].messageBoxes)
                    {
                        Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
                    }
                }
                else if (selection == "2")
                {
                    foreach (var CV in Base.workers[index].CVs)
                    {
                        foreach (var item in CV) 
                        {
                        }
                    }
                }
                else if (selection == "3")
                {

                }
                else if (selection == "4")
                {

                }
                else
                {
                    Console.WriteLine("Yalnis secim");
                }
            }
        }

        #endregion
        public void StarEmployer()
        {

        }
        public void StartAdmin()
        {

        }
        #endregion
        public void StartInfo() { }
        public void StartChatBot() { }
        public void Error()
        {

        }


    }
}
