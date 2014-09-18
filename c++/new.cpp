#ifndef CARRO_H
#define CARRO_H
#include <string>
#include <iostream>
#include <stdlib.h>
#include <sstream>
using namespace std;

#define private public

class Carro{
private:
	bool _manejando;
	string _id;
	int _velocidad;
public:
	Carro(){
		_manejando = false;
		_id = "";
		_velocidad = 0;
	};
	Carro(string id, bool manejando, int velocidad){
		_manejando = manejando;
		_id = id;
		_velocidad = velocidad;
	};
	void Manejar(){
		_manejando = true;
	};

	string toString(){
		stringstream ss;
		ss << _velocidad;
		if( _manejando )
			return "En movimiento: " + _id + " a velocidad: " + ss.str();
		else
			return "Estacionado.";
	};
};

#endif

int main(){
	Carro *c = new Carro("123", false, 120);
	c->_manejando = true;

	cout << c->toString() << endl;

	string str = new(c) Carro().toString();

	cout << str << endl;

	free( c );
	return 0;
}
