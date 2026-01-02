// დავალება 1 კვადრატული ფესვების დაბრუნება

//List<double> numbers = new List<double> { 1, 2, 3, 4, 5 };
//Func<List<double>, List<double>> squares = numbers =>
//{
//    List<double> result = new List<double>();
//    foreach (var number in numbers)
//    {
//        result.Add(Math.Pow(number, 2));
//    }
//    return result;
//};

//List<double> squaredNumbers = squares(numbers);

//foreach (var num in squaredNumbers)
//{
//    Console.WriteLine(num);
//}


// დავალება 2 ლექსიკონიდან ელემენტების დაბრუნება

//Func<Dictionary<string, int>, Dictionary<string, int>> filterDic = dict =>
//{
//    Dictionary<string, int> result = new Dictionary<string, int>();
//    foreach (var word in dict)
//    {
//        if (word.Value > 10)
//        {
//            result.Add(word.Key, word.Value);
//        }
//    }
//    return result;
//};

//Dictionary<string, int> myDictionary = new Dictionary<string, int>
//{
//    { "Computer", 15 },
//    { "Phone", 8 },
//    { "Tablet", 12 },
//    { "Monitor", 5 },
//    { "Mouse", 77 }
//};

//Dictionary<string, int> filteredDictionary = filterDic(myDictionary);

//foreach (var item in filteredDictionary)
//{
//    Console.WriteLine($"{item.Key}, {item.Value}");
//}zz




using SeventeenthConsoleApp.models;

BankingSystem bankingSystem = new BankingSystem();

KeyListener keyListener = new KeyListener();
keyListener.OnBalanceCheck += bankingSystem.ShowBalance;
keyListener.OnWithdrawMoney += bankingSystem.WithdrawMoney;
keyListener.OnDepositMoney += bankingSystem.DepositMoney;

keyListener.StartListening();
