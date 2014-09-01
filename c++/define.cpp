#ifndef CARRO_H
#define CARRO_H
#include <string>
#include <iostream>
#include <stdlib.h>
using namespace std;

#define private public

class Carro{
private:
	bool _manejando;
	string _id;
public:
	Carro(){
		_manejando = false;
		_id = "";
	};
	Carro(string id){
		_manejando = false;
		_id = id;
	};
	void Manejar(){
		_manejando = true;
	};

	string toString(){
		if( _manejando )
			return "En movimiento: " + _id;
		else
			return "Estacionado.";
	};
};

#endif

int main(){
	Carro *c = new Carro("123");
	c->_manejando = true;

	cout << c->toString() << endl;
	free( c );
	return 0;
}