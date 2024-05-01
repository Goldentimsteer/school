//***************************************************************************
//							Assingment #4
//							Name: Timothy Lockhart
//							Data Structure 4/11/2020
//***************************************************************************
//	Using pointers the program has a 2d array called arr2d and uses has the 
//	user imput what size the square matrix will be. Once created useing the 
//	rand() function it creates a matrix from the value 1000 - 6000. The 
//	numbers will represent a person SSN and will sort throught them to figure
//	out where your number belongs. After that using the SSN the last number
//	will deterimin if you are a male or femail and will sort that out as well
//***************************************************************************

#include <iostream>
using namespace std;

void gender(int, int **, int);
void SNN(int , int **);

int main()
{	
	cout << "Please type the size of the squared matrix" << endl;
	int size;
	cin >> size;

	int** arr2d;
	arr2d = new int* [size];
	for (int i = 0; i < size; ++i)
		arr2d[i] = new int[size];

	for (int i = 0; i < size; ++i)
		for (int j = 0; j < size; ++j)
		{
			arr2d[i][j] = rand() % 5000 + 1000;
		}
		
	cout << "======================================================" << endl;
	cout << endl;
	cout << "The Matrix:" << endl;
	for (int i = 0; i < size; ++i)
	{
		for (int j = 0; j < size; ++j)
		{
			cout << arr2d[i][j] << "  ";
		}
		cout << endl;
	}
	
	SNN(size, arr2d);

	system("pause");
	return 0;
}
//***************************************************************************
//	SNN this function needs the Size of the array and the array. once it has
//	that the function will sort out the SSN and takes note of where the SSN
//	takes place. Does not return a value.
//***************************************************************************
void SNN(int size, int** arr2d)
{
	int SSN1 = 0, SSN2 = 0, SSN3 = 0, SSN4 = 0, SSN5 = 0, total = 0;

	for (int i = 0; i < size; ++i)
		for (int j = 0; j < size; ++j)
		{
			if (arr2d[i][j] < 2000)
				++SSN1;
			if (arr2d[i][j] < 3000)
				if (arr2d[i][j] >= 2000)
					++SSN2;
			if (arr2d[i][j] < 4000)
				if (arr2d[i][j] >= 3000)
					++SSN3;
			if (arr2d[i][j] < 5000)
				if (arr2d[i][j] >= 4000)
					++SSN4;
			if (arr2d[i][j] > 5000)
				++SSN5;
		}


	total = SSN1 + SSN2 + SSN3 + SSN4 + SSN5;
	cout << "======================================================" << endl;
	cout << "the following summarizes the SSNs in Tiny Ville" << endl;
	cout << "SSN: 1000s =" << SSN1 << endl;
	cout << "SSN: 2000s =" << SSN2 << endl;
	cout << "SSN: 3000s =" << SSN3 << endl;
	cout << "SSN: 4000s =" << SSN4 << endl;
	cout << "SSN: 5000s =" << SSN5 << endl;
	cout << "The total number of habitants in Tiny villle is = "
		<< total << endl;

	gender(size, arr2d, total);
}
//***************************************************************************
//	Gender is called from the SNN fucntion and requires the size, the array, 
//	and the total. The Function will use the SNN to find if you are a male or
//  female. The function does not return anything. 
//***************************************************************************
void gender(int size, int **arr2d, int total)
{
	int men = 0, woman = 0;
	for (int i = 0; i < size; ++i)
	{
		for (int j = 0; j < size; ++j)
		{
			if (arr2d[i][j] % 2 == 0)
				++woman;
			else
				++men;
		}

	}
	cout << "======================================================" << endl;
	cout << endl;
	cout << "The following summarized the Genders in Tiny Ville" << endl;
	cout << "The totoal number of habitants in Tiny villle is = "
		<< total << endl;
	cout << "Tiny Ville has = " << woman << "Woman" << endl;
	cout << "Tiny Ville has = " << men << "Men" << endl;;
	cout << "======================================================" << endl;
	
}

