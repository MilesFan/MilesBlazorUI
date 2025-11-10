using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.BlazorUI
{
    public class DialogService
    {
        internal List<Dialog> _dialogList = [];
        public void Show(Dialog dialog)
        {
            _dialogList.Add(dialog);
        }
        public void Remove(Dialog dialog)
        {
            _dialogList.Remove(dialog);
        }
    }
}
