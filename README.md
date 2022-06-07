E3.ProjectEditor

Hallo Flo, Stefan
damit das Ding bei euch funzt, müsst ihr eine localDb erstellen. Ihr könnt das mit dem Package-Manager in Visual Studio machen:
(-> Im Package-Manager muss "E3ProjectEditor.Persistence" als Startprojekt gewählt werden; Drop-down Menu im oberen Bereich) 

1.) add-migration "initial" -startupProject "E3ProjectEditor.Persistence"
-> Migration wird erstellt
2.) update-database -startupProject "E3ProjectEditor.Persistence"
-> Datenbank updaten
