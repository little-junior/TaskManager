using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAccess.Interfaces
{
    public interface IDataManagement<T>
    {
        void WriteJSON(T data);
        void WriteJSON(List<T> data);
        List<T> ReadJSON();
    }
}
