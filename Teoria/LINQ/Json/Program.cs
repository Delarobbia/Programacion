//Conseguir un JSON de un API y usar su contenido

using System.Net;

/*Creamos un request y un response para obtener el JSON
 * request = peticion al servidor de la API
 * response= guardamos los datos de la peticion
 * */

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://cat-fact.herokuapp.com/facts");
HttpWebResponse response = (HttpWebResponse)request.GetResponse() ;

//Creamos un stream

Stream stream = response.GetResponseStream() ;
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd() ;
Console.WriteLine(json) ;