﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Seminar_1.Models;
using Seminar_1.Servises;

namespace Seminar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember familyMember9 = new FamilyMember()
            {
                Name = "Екатерина",
                SurName = "Петрова",
                DateOfBirth = new DateTime(1925, 09, 18),
                Gender = Gender.Female
            };
            //прабабушка по линии отца

            FamilyMember familyMember10 = new FamilyMember()
            {
                Name = "Владимир",
                SurName = "Петров",
                DateOfBirth = new DateTime(1920, 05, 17),
                Gender = Gender.Male
            };
            //прадедушка по линии отца

            familyMember9.Spouse = familyMember10;
            familyMember10.Spouse = familyMember9;

            FamilyMember familyMember11 = new FamilyMember()
            {
                Name = "Валентина",
                SurName = "Малышева",
                DateOfBirth = new DateTime(1923, 04, 20),
                Gender = Gender.Female
            };
            //прабабушка по линии матери

            FamilyMember familyMember12 = new FamilyMember()
            {
                Name = "Владислав",
                SurName = "Малышев",
                DateOfBirth = new DateTime(1928, 03, 17),
                Gender = Gender.Male
            };
            //прадедушка по линии матери

            familyMember11.Spouse = familyMember12;
            familyMember12.Spouse = familyMember11;

            FamilyMember familyMember5 = new FamilyMember()
            {
                Name = "Екатерина",
                SurName = "Петрова",
                DateOfBirth = new DateTime(1952, 09, 20),
                Gender = Gender.Female,
                Father = familyMember12,
                Mother = familyMember11
            };
            //бабушка по линии матери

            FamilyMember familyMember6 = new FamilyMember()
            {
                Name = "Владимир",
                SurName = "Петров",
                DateOfBirth = new DateTime(1950, 05, 17),
                Gender = Gender.Male,
                Father = familyMember10,
                Mother = familyMember9
            };
            //дедушка по линии матери

            familyMember5.Spouse = familyMember6;
            familyMember6.Spouse = familyMember5;

            FamilyMember familyMember7 = new FamilyMember()
            {
                Name = "Валентина",
                SurName = "Иванова",
                DateOfBirth = new DateTime(1955, 04, 20),
                Gender = Gender.Female
            };
            //бабушка линии отца

            FamilyMember familyMember8 = new FamilyMember()
            {
                Name = "Максим",
                SurName = "Иванов",
                DateOfBirth = new DateTime(1954, 03, 17),
                Gender = Gender.Male
            };
            //дедушка по линии отца

            familyMember7.Spouse = familyMember8;
            familyMember8.Spouse = familyMember7;

            FamilyMember familyMember1 = new FamilyMember()
            {
                Name = "Иван",
                SurName = "Иванов",
                DateOfBirth = new DateTime(1989, 12, 25),
                Gender = Gender.Male,
                Mother = familyMember7,
                Father = familyMember8
            };
            //отец

            FamilyMember familyMember2 = new FamilyMember()
            {
                Name = "Мария",
                SurName = "Иванова",
                DateOfBirth = new DateTime(1992, 07, 25),
                Gender = Gender.Female,
                Mother = familyMember5,
                Father = familyMember6
            };
            //мать

            familyMember1.Spouse = familyMember2;
            familyMember2.Spouse = familyMember1;

            var familyMember3 = new FamilyMember()
            {
                Name = "Алексей",
                SurName = "Иванов",
                DateOfBirth = new DateTime(2020, 08, 05),
                Gender = Gender.Male,
                Mother = familyMember2,
                Father = familyMember1
            };
            //сын

            var familyMember4 = new FamilyMember()
            {
                Name = "Мария",
                SurName = "Иванова",
                DateOfBirth = new DateTime(2018, 03, 10),
                Gender = Gender.Female,
                Mother = familyMember2,
                Father = familyMember1
            };
            //дочь



            var service = new FamilyMemberService();
            service.AddPerson(familyMember12, familyMember11, familyMember10, familyMember9, familyMember8, familyMember7,
                familyMember6, familyMember5, familyMember4, familyMember3, familyMember2, familyMember1);


            //все дедушки
            Console.WriteLine($"Все дедушки для :\t{familyMember3.SurName} {familyMember3.Name} ");
            foreach (var member in service.GetGrandFathers(familyMember3))
            {
                Console.Write(member);
            }
            Console.WriteLine();
            
            //родственник с максимальным возрастом
            Console.WriteLine($"Максимальный возраст у:\n{service.OldFamilyMember()}");
            Console.WriteLine();

            //супруг/супруга
            Console.WriteLine($"Супруг/Супруга для :\t{familyMember1.Name} {familyMember1.SurName}\n" +
                $"{service.GetSpouse(familyMember1)}");
            Console.WriteLine();
            
            //дедушки супруга
            Console.WriteLine($"Все дедушки для :\t{service.GetSpouse(familyMember1).Name} {service.GetSpouse(familyMember1).SurName} ");
            foreach (var member in service.GetGrandFathers(service.GetSpouse(familyMember1)))
            {
                Console.Write(member);
            }
            Console.WriteLine();
            
            //бабушки супруга
            Console.WriteLine($"Все бабушки для :\t{service.GetSpouse(familyMember1).Name} {service.GetSpouse(familyMember1).SurName} ");
            foreach (var member in service.GetGrandMothers(service.GetSpouse(familyMember1)))
            {
                Console.Write(member);
            }
            Console.WriteLine();
        }
    }
}
