using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class WSPersonas : IWSPersonas
{
    public Persona ObtenerPersona(string Identificacion)
    {
        if (Identificacion == "0")
        {
            return new Persona() { Nombre = "Nombre0", Edad = 99 };
        }
        else if (Identificacion == "1")
        {
            return new Persona() { Nombre = "Nombre1", Edad = 24 };
        }
        else if (Identificacion == "2")
        {
            return new Persona() { Nombre = "Nombre2", Edad = 44 };
        }
        else   {
            return new Persona() { Error = "Persona no encontrada" };
        }
    }
}
