// Goal: Practice variables, data types, console input/output, and conditionals.
// Specs:
//  - Program generates a random number (1–100).
//  - User guesses until correct.
//  - Display hints (higher/lower).
//  - Track number of attempts and display them at the end.


Random random = new();
int number = random.Next(1, 101);
int guess = 0;
int guesses = 0;


WriteLine("Guess a number between 1 and 100 ");

while (true)
{
    Write("Guess: "); 
    if(!Int32.TryParse(ReadLine(), out guess) || guess < 1 || guess > 100)
    {
        WriteLine("Guess a number between 1 and 100 ");
        continue;
    }

    guesses++;
    if(guess == number)
    {
        break;
    }
    
    if (guess < number)
    {
        WriteLine("Your guess was too low");
    }
    else
    {
        WriteLine("Your guess was too high");
    }
        
}

WriteLine($"Congratulations! It took you {guesses} guesses to find my number!");



