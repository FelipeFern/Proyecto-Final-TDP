
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Persistencia 
{
   
    public static void SaveHighscore(Player player)
    {
        BinaryFormatter traductor = new BinaryFormatter();
        string place = Application.persistentDataPath + "/player.Highscore";
        FileStream archivo = new FileStream(place, FileMode.Create);

        Highscore puntaje = new Highscore(player);

        traductor.Serialize(archivo, puntaje);
        archivo.Close();
        
    }


    public static Highscore LoadHighscore()
    {
        string place = Application.persistentDataPath + "/player.Highscore";
        if (File.Exists(place))
        {
            BinaryFormatter traductor = new BinaryFormatter();
            FileStream archivo = new FileStream(place, FileMode.Open);

            Highscore highscore = traductor.Deserialize(archivo) as Highscore;
            archivo.Close();

            return highscore;
        }
        else
        {
            Debug.Log("No se encontro el archivo de persistencia.");
            return null;
        }
    }

}
