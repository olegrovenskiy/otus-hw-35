using System;
using System.Reflection;


public class OtusDictionary<T>
{
    public static int size = 2;
    public int hash;
    public DictionaryItem[] dictionary = new DictionaryItem[size];

    // индексатор
    public DictionaryItem this[int index]
    {
        get => dictionary[index];
        set => dictionary[index] = value;
    }

    public void Add(int key, string value)
    {
        // проверка дублирования ключа

        for (int i = 0; i < size; i++)
            if (dictionary[i] != null && dictionary[i].Key == key) throw new KeyExistException("ключ дублируется");



        // проверка свободного места и ресайз если его нет

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("size - " + size);
            if (dictionary[i] == null) break;
            else
            {
                if (i == size - 1)
                {
                    Console.WriteLine("Resize");
                    Resize();
                }
            }
        }

            if (value != null) // если value = null, то такой элемент проигнорируется
        {


            DictionaryItem item = new DictionaryItem();
            item.Key = key;
            item.Value = value;
            hash = GetHash(key);

            for (int i = 0; i < size; i++)
            {
                if (dictionary[hash] == null)
                {
                    dictionary[hash] = item;
                    break;
                }
                else
                {
                    hash = hash + 1;
                    if (hash == size) hash = 0;
                }
            }
        }
    }

    public string Get(int key)
    {
        hash = GetHash(key);

        for (int i = 0; i < size; i++)
        {
            if (dictionary[hash] == null) return "Key not exist";

            if (dictionary[hash].Key == key)
            {
                return dictionary[hash].Value;

            }
            else
            {
                hash = hash + 1;
                if (hash == size) hash = 0;
            }
        }

        return "Key not exist";
    }

    int GetHash(int key) => key % size;

    public void Resize()
    {
        var dictionaryTmp = dictionary;

        dictionary = new DictionaryItem[size*2];

        // пересчёт хеша

        int oldSize = size;
        size *= 2;

        for (int i = 0; i < oldSize; i++)
        {

            hash = GetHash(dictionaryTmp[i].Key); // ?
            if (dictionary[hash] == null)
            {
                dictionary[hash] = dictionaryTmp[i];
              //  break;
            }
            else
            {
                hash = hash + 1;
                if (hash == size) hash = 0;
            }

        }

    }
  
}



