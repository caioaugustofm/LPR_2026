#include <iostream>
using namespace std;

int main() {
    int vetor[10];
    int numero;
    int count = 0;
    cout << "Digite 10 números inteiros:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << "Posição " << i << ": ";
        cin >> vetor[i];
    }
    cout << "\nDigite o número que deseja pesquisar: ";
    cin >> numero;
    cout << "\nResultado da pesquisa:" << endl;
    for (int i = 0; i < 10; i++) {
        if (vetor[i] == numero) {
            cout << "Encontrado na posição " << i << endl;
            count++;
        }
    }
    if (count > 0) {
        cout << "Total de ocorrências: " << count << endl;
    } else {
        cout << "Número não encontrado no vetor." << endl;
    }    
    return 0;
}