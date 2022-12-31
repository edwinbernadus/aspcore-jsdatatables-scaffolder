what is this ?  
aspcore starter kit template + scaffolder + js-datatables  
sample project using in memory EF

when sample is populated ?  
await DataHelper.InitData(this._applicationDbContext)   
at Home-Index    

how to build ?  
dotnet build  

how to run ?  
dotnet run      

how to generate the scaffolder ?    
dotnet aspnet-codegenerator controller -name TreeController -outDir Controllers -m Tree -dc ApplicationDbContext -f -udl

why use old netcoreapp2.2 ?  
i'm too lazy to update to latest version   
but you can upgrade it yourself or open issue on the github repo