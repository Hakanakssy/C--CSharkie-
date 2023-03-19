// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    string user_name= "", user_sur="", user_pas="1234",log_pass="";
    
    for (int i = 0; i < 5; i++)
    {
        user_name=Console.ReadLine();
        user_sur=Console.ReadLine();
        log_pass=Console.ReadLine();
        if (log_pass.Equals(user_pas))
        {
            System.Console.WriteLine("Sisteme hoşgeldin");
            break;
        }
        else
        {
            System.Console.WriteLine("giriş başarısız");
            
        }
    }
