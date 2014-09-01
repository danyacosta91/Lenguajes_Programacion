#include <iostream>
#include <vector>
#include <string>
using namespace std;

int main(){
	int _A[5];
	for( auto i = 0; i < 5; i++ )
		_A[i] = (i+1)/2;

	vector<string> _vec;
	int cont = 0;
	for( auto it = _vec.begin(); it != _vec.end(); it++ ){
		auto _add = "" + _A[cont];
		_vec.push_back( _add );
	}

	return 0;
}