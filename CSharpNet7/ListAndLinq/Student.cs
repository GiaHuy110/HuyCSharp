namespace ListAndLinq;
internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}}}";
    }
}