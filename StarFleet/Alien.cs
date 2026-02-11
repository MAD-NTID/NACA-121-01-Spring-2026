public class Alien
{
    private string name;

    public string Name { 
        get
        {
            return name;
        } 

        set
        {
            if(string.IsNullOrEmpty(value))    
                value = "Undefined";

            name = value;
        }
    }

    private string role;

    public string Role
    {
        get
        {
            return role;
        }

        set
        {
            if(IsValidRole(value))
                role = value;
            else
                role = "Unknown Role";            
        }
    }

    //  Create a Constructor which takes name and role and assign them to the property.
    public Alien(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public bool IsValidRole(string role)
    {
        role = role.ToLower();

        // One way to do it
        // if(role == "captain" || role == "chief officer" || role == "navigator" 
        //     || role == "pilot" || role == "engineer" || role == "doctoer") {
        //     return true;
        // }

        // return false;

        // Another way of doing it
        return role == "captain" || role == "chief officer" || role == "navigator" 
            || role == "pilot" || role == "engineer" || role == "doctoer";
    }

    public override string ToString()
    {
        return $"Name:{name} Role: {role}";
    }
}