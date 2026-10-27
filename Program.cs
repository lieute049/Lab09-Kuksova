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



// // Console.WriteLine($"bukv 'a': {count}");
// // Console.WriteLine("vvedi imya faila: ");
// // string file = Console.ReadLine().ToLower();
// // if (file.EndsWith(".cs"))
// //     Console.WriteLine("eto fail c#");
// // else if (file.EndsWith(".png") || file.EndsWith(".jpg"))
// //     Console.WriteLine("eto izobrazenie");
// // else
// //     Console.WriteLine("neizvestni tip");
// // if (file.StartsWith("lab"))
// //     Console.WriteLine("eto laboratornaya rabota");
// // if (file.Contains("test"))
// //     Console.WriteLine("testovi fail");




// // Console.WriteLine("vvedi frazu: ");
// // string phrase = Console.ReadLine();
// // Console.WriteLine($"bolshimi: {phrase.ToUpper()}");
// // Console.WriteLine($"s probelami _: {phrase.Replace(" ", "_")}");
// // if (phrase.ToLower().Contains("стоп"))
// //     Console.WriteLine("stop-slovo naideno!");





// Console.WriteLine("vvedi datu (2026-09-29): ");
// string date = Console.ReadLine();
// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);
// Console.WriteLine($"{day}.{month}.{year}");
// Console.WriteLine("vvedi telefon (11 cifr): ");
// string phone = Console.ReadLine();
// string kod = phone.Substring(1, 3);
// string a = phone.Substring(4, 3);
// string b = phone.Substring(7, 2);
// string c = phone.Substring(9, 2);
// Console.WriteLine($"+7 ({kod}) {a}-{b}-{c}");



// Console.WriteLine("vvedi tekst: ");
// string text = Console.ReadLine().ToLower();
// int spaces = 0;
// int vowels = 0;
// string glasnie = "аеёиоуыэюя";
// foreach (char c in text)
// {
//     if (c == ' ') spaces++;
//     if (glasnie.Contains(c)) vowels++;
// }
// Console.WriteLine($"simvolov: {text.Length}");
// Console.WriteLine($"probelov: {spaces}");
// Console.WriteLine($"glasnih: {vowels}");




// Console.WriteLine("vvedi slovo: ");
// string word = Console.ReadLine();
// string reversed = "";
// for (int i = word.Length - 1; i >= 0; i--)
//     reversed += word[i];
// Console.WriteLine($"naoborot: {reversed}");
// if (word.ToLower() == reversed.ToLower())
//     Console.WriteLine("eto palindrom");
// else
//     Console.WriteLine("ne palindrom");







Console.WriteLine("vvedi email: ");
string email = Console.ReadLine();
int atCount = 0;
foreach (char c in email)
    if (c == '@') atCount++;
if (email.Length < 5)
    Console.WriteLine("adres nekorrektem: korotki");
else if (atCount != 1)
    Console.WriteLine("adres nekorekten: dolzno bit rovno odna @");
else if (email.StartsWith("@") || email.EndsWith("@"))
    Console.WriteLine("adres nekorekten: ne dolzen nachinatsya/zakanchivatsya na @");
else if (email.Contains(" "))
    Console.WriteLine("adres nekorekten: est probel");
else if (!email.ToLower().EndsWith(".ru") && !email.ToLower().EndsWith(".com"))
    Console.WriteLine("adres nekorekten: dolzen zakanchivatsya na .ru ili .com");
else
    Console.WriteLine($"adres korekten: {email.ToLower()}");