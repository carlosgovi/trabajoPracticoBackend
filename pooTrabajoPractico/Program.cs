// See https://aka.ms/new-console-template for more information
using pooTrabajoPractico;

Console.WriteLine("Hello, World!");
/* Paso 1: Crear la clase abstracta

Comenzaremos creando una clase abstracta llamada "Figura". Esta clase representará una figura geométrica genérica y tendrá un método abstracto para calcular el área de la figura.

Paso 2: Crear una clase concreta

A continuación, crearemos una clase concreta llamada "Circulo" que herede de la clase abstracta "Figura". Esta clase representará un círculo y tendrá un radio como propiedad. Implementaremos el método abstracto "CalcularArea()" para calcular el área del círculo.

Paso 3: Crear otra clase concreta

Por último, crearemos otra clase concreta llamada "Rectángulo" que también herede de la clase abstracta "Figura". Esta clase representará un rectángulo y tendrá dos propiedades para representar su base y altura. Implementaremos el método abstracto "CalcularArea()" para calcular el área del rectángulo

Paso 4: Utilizar las clases en la aplicación de consola

El Program.cs de la aplicación de consola instanciar un círculo y un rectángulo con diferentes valores. Calcular el area para cada objeto y mostrarlo por consola

Pista: investiguen las palabras clave virtual y override en los métodos para sobrescribir métodos de las clases padre a las clases hijas. Hay muchas formas de hacerlo bien investiguen y googlen mucho, no se aten a lo solo dado en clase.

Formato de entrega:

Entregar la actividad con el link del repositorio de github donde se encuentre un proyecto de aplicación de consola hecho por ustedes con el código necesario para satisfacer los requerimientos enunciados en la consigna. Recuerden cerciorarse que el repositorio que publicaron se encuentre publica para que pueda acceder. El tiempo de entrega es hasta 8/05 (incluido), es decir que cualquier commit por fuera de ese plazo sera ignorado en la corrección.

 

 

Abierta desde 02/05/2024 10:30 hasta 08/05/2024 23:59 */
Circulo circulo = new Circulo(5);
Console.WriteLine(circulo.CalculateArea());

Rectangulo rectangulo = new Rectangulo()
{
    Base = 5,
    Altura = 10
};
Console.WriteLine(rectangulo.CalculateArea());