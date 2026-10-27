// Console.WriteLine("vvedi slovo: ");
// string word = Console.ReadLine();
// Console.WriteLine($"dlina: {word.Length}");
// Console.WriteLine($"pervi simvol: {word[0]}");
// Console.WriteLine($"posledni simvol: {word[word.Length - 1]}");



// Console.WriteLine("vvedi slovo: ");
// string word = Console.ReadLine().ToLower();
// // int count = 0;
// // foreach (char c in word)
// // {
// //     if (c == 'а' || c == 'a')
// //         count++;
// // }



Console.WriteLine($"bukv 'a': {count}");
Console.WriteLine("vvedi imya faila: ");
string file = Console.ReadLine().ToLower();
if (file.EndsWith(".cs"))
    Console.WriteLine("eto fail c#");
else if (file.EndsWith(".png") || file.EndsWith(".jpg"))
    Console.WriteLine("eto izobrazenie");
else
    Console.WriteLine("neizvestni tip");
if (file.StartsWith("lab"))
    Console.WriteLine("eto laboratornaya rabota");
if (file.Contains("test"))
    Console.WriteLine("testovi fail");