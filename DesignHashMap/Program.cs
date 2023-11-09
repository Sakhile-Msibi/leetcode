using System;
using System.Collections;
using System.Collections.Generic;

public class MyHashMap
{
    private const int BUCKET_SIZE = 100;
    private Dictionary<int, int> map;


    public int HashFunction(int key)
    {
        return key % BUCKET_SIZE;
    }

    public MyHashMap()
    {
        map = new Dictionary<int, int>(BUCKET_SIZE);

        for (int i = 0; i < BUCKET_SIZE; i++)
        {
            map.Clear();
        }
    }

    public void Put(int key, int value)
    {
        if (!map.ContainsKey(key))
        {
            map.Add(key, value);
        }
        else if (map.ContainsKey(key))
        {
            map.Remove(key);
            map.Add(key, value);
        }
    }

    public int Get(int key)
    {
        int value = -1;

        return (map.ContainsKey(key) && map.TryGetValue(key, out value)) ? value : -1;
    }

    public void Remove(int key)
    {
        if (map.ContainsKey(key))
        {
            map.Remove(key);
        }
    }

    public void DisplayHashMap()
    {
        foreach (KeyValuePair<int, int> kvp in map)
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }

    private static void Main(string[] args)
    {
        MyHashMap myHashMap = new MyHashMap();

        myHashMap.Put(1, 1);
        myHashMap.Put(2, 2);
        myHashMap.DisplayHashMap();
        Console.WriteLine(myHashMap.Get(1));
        Console.WriteLine(myHashMap.Get(3));
        myHashMap.Put(2, 1);
        myHashMap.DisplayHashMap();
        Console.WriteLine(myHashMap.Get(2));
        myHashMap.Remove(2);
        Console.WriteLine(myHashMap.Get(2));

        Console.ReadKey();
    }
}