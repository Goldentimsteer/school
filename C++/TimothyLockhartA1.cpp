/*
Timothy Lockhart
9/14/2022
Description:
Compute the Summation, Base and Exponant, and the product of the numbers
the user inputs, If the user inputs an incorrect value, it will ask for 
a correct value.
*/
#include <iostream>
using namespace std;
unsigned long long int summation(unsigned long long int);
unsigned long long int BaseExponent(unsigned long long int, int);
unsigned long long int Product(unsigned long long int);
int num(int);

int main()
{
	unsigned long long int sum, exp, prod = 0;
	int num1 ,num2, num3, num4 = 0;
	/*summation*/
	cout << "Please insert a number for a summation" << endl;
	cin >> num1;
	num1 = num(num1);
	sum = summation(num1);

	
	/*Base and Exponant*/

	cout << "Please insert two numbers, a base and an exponant" << endl;
	cin >> num2;
	num2 = num(num2);
	cin >> num3;
	num3 = num(num3);
	exp = BaseExponent(num2, num3);

	
	/*Product*/
	cout << "Please enter a number for a product" << endl;
	cin >> num4;
	num4 = num(num4);
	prod = Product(num4);
	
	/*typing to console*/
	cout << "The Summation of all odd numbers between " << num1 
		<< " and 1 is:" << endl;
	cout << sum << endl;
	cout << "The Number " << num2 << " to the power of " << num3
		<< " is:" << endl;
	cout << exp << endl;
	cout << "The product of all even numbers between " << num4 
		<< " and 1 is:" << endl;
	cout << prod << endl;
	
	return 0;
}
/*
the summation function will add the number entered 
*/
unsigned long long int summation(unsigned long long int num)
{
	if (num == 1)
		return num;
	else if (num % 2 == 0)
		return summation(num - 1);
	else
		return (num + summation(num - 2));

}
/*
the Base Exponent function takes the base and multiplies it by the exponant
time using recrsive.
*/
unsigned long long int BaseExponent(unsigned long long int base , int exp)
{
	if (exp != 0)
		return (base * BaseExponent(base, exp - 1));
	else
		return 1; 
	
}
/*
The Product fucntion is a recrsive function to calculate the product
of all even numbers between the entered number and 0.
*/
unsigned long long int Product(unsigned long long int prod)
{
	if (prod == 0)
		return prod + 1;
	else if (prod % 2 == 0)
		return (prod * Product(prod - 2));
	else
		return Product(prod - 1);
	
}

/*
Int num is given the value number, then checks if the number is bigger
then 0. If not, will continue to ask until the correct value is entered.
*/
int num(int number)
{
	while (number <= 0)
	{
		cout << "please insert a number bigger then 0" << endl;
		cin >> number;
	}
	return number;
}