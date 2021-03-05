using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IWSPersonas
{
	[OperationContract]
    Persona ObtenerPersona(string Identificacion);
}

[DataContract]
public class Persona : BaseRespuesta
{
    [DataMember]
	public string Nombre { get; set; }
	
	[DataMember]
	public int Edad { get; set; }

    public string Secreto { get; set; }
}

[DataContract]
public class BaseRespuesta
{
	[DataMember]
    public string MensajeRespuesta { get; set; }
	[DataMember]
	public string Error { get; set; }
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
