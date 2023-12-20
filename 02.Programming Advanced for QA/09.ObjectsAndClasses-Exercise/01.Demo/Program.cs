public class Person
{
    //field: характеристики -> име, възраст, ЕГН
    private string name;
    private int age;
    private string egn;

    //properties (get/set): осигуряват достъп до полетата
    public string Name         //or automatic property without fields -> public string Name { get; set; }
    {
        get { return name; }
        set { name = value; }
    }
    public string Egn
    {
        get { return egn; }
        set { egn = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}