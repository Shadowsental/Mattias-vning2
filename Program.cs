using System;
using System.Collections.Generic;
using System.Linq;

namespace MattiasÖvning2
{
    class Person
    {
        int age;
        int agePrice;
        string personPrice;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int AgePrice
        {
            get { return agePrice;  }
            set { agePrice = value; }
        }

        public string PersonPrice
        {
            get { return personPrice; }
            set { personPrice = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personGroup = new List<Person>();
            List<int> ageSum = new List<int>();
            List<string> repeatThis = new List<String>();
            string splitThis;
            bool isOn = true;
            while (isOn == true)
            {

                Console.WriteLine("Welcome to the Main Menu. You have a selection of menus that will do different things. Type in a number to view them. \n Menu 1: Buy tickets. \n Menu 2: Repeat words ten times. \n Menu 3: Split words.");
                Console.Write("Enter a number to view something really cool: ");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 0:
                        isOn = false;
                        break;

                    case 1:
                        string ageGroup;
                        bool addPerson = true;
                        while (addPerson == true)
                        {
                            Console.WriteLine("Welcome to the Big Cinematic Theater. The costs of a ticket depends on a persons age. Enter a number to do the following" +
                                "\n 1: Buy Tickets. \n 2: Add the total up. \n 3: Remove the group. \n 0 Close tab.");
                            Console.Write("Enter a number: ");
                            int number = int.Parse(Console.ReadLine());

                            switch (number)
                            {
                                case 0:
                                    addPerson = false;
                                    break;
                                case 1:
                                    Console.Write("Type in your age to determine price. ");
                                    Person thisPerson = new Person();
                                    int myAge = int.Parse(Console.ReadLine());


                                    thisPerson.Age = myAge;
                                    if (thisPerson.Age <= 20)
                                    {
                                        thisPerson.AgePrice = 80;
                                        ageGroup = "Ungdomspris: ";
                                        personGroup.Add(new Person() { Age = myAge, AgePrice = thisPerson.AgePrice, PersonPrice = ageGroup });
                                        ageSum.Add(thisPerson.AgePrice);
                                        Console.WriteLine($"{ thisPerson.Age}. {ageGroup} { thisPerson.AgePrice }kr");
                                    }

                                    else if (thisPerson.Age >= 64)
                                    {
                                        thisPerson.AgePrice = 90;
                                        ageGroup = "Pensionärspris: ";
                                        personGroup.Add(new Person() { Age = myAge, AgePrice = thisPerson.AgePrice, PersonPrice = ageGroup });
                                        ageSum.Add(thisPerson.AgePrice);
                                        Console.WriteLine($"{ thisPerson.Age}. {ageGroup} { thisPerson.AgePrice }kr");
                                    }

                                    else
                                    {
                                        thisPerson.AgePrice = 120;
                                        ageGroup = "Standardpris: ";
                                        personGroup.Add(new Person() { Age = myAge, AgePrice = thisPerson.AgePrice, PersonPrice = ageGroup });
                                        ageSum.Add(thisPerson.AgePrice);
                                        Console.WriteLine($"{ thisPerson.Age}. {ageGroup} { thisPerson.AgePrice }kr");
                                    }
                                    break;
                                case 2:
                                    int sum = ageSum.Sum();
                                    Console.WriteLine($"Number of people: {personGroup.Count}. Total price: {sum}.");
                                    break;
                                case 3:
                                    personGroup.Clear();
                                    break;
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Here you can repeat a word ten times. Type in a word or number to repeat.");
                        Console.Write("Repeat this: ");
                        string repeat = Console.ReadLine();

                        for (int i = 0; i < 1; i++)
                        {
                            Console.WriteLine(string.Concat(Enumerable.Repeat($"{repeat}, \t", 10)));
                        }
                        break;

                    case 3:
                        Console.WriteLine("Here we will split sentences and output the third word in the sentence.");
                        Console.Write("Write a sentence to split: ");
                        splitThis = Console.ReadLine();
                        string[] subs = splitThis.Split(' ');
                        for (int i = 0; i < subs.Length - 2; i += 3)
                            {
                                Console.WriteLine(subs[i]);
                            }
                        break;

                    default:
                        Console.WriteLine("That input is illegal.");
                        break;
                }
            }
        }
    }
}
