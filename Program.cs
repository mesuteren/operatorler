﻿using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           // Atama ve işlemli Atama
           int x =3;
           int y =3;
           y = y+2;
           Console.WriteLine(y);
           y += 2;
           Console.WriteLine(y);
           y/=1;
           Console.WriteLine(y);
           x *=2;
           Console.WriteLine(x);

           //Mantıksal Operatörler
           //||,&&, !

           bool isSuccess = true;
           bool isCompleted = false;

           if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess||isCompleted)
                Console.WriteLine("Great!");
            
             if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            //İlişkisel Operatörler
            //<,>,>=,<=,==,!=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc =a>=b;
            Console.WriteLine(sonuc);
            sonuc =a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            // /, *, +, -,
            int sayi =10;
            int sayi2=5;
            int sonuc1 =sayi/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi++;
            Console.WriteLine(sonuc1);

            //% : mod alır
            int sonuc2 =20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
