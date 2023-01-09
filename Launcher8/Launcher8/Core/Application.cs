using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Launcher8.Core
{
    public class Application
    {
        public String Name { get; }
        public String ParsingName { get; }
        public ImageSource Icon { get; }

        public Application(String name, String parsingName, ImageSource icon)
        {
            Name = name;
            ParsingName = parsingName;
            Icon = icon;
        }
    }
}
