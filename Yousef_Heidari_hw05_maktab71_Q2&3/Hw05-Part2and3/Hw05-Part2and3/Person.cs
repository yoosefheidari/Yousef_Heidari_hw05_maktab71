public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }    
    public int Age { get; set; }
    public DateTime Created { get; set; }
    public string Address { get; set; }
    public int National_Code { get; set; }
    public Person()
    {
        bool id = true;
        while (id)
        {
            Id = IdGen();
            id=DataStorage.persons.Any(x => x.Id == Id);
        }
        National_Code = CodeGen();        
        Name = NameGen();
        Address = AddressGen();
        Created = BirthDay();
        Age = AgeGen();

    }
    int IdGen()
    {
        var rnd = new Random();
        return rnd.Next(1,3001);
    }
    int CodeGen()
    {
        var rnd=new Random();
        return rnd.Next(1, 2001);
    }
    
    string NameGen()
    {
        string[] names = {"Ali","Amir","Hessam","Reza","Saeed","Iman","Amin","Hashem","Masoud","Mohsen",
            "Mehdi","Naser","Taher","Sina","Mostafa"};
        var rnd = new Random();
        return names[rnd.Next(0,15)];
    }
    string AddressGen()
    {
        string[] address = {"Tehran","Esfahan","Mashhad","Shiraz","Yazd","Kerman","Ilam","Bushehr",
        "Gilan","Zanjan","Ghazvin","Arak","Ghom","Kermanshah","Hamedan","Khuzestan","Lorestan"};
        var rnd = new Random();
        return address[rnd.Next(0, 17)]+Id;
    }
    DateTime BirthDay()
    {
        var rnd = new Random();
        var year = rnd.Next(1960, 2022);
        var month = rnd.Next(1, 13);
        var day = rnd.Next(1, 29);
        DateTime a = new DateTime(year, month, day);
        return a;
    }
    int AgeGen()
    {
        return 2022 - Created.Year;
    }

    //Question 2 Part b.  :

    //I didn't include "Created" Field in comparison because it need to makes operator overload for "DateTime" Struct!
    public static bool operator==(Person a, Person b)
    {
        if(a.Id == b.Id && a.Age==b.Age && a.Name==b.Name && a.Created==b.Created && a.Address==b.Address && a.National_Code==b.National_Code)
            return true;
        return false;
    }
    public static bool operator !=(Person a, Person b)
    {
        if (a.Id == b.Id && a.Age == b.Age && a.Name == b.Name && a.Created == b.Created && a.Address == b.Address && a.National_Code == b.National_Code)
            return false;
        return true;
    }
    
}