using System;

// short numero = 10;
// numero += 5;
// Console.WriteLine(numero);



// string cadena1 = "mila";

// string cadena2 ="nesa";

// string concatenar = $"la palabra concatenada es {cadena1}{cadena2}";
// Console.WriteLine(concatenar);





// short numero1 = 25 ;
// short numero2 = 40;
// string mayorOMenor = numero1 < numero2 ? $"{numero1} es menor que {numero2}" : 
// $"{numero1} es mayor que {numero2}";
// Console.WriteLine(mayorOMenor);






// short numero3 = short.Parse(Console.ReadLine());
// string grupo;
// switch (numero3)
// {
//     case short e when (numero3 <= 3):
//         grupo = "1";
//         break;
//     case short e when (numero3 >=4 && numero3 <= 6):
//         grupo = "2";
//         break;
//     case short e when (numero3 <= 10 && numero3 >= 7):
//         grupo = "3";
//         break;
//     default:
//         grupo = "a ningun grupo";
//         break;
// }
// Console.WriteLine($"El numero {numero3} pertenece al grupo {grupo}");



// short num = 0;
// while (num <10)
// {
//     Console.WriteLine(num);
//     num++;
// }




// int[] arrayCeroAlDiez = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int Total = arrayCeroAlDiez[0];
// for (int i = 1; i !=arrayCeroAlDiez.Length; i++)
// {
//     Total *= arrayCeroAlDiez[i]; 
// }

// Console.WriteLine(Total);

//METODOS:


// int numero4 = int.Parse(Console.ReadLine());
// int numero5 = int.Parse(Console.ReadLine());

// int suma = Sumar(numero4, numero5);

// Console.WriteLine(suma);

// int Sumar(int numero4, int numero5)
// {
//     return numero4 + numero5;
// }



// string palabra1 = (Console.ReadLine());
// string palabra2 = (Console.ReadLine());
// string palabraConcatenada = concatenar (palabra1,palabra2);
// Console.WriteLine(palabraConcatenada);

// string concatenar(string palabra1, string palabra2)
// {
//     return palabra1 + palabra2;
// }



// float cantidad = 12;
// float precio = 100;
// float retornar = cantidadYprecio(cantidad, precio);
// float cantidadYprecio(float cantidad, float precio)
// {
//     return cantidad * precio;

// }
// if (retornar > 1000)
// {
//     Console.WriteLine($"El precio con descuento es de {retornar * 0.9}");
//      }
// else
// {
//     Console.WriteLine($"El precio final es {retornar}");
// }





// dibujarAsteriscos();
// void dibujarAsteriscos()
// {

// int asteriscos = Convert.ToInt32(Console.ReadLine());
// for (int i=0; i<=asteriscos; i++){
//     Console.Write("*");

// }
// }


