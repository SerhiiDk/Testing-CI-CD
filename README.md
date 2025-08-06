# Punktforms guide til QA
- Opret ny branch fra master.
- Opret ny fil i mappen POC-CI-CD.Tests med nye unittest (Kopier gerne fra en original)
- Commit changes, og opret pullrequest, og check at det henholdsvis er muligt/umuligt at merge alt efter om test fejler.
- Yderligere check kan ses under det nyeste workflow i actions tabben.


# Beskrivelse
Projektet indeholder Api(POC-CI-CD) og Test(POC-CI-CD.Tests) produkter.  
Test project findes i POC-CI-CD.Tests mappen. 

Sådan køre man tests
- UI: Tryk på Test => Run All Tests
- Terminal/PowerShell: køre kommand "dotnet test"


Nye unit tests skal altid tilføjes til fillen UnitTest.cs.
Nye end to end test skal altid tilføjes til filen EndToEndTest.cs.

Yderligere filer kan også tilføjes til Test projectet hvis ønsket.


GitHub actions er blevet sat op til afvise merge/deployment, hvis test fejler.

Link til github actions: https://github.com/SerhiiDk/Testing-CI-CD/actions

Nye tilføjelser til alt kode i virksomheden, skal sættes op til at gøre brug af github actions, for at sikre koden stemmer overens med nye standarder.


