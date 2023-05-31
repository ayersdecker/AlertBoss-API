# AlertBoss-API

> Framework

.NET Web API (C#)

> AlertBoss Description

This project is part of a program to provide technological support to individuals who have the desire or need for a smart alternative alert system. AlertBoss facilitates different alert types to key in users to weather, family, and other systems via smart devices. The main development surrounds the use of smart bulbs to not only notify users and families, but to provide different colors depending on the type of alert. AlertBoss is being developed by RIT CAT lab for a private client. 

> API Description

This REST API is built to facilitate the transaction sequence between AlertBoss’s database, website, mobile applications, and primary programs. Data that comes into the system will run processing checks with return codes, data exiting the system is supplied via JSON formatting, and the system itself will track logging messages for errors or warnings. 

> Deployment

This application will be deployed using AWS 

> How to Get Authorization

Currently the system is a closed API intended only for AlertBoss’s Web and Mobile development team. If the system deploys for public use, this section of documentation will be updated with more information. If you have any questions, please notify AlertBoss’s development team to receive further assistance.

> How to Interact

The AlertBoss API is designed to be interacted with human-readable endpoints. To petition the server, use one of the following CRUD operations, GET, POST, PUT, DELETE.  Depending on your access level, some high-risk operations may be blocked for system safety. If access is blocked for a petitioned request, please notify AlertBoss’s development team to receive further assistance. 

Formatting a Request: ``` <METHOD> <request-uri> <HTTP-VERSION> ```
Format Requirements: The full URL (https://) is required in order to connect to proxy servers
Sample Request: ``` GET http://alertboss.com/api/documentation ``` - Link to our documentation

> Endpoint Families

 Alert, Alarm, Contact, Device, Event,  User, Settings

> ### Contact Information

Phone: (585)371-7992
Email: cat@rit.edu
Website: cat.rit.edu
Facebook: ntidcat
Twitter: @ntidcat
