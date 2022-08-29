Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine ();

if(username.ToLower() == "антон")
{
    Console.WriteLine ("Ура это же самый крутой человек на свете!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}