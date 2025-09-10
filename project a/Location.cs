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
    public Location ItemRequiredToEnter;

    // Constructor
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

    // Making a player class to populate in the world
    public class Player
    {
        public Location CurrentLocation;

        public Player(Location start_location)
        {
            CurrentLocation = start_location;
        }
    }

    public void ShowCompass()
    {
        System.Console.WriteLine($"You are at location: {CurrentLocation.Name}");
        System.Console.WriteLine(CurrentLocation.Description);
        System.Console.WriteLine("");

        // North compass
        if (LocationToNorth != null)
        {
            Console.WriteLine("    N");
            Console.WriteLine("    |");
        }
        string line = "    |"; // default if no directions allowed

        if (west_Y && east_Y != null)
        {
            line = "W---|---E";
        }
        else if (west_Y != null)
        {
            line = "W---|";
        }
        else if (east_Y != null)
        {
            line = "    |---E";
        }
        Console.WriteLine(line);
        
        // South
        if (south_Y)
        {
            Console.WriteLine("    |");
            Console.WriteLine("    S");
        }

        // Blank line
        Console.WriteLine();
    }
}