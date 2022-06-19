using System;

namespace hometask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person name = new Person(GetCommand("personName"));
                                     GetCommand("personSurname");
                                     GetCommand("personFatherName");
                                     GetCommand("personAge");
                                     GetCommand("personFIN");
                                     GetCommand("personPhoneNumber");
                                     GetCommand("personPosition");
                                     GetCommand("personSalary");
            name.LengthProblem
        }

        public static string GetCommand(string text)
        {
            Console.WriteLine(text);
            return GetCommand(Console.ReadLine());
        }
        class Person
        {
            public string _personName;
            public string _personSurname;
            public string _personFatherName;
            public int _personAge;
            public string _personFIN;
            public string _personPhoneNumber;
            public string _personPosition;
            public string _personSalary;

            public Person(string personName, string personSurname, string personFatherName, int personAge, string personFIN, string personPhoneNumber, string personPosition, string personSalary)
            {
                _personName = personName;
                _personSurname = personSurname;
                _personFatherName = personFatherName;
                _personAge = personAge;
                _personFIN = personFIN;
                _personPhoneNumber = personPhoneNumber;
                _personPosition = personPosition;
                _personSalary = personSalary;

            }
            public bool FirstNamethod(string targetName)
            {
                string targetName = _personName;
                if (targetName.Length > 2 && targetName.Length < 20)
                {
                    return true;
                }
            }
            public bool econdNameMethod(string personName)
            {
                string targetName = _personName;
                char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                for (int i = 0; i < alphabet.Length; i++)
                {
                    for (int k = 0; k < targetName.Length; k++)
                    {
                        if (personName[k] == alphabet[k])
                        {
                            Console.WriteLine("incorrect");
                            return true;
                        }
                    }
                }
            }
        }


    }
}
