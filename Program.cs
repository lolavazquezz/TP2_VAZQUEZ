using System.Collections.Generic;
Dictionary<int, persona> dicPersonas= new Dictionary<int, persona>();
int opcion;
do
{
    funciones.menu();
    opcion = funciones.IngresarEnteroEnRango("Elija opcion: ", 1, 5);
    Console.Clear();
    switch (opcion)
    {
        case 1:
            ingresarDatos();
            break;
        case 2:
            estadisticas();
            break;
        case 3:
            buscarPersona();
            break;
        case 4:
            modificarMail();
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (opcion != 5);
void modificarMail(){
    int dni = funciones.ingresarInt("ingrese un DNI: ");
    string nuevoMail=funciones.ingresarString("Ingrese nuevo mail: ");
    if (dicPersonas.ContainsKey(dni)){
            dicPersonas[dni].mail=nuevoMail;
            Console.WriteLine("Listo!");
    }
    else{
        Console.WriteLine("No se encuentra el DNI");
    }
}
void buscarPersona(){
        int dni = funciones.ingresarInt("ingrese un DNI: ");
        if (dicPersonas.ContainsKey(dni)){
            Console.WriteLine("Nombre: "+dicPersonas[dni].nombre);
            Console.WriteLine("Apellido: "+dicPersonas[dni].apellido);
            Console.WriteLine("Fecha de nacimiento: "+dicPersonas[dni].fecha);
            Console.WriteLine("Edad: "+dicPersonas[dni].Edad());
            Console.WriteLine("Mail: "+dicPersonas[dni].mail);
            if(dicPersonas[dni].Vota()==true){
                Console.WriteLine("Puede votar");
            }
            else{
                Console.WriteLine("No puede votar");
            }
        }
        else{
            Console.WriteLine("No se encuentra el DNI");
        }
    }
void estadisticas(){
    int acum=0;
    foreach (persona item in dicPersonas.Values)
    {
        acum+=item.Edad();
    }
    if(dicPersonas.Count>0)
    {
        Console.WriteLine("Estadísticas del Censo:");
        Console.WriteLine("Cantidad de personas: "+dicPersonas.Count);
        Console.WriteLine("Cantidad de personas habilidatas para votar: "+ funciones.contVota(dicPersonas));
        Console.WriteLine("Promedio de edad: "+ acum/dicPersonas.Count);
    }
    else{
        Console.WriteLine("Aun no se ingresaron personas");
    }
}
void ingresarDatos(){
    string Nombre = funciones.ingresarString("Ingrese Nombre: ");
    string Apellido = funciones.ingresarString("Ingrese Apellido: ");
    int dni = funciones.ingresarInt("Ingrese DNI: ");
    dni=funciones.validarDNI(dni,"Ingrese DNI: ", dicPersonas);
    DateTime Fecha = funciones.ingresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd): ");
    string Mail=funciones.ingresarString("Ingrese Mail: ");
    persona unaPersona =  new persona(dni,Apellido,Nombre,Fecha,Mail);
    dicPersonas.Add(unaPersona.DNI, unaPersona);
}