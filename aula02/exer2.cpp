#include <iostream>

using namespace std;

int main() {
    int a, b, c, d, dif;
  cout << "Digite o valor de a: ";
    cin >> a;
    cout << "Digite o valor de b: ";
    cin >> b;
    cout << "Digite o valor de c: ";
    cin >> c;
    cout << "Digite o valor de d: ";
    cin >> d;
    dif = (a * b - c * d);
    cout << "Diferenca = " << dif << endl;
    return 0;
}