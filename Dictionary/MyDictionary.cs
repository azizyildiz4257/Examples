using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T_key, T_value>
    {
        T_key[] Key;
        T_value[] Value;

        public MyDictionary()
        {
            Key = new T_key[0];
            Value = new T_value[0];
        }
        public void Add(T_key key, T_value value)
        {
            T_key[] tempkey = Key;
            T_value[] tempvalue = Value;

            Key = new T_key[Key.Length + 1];
            Value = new T_value[Value.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                Key[i] = tempkey[i];
            }
            Key[Key.Length - 1] = key;

            for (int i = 0; i < tempvalue.Length; i++)
            {
                Value[i] = tempvalue[i];
            }
            Value[Value.Length - 1] = value;
        }
        public int Count
        {
            get { return Key.Length; }
        }

        public T_key[] Keys
        {
            get { return Key; }
        }

        public T_value[] Values
        {
            get { return Value; }
        }

    }
}
