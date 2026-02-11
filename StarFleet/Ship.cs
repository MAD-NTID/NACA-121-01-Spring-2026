using System.Runtime.InteropServices;

public class Ship
{
    //  Create a read only property that returns the total distance travel. The total distance is measure in an integer
    public int TotalDistanceTraveled { get; private set; }

    //  Create a read only property that return the current warp speed. The ship’s warp speed is an integer value.
    public int CurrentWarpSpeed { get; private set; }

    // Create a read only property that returns the name of the ship.
    public string? Name { get; private set; }

    // Use the default constructor to initialize the list of aliens to an initial capacity of 10, distance to 0, current warp speed to 0, total crew to 0 and the name of the ship to “Unidentified Flying Object”
    private Alien[] aliens;
    private int totalCrew;

    const int SPEED_INCREMENT = 3;
    const int DISTANCE_INCREMENT = 5;

    public Ship()
    {
        aliens = new Alien[10];
        TotalDistanceTraveled = 0;
        CurrentWarpSpeed = 0;
        totalCrew = 0;
        Name = "Unidentified Flying Object";
    }

    // Create a parametrize constructor that takes the name of the ship and the total aliens capacity. Your constructor must set the alien list capacity to the total aliens capacity received from parameter.  Set the distance, current warp speed and total crew to 0. Set the name of the ship to the name supplied in the parameter.
    public Ship(string name, int alienCapacity)
    {
        aliens = new Alien[alienCapacity];
        TotalDistanceTraveled = 0;
        CurrentWarpSpeed = 0;
        totalCrew = 0;
        Name = name;
    }

    // Create a public method Add which takes an Alien class and add the alien to the list. Note, there can only be 1 captain and 1 chief officer on the ship. If the alien cannot be added, your method must return false. True otherwise. You must also track the total number of crew current on the ship in this method.
    public bool Add(Alien alien)
    {
        bool haveCaptain = false;
        bool haveChiefOfficer = false;

        for(int i = 0; i < aliens.Length; i++)
        {
            Alien thisAlien = aliens[i];

            if(thisAlien != null && thisAlien.Role.ToLower() == "captain")
                haveCaptain = true;

            if(thisAlien != null && thisAlien.Role.ToLower() == "chief officer")
                haveChiefOfficer = true;

            // We can break out of the loop early if both are true - not required on exam
            // But assume you have a list of 1,000,000 - would you wanna loop all?
            if(haveCaptain && haveChiefOfficer)
                break;
        }

        // if object alien has role of captain and there is no captain in the list, then add
        if(alien.Role.ToLower() == "captain" && haveCaptain || alien.Role.ToLower() == "chief officer" && haveChiefOfficer)
        {
            return false;
        }

        // Add the new crew member to any available slot in the Aliens list(do not use totalCrew as index)
        // crew (captain/chief officer/other) is added, increment totalCrew by one
        for(int i = 0; i < aliens.Length; i++)
            if(aliens[i] == null)
            {
                aliens[i] = alien;
                totalCrew ++;
                break;
            }

        return true;        
    }

    // Create a public method called Remove that takes a name and remove the alien as crew from the ship. If the alien was removed, return true. False otherwise.
    public bool Remove(string name)
    {
        for(int i = 0; i < aliens.Length; i++)
        {
            if(aliens[i] != null && aliens[i].Name.ToLower() == name)
            {
                aliens[i] = null;
                
                totalCrew --;
                
                return true;
            }
        }

        return false;
    }

    // Create a public method called Fly. The method should increment the current warp speed by 3 and the distance by 5. For example if the current warp speed is 0 and 0 then the increment values will be 3 and 5 respectively. If the fly is called again, it will be 6 and 10 and so on. This method doesn’t return anything..
    public void Fly()
    {
        CurrentWarpSpeed += SPEED_INCREMENT;
        TotalDistanceTraveled += DISTANCE_INCREMENT;
    }

    // Create an overload Fly method that takes a warp speed. The warp speed will be given in the multiple of 3. You do not need to validate it in this method. The validation will happen later in the Program.cs you should take the current warp speed and increment it by the the supplied warp speed given in the parameter.  For every 3 warp speed increments, the ship travels 5 interstellar distances.  For example, if the given warp speed is 30 then the ship has traveled 50 interstellar distance. You must add the newly calculate distance to the previous distance.
    public void Fly(int speed)
    {
        // find the multiples for the speed and distance
        int multiple = speed / SPEED_INCREMENT;
        // int totalSpeedIncrement = SPEED_INCREMENT * multiple;
        // int totalDistanceIncrement = DISTANCE_INCREMENT * multiple;

        // CurrentWarpSpeed += totalSpeedIncrement;
        // TotalDistanceTraveled += totalDistanceIncrement;

        // much simpler way if you want
        for(int i = 0; i < multiple; i++)
            Fly();
    }

    /*
    Your ToString must return the information about the ship in the format(the new line are important):
    Ship Name: <name>
    Speed: <current warp speed>
    Distance: <distance>
    Total Crew: <total>
    Crews:
                                - name 1 role 1
    - name 2 role 2
    - name n role n
    */
    public override string ToString()
    {
        string toString = $"Ship Name: {Name}\n" +
        $"Speed: {CurrentWarpSpeed}\n" +
        $"Distance: {TotalDistanceTraveled}\n" +
        $"Total Crew: {totalCrew}\n" +
        $"Crews:\n";

        // Iterate the Alien list (crews) and append their information
        for(int i = 0; i <aliens.Length; i++)
        {
            // Validate Alien is not null (first)
            if(aliens[i] != null)
                toString += $"\t{aliens[i]}\n";   
        }

        return toString;
    }
}