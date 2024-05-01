//************************************************
//    Assingment #2
//    Name: timothy Lockhart
//    Data Structures Date: 3/4/2020
//************************************************
// Assingment #2 was to have overloaded functions
// as well as having class phaser to make functions
// for A, B, C, and D. and to divide B and C to 
// create D. then format them in a neat arangents
//******************************z*****************
#include<iostream>
using namespace std;
//************************************************
//class phaser has the getter and setter for 
// A, B, C, and D. as well as originaly setting 
//them to 0.
//************************************************
class phaser {
public:

    void setmagnitude( double mag);
    void setphase( double pha );
    double getmagnitude( void );
    double getphase( void);
    phaser(); 
    ~phaser(); 
  
private:
    double magnitude = 0, phase = 0;
};

//************************************************
// this is the constructor of phase
//************************************************
phaser::phaser(void) {}
//************************************************
//this is the deconstructor of phase 
//******************************z*****************
phaser::~phaser(void) {}
//************************************************
// void line::setmagnitude() 
// sets magnitude to mag.
//************************************************
void phaser::setmagnitude(double mag) 
{
    magnitude = mag;
}
//************************************************
// void line::setphase()
// makes sure that phase is not more then 360
// or less then 0.
// sets pha to phase.
//************************************************
void phaser::setphase(double pha) 
{
    while (pha > 360)
        pha = pha - 360;
    while (pha < 0)
        pha = pha + 360;

    phase = pha;
}
//************************************************
// this is the getter magnitude, requires magnitude
//******************************z*****************
double phaser::getmagnitude(void) {
    return magnitude;
}
//************************************************
// this is the getter phase, requires phase.
//******************************z*****************
double phaser::getphase(void) {
    
    return phase;
}
//************************************************
//class complex will overloade the / function 
//so you are able to compile D = B /C
//************************************************
class Complex {
private:
    int real, imag;
public:
    Complex(double r = 0, double i = 0) { real = r;   imag = i; }

     
    Complex operator / (Complex const& obj) {
        Complex res;
        res.real = real / obj.real;
        res.imag = imag / obj.imag;
        return res;
    }
};

    

    
//************************************************
// Main function
//************************************************
int main() 
{
    phaser A, D;
    phaser B, C;

    A.setmagnitude(3);
    A.setphase(-45);

    B.setphase(-sqrt(2));
    B.setmagnitude(sqrt(2));

    C.setphase(sqrt(2));
    C.setmagnitude(sqrt(3));

    D.setmagnitude(B.getmagnitude() / C.getmagnitude());
    D.setphase(B.getphase() / C.getphase());

    cout << "=====================================" << endl;
    cout << "This is A " << endl;
    cout << "Magnitude: "  << A.getmagnitude() << "          " << "Phase: " 
        << A.getphase() << endl;
    cout << "=====================================" << endl;
    cout << "This is B " << endl;
    cout << "Magnitude: " << B.getmagnitude() << "    " << "Phase: "
        << B.getphase() << endl;
    cout << "=====================================" << endl;
    cout << "This is C " << endl;
    cout << "Magnitude: " << C.getmagnitude() << "    " << "Phase: "
        << C.getphase() << endl;
    cout << "=====================================" << endl;
    cout << "This is D = B / C " << endl;
    cout << "Magnitude: " << D.getmagnitude() << "   " << "Phase: "
        << D.getphase() << endl;
    cout << "=====================================" << endl;
    
    system("Pause");
    return 0;
}

