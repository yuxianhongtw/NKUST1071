using OpenDataImport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OpenDataImport
{
    public class Porgram
    {
        static void Main(string[] args)
        {
            var nodes = findOpenData();
            ShowOpenData(nodes);
            Console.ReadKey();

        }
        static List<OpenData> findOpenData()
        {
            List<OpenData> result = new List<OpenData>();

            var xml = XElement.Load(@"C:\Users\Owner\Downloads\D54BA676-ED9A-4077-9A10-A0971B3B020C.xml");

            //XNamespace gml = @" ";
            //XNamespace twed = @"";
            var nodes = xml.Descendants("ReservoirsInformation").ToList();

            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                OpenData item = new OpenData();

                item.Area = getValue(node, "Area");
                item.BasinName = getValue(node, "BasinName");
                item.Location = getValue(node, "Location");
                item.ReservoirName = getValue(node, "ReservoirName");
                result.Add(item);
            }
            return result;
        }

        private static string getValue(XElement node, string propertyName)
        {
            return node.Element(propertyName)?.Value?.Trim();
        }

        public static void ShowOpenData(List<OpenData> nodes)
        {
            Console.WriteLine(string.Format("共收到{0}筆的資料", nodes.Count));
            nodes.GroupBy(node => node.Area).ToList()
                .ForEach(group =>
                {
                    var key = group.Key;
                    var groupDatas = group.ToList();
                    var message = $"Area:{key},共有{groupDatas.Count()}筆資料";
                    Console.WriteLine(message);

                });
        }
    }
}