namespace PhysicValuesLib.Values;

public class Power : IValue
{
    private string _valueName = "Мощность";

    public string GetValueName()
    {
        return _valueName;
    }

    private Dictionary<string, double> _coeff = new Dictionary<string, double>()
    {
        { "Ватт",            1          },
        { "Киловатт",        1000       },
        { "Калорий/секунду", 4.1868     },
        { "Лошадиная сила",  745.699921 },
    };

    public Dictionary<string, double> GetCoefficients()
    {
        return _coeff;
    }
}
