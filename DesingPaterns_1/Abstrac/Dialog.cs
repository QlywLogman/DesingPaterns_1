using DesingPaterns_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaterns_1.Abstrac
{
    public abstract class Dialog
    {
        public abstract IButton CreatButton();

        public void Render()
        {

            IButton OkButton = CreatButton();
            OkButton.OnClick();

        }
    }
}
