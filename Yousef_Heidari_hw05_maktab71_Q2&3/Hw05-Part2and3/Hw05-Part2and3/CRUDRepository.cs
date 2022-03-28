//Question 2 Part a. :
public class CRUDRepository : ICRUD
{
    public void Create(Person item)
    {
        DataStorage.persons.Add(item);
    }

    public void Delete(int id)
    {
        var item=DataStorage.persons.FirstOrDefault(p => p.Id == id);
        DataStorage.persons.Remove(item);
    }

    public Person? GetItem(int id)
    {
        return DataStorage.persons.FirstOrDefault(p=>p.Id == id);
    }

    public void Update(Person item)
    {
        var temp = item;
        var holder=DataStorage.persons.FirstOrDefault(p=>p.Id==item.Id);
        DataStorage.persons.Remove(holder);
        DataStorage.persons.Add(temp);
    }
    public List<Person> GetAll()
    {
        return DataStorage.persons;
    }
}