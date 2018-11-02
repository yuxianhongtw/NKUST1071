using OpenDataImport.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenDataImport.Service
{
    class EFImportService
    {
        private Repository.EFOpenDataRepository _efRepository;

        public EFImportService()
        {
            _efRepository = new Repository.EFOpenDataRepository();
        }

        public List<OpenData> FindOpenDataFromDb(string name)
        {
            return _efRepository.SelectAll(name);
        }
    }
}
