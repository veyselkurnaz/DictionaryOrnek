using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOrnek
{
    class MyDictionary<I, N>
    {
        I[] id;
        N[] name;

        public MyDictionary()
        {
            id = new I[0];
            name = new N[0];
        }

        I[] tempid;
        N[] tempname;

        public void Add(I ids, N names)
        {
            tempid = id;
            tempname = name;
            id = new I[id.Length + 1];
            name = new N[name.Length + 1];

            for (int i = 0; i < tempid.Length; i++)
            {
                id[i] = tempid[i];
            }
            for (int i = 0; i < tempname.Length; i++)
            {
                name[i] = tempname[i];
            }

            id[id.Length - 1] = ids;
            name[name.Length - 1] = names;

        }

        public void Say()
        {
            Console.WriteLine(id.Length);
        }
    }
}