#include <iostream>
using namespace std;

Factorial<int, int> Factorial = x => x < 0 ? -1 : x == 1 || x == 0 ? 1 : x * Factorial(x - 1);

int main(){
	int n;
	cout << "Ingrese n:" << endl;
	cin >> n;

	cout << "Factorial es: " << Factorial(n) << endl;

	return 0;
}