namespace PhysicValuesLib.Values;

public class Weight : IValue
{
    private string _valueName = "Вес";

    public string GetValueName()
    {
        return _valueName;
    }

    private Dictionary<string, double> _coeff = new Dictionary<string, double>()
    {
        { "Килограммы",   1        },
        { "Граммы",       0.001    },
        { "Тонн",         1000     },
        { "Фунт",         0.453592 },
    };

    public Dictionary<string, double> GetCoefficients()
    {
        return _coeff;
    }
}
