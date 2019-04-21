
Add-migration Init1 -context WebAPI.DAL.AuthenticationContext -project WebAPI
 update-database -context WebAPI.DAL.AuthenticationContext -project WebAPI

//2nd
Add-migration Init2 -context WebAPI.DAL.AgroDbContext -project WebAPI
update-database -context WebAPI.DAL.AgroDbContext -project WebAPI