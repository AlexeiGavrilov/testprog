Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "юля")
{
    Console.WriteLine("Привет, ЖОПА вонючка"); 
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}