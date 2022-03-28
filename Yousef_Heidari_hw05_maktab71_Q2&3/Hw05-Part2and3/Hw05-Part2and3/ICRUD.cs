//Question 2 Part a. :
public interface ICRUD
{
    void Create(Person item);
    void Delete(int id);
    Person? GetItem(int id);
    void Update(Person item);
    List<Person> GetAll();
}