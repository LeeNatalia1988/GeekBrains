using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.Entities
{
    internal class ProjectFile
    {

        private string _fileName;
        private int _setting1;
        private string _setting2;
        private bool _setting3;

        public ProjectFile(string fileName)
        {
            _fileName = fileName;

            _setting1 = 1;
            _setting2 = "...";
            _setting3 = false;

        }

        public string GetFileName()
        {
            return _fileName;
        }

        public int GetSetting1()
        {
            return _setting1;
        }

        public string GetSetting2()
        {
            return _setting2;
        }

        public bool GetSetting3()
        {
            return _setting3;
        }




    }
}
