public class Location
{
    // Fields

    // Information about the location
    public int ID;
    public string Name;
    public string Description;
    // Location links
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;
    // Location features
    public Monster MonsterLivingHere;
    public Quest QuestAvailableHere;

    //Constructor
    public Location(int id, string name, string description, Location north = null, Location east = null, Location south = null, Location west = null)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.LocationToNorth = north;
        this.LocationToEast = east;
        this.LocationToSouth = south;
        this.LocationToWest = west;
    }
}