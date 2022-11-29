# Projekt-Dokumentation



Gruppe Candy Manser, Tanner, Lutziger, Koelewijn, Oestrich

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 22.11.2022 | 0.0.1   | Informieren und Planen |
| 22.11.2022      | 0.0.2     |  Planen und realisieren                                                            |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt
In diesem Projekt programmieren wir mithifle von Winforms ein "Schiffeversenken" Spiel


### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss                | Funktional      |  ich als Nutzer erwarte, dass man seine Schiffe platzieren kann |
| 2    | Muss                | Funktional      | ich als Spieler erwarte, dass man die Schiffe der Gegner abschiessen können |
| 3    | Muss                | Funktional      | Ich als Spieler erwarte, dass bei einem fehlschuss eine Rückmeldung gemacht wird|
| 4    | Muss         | Funktional |Ich als Spieler erwarte, dass bei einem Treffer/versenken eine Rückmeldung gemacht wird |
| 5    | Muss | Funktional | Ich als Spieler erwarte, dass Zwischen Spieler 1 und 2 gewechselt wird  |
| 6 | Muss | Funktional | Ich als Spieler erwarte, dass der Gewinner und verlierer ausgegeben wird |
| 7 | kann | Qualität | Ich als Spieler erwarte, dass die gebrauchte Zeit gespeichert wird  |
|8 |    | Randbedingung    | Das Spiel wird in C# programmiert   |
|9 |     | Randbedingung  | Das Spiel wird mit Winforms programmiert |
| 10 | Kann |Qualität | Ich als Spieler erwarte, dass ich am Ende gefragt werde ob ich Nochmal spiele will |
| 11 | Muss | Funktional | Ich als Spieler erwarte, dass das Programm mit Fehleingaben umgehen kann |
| 12 | Muss | Funktional | Ich als Spieler erwarte, dass 10 verschiedene Schiffe mit vorgegebener Form zur verfügung stehen |
|13| Kann |Qualität| Ich als Spieler erwarte, dass ich eine Startsequenz erhalte, wenn ich das Programm starte.|
|14| Kann|Qualität| Ich als Spieler erwarte, dass ich eine Spielerklärung erhalte, wenn ich das Programm starte.|
|15| Kann|Qualität| Ich als Spieler erwarte, dass ich ein übersichtliches Spiel haben.|
|16| Kann |Qualität | Ich als Spieler erwarte, dass ich einen Nickname eingeben kann|
|17| Kann |Qualität |Ich als Spieler erwarte, dass es einen Gewinnersequenz gibt|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   **Programm gestartet**         |    **Nichts**     |     Eingabefeld für Coordinaten, für die platzierung erscheint            |
| 1.2  |   **Programm gestartet**  Platzierte Schiffe überschneiden sich       |    **Nichts**     |     "Die Schiffe dürfen sich nicht überschneiden" **Eingabefeld erscheint**
| 2.1  | **Programm gestartet** Schiffe wurde platziert. Eigabefeld für die Coordinaten erscheint.  |     Coordinatenfeld vom Gegner    |        **Nichts**       |
| 3.1 | **Programm gestartet** Schiffe wurde platziert. Eigabefeld für die Coordinaten erscheint.  |     Nichts besetztes Coordinatenfeld vom Gegner **Enter**   |         "Ziel verfehlt"          |
| 4.1 | **Programm gestartet** Schiffe wurde platziert. Eigabefeld für die Coordinaten erscheint.            |  Besetztes Coordinatenfeld vom Gegner **Enter**     |     "Ziel getroffen"              |
| 4.2  |  **Programm gestartet** Coordinatern von gegnerischem Schiff wurde eingegeben.    |   **Enter**    |       "Ziel wurde versänkt"            |
| 5.1  | **Programm gestartet**  Nicht besetztes Coordinatenfeld wurde eingegebn.          |   **Enter**    |   "Ziel verfehlt"  **Spieler wechsel**             |
| 5.2  |  **Programm gestartet** Besetztes Coordinatenfeld wurde eingegebn.                |   **Enter**    |  "Ziel getroffen"  **Spieler wechsel**                   |
| 6.1  |   **Programm gestartet** Spieler 1 hat alle Schiffe vom Gegner versänkt.      |  **Nichts**     |    "Spieler 1 hat alle Schiffe von Spieler 2 versänkt"|
| 6.2  |   **Programm gestartet** Spieler 2 hat alle Schiffe vom Gegner versänkt.      |  **Nichts**     |    "Spieler 2 hat alle Schiffe von Spieler 1 versänkt"|
| 7.1  |   **Programm gestartet** Spiel wurde beendet, es wurde ein Gewinner ermittelt.       | **Nichts**     |    Die gebrauchte Zeit wird ausgegeben         |
| 8.1  |         |      |             |
| 9.1  |         |      |             |
| 10.1  |**Programm gestartet** Spiel wurde beendet, es wurde ein Gewinner ermittelt und die gebrauchte Zeit wurde ausgegeben.         | **Nichts**     |  "Möchten Sie noch einmal Spielen? y-n" **Eingabefeld erscheint** |
|11.1 |  **Programm gestartet** Eigabefeld für die Coordinaten erscheint.     |  Coordinaten, die nicht auf dem Spielfeld sind. **Enter**    |   "Diese Coordinaten sind ausserhalb der Spielfelds."  |
| 11.2  | **Programm gestartet** Eigabefeld für die Abfrage, ob man das Spiel wiedeholen möchte.        |  2    |    "Ungültige Eingabe" Eingabefeld für die Abfrage erscheint.         |
| 11.3  | **Programm gestartet** Eigabefeld für die Abfrage, ob man das Spiel wiedeholen möchte.        |  Zwei    |    "Ungültige Eingabe" Eingabefeld für die Abfrage erscheint.         |
| 12.1  |  **Programm gestartet** Die Schiffe werden am Rand angezeigt.       |  **Nichts**    |   "Platzieren Sie Ihre Schiffe"          |
| 13.1   |Programm wird gestartet **Startsequenz erscheint**|  **Nichts**    |  Start des Spiels          |
| 14.1   |**Programm gestartet**|  **Nichts**    | Eine Anleitung des Spiels erscheint .        |
| 15.1   |**Programm gestartet** Eingaben werden getätigt |  **Nichts**    | Das spiel bleibt übersichtlich.|
| 16.1   |**Programm gestartet**  |  **Nichts**    |Eingabefeld für die Namen der Spieler erscheint.|
| 17.1   |**Programm gestartet** Gewinner wurde ermittelt  |  **Nichts**    |Gewinnersequenz erscheint.|





