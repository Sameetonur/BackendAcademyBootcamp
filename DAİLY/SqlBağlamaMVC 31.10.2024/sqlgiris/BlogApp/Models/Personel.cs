using System;

namespace BlogApp.Models;

public class Personel
{
    public string Name { get; set; }
    public IEnumerable<Social> Socials {get;set;}
    public IEnumerable<Skill>  Skills {get;set;}
    public string Img { get; set; }
    public string Unvan { get; set; }
    public string Title {get;set;}
    public string AboutText { get; set; }
    public string AboutTitle { get; set; }
    public DateTime BirthDay { get; set; }
    public string Website { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public int Age { get; set; }
    public string About { get; set; }

}
