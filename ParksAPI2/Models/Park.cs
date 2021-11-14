namespace ParksAPI2.Models
{
  public class Park
  {
    public int ParkId {get; set;}
    public string ParkName { get; set; }
    public string Size { get; set; }
    public string Description { get; set; }

    public bool Visited { get; set;}

    public int Rating { get; set; }
  }
}

