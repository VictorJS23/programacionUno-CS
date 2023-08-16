
using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Hola mundo");

//// realize el factorial de un numero 

//int num = 5;

//int factorial = 1;

//for (int i = 1; i <= num; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine($"El factorial de {num} es: {factorial} \n");

/*
 * si en un dado caso la consola se cerrara se tiene que poner el comando
 * Console.ReadKey();
 */

//String nombre = "Victor";
//Console.WriteLine(nombre);

//bool isMoreThan25 = true;
//Console.WriteLine(isMoreThan25);

//Definicion de constantes (no pueden cambiar su valor)

//const int edad = 24;

//Console.WriteLine("Ingrese su edad: ");
//int edadUno;

//edadUno = Convert.ToInt32(Console.ReadLine()); // Esto lo que hace es leer la linea

//Otra manera de concatenar

// string nombreVariable = string.Concat(variableUno, variableDos);


// Decir si un arreglo esta ordenado

//Console.WriteLine("Ingrese un numero para el arreglo");

//int[] array = new int[5];

//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}

//bool validation = true;

//for(int i = 0; i < array.Length; i++)
//{
//    if (array[i] > array[i+1])
//    {
//        validation = false;
//        break;
//    }
//}

//if(validation == true)
//{
//    Console.WriteLine("El arreglo esta ordenado");

//} else
//{
//    Console.WriteLine("El arreglo no esta ordenado");
//}

// Ordenar un arreglo 

//int[] array = { 1, 6, 7, -3, 0, 2 };

//int aux;

//for(int i = 0; i < array.Length; i++)
//{
//    for(int j = 0; j < array.Length-1; j++)
//    {
//        if (array[j] > array[j + 1])
//        {
//            aux = array[j];           
//            array[j] = array[j + 1];  
//            array[j + 1] = aux;
//        }
//    }
//}

//foreach(int item in array)
//{
//    Console.WriteLine(item);
//}

// Decir si un valor se encuentra en el arreglo o no

//string[] array = { "victor", "dietmar", "brandon" };

//Console.WriteLine("Ingrese un nombre a buscar");
//string name;
//name = Console.ReadLine();

//name.ToLower();

//bool validation = false;

//for(int i = 0; i < array.Length; i++)
//{
//    if(name == array[i])
//    {
//        validation = true;
//        break;
//    }
//}

//if(validation == true)
//{
//    Console.WriteLine("El nombre si existe");
//} else
//{
//    Console.WriteLine("El nombre no existe");
//}

/*
 Crear un programa que registre 10 Autos, con todos los atributos definidos anteriormente
motor, llantas, marca, modelo, puertas, color, placa, vim
 */


// ESTE ES PRIMER COMMIT DEL REPOSITORIO //

//**********************************************************************************************************

//string[] motor = new string[10];
//string[] llantas = new string[10];
//string[] marca = new string[10];
//string[] modelo = new string[10];
//int[] puertas = new int[10];
//string[] color = new string[10];
//string[] placa = new string[10];
//string[] vin = new string[10];

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Auto n° {i + 1} \n ");
//    Console.Write("Motor: "); motor[i] = Console.ReadLine();
//    Console.Write("Llantas: "); llantas[i] = Console.ReadLine();
//    Console.Write("Marca: "); marca[i] = Console.ReadLine();
//    Console.Write("Modelo: "); modelo[i] = Console.ReadLine();
//    Console.Write("Puertas: "); puertas[i] = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Color: "); color[i] = Console.ReadLine();
//    Console.Write("Placa: "); placa[i] = Console.ReadLine();
//    Console.Write("Vin: "); vin[i] = Console.ReadLine();
//    Console.WriteLine("\n");
//}

//Console.WriteLine("Acontinuacion la impresion de las Caract. ingresadas de los autos \n");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Auto n° {i + 1} \n ");
//    Console.WriteLine($"Motor: {motor[i]}");
//    Console.WriteLine($"Llantas: {llantas[i]}");
//    Console.WriteLine($"Marca: {marca[i]}");
//    Console.WriteLine($"Modelo: {modelo[i]}");
//    Console.WriteLine($"Puertas: {puertas[i]}");
//    Console.WriteLine($"Color: {color[i]}");
//    Console.WriteLine($"Placa: {placa[i]}");
//    Console.WriteLine($"Vin: {vin[i]}");
//    Console.WriteLine("\n");
//}

