using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        K[] temp_keys;
        V[] temp_values;


        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }


        public void Add(K Key, V Value)
        {
            temp_keys = keys;
            temp_values = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < temp_keys.Length; i++)
            {
                keys[i] = temp_keys[i];

            }

            for (int i = 0; i < temp_values.Length; i++)
            {
                values[i] = temp_values[i];
            }



            Console.WriteLine(" Anahtarların sayısı: " + keys.Length + " Değerin sayısı: " + values.Length  );
            Console.WriteLine("Plaka numarası "+ Key + " olan " + Value + " şehri sisteme eklendi!");

        }

    }
}
