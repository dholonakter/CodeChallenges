using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Encapsulation
{
	public class BankAccount
	{
		#region Fields
		//private string? _account_holder;
		private decimal _balance;
		#endregion
		#region Properties
		public string? AccountHolder { get; set; }
		public decimal Balance
		{
			get { return _balance; }
			private set
			{
				if (_balance >= 0)
				{
					_balance = value;
				}
				else
				{
					throw new ArgumentException("blance can not be negative");
				}

			}
		}
		#endregion
		#region Constructor
		public BankAccount(string accountholder, decimal balance)
		{
			AccountHolder = accountholder;
			Balance = balance;
		}
        public BankAccount()
        {
            
        }
        #endregion
        #region Method
        public void Deposit(decimal amount)
		{
			Balance += amount;
		}
		public void Withdraw(decimal amount)
		{
			Balance -= amount;
		}
		#endregion
	}
}
