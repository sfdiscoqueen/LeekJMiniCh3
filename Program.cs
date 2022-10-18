// Jasmine Leek
// 18 Oct 2022
// Mini-Challenge #3 "Asking Questions"
// This is a program that asks a user for their name and the time they woke up, 
// then prints out the information in a sentence

Console.Clear();
bool playAgain = true;

while (playAgain)
{
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();

    bool userTime = true;
    while (userTime)
    {
        Console.WriteLine($"What time did you wake up today, {name}?");
        string time = Console.ReadLine();
        DateTime validTime;

        bool success = DateTime.TryParse(time, out validTime);
        if (success)
        {
            Console.WriteLine($"{name} woke up at {time} today.\n");
            userTime = false;
        }
        else
        {
            Console.WriteLine("Please enter the time you woke up as hh:mm");
        }
    }
    Console.Write("Want to play again? \n \nEnter any key to restart or type 'end' to quit: ");

    string ready = Console.ReadLine();
    if (ready == "end")
    {
        playAgain = false;
    }

}