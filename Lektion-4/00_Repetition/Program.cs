/*
 

    Objektorienterad Programmering (OOP)
    ---------------------------------------------------------------------
    Encapsulation
    Inheritance
    Polymorphism
    Abstraction
 
 
    Klasser/Classes (Encapsulation)
    -------------------------------------------------------
    C#          Participant participant = new Participant();
                class Participant 
                {
                    public string FirstName { get; set; }
                    public string LastName { get; set; }
                    public string Email { get; set; }
                    public string SpecialRequests { get; set; }
                }
    Exempel GET:        Console.WriteLine(participant.FirstName);
    Exempel SET:        participant.FirstName = "Hans";

        MVC (Model, View, Controller)
        -----------------------------------------------------------------
        Model       = en speciell klass för ett speciellt ändamål
        View        = en speciell sida såsom en produktsida
        Controller  = en kontroller som bryggar ihop modellen med vyn


    Helpers / Handlers/Services = är klasser som hjälper oss att göra olika metoder.
    Models = är modeller dvs klasser över objekt som vi använder oss utav. En del av MVC (Model View Controller).
    Class = är en mall/modell över hur ett objekt ser ut. Kan vara vad som helst.  
*/

using _00_Repetition.Handlers;


int Option = -1;
do
{
    Option = MenuHandler.Menu();
    Console.Clear();

    switch(Option)
    {
        case 1:
            MenuHandler.MenuOption_Create();
            break;

        case 2:
            MenuHandler.MenuOption_Remove();          
            break;

        case 3:
            MenuHandler.MenuOption_List();           
            break;

        default:
            break;
    }
    Console.Clear();


}
while (Option != 0);