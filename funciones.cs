    public static class funciones{
        public static int IngresarEnteroEnRango(string msj, int minimo, int maximo)
        {
            int entero;
            entero = ingresarInt(msj);
            while (entero < minimo || entero > maximo)
            {
                entero = ingresarInt("ERROR! " + msj);
            }
            return entero;
        }
         public static int ingresarInt(string msj)
    {
        int entero=-1;
        while (entero == -1)
        {   
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }
    public static string ingresarString(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }

    public static DateTime ingresarFecha(string msj)
    {
        DateTime fechaDate;
        string fechaCadena = ingresarString(msj);
        while (!DateTime.TryParse(fechaCadena, out fechaDate))
        {
            fechaCadena = ingresarString("ERROR! " + msj);
        }
        return fechaDate;
    }
    public static int validarDNI(int dni, string msj, Dictionary<int, persona> dicPersonas){
        do{
            if (dicPersonas.ContainsKey(dni))
                dni = ingresarInt("ERROR! Ya se ingresó ese DNI " + msj);
        }while(dicPersonas.ContainsKey(dni));
        return dni;
    }

    public static int contVota(Dictionary<int, persona> dicPersonas){
        int cont=0;
        foreach (persona item in dicPersonas.Values)
        {
            if (item.Vota()==true) cont++;
        }
        return cont;
    }

    public static void menu(){
        Console.WriteLine("1. Cargar Nueva Persona");
        Console.WriteLine("2. Obtener Estadísticas del Censo");
        Console.WriteLine("3. Buscar Persona");
        Console.WriteLine("4. Modificar Mail de una Persona");
        Console.WriteLine("5. Salir");
    }
}