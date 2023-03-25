using System;


public class OtusDictionary<T>
{
    public static int size = 32;
    public int pointer = 0;
    DictionaryItem[] dictionary = new DictionaryItem[size];

    // индексатор
    public DictionaryItem this[int index]
    {
        get => dictionary[index];
        set => dictionary[index] = value;
    }

    public void Add(int key, string value)
    {
        for (int i = 0; i < pointer; i++)
            if (dictionary[i].Key == key) throw new KeyExistException("ключ дублируется");

        if (value != null)
        {

            if (pointer == size)
            {
                size *= 2;
                Array.Resize(ref dictionary, size);
            }

            DictionaryItem item = new DictionaryItem();
            item.Key = key;
            item.Value = value;
            dictionary[pointer] = item;
            pointer++;

        }

    }

    public string Get(int key)
    {

        for (int i = 0; i < pointer; i++)
            if (dictionary[i].Key == key) return dictionary[i].Value;

        return "Key not exist";

    }

}
