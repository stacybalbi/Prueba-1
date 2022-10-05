
using Prueba_1;

//Object
var est = new Estudiantes("Gabriel Abreu", 20);
var anim = new Animal();

Console.WriteLine("Bienvenidos a mi programa :)");
Console.WriteLine("Acciones que tienen los animales:");
Console.WriteLine("Caminar:");
anim.Caminar();
Console.WriteLine("Comer:");
anim.Comer("Purina");
Console.WriteLine("Ver:");
anim.Ver();

//Enums
int persons = (int) enums.personas;
int estudiantes = (int)enums.estudiantes;
int animals = (int) enums.animales;

Console.WriteLine("---------------------------------------------");
Console.WriteLine("En el aula tenemos a " + persons + " persona/s");
Console.WriteLine("En el aula tenemos a " + estudiantes + " persona/s");
Console.WriteLine("En el aula tenemos a " + animals + " animal/es");
Console.WriteLine("---------------------------------------------");

string n1 = "Martha";
string n2 = "Cristina";

//Object
var chicas = new Chicas<string,string>("Martha", "Cristina");
Console.WriteLine(chicas);

//Nullable Types 
int? num = default;
num = 15;

Console.WriteLine("---------------------------------------------");
Console.WriteLine("Ahora presentamos el numero del dia de hoy: " + num);

