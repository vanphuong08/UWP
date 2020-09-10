using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lession1.models
{
    class tes
    {
        private string email;
        private string title;
        private string text;
       public string Email
        {
            get { return email;  }
            set { email = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public tes(string email, string title, string text)
        {
            Email = email;
            Title = title;
            Text = text;
        }
    }
}
