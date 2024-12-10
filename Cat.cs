namespace CA241210;

internal class Cat
{
    public Guid Guid { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Pattern { get; set; }
    public string? Color { get; set; }

    public Cat(Guid guid, string species, string name, DateTime birthDate, string? pattern, string? color)
    {
        Guid = guid;
        Species = species ?? throw new ArgumentNullException(nameof(species));
        Name = name ?? throw new ArgumentNullException(nameof(name));
        BirthDate = birthDate;
        Pattern = pattern;
        Color = color;
    }
}
