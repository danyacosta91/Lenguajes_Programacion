#include <iostream>
#include <vector>
#include <string>
#include <stdlib.h>
using namespace std;

struct Carro{
	bool manejar;
};

void Manejar( Carro* c ){
	c->manejar = true;
}

int main(){
	Carro *A = new Carro();
	Manejar( A );
	Carro B;
	Manejar( &B );

	free( A );
	return 0;
}