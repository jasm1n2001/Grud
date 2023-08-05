

    var PersonService = new PersonService();
    bool test = true;
    while (test)
    {
        Console.WriteLine("Get all persons : getAll");
        Console.WriteLine("Get  person by id : ById");
        Console.WriteLine("Add new person : Add");
        Console.WriteLine("Update person by id : Update");
        
        Console.Write("enter command: ");
        var command = Console.ReadLine();

        if(command.ToLower().Trim()=="getAll".ToLower())
        {
            Console.Write(" ");
            Console.WriteLine(new string('=',120));
            Console.Write(" ");

            var persons = PersonService.GetAllPersons();
            foreach (var person in persons)
            {
                Console.WriteLine(
                    $"FirstName : {person.FirstName}," + 
                    $"LastName : {person.LAstName}," +
                    $"Age :  {person.Age}");
                
            }
            Console.WriteLine(" ");
            Console.WriteLine(new string('=', 120));
            Console.WriteLine(" ");           

        }

        else if (command.ToLower().Trim()== "getById".ToLower())
        {
            Console.Write(" ");
            Console.WriteLine(new string('=', 1200))
            Console.Write(" ");


            Console.Write("Enter person id");
            int id = Convert.ToInt32(Console.ReadLine());
            var person = PersonService.PersonGetById(1);
            Console.WriteLine(
                $"FirstName : {person.FirstName}, " +
                $"LastName : {person.LastNAme}, " +
                $"Age : {person.Age}" );

                Console.WriteLine(" ");
                Console.WriteLine(new string('=',120));
                Console.WriteLine(" ");
        }
        else if(command.ToLower().Trim()=="add")
        {
            Console.WriteLine(" ");
            Console.WriteLine(new string('=',120));
            Console.WriteLine(" ");

            var newPerson = new Person();
            Console.Write("FirstName: ");
            newPerson.FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            newPerson.LastName = Console.ReadLine();
            Console.Write("Age");
            newPerson.Age = Convert.ToInt32(Console.ReadLine());
            PersonService.AddNewPerson(newPerson);

            Console.WriteLine(" ");
            Console.WriteLine(new string('=',120));
            Console.WriteLine(" ");
        }

        else if(command.ToLower().Trim == "update")
        {
            Console.WriteLine(" ");
            Console.WriteLine(new string('=',120));
            Console.WriteLine(" ");


            var newPerson = new Person();
            Console.Write("Id : ");
            newPerson.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("FirstName: ");
            newPerson.FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            newPerson.LastName = Console.ReadLine();
            Console.Write("Age");
            newPerson.Age = Convert.ToInt32(Console.ReadLine());
            PersonService.UpdatePerson(newPerson);

            Console.WriteLine(" ");
            Console.WriteLine(new string('=',120));
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine(Komanda ne verno!);

        }
    

        Result();
    }

     static bool Result()
     {

         Console.WriteLine("Vi khotite prodolzhit rabotu ?");
         Console.Write("da / net");
         bool result = false;
         string res = string Empty;
         res = Console.ReadLine() ?? "net";
         if(res.ToLower()=="da")
         {
            result = true;
         }
         else 
         {
            result = false;
         }
         return result;
              }
