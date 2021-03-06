#include <iostream>
#include <sstream>
#include <string>
#include <vector>
using namespace std;

class Alumno
{
private:
	string _nombre;
	string _correo;
	double _nota;
public:
	Alumno(string nombre, string correo, double nota){
		_nombre = nombre;
		_nota = nota;
		_correo = correo;
	};
	string toString(){
		stringstream ss;
		ss << _nota;
		return "Alumno: " + _nombre + " con nota: " + ss.str() + " con correo: " + _correo;
	};

	~Alumno();
};

int main(){
	std::vector<Alumno*> v;
	v.push_back( new Alumno("PEDRO JUAN", "pedro.juan@gmail.com", 59.3) );
	v.push_back( new Alumno("CARLOS JOSE", "carlos.jose@gmail.com", 59.4) );
	v.push_back( new Alumno("ANA RUTH", "ana.ruth@gmail.com", 59.2) );
	v.push_back( new Alumno("CARMEN FIORELLA", "carmen.fiorella@gmail.com", 59.5) );
	v.push_back( new Alumno("PANCRACIA ANASTACIA", "pancracia.anastacia@gmail.com", 100) );

	for( Alumno *i : v )
		cout << i->toString() << endl;

	return 0;
}