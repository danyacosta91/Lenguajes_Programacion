#include <iostream>
#include <sstream>
#include <string>
#include <vector>
using namespace std;

class Alumno
{
private:
	string _nombre;
	double _nota;
public:
	Alumno(string nombre, double nota){
		_nombre = nombre;
		_nota = nota;
	};
	string toString(){
		stringstream ss;
		ss << _nota;
		return "Alumno: " + _nombre + " con nota: " + ss.str();
	};

	~Alumno();
};

int main(){
	std::vector<Alumno*> v;
	v.push_back( new Alumno("PEDRO JUAN", 59.3) );
	v.push_back( new Alumno("CARLOS JOSE", 59.4) );
	v.push_back( new Alumno("ANA RUTH", 59.2) );
	v.push_back( new Alumno("CARMEN FIORELLA", 59.5) );
	v.push_back( new Alumno("PANCRACIA ANASTACIA", 100) );

	for( Alumno *i : v )
		cout << i->toString() << endl;

	return 0;
}