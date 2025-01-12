using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Practice.Encapsulation;

public class Customer
{
	public List<BankAccount> BankAccounts { get; set; }

    public Customer()
    {
        BankAccounts = new List<BankAccount>(); 
    }

    public void Deposit(decimal amount,BankAccount bankAccount)
	{
        bankAccount.Deposit(amount);
	}
	public void Withdraw(decimal amount, BankAccount bankAccount)
	{
		bankAccount.Deposit(amount);
	}
}
