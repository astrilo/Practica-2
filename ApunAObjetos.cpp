#include <iostream>
#include <cstdlib>
using namespace std;

class alumno {
      string nombre;
      int edad;
      int semestre;
      string carrera;
public:
      alumno(string nom, int ed, int sem, string car) {
          nombre = nom;
          edad = ed;
          semestre = sem;
          carrera = car;
      }
      // Accesores o getters
      string getNombre() {
          return nombre;
      }
      int getEdad() {
          return edad;
      }
     string getCarrera() {
          return carrera;
      }
      //Mutadores o Setters
      void setNombre(string nom) {
          nombre = nom;
      }
      void setEdad(int ed) {
          edad =ed;
      }
};

int main() {
    //Alumno estatico
     alumno alue("Leornardo Castillo", 20, 2, "Ing en Ciencias Computacionales");
     //Alumno declarado dinamico
     alumno *alud = new alumno("Alicia Machado", 21, 4, "Medico Cirujano");
     alue.setNombre("Leonardo Fabian Castillo");
     alud->setNombre("Alicia Machado Castro");
     alue.setEdad(21);

     cout << alue.getNombre() << " " << alue.getCarrera() << endl
             << alud->getNombre() << " " << alud->getCarrera() << endl;

    return EXIT_SUCCESS;
}
