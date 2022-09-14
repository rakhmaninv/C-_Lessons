Console.WriteLine("insert your name");
string? username = Console.ReadLine();
if(username != null)
{
    if(username.ToLower() == "vadim")
    {
        Console.WriteLine("Hello my favorite user");
    }
    else
    {
        Console.WriteLine("Hello " + username);
    }
}
else
{
    Console.WriteLine(" ");
}