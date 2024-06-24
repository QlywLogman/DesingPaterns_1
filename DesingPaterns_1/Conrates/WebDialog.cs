using DesingPaterns_1.Abstrac;
using DesingPaterns_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaterns_1.Conrates
{
    public class WebDialog : Dialog
    {

        public override IButton CreatButton() => new HTMLButton();

    }
}
