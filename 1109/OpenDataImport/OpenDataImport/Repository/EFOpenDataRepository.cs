using OpenDataImport.Database;
using OpenDataImport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenDataImport.Repository
{
    class EFOpenDataRepository
    {
        private OpenDataDbContext OpenDataDbContext { get; set; }

        public EFOpenDataRepository()
        {
            OpenDataDbContext = new OpenDataDbContext();
        }

        public List<OpenData> SelectAll(string name)
        {
            var result = new List<OpenData>();
            var query = OpenDataDbContext.OpenData.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => x.服務分類 == name);
            }
            //Orderby(query);
            return query.ToList();
        }

        /*private void Orderby(IQueryable<OpenData> query)
        {
            query.OrderBy(x => x.資料集名稱);
        }*/

        public void Insert(OpenData item)
        {
            OpenDataDbContext.OpenData.Add(item);
            OpenDataDbContext.SaveChanges();
        }

        public void Update(OpenData item)
        {
            var exist = OpenDataDbContext.OpenData
                .Where(x => x.id == item.id).SingleOrDefault();
            if (exist == null)
                return;
            exist.主要欄位說明 = item.主要欄位說明;
            exist.服務分類 = item.服務分類;
            exist.服務分類 = item.資料集名稱;
            OpenDataDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var exist = OpenDataDbContext.OpenData
                .Where(x => x.id == id).SingleOrDefault();
            if (exist == null)
                return;
            OpenDataDbContext.OpenData.Remove(exist);
            OpenDataDbContext.SaveChanges();
        }
    }
}