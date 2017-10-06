using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPApp
{
    class UPWDialog:PCLProyect.IDialog
    {
        public async void Show(string messange) {
            var Dialog = new Windows.UI.Popups.MessageDialog(messange);
            await Dialog.ShowAsync();

        }

    }
}
