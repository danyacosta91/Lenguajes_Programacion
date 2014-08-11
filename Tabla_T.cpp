#include <iostream>
#include <string>
#include <string.h>
#include <stdlib.h>
using namespace std;

bool validar( const char * _str, char** _data ){
	bool _change = false;
	for (int i = 0; i < strlen( _str ); ++i){
		if( i == 0 )
			if( _data[0][0] != _str[i] )
				return false;
		else{
			if( _change == false ){
				do{
					i++;
				}while( _data[0][0] == _str[i] );

				_change = true;
			}else{
				if( _data[1][0] != _str[i] )
					return false;

				do{
					i++;
					if( _data[1][0] != _str[i] )
						return false;
				}while( _data[1][0] == _str[i] );

				if( _data[1][0] != _str[i] )
					return false;
			}
		}
	}
	return true;
}

int main(){
	char** _m = new char*[2];
	for( int i = 0; i < 2; i++ )
		_m[i] = new char[2];

	_m[0][0] = '1';_m[0][1] = '0';
	_m[1][0] = '0';_m[1][1] = ' ';

	string _get = "";

	do{
		cout << "Ingrese cadena (exit - salir):" << endl;
		cin >> _get;
		if( strcmp( "exit", _get.c_str() ) == 1 ){
			if( validar( _get.c_str(), _m ) )
				cout << "Cadena correcta!" << endl;
			else if( validar( _get.c_str(), _m ) == false )
				cout << "Cadena incorrecta!" << endl;
		}
	}while( strcmp( "exit", _get.c_str() ) == 1 );

	free( _m );
	return 0;
}