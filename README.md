# PremiumCalculations
Premium calculation
************Deployment Process******************
1. Prerequisite: Visual Studio 2019, .NET Core SDK 3.1, Angular CLI 8
	a. Install  NodeJS: https://nodejs.org/en/download/
	b. Install Angualr CLI using cmd window -  npm install -g angular/cli  
	c. Install Visual Studio 2019:https://visualstudio.microsoft.com/downloads/
	d.Install .NET Core 3.1:https://dotnet.microsoft.com/download/dotnet/3.1
2. Download the 2 projects from GitHub
	a. Download WebAPi Solution and files from https://github.com/mbtix/PremiumCalculations
  and open CoreWebApplication.sln usiing Visual Studio 2019
 	b.Run the Solution,  (PremiumCalculationAPI.csproj should be the startup project) API service should start running.
	c. url:https://localhost:44316/PremiumCalculation  should be opened in the browser. Don't close the browser
	d.For NUnit testing , stop the run. And manual run the tests by rick click on Nunit Project
	c. Download https://github.com/mbtix/PremiumCalculationUI from GitHub and open cmd promt from PremiumCalcuation path. Run the cmd - npm start, used to build and start the application. 
	Once build is successful, url will be open in the browser 'http://localhost:4200/premium'
	d. Follow the test cases for testing this 'http://localhost:4200/premium' application

***********For testing flow the unit test cases provided in excel Test-cases.xls************
Test Cases available in https://github.com/mbtix/PremiumCalculations
