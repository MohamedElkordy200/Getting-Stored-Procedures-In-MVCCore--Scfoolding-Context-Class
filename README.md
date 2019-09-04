*****Hint:
"
 beacause Core Scafoolding does't map Stored Procedures in Context Class and there isn't ObjectResault In core   so I made this simple app.
 This is simple App for Converting  Stored Procedures  that exists in MVC Scafooding  DBContext Class To the opposite in Core DBContext Class contains new  modified Stored Procedures.
 the modified Stored Procedures  are coded using _.FromSql("EXECUTE dbo.*") Method show this Link https://stackoverflow.com/questions/28599404/how-to-run-stored-procedures-in-entity-framework-core  .
 this app is very useful in some cases  such as  (Upgrading old MVC Project To core -  you have More  Stored procdures in MVC that it is  difficult to write  _.FromSql("EXECUTE dbo.*") For each one   )
"

*****Steps of Usage:
1-Enter Full Connection String of  DataBase Connection Where DB that you want to make Core Scafooling from it .
2-Select type Of Provider (SQL Server or My SQl).
3-From OpenFile open an Old Mvc Context Class File that contains  Old Mvc Stored Procedures "it have ObjectReasult".
4-Now Click On Convert Button .
5-the resault show in other side cantains "Core Context Class From Scaffolding +Modified Stroed Procedures".
6-Now You should copy Files of  Classes of Resault of Old Stored procedure "it exsits in Old MVC Project  thier names ends with _Reasult "  change its namespaces to the same namespace of Modified Class Context.
7- copy modified context class and classes of reault to your project.

****Notes:
- I'm not handle If Stored Procedures have paramter of output  paramter

*****KeyWords:
-Scafoolding 
-DB fisrt-MVC Core
-Upgrate to core
-ExecuteFunction
-ModelBuilder
-ObjectResault
-Entity core
-Entity Framwork 2.2-Entity Framwork 2.1-DB Context
-Entity Context
-stored Procedures
-stored procedures Core
-stored procedure scafoolding
-automatic convert mvc SP to core 
-Stored procedure Templete
-ObjectResault replacement in core
-core scafoolding
-core

******************************************************************************************************************************************************************************************************
for contact with me 
Email:mohamed.elkrody@asyadcapital.com
Mobile:02-01021948402
