//***********************************************
//			Timothy Lockhart
//			Assingment: A5 recursive functions
//			Date: 4/27/20
//***********************************************
// This program will solve equations using 
// recursive function. The first function is
// Summation, the second is BaseExponet,
// and the third is Product.
//***********************************************
#include<iostream>
using namespace std;

int Summation(int n1);
int BaseExponent(int base, int expo);
int Product(int n1);
//***********************************************
// The Summation function will take all the odd 
// numbers from n1 and add them all together.
// Summation requires N1 from main. and returns
// n1
//***********************************************
int Summation(int n1)
{
	if (n1 > 0)
	{
		if (n1 % 2 == 1)
		{
			return(n1 + Summation(n1 - 2));
		}
		else
		{
			Summation(n1 - 1);
		}
	}
	else
		return 0;
}
//***********************************************
// BaseExponent will take a base number as well 
// as an exponent number and will multiply the  
// base number the exponent number of times.
// BaseExponent requires base, and expo from main
// and returns the base to the exponent times.
//***********************************************
int BaseExponent(int base, int expo)
{
	if (expo == 0)
		return 1;
	else if (expo > 0)
		return base * BaseExponent(base, expo - 1);
	else
		return 1 / BaseExponent(base, -expo);

}
//***********************************************
// Product will take all the even numbers between
// 1 and n1 and multiply them together. Product
// requires n1 from the main. and returns product
//***********************************************
int Product(int n1)
{
	if (n1 > 0)
	{
		if (n1 % 2 == 0)
		{
			return(n1 * Product(n1 - 2));
		}
		else
		{
			Product(n1 - 1);
		}
	}

	else
		return 1;
}

int main()
{
	int n1;
	int base = 0, expo = 0;
	cout << "========================================================" << endl;
	cout << "Please ender a number to be Summation of all odd numbers." 
		<< endl;
	cin >> n1;
	cout << Summation(n1) << endl;
	cout << "========================================================" << endl;
	cout << "Please enter a base number and a exponent number." << endl;
	cin >> base;
	cin >> expo;
	cout << BaseExponent(base, expo) << endl;
	cout << "========================================================" << endl;
	cout << "Please ender a number to compute product of all even " << endl;
	cout <<	"numbers between 1 and your number." << endl;
	cin >> n1;
	cout << Product(n1) << endl;
	cout << "========================================================" << endl;
	system("pause");
	return 0;
}