using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    public interface IContenedor
    {
        bool EstaLlena();
        int Contar();
        bool Guardar(object elemento);
        object Sacar();
    }
}
