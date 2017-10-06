using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLProyect
{
    public class AppValidator
    {
        IDialog Dialog;
        public AppValidator(IDialog plataformDialog) {
            Dialog = plataformDialog;
        }

        public string EMail{ get; set; }
        public string Password { get; set; }
        public string Device { get; set; }

        public async void Validate() {

            string Result;
            Result = "Aplicación Validada";
            Dialog.Show(Result);
            var ServiceClient = new SALLab04.ServiceClient();
            var SvcResult = await ServiceClient.ValidateAsync(EMail,Password,Device);
            Result = $"{SvcResult.Status}\n{SvcResult.Fullname}\n{SvcResult.Token}";
            Dialog.Show(Result);
        }
    }
}
