using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro3
{
    class Erro
    {
        static void Main()
        {
            //Microsoft criminosa
            ICollection<int> collection = new int[] { 0 };
            collection.Add(1);
        }
    }
}
