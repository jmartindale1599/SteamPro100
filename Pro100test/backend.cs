using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro100test
{
    internal class backend
    {
        string client_ID = "ukinm8oq8njkab73c59c1b0vpmv69h";
        string client_secret = "9rprk08hlt1ci4ysb41wey5rvx7i1b";

        string call = "https://id.twitch.tv/oauth2/token/client_id=" + client_ID + "/client_secret=" + client_secret + "/grant_type=client_credentials";

    }
}
