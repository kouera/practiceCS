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






//int n = 0;
//Console.WriteLine("enter an integer ");
//n = Convert.ToInt32(Console.ReadLine());
//while (n != 0)
//{
//    Console.WriteLine("enter an integer ");
//    n = Convert.ToInt32(Console.ReadLine());
//}
//Console.Write(" you are out of the loop");



//int n = 0;

//do
//{
//    Console.WriteLine("enter an integer");
//    n = Convert.ToInt32(Console.ReadLine());
//}
//while (n != 0);
//Console.WriteLine(" you are out of the loop");








//// STRING MANIPULATION

////Example 1:


//string myName;

//Console.WriteLine(" Plesase enter your name and press enter: ");
//myName = Console.ReadLine();

//string myNameUpperCase = string.Format("upper case : {0}", myName.ToUpper());
//string myNameLowerCase = string.Format("lower case: {0}", myName.ToLower());
//string myNameTrimmed = string.Format("trimmed value: {0}", myName.Trim());
//string myNameSubstring = string.Format("Substring value: {0}", myName.Substring(1,5));

//Console.WriteLine(myNameUpperCase);
//Console.WriteLine(myNameLowerCase);
//Console.WriteLine(myNameTrimmed);
//Console.WriteLine(myNameSubstring);



////Example 2:


//Console.WriteLine(" enter a string here :  ");
//string inputString = Console.ReadLine();

//Console.WriteLine("enter a character to search: ");
//// read the character input to search
//char searchInput= Console.ReadLine()[0];

////get the index of the character from string 

//int searchIndex = inputString.IndexOf(searchInput);

//// Prints the Index as a search result on console

//Console.WriteLine(" index of character {0} in string is {1}", searchInput, searchIndex);



////CONCAT


//Console.WriteLine("Enter your first name: \n");
//string firstName = Console.ReadLine();

//Console.WriteLine(" Enter your last name: \n");
//string lastName = Console.ReadLine();

//string fullname = string.Concat(firstName," ", lastName);
//Console.WriteLine(" Your fullname is {0}", fullname);


////Challenge data type variable

//byte myByte = 25;
//Console.WriteLine(myByte);

//sbyte mySbyte = -15;
//Console.WriteLine(mySbyte);

//int myInt = 1245585;
//Console.WriteLine(myInt);

//short myShort = -32768;
//Console.WriteLine(myShort);

//uint myUInt = 85885;
//Console.WriteLine(myUInt);

//ushort myUshort = 65535;
//Console.WriteLine(myUshort);

//float myFloat = 12.8585f;
//Console.WriteLine(myFloat);

//double myDouble = -12.121125548;
//Console.WriteLine(myDouble);

//char myCharacter = 'a';
//Console.WriteLine(myCharacter);

//bool myBoolean = false;
//Console.WriteLine(myBoolean);

//string myString = "I control text";
//Console.WriteLine(myString);

//string myString2 = "15";
//int myNumFromText = int.Parse(myString2); //// alternative : int32.parse(myString2)
//Console.WriteLine(myNumFromText);
//Console.ReadLine();
























   
