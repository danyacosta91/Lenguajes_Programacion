#include <iostream>
using namespace std;

class Carro
{
    public:
    bool _manejando;
};

int main()
{
    Carro c1;
    c1._manejando = true;
    cout << "MANEJANDO!" << endl;
    c1.*pSpeed = false;
    cout << "ESTACIONADO!" << endl;

    return 0;
}