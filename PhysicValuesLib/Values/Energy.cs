namespace PhysicValuesLib.Values;

public class Energy : IValue
{
    private string _valueName = "Энергия";

    public string GetValueName()
    {
        return _valueName;
    }

    private Dictionary<string, double> _coeff = new Dictionary<string, double>()
    {
        { "Килоджоуль",    1           },
        { "Мегаджоуль",    1000        },
        { "Джоуль",        0.001       },
        { "Мегакалорий",   4186.799941 },
        { "Килокалорий",   4.1868      },
        { "Калорий",       0.004187    }
    };

    public Dictionary<string, double> GetCoefficients()
    {
        return _coeff;
    }
}
