/* Console.Write("enter a string ");
string readInput = Console.ReadLine();
Console.WriteLine("you have entred {0}",readInput);

Console.Write(" Enter a string and press enter: ");
int asciiValue = Console.Read();
Console.WriteLine("ASCII value is {0}", asciiValue);
Console.ReadKey()*/



//Console.Write("Write your first name:  ");
//String firstname = Console.ReadLine();

//Console.Write("Write your last name:  ");
//String lastname = Console.ReadLine();

//string fullname = firstname + " " +lastname;
//Console.WriteLine("your full name is: " + fullname);
//Console.WriteLine("the lenghth of the string is "+ fullname.Length);




//Console.WriteLine("enter your age");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("your age is : " + age + " years old");




//string fname = Console.ReadLine();
//if (fname == "")
//    Console.WriteLine("please enter a correct name: ");
//else
//    Console.WriteLine("Thank you");

//return;


// -----------------if else Statemet--------------------

//int time = 22;
//if (time < 12)
//{
//    Console.WriteLine("Good day!");
//}
//else if (time > 12 && time <=20)
//{
//    Console.WriteLine("Good evening");
//}
//else
//{
//    Console.WriteLine("Good night");
//}




// --Ternary Operator  ---  variable = (condition) ? expressionTrue :  expressionFalse;
//int Tid = 16;

//string result = (Tid < 18) ? "good day" : "good evening";
//Console.WriteLine(result);




//// check whether a given number is even or odd
//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)

//    Console.WriteLine(" {0} is an even number", num);
//else

//    Console.WriteLine("{0} is an odd number", num);


// check whether a given number is positive or negative
//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num <0)

//    Console.WriteLine(" {0} is negative", num);
//else

//    Console.WriteLine("{0} is an positive", num);





//---------- switch------------------ 

//Console.WriteLine(" Give a number from 1-7 to get its relative week day");
//int day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;

//    case 2:
//        Console.WriteLine("Tuesday");
//        break;

//    case 3:
//        Console.WriteLine("Wednesday");
//        break;

//    case 4:
//        Console.WriteLine("Thursay");
//        break;

//    case 5:
//        Console.WriteLine("Friday");
//        break;

//    case 6:
//        Console.WriteLine("Saturday");
//        break;

//    case 7:
//        Console.WriteLine("Sunday");
//        break;

//    default:
//        Console.WriteLine("your number doesn't match");
//        break ;
//}




// --------- while loop ------- MULTIPLICATION TABLE


//int number, i, result;

//Console.WriteLine(" The multiplication table \n " +
//                    "---------------------- \n " +
//                    " Please enter a number :   ");
//number = Convert.ToInt32(Console.ReadLine());

//i = 1;

//while (i <= 10) 
//{
//    result = number * i;
//    Console.WriteLine("{0} x  {1}  = {2}", number, i, result);
//    i++;

//}

//Console.ReadLine();







Console.WriteLine("enter an integer ");
int n = Convert.ToInt32(Console.ReadLine());
while (n != 0)
{
    Console.WriteLine("enter an integer ");
    n =  Convert.ToInt32(Console.ReadLine());
}
Console.Write(" you are out of the loop");





 





