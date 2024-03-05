using System;
using libPluviometrie;

int[] dijon = { 35, 38, 40, 24, 18, 11, 5, 4, 12, 19, 21, 29 };
int[] beaune = { 31, 35, 38, 25, 19, 10, 6, 5, 13, 17, 20, 27 };
int[] montbard = { 36, 36, 39, 23, 15, 9, 4, 3, 14, 20, 22, 28 };

Pluviometrie cotedor = new Pluviometrie(dijon, beaune, montbard);

Console.WriteLine("1- Voulez vous connaitre la pluviosité par mois ?");
Console.WriteLine("2- Voulez vous connaitre la pluviosité par région ?");
Console.WriteLine("3- Voulez vous connaitre la pluviosité par annuelle ?");

string rep = Console.ReadLine();


switch (rep)
{
    case ("1"):
        cotedor.PluviositeMois();
        break;
    case ("2"):
        cotedor.PluviositeRegion();
        break;
    case ("3"):
        cotedor.PluviositeAnnee();
        break;
  
}