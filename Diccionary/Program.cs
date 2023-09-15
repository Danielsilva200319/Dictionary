using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();
        diccionario.Add("txt", "notepad.exe");
        diccionario.Add("bmp", "paint.exe");
        diccionario.Add("dip", "paint.exe");
        diccionario.Add("rtf", "wordpad.exe");
        /* try
        {
            diccionario.Add("txt", "winword.exe");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Un elemento con la llave = \"txt\" ya existe\n");
        }
        Dictionary<string, string>.KeyCollection KeyColl = diccionario.Keys;
        foreach (string key in KeyColl)
        {
            Console.WriteLine(key);
        }
        foreach (KeyValuePair<string, string> pair in diccionario)
        {
            Console.WriteLine("Llave : {0} -- Valor : {1}", pair.Key, pair.Value);
        } */
        if (diccionario.ContainsKey("bmp"))
        {
            Console.WriteLine("El tipo de formato esta soportado.");
        }
        if (diccionario.ContainsValue("notepad"))
        {
            Console.WriteLine("EL valor se encuentra registrado");
        }
        else
        {
            Console.WriteLine("El valor no se encuentra registrado");
        }
        Dictionary<string, string>.ValueCollection ValueColl = diccionario.Values;
        diccionario.Remove("dip");
        foreach (string valor in ValueColl)
        {
            Console.WriteLine(valor);            
        }
        /* diccionario.Clear();
        Console.WriteLine("Total de datos en el diccionario: " + diccionario.Count); */
    }   
}