using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Constructor;

public class Car
{
    #region private fields
    private string _make;
    private string _model;
    private int _year;
    #endregion

    #region properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    #endregion

    #region Method
    public void DisplayInfo()
    {
        Console.WriteLine(" Make " + Make + " Model " + Model + "Year " + Year);
    }
    #endregion


}
