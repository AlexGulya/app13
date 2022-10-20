
Person person = new Person("tom", 19);
person.Info();


(string name, int age) = person;
Console.WriteLine(name);
Console.WriteLine(age);

//string name; int age;
//person.Deconstruct(out name, out age);

//(_, int age) = person;
//Console.WriteLine(age);

name = "tim";
person.Info();


class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Deconstruct(out string Personname, out int Personage)
    {
        Personname = name;
        Personage = age;
    }
    public void Info() => Console.WriteLine($"name:{name} - age:{age}");

}
