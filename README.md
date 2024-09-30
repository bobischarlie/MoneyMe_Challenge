# MoneyMe_Challenge
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

      Login Type: SQL Server Authentication;
      Login Name: localUser;
      Password: password;
   - On the server roles, check the checkbox for public and sysadmin
     ![image](https://github.com/user-attachments/assets/9d6ef35d-df51-4dcb-b30f-3e9318b26aaa)
    
- Open the downloaded Solution then right click on the MoneyMe_Db Project then click Publish
![image](https://github.com/user-attachments/assets/481c009f-da7a-4c84-afd3-bcb1edd6a81c)

- Click the Edit button then Go to Browse Tab and fill up the login credential for the local user that you just created, please refer to screenshot below
  ![image](https://github.com/user-attachments/assets/0d305159-4400-4ef9-9367-019b3d4965b7)

-Then click Publish button
![image](https://github.com/user-attachments/assets/0991aec9-ebc7-432e-9d14-0624dd54c10f)

It should show that the publish completed successfully
![image](https://github.com/user-attachments/assets/2d522cd6-4631-4ab7-b028-4fe449daf707)
you may also check that the tables have been created under moneyme_challenge database
![image](https://github.com/user-attachments/assets/da2ad5f2-815c-4477-b3cb-135d80402f41)
