using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studrate
{
    class ErrorHandler
    {
        private int code;
        private string message;

        public ErrorHandler(int number, string text)
        {
            code = number;
            message = text;
            errorMessage();
        }

        private void errorMessage()
        {
            string error = "";
            switch (code)
            {
                case 547:
                    error += "Invalid row's values";
                    break;
                case 201:
                    error += "Missing parameter";
                    break;
                case 8178:
                    error += "Invalid parameter";
                    break;
                default:
                    error += message;
                    break;
            }
            MessageBox.Show(error, "Error #" + code);

        }
    }
}