//**********************************************************************************************************

// Metodos

/*

    tipoDatoDelMetodo NombreMetodo (parametros){
        cuerpo del metodo
    }

 */

// Un metodo sin parametros

//int sumaNumeros()
//{
//    int num1 = 7;
//    int num2 = 9;

//    int result = num1 + num2;

//    return result; // valor que devolvera el metodo

//}

//// Un metodo con parametros
//int sumaNumerosDos(int num1, int num2)
//{

//    int result = num1 + num2;

//    return result; // valor que devolvera el metodo

//}

// Sintaxis a usar

// void jamas llevara la funcion return

//static void mensajeConsola()
//{
//    Console.WriteLine("Este es un mensaje desde un metodo");
//}

//mensajeConsola(); // esto seria una llamada al metodo

//// metodo que sume numeros

//static void addNumbers(int numOne, int numTwo)
//{
//    Console.WriteLine($"La suma de los numeros es: {numOne + numTwo}");
//}

////Llamada del metodo

//addNumbers(6, 4);

//Console.WriteLine("Ingrese un numero");
//int numberOne = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese un numero");
//int numberTwo = Convert.ToInt32(Console.ReadLine());

//addNumbers(numberOne, numberTwo);

//*************************************************************************************************************

// ° Metodos con return

// en metodos con return no se usa void(este es un metodo sin retorno)

//static int addNumbers(int numOne, int numTwo) // esto dice que al final de la ejecucion del metodo devolvera un dato de tipo entero
//{
//    return numOne + numTwo;
//}

//Console.WriteLine(addNumbers(3,3));

//Console.WriteLine("Ingrese un numero");
//int numberOne = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese otro numero");
//int numberTwo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(addNumbers(numberOne, numberTwo));

/*
  En cuanto hay una llamada a un metodo, el flujo de ejecucion pasa a ese metodo
  !!! Una instruccion return siempre devuelve el flujo de ejecucion a la llamada, es decir en cuanto se 
  en codigo se encuentra un return se sale del metodo y devuelve el flujo de ejecucion donde se produjo 
  la llamada.

  un return solo osea (return;) sirve para decirle al codigo que salga del bucle o metodo (aunque es mala practica)
 */

// otra manera de hacer un metodo (es una nomeclatura), pero solo cuando este tiene una linea de codigo
// Esta manera lo que hace es precindir de la funcion return

//static int function(int a, int b) => a + b;

//Console.WriteLine($"La suma es: {function(5, 5)}");

//*********************************************************************************************************

// ° Ambito y sobreCarga
// ambito o alcance de las variables y la sobrecarga de metodos

// ambito o alcance del metodo es todo lo que se encuentra dentro del codigo entre {} y todo lo que sea
// declarado dentro de ellas tendras validez y solo sera visible dentro de ese ambito o alcance.

//class program // Este class program se creo para demostrar el ambito de las variable
//{
/*
 Para compartir variables entre diferentes metodos de una misma clase se deben declara las variables
no como ambito local(dentro de un metodo) sino como AMBITO DE CLASE(dentro de la clase), esta es la
excepcion dicha en la linea 309 a 311.
 */

//int numeroUno = 5;
//int numeroDos = 7;

// se pueden declarar en cualquier momento e incluso iniciarlas
//Como se ve estas variables son visibles y accesibles tanto desde firstMethod como de secondMethod
// o cualquier otro metodo esto de debe a porq el ambito de estas estan comprendidas dentro de las {}
// de class program y todo lo que este entre ellas podran acceder a estas

// las variables que estan declaradas con ambito de clase se les denomina "campo ó campos de clase"

//void firstMethod() // no es necesario que sea static ya que no se llamara desde el metodo main
//{
//    //Console.WriteLine(numeroUno + numeroDos);

//    // esto daria error ya que hay una EXCEPCION, y es que cuando se declara una variable no con ambito de
//    // metodo (ambito local) sino con ambito de clase, es decir dentro de una clase pero fuera de cualquier
//    // metodo, en estos casos el flujo de ejecucion es permisivo


//    Console.WriteLine(numeroUno + numeroDos);
//}

//void secondMethod()
//{
//    //Console.WriteLine(numeroUno); Este codigo dara error !!!

//    /*
//     Este codigo da error ya que no existe en contexto actual (ambito o alcance).

