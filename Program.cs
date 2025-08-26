string? choice;
int charcount = 0;
string file = "mariochardata.txt";
do
{
  
    Console.WriteLine("1) enter mario character.");
    Console.WriteLine("2) read file.");
    Console.WriteLine("anything else: exit.");
    
    choice = Console.ReadLine();
    if (choice == "1")
    {
        
      
        string prevfile = "";
         if (File.Exists(file))
         {
            StreamReader sr = new StreamReader(file);
           prevfile = sr.ReadToEnd();
            sr.Close();
         }
         //keeps previous characters entered to the file

        StreamWriter sw = new(file);
        Console.WriteLine("enter mario id: ");
        string id = Console.ReadLine();
        Console.WriteLine("enter mario character name: ");
        string name = Console.ReadLine();
        Console.WriteLine("enter relationship to mario: ");
        string relationship = Console.ReadLine();
        charcount++;
        //increments for each character added
        //mario creator
        sw.WriteLine(prevfile + $"\nid:{id} \n" + $"name: {name}\n" + $"relationship to mario: {relationship}\n");
        sw.Close();

    }
    else if (choice == "2")
    {
        
        if (File.Exists(file))
        {
            StreamReader sr = new(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("there is no file");
        }

    }
} while (choice == "1" || choice == "2");