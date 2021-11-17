using System;
using System.Collections.Generic;
using System.Text;
using MeteoStation.Models;

namespace MeteoStation.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get();
    }
}
