using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SC4Backup
{
    class Region
    {
        private Dictionary<string, City> cities;
        private string name, path;

        // Can throw a FileNotFoundException if region is not found.
        public Region(string path)
        {
            string prefix = String.Format("{0}{1}",
                Properties.Settings.Default.RegionDirectory,
                Path.DirectorySeparatorChar);

            string name = path.Replace(prefix, "");
            this.name = name;
            this.path = path;

            if (!Directory.Exists(path))
            {
                throw new FileNotFoundException();
            }

            this.cities = new Dictionary<string, City>();
            PopulateCityList(path);
        }

        public Dictionary<string, City> GetCities() { return cities; }
        private void PopulateCityList(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                string temp = file.Replace(this.path + Path.DirectorySeparatorChar, "");
                if (temp.EndsWith(".sc4") && !temp.StartsWith("City - New City"))
                {
                    int indexOfEnd = temp.IndexOf(".sc4");
                    cities.Add(temp.Substring(0, indexOfEnd), new City(temp, this));
                }
            }
        }

        public override string ToString() { return GetName(); }
        public string GetName() { return this.name; }
        public string GetPath() { return this.path; }
        public City GetCityByName(string name)
        {
            City ret;
            if(!cities.TryGetValue(name, out ret))
            {
                return null;
            }

            return ret;
        }
    }
}
