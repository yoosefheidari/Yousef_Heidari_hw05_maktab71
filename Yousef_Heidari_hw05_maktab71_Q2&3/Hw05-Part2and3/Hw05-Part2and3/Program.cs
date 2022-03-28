
ICRUD _repository = new CRUDRepository();

//Question 3 :
for (int n = 0; n < 1000; n++)
{
    var person = new Person();
    _repository.Create(person);
}
//if you recieve error during debugging pls comment Lines 19 & 26 !! then uncomment those and comment others!!!!
var persons = _repository.GetAll();
//a.
var a = persons.Where(x => x.Age > 20).OrderBy(x => x.Name);
//b.
var b = persons.Where(y => y.Created.Year < 1999);
//c.
var c = persons.GroupBy(x => x.Created).Where(p=>p.Count()>1).Select(p=>p.Select(m=>m.Name));
//d.
var d1 = persons.OrderBy(x => x.Id).Skip(3).Take(1);
//another way :
//var d2 = persons.OrderBy(x => x.Id).ElementAt(3);

//e.
var e = persons.OrderBy(x => x.Id).Skip(49).Take(31);
//f.
var f = persons.Where(x=>x.Age== persons.Max(x => x.Age));
//g.
var g = persons.GroupBy(x => x.National_Code).Any(p => p.Count() > 1); //return true if there was duplicate national_codes
//h.
var h = persons.FindAll(x=>x.Address.Contains("Tehran")).Select(p=>p.Address).ToList();
//i.
var i = persons.FindAll(x => x.Address.Contains("Tehran")).GroupBy(s=>s.Name).Where(p => p.Count() > 1).Select(c => c.Select(g=>g.Address)).ToList();
//j.
var j = persons.Where(s => s.National_Code.ToString().Equals("123"));
//k.
var k = persons.Where(p => p.Age > 25).Select(o => new {National_Code=o.National_Code , Address=o.Address});