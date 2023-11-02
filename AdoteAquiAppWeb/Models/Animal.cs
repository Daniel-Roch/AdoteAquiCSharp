namespace AdoteAquiAppWeb.Models;
public class Animal {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Img { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string Andress { get; set; }

    public Animal(int id, string name, string img, string url, string description, string andress) {
        Id = id;
        Name = name; 
        Img = img; 
        Url = url; 
        Description = description;
        Andress = andress;
    }
}
