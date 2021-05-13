<h1>Advanced SQL Injection Scanner - IIS & DBO</h1>

<h2>Advanced mechanisms of sql injection that can be used by malicious users to obtain critical information and take advantage of it to gain complete control of a computer system.</h2>

<h3>Explanatory Note</h3>
This article doesn't attempt to explain a new technique of compromising computer systems, the technique of SQL Injection is very old and known but at the same time can be very powerful. The article also doesn't reflect the exploit of an unknown vulnerability, this is known and has already been reported, which if can reflect are unpublished advanced mechanisms of sql injection that can be used by malicious users to obtain critical information and take advantage of it to gain complete control of a computer system.<br>
Combining this technique with an IIS Web Server with elevated user permissions (DBO) in the Microsoft SQL Server database can lead to complete loss of control of the affected server.<br>
This article will attempt to explain the potential risk caused by misconfiguration of an SQL database that interacts with an external web page through an IIS Web Server and give details of how malicious users can benefit from it.

<h3>Short Summary (wikipedia)</h3>
SQL Injection is a code injection technique, used to attack data-driven applications, in which nefarious SQL statements are inserted into an entry field for execution (e.g. to dump the database contents to the attacker). SQL injection must exploit a security vulnerability in an application's software, for example, when user input is either incorrectly filtered for string literal escape characters embedded in SQL statements or user input is not strongly typed and unexpectedly executed. SQL injection is mostly known as an attack vector for websites but can be used to attack any type of SQL database.<br>
SQL injection attacks allow attackers to spoof identity, tamper with existing data, cause repudiation issues such as voiding transactions or changing balances, allow the complete disclosure of all data on the system, destroy the data or make it otherwise unavailable, and become administrators of the database server.

<h3>Vulnerability</h3>
Assuming that in the web page there are security problems with the passing of parameters to allow SQL Injection, the main problem is that the IIS Web Server is able to display critical information to the user by using an invalid Transact-SQL conversion function. Imagine the following URL where the id parameter allows injection.<br><br>
https://www.victim.com/index.aspx?id=1<br><br>
A malicious user could override the value of the id parameter by the Transact-SQL convert function<br><br>
convert(int, (SELECT+USER));--<br><br>
The final URL would be of this style:<br><br>
https://www.victim.com/index.aspx?id=convert(int, (SELECT+USER));--<br><br>
The conversion function tries to convert a string to integer, which causes an exception where the IIS Web Server makes a serious error showing the value of the executed query.<br><br>
A typical output would be something like this:<br><br>
Conversion failed when converting the nvarchar value '{user}' to data type int.<br><br>
As we can see the {user} value corresponds to the current value of the user of the database, in addition to all of this if the value returned is dbo will tell us that the database user has maximum execution privileges, so that will be able to execute shell commands using the xp_cmdshell Transact-SQL function.<br><br>
Using a web page with a database user with maximum privileges is a serious security error where system administrators should not fall.<br><br>
In summary, could say that vulnerability consists of three factors:<br><br>
<ul>
  <li>Error in handling the GET/POST parameters that allow SQL Injection. (Software Developer)</li>
  <li>IIS Web Server that displays the conversion function information. (Microsoft)</li>
  <li>Use a database user in the web page with maximum privileges. (System Administrator/Software Developer)</li>
</ul>

<h3>More information</h3>
https://advanced-sql-injection.blogspot.com/2017/06/ivan-ricart-borges-advanced-sql.html

<h3>Version 4.0</h3>

I have the extended version 4.0 of the scanner in a private repository with all its functionalities.
