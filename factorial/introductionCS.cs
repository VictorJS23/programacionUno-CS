using System;
using System.Linq.Expressions;

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