//    Ya que solo se puede acceder a ella desde su ambito en cuanto el metodo termina su ejecucion, todo 
//    lo que hay en su interior desaparece de la memoria y queda fuera del alcance de cualquier otro sitio

//    Es decir que la variable numeroUno tiene un "ambito local" 
//     */

//    Console.WriteLine(numeroUno + numeroDos);

//}

// Sobrecarga de metodos ******************************************************************************

// Esta se produce cuando se tiene en el mismo ambito (o clase) dos o mas metodos con el mismo nombre

//static hace que se puedan llamar desde el metodo main 

// para que la sobrecarga se cumpla, estos metodo deben recibir diferentes tipos de parametros
// o diferente numero de parametros.

//static int Suma(int operador1, int operador2) => operador1 + operador2;

//static int Suma(int numero1, double numero2) => numero1;

//static double Suma(double numero1, double numero2, double numero3) => numero1 + numero2 + numero3;

//static void Main(string[] args)
//{

//  Console.WriteLine(Suma(7,5.3)); // el compilador es el que distingue que metodo usar debido a los parametros

//}


//}

//***********************************************************************************************************

// ° PARAMETROS OPCIONALES

//class program 
//{

//    static void Main(string[] args) 
//    {
//        int valor1 = 7;

//        double valor2 = 5.2;

//        double valor3 = 8.3;

//        Console.WriteLine(Suma(valor1, valor2));

//     // no da un error por no poner valor3 ya que no se pasa el parametro de este ya que es opcional
//     // se podria agregar en cualquier momento y no toma el valor de 0 toma el valor que se le pase
//     // TODO PARAMETRO OPCIONAL DEBE DE IR SEGUIDO A LOS OBLIGATORIOS (al final)!!!

//    }

//    // para que un parametro sea opcional hay que asignarle un valor por defecto

//    static double Suma(int num1, double num2, double num3 = 0) // fuciona parecido a la sobrecarga sin que este presente
//    { 
//        return num1 + num2 + num3; 
//    }

//    // ambiguedades ************************************************************************************

//    static double Suma(int num1, double num2) 
//    {
//        return num1 + num2;
//    }

//    //basicamente se hace la llamada al metodo que mas se adapte a los parametros

//}

// Excepciones ***************************************************************************************

// que son las exepciones
// que es el manejo o captura de excepciones

/*Las excepciones son errores en tiempo de ejecucion del programa que escapan al control del 
 programador
algunos mencionados

 memoria corrupta
desbordamiento de pila
sectores de disco duro defectusos
conexiones a bases de datos... etc

 estos provocan que el programa caiga*/

// POO *****************************************************************************************************

/*
 Consiste en que los objetos tiene un estado, un comportamiento(que puede hacer) y sus propiedades

° Modificadores de acceso:

Public - accesible desde cualquier parte
Private - accesible solo desde la propia clase
Protected - accesible desde clase derivada
internal - accesible desde el mismo ensamblado
protected internal - accesible desde el mismo ensamblado o clase derivada de otro ensamblado
private protected - accesible desde la misma clase o clase derivada del mismo ensamblado
por defecto - accesible desde el mismo paquete

Clase
Modelo donde se redactan las caracteristicas comunes de un grupo de objetos.

Objeto
son los que derivan de la clase

- tiene propiedadades(atributos)
- tiene un comportamiento(metodos o funciones), (que es capaz de hacer?)

 */

//namespace EjemploPOO
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            // el primer objeto de la clase circulo Ó la primera instancia de tipo circulo


//            Circulo miCirculo; // esto es una creacion de objeto de tipo circulo. Variable/objeto de tipo Circulo

//            // como se la un valor

//            miCirculo = new Circulo(); // esto se llama iniciazion de variable/objeto de tipo circulo. Intanciar una clase
//                                       // Se le puede denominar Instanciacion, Ejemplarizacion, Creacion de ejemplar de clase.

//            //Console.WriteLine(miCirculo.CalculoArea(3));

//            ConversorEuroDollar obj = new ConversorEuroDollar();

//            obj.cambiarValorEuro(-3);

//            Console.WriteLine(obj.convert(50));
//        }
//    }

//    class Circulo
//    {
//        // todo el codigo de la clase circulo
//        // area de un circulo es PI* r^2

//        private const double pi = 3.1416; // esto es una propiedad de la clase circulo. Cuando estan definidas dentro de una 
//                            // clase se les denomina Campo de clase.

