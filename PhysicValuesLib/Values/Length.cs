namespace PhysicValuesLib.Values;

public class Length : IValue
{
    private string _valueName = "Длина";

    public string GetValueName()
    {
        return _valueName;
    }

    private Dictionary<string, double> _coeff = new Dictionary<string, double>()
    {
        { "Сантиметры",   1      },
        { "Метры",        100    },
        { "Километры",    100000 },
        { "Миллиметры",   0.1    },
        { "Дециметры",    10     },
    };

    public Dictionary<string, double> GetCoefficients()
    {
        return _coeff;
    }
}
