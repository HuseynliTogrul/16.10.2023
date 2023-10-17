public class car
{
    private string _model;
    private int _topspeed;
    private double _engine;
    private double _km;
    private int _hp;

    public string model
    {
        get
        {
            return _model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 10)
            {
                Console.WriteLine("duzgun deyer daxil edin!");
            }
            else
            {
                _model = value;
            }
        } 
    }

    public int topSpeed 
    {  
       get
       { 
            return _topspeed;
       }
       set 
       {
            if (value >= 10 && value <= 1000)
            {
                _topspeed = value;
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
            return _engine; 
        } 
        set
        {
            if (value >= 0.3 && value <= 10)
            {
                _engine = value;
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
            return _km;
        }
        set
        {
            if (value > 0)
            {
                _km = value;
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
            return _hp;
        }
        set
        {
            if (value >= 50 && value <= 1000)
            {
                _hp = value;
            }
            else
            {
                Console.WriteLine("duzgun hp daxil edin!");
            }
        }
    }
}