//        // crear un metodo que sea capaz de calcular su area

//        public double CalculoArea(int radio) // metodo de clase. Esto es el comportamiento de los objetos de circulo
//        {
//            return pi * Math.Pow(2, radio);
//        }

//     // Encapsulamiento y convenciones **************************************************************************

//     //cuando no sea necesario que una variable o constante o incluso metodo sea accesible desde fuera de su clase
//     // se encapsula (private) solo sera visible desde la clase donde se encuentra (aunque en C#
//     // ya esta "por defecto")

//     // como regla general cuando una clase se usa variables, constantes, datos estas deben estar encapsuladas
//     // y si se necesita acceder a ellas fuera de su clase se hara a travez de un "metodo de acceso"



//        // convenciones***********************************************************************

//        /*
//         Los identificadores "public" deben de comenzar con letra mayuscula (PascalCase), y los que no
//        son "public" deben comenzar con letra minuscula (camelCase)
//         */

//    }

//    class ConversorEuroDollar
//    {
//        private double euro = 1.253;

//        public double convert(double cantidad)
//        {
//            return euro * cantidad;
//        }

//        public void cambiarValorEuro(double newValue)
//        {
//            if (newValue < 0) euro = 1.253;

//            else
//                euro = newValue;

//            // esta validacion se hace ya que este valor si bien puede cambiar su valor,
//            // jamas este sera < 0 por lo tanto se hace este metodo
//        }
//    }

//}


// Constructores ***************************************************************************************
/*
   Los constructores tiene como finalidad dar un estado inicial a los objetos (se podra modificar despues)
 */

//**********************************++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// getters & setters
// uso del this
// dividir (split) las clases largas

// Ejemplo llamado usoCoches

namespace UsoCoche
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche coche1 = new Coche(); // esto es un objeto o instancia de la clase Coche
            // esto es dar un estado inicial a nuestro coche1

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            // si yo por ejmp quisiera crear un coche que no tenga el mismo estado inicial, hay que crear
            // mas de un constructor, y a esto se le llama sobrecarga de constructores
            // se produce cuando se tiene mas de un constructor (debe resibitr diferente numero de parametros)

            Coche coche3 = new Coche(4500.25, 1200.35);// esto lo que hace es que llama al constructor que
                                                       // si tiene parametros

            Console.WriteLine(coche3.getInfoCoche());

            coche3.setExtras(true, "cuero");

            Console.WriteLine(coche3.getExtras());


        }
    }

    // Only separator of the class principal Main ***************************************************

    partial class Coche
    {

        // constructor obligado DEBE TENER EL MISMO NOMBRE DE LA CLASE Y NO PUEDE DEVOLVER NINGUN DATO
        // Y TAMPOCO PUEDE SER VOID

        public Coche()
        {
            // aca se define el estado inicial de la clase, en este caso "estado inicial del Coche"
            // este sera el estado inicial de los objetos derivados de la clase Coche

            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

            tapiceria = "tela";

        }


        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;

            tapiceria = "tela";

    // poder acceder a estas propiedades de inicio hay que hacer un "metodo de acceso"
    // este tipo de metodos que permiten acceder a propiedades se les denomina metodos getter
    // son las que dan informacion de propiedades (es por convencion)

        }
    }
        // en algunos casos es importamte particionar las clases ya que el codigo dentro de una clase
        // podrias llegar a ser poco legible ********************************************************

    partial class Coche {

        public string getInfoCoche()
        {
            return $"Informacion de coche: ruedas: {ruedas}....Largo: {largo}....Ancho: {ancho}";
        }

        //Metodo setter(establecer) esta dedicado a establecer propiedades a los objetos, estos no devuelven nada
        // tiene que ir a compañado de un getter
        // el objetivo de este es establecer un valor 

        public void setExtras(bool climatizador, string tapiceria)// son los parametros que le queremos pasar el metdo
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;

            //Uso del this sirve para diferenciar cuando se refiere a un campo de clase o a un parametro
            // al poner this en este caso climatizador y tapiceria "this" hace que haga referencia
            // a la variable de clase "al campo de clase"
        }

        public String getExtras()
        {
            return $"Extras del coche: Tapiceria: {tapiceria}.... climatizador: {climatizador}";
        }

        // propiedades o comportamientos

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;

        // definir comportamiento 

    }
}



