using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager {
    
    public static List<Result> results = new List<Result>();
    public static string path = Application.persistentDataPath + "/Leaders.dat";

    public static void Save(string name, int score)
    {
        results.Add(new Result(name, score));
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file;
        if (File.Exists(path))
        {
            file = File.Open(path, FileMode.Append);
        }
        else
        {
            file = File.Create(path);
        }

        results.Sort(delegate(Result a, Result b) 
        {
            return a.score > b.score ? 1: -1;
        });

        bf.Serialize(file, results);
        file.Close();

        for(int i = 0; i < results.Count; i++)
        {
            Debug.Log(results[i].name + " " + results[i].score);
        }

        Debug.Log(path);
        Debug.Log("Saved!");
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            results = (List<Result>)bf.Deserialize(file);
            file.Close();
        }
    }

    public static void Clear()
    {
        File.Delete(path);
    }
}
