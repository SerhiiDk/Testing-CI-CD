Projektet indeholder Api(POC-CI-CD) og Test(POC-CI-CD.Tests) produkter.  
Test project findes i POC-CI-CD.Tests mappen. 

Sådan køre man tests
- UI: Tryk på Test => Run All Tests
- Terminal/PowerShell: køre kommand "dotnet test"


Nye unit tests skal tilføjes til fillen UnitTest.cs. 
Nye end to end test skal tilføjes til filen EndToEndTest.cs.


GitHub actions er blevet set op til afvise merge/deployment, hvis test fejler.
Link til github actions: https://github.com/SerhiiDk/Testing-CI-CD/actions
