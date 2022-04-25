// Комментарий к коду не относящийся. Заметки, памятки
// ToLower - переводит все символы в нижний регистр (Маша, МАша ...)
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}