![Use Case](https://user-images.githubusercontent.com/110892258/203281739-59d0f74e-6e20-400e-8432-dcfd8e43dd38.png)


![Schiffe-versenken](https://user-images.githubusercontent.com/110892537/203281842-90f9426b-07c4-4559-a447-c9fb98ccc384.png)





## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |    22.11.2022   |Manser & Koelewijn|       Informieren / Userstory       |      1        |
| 1.B |    22.11.2022|    Oestrich|        Informieren / Testfälle      |       0.5        |
| 1.C |    22.11.2022|     Lutziger|        Informieren / PAP     |       0.75        |
| 2.A |    22.11.2022|      Manser & Koelewijn  |        Planung     |       0.45        |
| 3.A |   22.11.2022|      Alle    |        Entscheidung|       1.5        |
|4.A| 29.11.2022 | Manser | Boote platzieren | 1.5|
|4.B|06.12.2022  | Manser | Startsequenz | 1|
|5.A| 29.11.2022| Lutziger |Wechsel Spieler 1 & 2|1.5|
|6.A|29.11.2022| Koelewijn  |Schiessen & Rückmeldung | 1.5|
|6.B| 06.12.2022 | Koelewijn |Gewinner Verlierer und gebrauchte Zeit | 1.5| 
|7.A| 13.12.2022  | Lutziger |Fehleingaben abfangen|1.5|
|8.A| 29.11.2022 | Oestrich |Vorgegebene Schiffe anzeigen | 1|
|9.A|  29.11.2022| Tanner |Spielerklärung & übersichtliches Spiel|1.5|
|10.A|13.12.2022  | Oestrich |Gewinnersequenz & nochmal Spielen|1|
|11.A| 06.12.2022 | Tanner | Nickname | 0.5|
| 12.A |    13.12.2022|      Alle  |Ergänzungen des Programmierens|       5        |
| 13.B |    20.12.2022|      Tanner   |        Testprotokoll   |       1        |
| 14.A| 20.12.2022|      Alle    |        Lernbericht / Dokumentation   |       1.45       |

Total: 

**1 Arbeitspaket ist etwa 45 Minuten**

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 22.11.2022      | Manser & Koelewijn          | 1               | 0.5                |
| 1.B | 22.11.2022      |Oestrich    1.5 | 0.5              | 0.75                  |
| 1.C | 22.11.2022 | Lutziger | 0.75 | 0.5 |
| 2.A | 22.11.2022 | Manser & Koelewijn | 0.45 | 0.5 |
| 3.A | 22.11.2022 | Alle | 1.5 | 1 |
| 4.B  | 29.11.2022   | Manser    | 1   | 1.5    |
| 8.A  | 29.11.2022   | Oestrich   |  1   | 0.5   |
| 9.A  | 29.11.2022  | Tanner    | 1.5   | 1   |
| 11.A   |29.11.2022   |Tanner    | 0.5   | 0.5    |
|   |   |    |   |    |
|   |   |    |   |    |
|   |   |    |   |    |



✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
