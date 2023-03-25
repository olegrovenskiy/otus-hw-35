using System;


public class OtusDictionary
{
	int pointer = 0;
	public int Key { get; set; }
	public string Value { get; set; }

    public static int size = 32;

    public OtusDictionary[] dictionary = new OtusDictionary[size];



    public OtusDictionary()
	{
	}

    public OtusDictionary(int key, string value)
    {
		Key = key;
		Value = value;	

    }



    public void Add (int key, string value)

	{
        for (int i = 0; i < pointer; i++)
            if (dictionary[i].Key == key) throw new KeyExistException("ключ дублируется");


        if (value != null)
        {
            OtusDictionary otus = new OtusDictionary();


            if (pointer == size)
            {
                //         throw new NoFreeException("словарь полон"); это ддля первых 2х пунктов, когда фиксированный размер массива
                size *= 2;
                Array.Resize(ref dictionary, size);
            }

            otus.Key = key;
            otus.Value = value;
            dictionary[pointer] = otus;
            pointer++;
        }
    }


    public  string Get (int key)
    {

        for (int i = 0; i < pointer; i++)
            if (dictionary[i].Key == key) return dictionary[i].Value;
           
       return "Key not exist";

    }
        
   
  


}
