public class car
{
    public string Model;
    public int topspeed;
    public double engine;
    public double km;
    public int hp;

    public string model
    {
        get
        {
            return Model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 10)
            {
                Console.WriteLine("duzgun deyer daxil edin!");
            }
            else
            {
                Model = value;
            }
        } 
    }

    public int topSpeed 
    {  
       get
       { 
            return topspeed;
       }
       set 
       {
            if (value >= 10 && value <= 1000)
            {
                topspeed = value;
            }
            else
            {
                Console.WriteLine("duzgun speed daxil edin!");
            }
       } 
    }

    public double Engine 
    { 
        get 
        { 
            return engine; 
        } 
        set
        {
            if (value >= 0.3 && value <= 10)
            {
                engine = value;
            }
            else
            {
                Console.WriteLine("duzgun engine daxil edin!");
            }
        }
    }

    public double Km
    {
        get
        {
            return km;
        }
        set
        {
            if (value > 0)
            {
                km = value;
            }
            else
            {
                Console.WriteLine("duzgun km daxil edin!");
            }
        }
    }

    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (value >= 50 && value <= 1000)
            {
                hp = value;
            }
            else
            {
                Console.WriteLine("duzgun hp daxil edin!");
            }
        }
    }
}

