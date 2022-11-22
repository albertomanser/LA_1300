# Projekt-Dokumentation



Gruppe Candy Manser, Tanner, Lutziger, Koelewijn, Oestrich

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt
In diesem Projekt programmieren wir mithifle von Winforms ein "Schiffeversenken" Spiel


### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss                | Funktional      |  ich als Nutzer erwarte, dass man seine Schiffe platzieren kann |
| 2    | Muss                | Funktional      | ich als Nutzer erwarte, dass man die Schiffe der Gegner abschiessen können |
| 3    | Muss                | Funktional      | Ich als Nutzer erwarte, dass bei einem fehlschuss eine Rückmeldung gemacht wird|
| 4    | Muss         | Funktional |Ich als Nutzer erwarte, dass bei einem Treffer/versenken eine Rückmeldung gemacht wird |
| 5    | Muss | Funktional | Ich als Nutzer erwarte, dass Zwischen Spieler 1 und 2 gewechselt wird  |
| 6 | Muss | Funktional | Ich als Nutzer erwarte, dass der Gewinner und verlierer ausgegeben wird |
| 7 | kann | Qualität | Ich als Nutzer erwarte, dass die gebrauchte Zeit gespeichert wird  |
|8 |    | Randbedingung    | Das Spiel wird in C# programmiert       |
|9 |     | Randbedingung  | Das Spiel wird mit Winforms programmiert |
| 10 | Kann |Qualität | Ich als Nutzer erwarte, dass ich am Ende gefragt werde ob ich Nochmal spiele will |
| 11 | Muss | Funktional | Ich als Nutzer erwarte, dass das Programm mit Fehleingaben umgehen kann |
| 12 | Muss | Funktional | Ich als Nutzer erwarte, dass 10 verschiedene Schiffe mit vorgegebener Form zur verfügung stehen |
|13| Kann |Qualität| Ich als Nutzer erwarte, dass ich eine Startsequenz erhalte, wenn ich das Programm starte.|
|14| Kann|Qualität| Ich als Nutzer erwarte, dass ich eine Spielerklärung erhalte, wenn ich das Programm starte.|
|15| Kann|Qualität| Ich als Nutzer erwarte, dass ich ein übersichtliches Spiel haben.|
|16| Kann |Qualität | Ich als Nutzer erwarte, dass ich einen Nickname eingeben kann|
|17| Kann |Qualität |Ich als Nutzer erwarte, dass es einen Gewinnersequenz gibt|



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





### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|1.A|  | Manser | Boote platzieren | 60 min |
|1.B|  | Manser | Startsequenz | 30 min |
|2.A|  | Lutziger |Wechsel Spieler 1 & 2|35 min |
|3.A|  | Koelewijn  |Schiessen & Rückmeldung | 40 min |
|3.B|  | Koelewijn |Gewinner Verlierer und gebrauchte Zeit | 40 min | 
|4.A|  | Lutziger |Fehleingaben abfangen|20 min |
|5.A|  | Oestrich |Vorgegebene Schiffe anzeigen | 35 min |
|6.A|  | Tanner |Spielerklärung & übersichtliches Spiel|30 min |
|7.A|  | Oestrich |Gewinnersequenz & nochmal Spielen|25 min |
|9.A| | Tanner | Nickname | 20 min|
|10.A| |Manser, Koelewijn| User Stories||
|10.B| | Oestrich | Testfälle | |
|10.C| | Manser| Planen | | 

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

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
