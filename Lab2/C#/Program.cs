﻿using System;

namespace Lab2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var set1 = "qwerty".ToCharArray();
            var set2 = "ery".ToCharArray();
            var set3 = "qwrrqwety".ToCharArray();
            
            var str1 = new MyString(set1); var str2 = new MyString(set2); var str3 = new MyString(set3);
            var text = new MyText();
            
            text.AddString(str1); text.AddString(str2); text.AddString(str3); 
            text.AddString(str1); text.AddString(str2); text.AddString(str3);
            text.Write();
            
            Console.WriteLine(text.AverageLength());
            Console.WriteLine(text.PercentOfVowel());
            
            text.RemoveString(1);
            text.Write();
            text.RemoveString("ery");
            text.Write();
            text.EraseText();
            text.Write();
        }
    }
}