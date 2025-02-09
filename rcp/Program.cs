string[] words = {"Камень","Ножницы","Бумага","Огонь","Вода"};
Random random = new Random();
Console.WriteLine("Добро пожаловать в раширеную игру 'Камень,ножницы,бумага,огонь,вода'");
int playerWins = 0;
int computerWins = 0;
while(true){
    Console.WriteLine("Сделайте выбор:1-Камень 2-Ножницы 3-Бумага 4-Огонь 5-Вода или 'q' выход из игры" );
    string? userInput = Console.ReadLine();
    if (userInput == "q"){
    Console.WriteLine("Спасибо за игру!Досвидания!");
    break;
    }
    if (!int.TryParse(userInput, out int userChoice) || userChoice < 1 || userChoice > 5){
        Console.WriteLine("Введите число от 1 до 5");
        continue;
    }
    int computerChoice = random.Next(1,6);
    Console.WriteLine($"Компьютер выбрал:{words[computerChoice - 1]}");
    Console.WriteLine($"Вы выбрали:{words[userChoice - 1]}"); 
    if(userChoice == computerChoice){
        Console.WriteLine("Это ничья");
    }
    else if((userChoice == 1 && (computerChoice == 2 || computerChoice == 4)) ||
            (userChoice == 2 && (computerChoice == 3 || computerChoice == 5)) ||
            (userChoice == 3 && (computerChoice == 1 || computerChoice == 4)) ||
            (userChoice == 4 && (computerChoice == 3 || computerChoice == 5)) ||
            (userChoice == 5 && (computerChoice == 1 || computerChoice == 2))) {
                Console.WriteLine("Вы выйграли");
                playerWins++;
    }
    else{
        Console.WriteLine("Вы проиграли");
        computerWins++;
    }
    Console.WriteLine($"Счет: игрок - {playerWins} компьютер - {computerWins}");
    if(playerWins == 3){
        Console.WriteLine("Вы выйграли компьютер");
        break;
    } 
    if(computerWins == 3){
        Console.WriteLine("Копьютер выйграл");
        break;
    } 
}
