![image](https://github.com/user-attachments/assets/758d7bd5-ffc0-4071-8fc1-93ffcd63dd7a)# MoneyMe_Challenge
Pre-requisites: Install applications below if not yet installed on your machine
Visual Studio, 
https://visualstudio.microsoft.com/downloads/

SQL Server, SSMS 
SQL SERVER: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
SSMS: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

.Net Core 8
https://dotnet.microsoft.com/en-us/download/dotnet/8.0

After downloading the repository and installing the required applications

Database:
- Open SQL Server Management Studio and Create database "MoneyMe_Challenge" (Your account should have access to create a user and database on your local), in my case I have a windows authentication login with admin access on my sql server
- Create a new login for localuser
   - Click on Security > Logins(Right click) > New Login
       ![image](https://github.com/user-attachments/assets/e9989c06-0990-475f-aaf3-53ed0252e655)

      Login Type: SQL Server Authentication
      Login Name: localUser
      Password: password
   - On the server roles, check the checkbox for public and sysadmin
     ![image](https://github.com/user-attachments/assets/9d6ef35d-df51-4dcb-b30f-3e9318b26aaa)
    
- Open the downloaded Solution then right click on the MoneyMe_Db Project then click Publish
![image](https://github.com/user-attachments/assets/481c009f-da7a-4c84-afd3-bcb1edd6a81c)
