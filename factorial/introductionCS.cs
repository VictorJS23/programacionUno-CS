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
 Crear un programa que registre 10 carros, con todos los atributos definidos anteriormente
motor, llantas, marca, modelo, puertas, color, placa, vim
 */

// ESTE ES PRIMER COMMIT DEL REPOSITORIO //

