using Hangman;

var man = new Man();
var game = new GameLogic();

run();
void run()
{

    while (game.alive && !game.completed)
    {
        Console.Clear();
        man.showMan(game.errors);
        game.showWord();
        game.promptInput();
        game.checkLetter(game.input);
        game.checkState();
    }

    if (game.completed) Console.WriteLine("Du vant!");
    else Console.WriteLine("Du tapte!");
    Console.ReadKey();
}
