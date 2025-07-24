// Goal: Check the probability of succeeding at different target values if difficulty levels are 2D6, 3D6, 4D6, etc. Display a nice console table.
// Specs:
//  - Simulate rolling n dice (2D6, 3D6…)
//  - For each possible target value, calculate probability of rolling equal to or lower than that value.
//  - Display as a formatted table in console using Console.WriteLine.


Random random = new();
string line = new string('-', 74);
WriteLine("Chance to roll below or equal to a Skill Value(SV)\n");
WriteLine($"{"SV",4}{"1D6",10}{"2D6",10}{"3D6",10}{"4D6",10}{"5D6",10}{"6D6",10}{"7D6",10}");
WriteLine(line);

for(int i = 1;  i <= 25; i++)
{
    Write($"{i,4}");

    int sum;
    int successes;
    for(int j = 1; j <= 7; j++)
    {
        successes = 0;

        for(int k = 1; k <= 10000; k++)
        {
            sum = 0;

            for(int l = 1; l <= j; l++)
            {
                sum += random.Next(1, 7);
            }

            if(sum <= i)
            {
                successes++;
            }
        }

        Write($"{successes/10000.0f, 10:##0.00%}");
    }

    WriteLine();
}

