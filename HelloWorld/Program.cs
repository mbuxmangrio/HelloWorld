using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        { // entry point of execution


            // Type Conversion & Casting.  
            int in1 = 500;
            long lo1;

            lo1 = in1; // automatic casting (Implicit Casting).
            Console.WriteLine(lo1);

            float f1 = 1.4f;
            double d1;

            d1 = f1; // automatic casting (Implicit Casting).
            Console.WriteLine(d1);

            // Manual casting (Explicit Casting).
            int i; // declare an int data type variable
            byte bt; // declare a byte data type variable

            i = 12000; // assign 12000 value to int type i variable

            bt = (byte)i;

            Console.WriteLine($"Explicit casting assigning int 32 bit 12000 value into byte 8 bit size: {bt}");

            long l; // declare a long data type variable
            int il; // declare an int data type variable

            l = 9500000;

            il = (int)l;
            Console.WriteLine(il); // print an int il, no value will be lost
            Console.WriteLine($"Explicit casting assigning int 64 bit size value into int 32 bit size: {il}");

            double dd1; // declare a double data type variable d1
            double d2; // declare a double data type variable d2
            int di; // declare an int data type variable

            dd1 = 54.22; // assign 54.22 value to double data type d1
            d2 = 55.2; // assign 55.2 value to double data type d2

            di = (int)(dd1 + d2);
            Console.WriteLine($"Explicit casting assigning double 32 bit size value into int 32 bit size: {di}");

            int ic; // declare an int data type variable
            char ch; // declare a char (character) data type variable

            ic = 5; // assign 3 value to an int (ic)

            ch = (char)ic;
            Console.WriteLine($"Explicit casting assigning int 32 bit size value into char bit size: {ch}");

            // End of Type Conversion & Casting.


            // 6 - Ternary Operator
            var humanAge = 18;
            var hasJob = true;

            var myAge = 31;

            var r = myAge == 30? 100 : 50;

            Console.WriteLine(r);

            var tResult = humanAge >= 18 && hasJob 
                ? $"He/She is {humanAge} & has job & ready for marriage" 
                : $"He/She is {humanAge} & has not job & not ready for marriage";

            Console.WriteLine($"Ternary Operatort (?:): {tResult}");
            // END

            // 5 - Logical Negation (Not)
            var lN = 12;
            Console.WriteLine($"Logical Negation (Not): {!(lN == 12 && lN > 12)}");
            Console.WriteLine($"Logical Negation (Not): {!true}");


            //END of Logical Negation (Not)

            // 4 - Logical Operators
            var l1 = 20;
            var l2 = 10;

            Console.WriteLine($"Logical OR (||): {l1 == 20 || l2 == 10}");
            Console.WriteLine($"Logical AND (&&): {l1 == 20 && l2 == 10}");

            Console.WriteLine($"Logical OR (||): {l1 == 20 || l2 > 10}");
            Console.WriteLine($"Logical AND (&&): {l1 == 20 && l2 > 10}");

            Console.WriteLine($"Logical OR (||): {l1 != 20 || l2 == 10}");
            Console.WriteLine($"Logical AND (&&): {l1 != 20 && l2 == 10}");

            Console.WriteLine($"Logical OR (||): {l1 != 20 || l2 < 10}");
            Console.WriteLine($"Logical AND (&&): {l1 != 20 && l2 < 10}");

            Console.WriteLine($"Comparing 3 conditions Logical OR (||): {l1 == 20 || l2 > 10 || l2 != 10}"); // return true
            Console.WriteLine($"Comparing 3 conditions Logical AND (&&): {l1 == 20 && l2 == 10 && 10 > 11}"); // return false


            Console.WriteLine($"Comparing 3 conditions Logical OR (||) Logical AND (&&) mixed: {l1 == 20 || (l2 == 5 && l2 > 10) }"); // return false
           // Console.WriteLine($"Comparing 3 conditions Logical AND (&&): {l1 == 20 && l2 == 10 && 10 > 11}"); // return false

            // End of Logical Operators

            // 3 - Relational Operators

            var a = 1;
            var b = 1;

            Console.WriteLine($"Equal to: {500 == 500}"); // this is (500 == 500) called a condition
            Console.WriteLine($"Greater than: {a > b}");
            Console.WriteLine($"Less than: {a < b}");
            Console.WriteLine($"Greater than or equal to: {a >= b}"); // this is a (>= b) called a condition
            Console.WriteLine($"Less than or equal to: {a <= b}");
            Console.WriteLine($"Not equal to: {a != b}");

            // 2 - Compound Assignment Operators

            var val1 = 10;
            var val2 = 5;

            //val1 = val1 + val2;
            val1 += val2;
            Console.WriteLine($"Addition Assignment: {val1}");

            val1 -= val2;
            Console.WriteLine($"Subtraction Assignment: {val1}");

            val1 *= val2;
            Console.WriteLine($"Multiplication Assignment: {val1}");

            val1 /= val2;
            Console.WriteLine($"Division Assignment: {val1}");

            val1 %= val2;
            Console.WriteLine($"Modulo Assignment: {val1}");




            // 1 - Arithmetic Operators

            var v1 = 10;
            var v2 = 5;
            int result;

            result = v1 + v2;
            Console.WriteLine($"Addition (+): {result}");
            
            result = v1 - v2;
            Console.WriteLine($"Subtraction (-): {result}");

            result = v1 * v2;
            Console.WriteLine($"Multiplication (*): {result}");

            result = v1 / v2;
            Console.WriteLine($"Division  (/): {result}");

            result = v1 % v2;
            Console.WriteLine($"Modulo (%): {result}");

            var number = 10;
            Console.WriteLine($"Actual number variable: {number}");

            // pre-increment-> ++ number
            // post-increment-> number ++

            // pre-decrement-> -- number
            // post-decrement-> number --

            --number;
            //++number;

            Console.WriteLine($"Update number variable: {number}");

            number--;
            Console.WriteLine($"Update number variable: {number}");

            Console.WriteLine($"Update number variable: {++number}");


            //Console.WriteLine($"Update number variable: {number}");
            // strict types is being checked at compile type.
            string cast, education, address, email; // declare 2 variables name and cast of type string.

            cast = "Mangrio";
            education = "Computer Science";
            address = "Vill: \n Haji wali Muhammad mangrio";

            var name = "\"Eng.\" Muhammad Bux";
            int age;
            long mobileNo;

           // name = "\"Eng.\" Muhammad Bux";
           

            mobileNo = 03423278134;
            humanAge = 31;
            humanAge = 21;

            // Dynamic types is not being checked at compile time but at runtime.
            // Following are implicitly typed variables.

            var rollNo = "aijaz";

            var d = 33.4;
            var price = 44.56m;
            var isOlder = false;
            var age2 = 30;

            cast = "Brohi";
            //int age;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Cast: {cast}");
            Console.WriteLine($"Education: {education}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Age: {humanAge}");
            Console.WriteLine($"Mobile#: {mobileNo}");

            // C# Type Conversion in-built Methods.

            var a1 = 0;
            var a2 = 45.67;
            var a3 = 34500;

            Console.WriteLine($"Convert an int into boolean: {Convert.ToBoolean(a1)}");
            Console.WriteLine($"Convert a double into an int: {Convert.ToInt32(a2)}");
            Console.WriteLine($"Convert an int into an string: {Convert.ToString(a3) + 100}");

            const double pi = 3.14;
            Console.WriteLine($"CONST PI: {pi}");

            const string stdName = "AIJAZ ALI";
            Console.WriteLine($"CONST stdName: {stdName}");

            //Console.Write("Enter Your Name: ");
            //string? inputName = Console.ReadLine();
            //Console.WriteLine(inputName);

            //Console.Write("Enter Value 1: ");
            //var inputV1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Value 2: ");
            //var inputV2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Addition (+): {inputV1 + inputV2}");
            //Console.WriteLine($"Substraction (-): {inputV1 - inputV2}");
            //Console.WriteLine($"Multiplication (x): {inputV1 * inputV2}");
            //Console.WriteLine($"Division (/): {inputV1 / inputV2}");
            //Console.WriteLine($"Remainder (%): {inputV1 % inputV2}");

            // C# Control Statement
            // if () { } statement
            //var var1 = 10;

            //if (var1 == 10 && var1 < 9)
            ////if (false)
            //{ // scope of if starts
            //    Console.WriteLine("if statement 1 is true");
            //    Console.WriteLine("if statement 2 is true");
            //    Console.WriteLine("if statement 3 is true");
            //} // scope of if ends
            //else
            //{
            //    Console.WriteLine("if statement is false and this is else 1");
            //    Console.WriteLine("if statement is false and this is else 2");
            //    Console.WriteLine("if statement is false and this is else 3");
            //}

            // Nested if () { } statements

            //var userName = "aijaz";
            //var pass = "123";

            //if (userName == "aijaz")
            //{ // Outer if scope
            //    if (pass == "123")
            //    { // Inner if scope

            //        Console.WriteLine($"You are authenticated! WELCOME {userName}");

            //    } // End Inner if scope
            //    else
            //    {
            //        Console.WriteLine("INVALID password!");
            //    }

            //} // End Outer if scope
            //else
            //{
            //    Console.WriteLine("INVALID username!");
            //}


            // IF-else-if ladder Statement
            //char grade = 'B';

            //if (grade == 'A')
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (grade == 'B')
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (grade == 'C')
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else if (grade == 'D')
            //{
            //    Console.WriteLine("Grade D");
            //}
            //else if (grade == 'E')
            //{
            //    Console.WriteLine("Grade E");
            //}
            //else
            //{
            //    Console.WriteLine("SORRY! no Grading could matched!");
            //}


            int num = 49;

            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }

            // Start switch statement

            var myGrade = '#';

            switch (myGrade)
            {
                case 'A':
                case '$':
                    Console.WriteLine("switch Grade A");
                    break;

                case 'B':
                case '*':
                    Console.WriteLine("switch Grade B");
                    break;

                case 'C':
                    Console.WriteLine("switch Grade C");
                    Console.WriteLine("switch Grade C 2nd statement");
                    break;

                case 'D':
                    Console.WriteLine("switch Grade D");
                    break;

                case 'F':
                    Console.WriteLine("switch Grade F");
                    break;

                default:
                    Console.WriteLine("No case with any grade could be matched!");
                    break;
            }

            // user password code using switch statement.

            var suserName = "aijaz";
            var spass = "123";

            switch (suserName)
            {
                case "aijaz":
                    switch (spass)
                    {
                        case "123":
                            Console.WriteLine($"You are authenticated! WELCOME {suserName}");
                            break;

                        default:
                            Console.WriteLine("INAVLID password!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("INAVLID username!");
                    break;
            }

            Console.WriteLine("This statement does not belong with above switch!");


        } // ENd of main method scope
    }
}