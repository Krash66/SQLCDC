# SQLCDC
SQLserver Transaction Log Analyzer

This project is a an analyzer of the SQL server 200, 2005, 2008 Trans action logs. 

It requires:
-SQL server  2000, 2005 or 2008
-You must build a test table that contains every SQL server data type (see code for field names and types)
-You must build insert and update SQL statements as TXT file to insert and update data in each datatype
-You must setup ODBC connection to Database with "SQL" in the description (see code)
-You must enable full replication on SQL server so transaction log will be complete.

Manipulate the code in the main form button events to decipher different parts of the transaction log tables.
Use SSMS as a reference.

Have fun

PS... CDCSetup project does not work and is incompatible with VS2017, so don't worry about it. Inever built a release of this. I strictly used it out of Visual Studio so I could constantly manipulate code to analyze the encryption in the Transaction Logs.
