using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class WSPersonas  : ServiceBase, IWSPersonas
{

    private readonly ILog log;
    public WSPersonas() : base()
    {
        XmlConfigurator.Configure();
        this.log = LogManager.GetLogger(typeof(WSPersonas));
        this.log.Debug("Creando WSPersonas...");
    }
    public string ObtDatosPersonaStr(Persona p)
    {
        string res = string.Empty;

        try
        {
            
            res = "[" +  (p.Error.Length <= 0 ? "Nombre: " + p.Nombre + " Edad: " +  p.Edad.ToString()  :
                                                "Error: " + p.Error)  + "]";
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Persona ObtenerPersona(string Identificacion)
    {
       
        if (Identificacion == "0")
        {
            return new Persona() { Nombre = "Nombre0", Edad = 99, Error = string.Empty};
        }
        else if (Identificacion == "1")
        {
            return new Persona() { Nombre = "Nombre1", Edad = 24, Error = string.Empty };
        }
        else if (Identificacion == "2")
        {
            return new Persona() { Nombre = "Nombre2", Edad = 44, Error = string.Empty };
        }
        else   {
            return new Persona() { Error = "Persona no encontrada" };
        }
    }
}
