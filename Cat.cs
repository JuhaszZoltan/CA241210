namespace CA241210;

internal class Cat
{
    public Guid Guid { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Pattern { get; set; }
    public string? Color { get; set; }
    public bool Sex { get; set; }

    public override string ToString()
    {
        string patColStr = Color is null || Pattern is null ?
            "unknown" : $"{Pattern} {Color}";

        return $"{Name} is a {patColStr} {Species} cat, {(Sex ? "he" : "she")} " +
            $"is {DateTime.Now.Year - BirthDate.Year} years old.";
    }


    public Cat(string name, string birthDate, string? pattern, string? color, bool sex, string species)
    {
        Guid = Guid.NewGuid();
        Species = species ?? throw new ArgumentNullException(nameof(species));
        Name = name ?? throw new ArgumentNullException(nameof(name));
        BirthDate = DateTime.Parse(birthDate);
        Pattern = pattern;
        Color = color;
        Sex = sex;
    }

    public Cat(string name, string birthDate, bool sex, string? pattern = null, string? color = null)
    {
        Guid = Guid.NewGuid();
        Species = "domestic";
        Name = name ?? throw new ArgumentNullException(nameof(name));
        BirthDate = DateTime.Parse(birthDate);
        Pattern = pattern;
        Color = color;
        Sex = sex;
    }
}
