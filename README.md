# PremiumCalculations
Premium calculation
************Deployment Process******************
1. Prerequisite: Visual Studio 2019, .NET Core SDK 3.1, Angular CLI 8
	a. Install  NodeJS: https://nodejs.org/en/download/
	b. Install Angualr CLI using cmd window -  npm install -g angular/cli  
	c. Install Visual Studio 2019:https://visualstudio.microsoft.com/downloads/
	d.Install .NET Core 3.1:https://dotnet.microsoft.com/download/dotnet/3.1
	
Deployment Process:
-------------------
1. Download the 2 projects from GitHub
	a. Download or clone WebAPi files from https://github.com/mbtix/PremiumCalculations and open CoreWebApplication.sln usiing Visual Studio 2019
 	b. Run the Solution using visual studio 2019 or press f5, (PremiumCalculationAPI.csproj should be the startup project), once  API service started, https://localhost:44316/PremiumCalculation url will be launched with message - API Service Started successfully, don't close the url.
	c. Download https://github.com/mbtix/PremiumCalculationUI from GitHub branch **Master** into a local folder named 'PremiumCalcuation'. Once download is done, open cmd promt from  path. Run below commands,
			1.run the cmd - 'npm install', all packages will be downloaded and installed in local environment
			2.Run the cmd - 'npm start', used to build and start the application. 
	d. Once build is successful, url will be open in the browser 'http://localhost:4200/premium'
	e. Follow the test cases for testing this 'http://localhost:4200/premium' application, test cases provided in xl sheet as mentioned below.
	f. For NUnit testing on API, stop the API Service. And manual run the tests by right click on Nunit Project and run all tests.

***********For testing flow the unit test cases provided in excel Test-cases.xls************
Test Cases available in https://github.com/mbtix/PremiumCalculations
