using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace LogParser

{
    public class Parser
    {
        public String _text;


        public Parser()
        {

            this.setText(this._text);
        }

        public void setText(String text)
        {
            if (text != null)
            {
                this._text = text;
            }
        }

        public String gettext()
        {
            return this._text;
        }

        public String ParseText(String text)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            this.setText(text);
            var sr = new System.IO.StringReader(this._text);
            String line = "";
            if(text == null)
            {
                return "You must input a text! Please try again";
            }


            while ((line = sr.ReadLine()) != null)
            {
                if(line.Contains("ERROR") || line.Contains("Exception") || line.Contains("Failed") || line.Contains("WARN"))
                {
                    sb.Append(line);
                    sb.Append(System.Environment.NewLine);
                    counter++;
                }
            }

            return sb.ToString();

        }

    }
}
