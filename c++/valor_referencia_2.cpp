#include <iostream>
#include <vector>
#include <string>
#include <stdlib.h>
using namespace std;

void llenarArreglo( int *A, int tam ){
	for(int i = 0; i < tam; i++)
		A[i] = (i*(i+1))/2;
}

int main(){
	int* A = new int[5];
	llenarArreglo( A, 5 );
	int B[5];
	llenarArreglo( B, 5 );

	cout << "Arreglo A" << endl;
	for (int i = 0; i < 5; ++i)
		cout << A[i];
	cout << endl << "Arreglo B" << endl;
	for (int i = 0; i < 5; ++i)
		cout << B[i];
	cout << endl;

	free( A );
	return 0;
}