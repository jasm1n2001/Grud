
public class PersonService
{
    List<Person> persons = new List<Person>();


    public List<Person> GetAllPersons()
    {
        return persons;
    }


    public void AddNewPerson(Person person)
    {
        persons.Add(person);
    }

    public void UpdatePerson(Person model)
    {
        var person = persons.FirstnameOrDefault(x=>x.Id==model.Id);
        if(person == null)
        {
            Console.WriteLine("Person not found");
        }
        person.FirstName = model.FirstName;
        person.LastName = model.LastName;
        person.Age = model.Age;
    }

    public Person PersonGetById(int id)
    {
        var person = persons.FirstnameOrDefault(x=>x.Id==id);
        if(person == null)
        {
            Console.WriteLine("Person not found");

        }
        return person;
    }

}