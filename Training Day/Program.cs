

// These are the variables assigned for the question above

string userName = "";

bool NameIsRight = false;


while (!NameIsRight)
{
    Console.WriteLine("Please enter your userName");
    
    userName = Console.ReadLine();

    bool isnull = string.IsNullOrEmpty(userName);

    if (!isnull)
    {
      
        if (!userName.All(char.IsDigit))
        {

            NameIsRight = true; 
        }
    }
    
}

bool AgeIsRight = false;

while (!AgeIsRight)
{
    Console.WriteLine("Please enter your age, " + userName);

    int age = Convert.ToInt32(Console.ReadLine());

    if (age < 16)
    {
        Console.WriteLine("Sorry, you do not fit the age criteria to proceed " + userName);

    }
    else {
        Console.WriteLine("Welcome to the Shinobi game " + userName);

        AgeIsRight = true;
    }
}

int UserEntry; 

bool numberEntry = false;



while (!numberEntry)
{

    Console.WriteLine(userName + " please enter a betwwen 1 and 10");

    UserEntry = int.Parse(Console.ReadLine());

    string[] Shinobis = new string[UserEntry];

    if (UserEntry < 10 && UserEntry > 0)
    {

        Console.WriteLine($"Well done,{userName}");


        numberEntry = true;

        for (int i = 0; i < Shinobis.Length; i++)
        {
            Console.WriteLine($"Enter the name of shinobis from Naruto { i + 1}:");
            Shinobis[i] = Console.ReadLine();

        }

        Console.WriteLine("Well Done buddy");

           }

    else
    { 
        Console.WriteLine("you did not understand the assignemnt,");

    }
}










