using System;
using System.Collections.Generic;
using System.Text;
using YX.Core.Models;

namespace YX.Core.Repository
{
    public interface IOpenDataRepository
    {
        void Delete(int id);
        void Insert(OpenData item);
        List<OpenData> SelectAll(string name);
        void Update(OpenData item);
    }
}
