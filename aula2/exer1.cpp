#include <iostream>
#include <iomanip>
using namespace std;
int main() {
    double raio, area;
    double pi = 3.14159;
    cout << "Digite o raio: ";
    cin >> raio;
    area = pi * raio * raio;
    cout << fixed << setprecision(4);
    cout << "A=" << area << endl;
    return 0;
}