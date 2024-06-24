using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaterns_1.Interface
{
    public interface IButton
    {
        public void Render() { }
        public void OnClick() { }
    }
}
