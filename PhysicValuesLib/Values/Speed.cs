namespace PhysicValuesLib.Values;

public class Speed : IValue
{
    private string _valueName = "Скорость";

    public string GetValueName()
    {
        return _valueName;
    }

    private Dictionary<string, double> _coeff = new Dictionary<string, double>()
    {
        { "Метры в секунду",       1        },
        { "Километры в секунду",   1000     },
        { "Километры в час",       0.277778 },
        { "Метры в минуту",        0.016667 },
    };

    public Dictionary<string, double> GetCoefficients()
    {
        return _coeff;
    }
}
