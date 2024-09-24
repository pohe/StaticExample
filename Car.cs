
/// <summary>
/// A very simple representation of a car
/// </summary>
public class Car
{
    #region Instance fields
    private string _licensePlate;
    private int _price;
    private static int _numberOfObjects =0;
    private static int _usesLicensePlate =0;
    #endregion

    #region Constructor
    public Car(string licensePlate, int price)
    {
        _numberOfObjects++;
        _licensePlate = licensePlate;
        _price = price;
    }
    #endregion

    #region Properties
    public string LicensePlate
    {
        get {
            _usesLicensePlate++;
            return _licensePlate; 
        }
        set { _licensePlate = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }
    #endregion

    public static void PrintUsageStatistics()
    {
        Console.WriteLine($"NumberOfObjects {_numberOfObjects}");
        Console.WriteLine($"Uses of LicencePate {_usesLicensePlate}");
    }
}
