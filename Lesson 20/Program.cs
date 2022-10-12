﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string _str = string.Empty;

            if (string.IsNullOrEmpty(_str)) //Проверка совпадения переменной с null
            {
                _str = "Example app";
                Console.WriteLine(_str); 
            }

            if (_str.Contains("app")) //Contains выполняет функцию поиска символов 
            {
                string _str1 = _str.Replace('m', '1'); //Replace замена старого символа на новый
                Console.WriteLine(_str1);
                _str = _str.ToLower();
                Console.WriteLine(_str);
                _str = _str.ToUpper();
                Console.WriteLine(_str);
            }

            _str = _str.Substring(8, 3); //Substring Возврат части символов
            Console.WriteLine(_str);
        }
    }
}
