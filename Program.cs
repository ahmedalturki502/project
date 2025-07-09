using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // إنشاء القائمة
        List<string> names = new List<string>();

        // إضافة عناصر
        names.Add("Ali");
        names.Add("Sara");
        names.Add("Hamad");

        // طباعة جميع العناصر
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // حذف عنصر
        names.Remove("Sara");

        // طباعة بعد الحذف
        Console.WriteLine("after Delete :");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // التأكد إذا العنصر موجود
        if (names.Contains("Ali"))
        {
            Console.WriteLine("Ali in the list");
        }

        // عدد العناصر
        Console.WriteLine("number of names : " + names.Count);
    }
}
