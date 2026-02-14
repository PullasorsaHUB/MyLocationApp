//  Eli tänne tehdään Tietomallit / Entityt... Esim. Location

namespace MyLocationApp.Backend.Models;

public class TodoCreateRequest
{
    // (Default!) meinaa null-forgiving operator Koska string (ilman ?) tarkoittaa: ei pitäisi olla null. Compiler sanoo:
    // “Hei, sä et anna tälle arvoa konstruktorissa”. default! sanoo: “kyllä se arvo tulee myöhemmin”.
    public string Title { get; set; } = default!;
    public string Location { get; set; } = "";
    public string SessionLength { get; set; } = "";
    public string Description { get; set; } = "";
}