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
    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }
	public string Model
	{
		get { return _model; }
		set { _model = value; }
	}
	public int Year
	{
		get { return _year; }
		set { _year = value; }
	}

	#endregion

	#region Method
	public void DisplayInfo()
    {
        Console.WriteLine(" Make " + Make + " Model " + Model + "Year " + Year);
    }
    #endregion


}
