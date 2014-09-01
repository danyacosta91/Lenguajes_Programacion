#include <iostream>
#include <vector>
#include <string>
using namespace std;

void ret_varios( int* a, int* b, int* c ){
	*a = 5;
	*b = 10;
	*c = 100;
}
int main(){
	int _a = 0, _b = 0, _c = 0;
	ret_varios( &_a, &_b, &_c );

	cout << "Suma es: " << _a + _b + _c << endl;

	return 0;
}