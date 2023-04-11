public class persona {
    public int DNI {get; set;}
    public string apellido {get; set;}
    public string nombre {get; set;}
    public DateTime fecha{get;set;}
    public string mail {get; set;}
    public int edad{get;set;}
    public bool vota{get;set;}

    public persona(){}

    public persona(int dni, string Apellido, string Nombre, DateTime Fecha= new DateTime(), string Mail=""){
        nombre = Nombre;
        DNI=dni;
        apellido=Apellido;
        fecha = Fecha;
        mail=Mail;
        edad=0;
        vota=false;
    }

    public int Edad()
    {
        DateTime fnHoy = new DateTime(DateTime.Today.Year, fecha.Month, fecha.Day);
        if (fnHoy< DateTime.Today)  edad = DateTime.Today.Year - fecha.Year;
            else   edad = DateTime.Today.Year - fecha.Year -1;
        return edad; 
    }
    public bool Vota()
    {
        if (edad>=16)  vota=true;
        return vota; 
    }
}