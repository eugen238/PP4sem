using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public interface I1
    {
        int Firsted { get; set; }
        void Hi();
        event EventHandler StartListening;
        C1 this[int index] { get => this[index]; set=> this[index]=value; }
    }
}
