#include <iostream>
#include <string>
#include <string.h>
#include <stdlib.h>
using namespace std;

bool validar( const char * _str, char** _data ){
	return false;
}

int main(){
	char** _m = new char*[2];
	for( int i = 0; i < 2; i++ )
		_m[i] = new char[2];

	_m[0][0] = 'p';_m[0][1] = 'q';
	_m[1][0] = 'q';_m[1][1] = ' ';

	string _get = "";

	do{
		cout << "Ingrese cadena (exit - salir):" << endl;
		cin >> _get;
		if( validar( _get.c_str(), _m ) )
			cout << "Cadena correcta!" << endl;
		else
			cout << "Cadena incorrecta!" << endl;
	}while( strcmp( _get.c_str(), "exit" ) == 1 );

	free( _m );
	return 0;
}