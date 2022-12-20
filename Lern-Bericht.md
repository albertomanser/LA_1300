# Lern-Bericht
Gruppe Candy (Alberto Manser, Cyril Lutziger, Salma Tanner, Pascal Oestrich, Keanu Koelewijn)

## Einleitung

In unserem Projekt, bei dem wir zum ersten mal mit WinForms gearbeitet haben, versuchten wir ein Schiffeversenken Spiel zu implementieren und haben viel Neues gelernt.

## Was habe ich gelernt?

Wir haben in diesem Projekt gelernt, wie man in WinForms die Control.Location Eigenschaft benutzt.
## Definition

Control.Location ruft die Koordinaten der oberen linken Ecke des Steuerelements (z.B Buttons) relativ zur oberen linken Ecke seines Containers ab oder legt diese fest.
## Beschreibung

Die 'Location' Eigenschaft von 'Control' ist eine Eigenschaft in Windows Forms von Microsoft, die die Position eines Steuerelements auf dem Bildschirm angibt. Die Eigenschaft ist vom Typ 'Point', der ein X- und Y-Koordinatensystem verwendet, um die Position auf einer 2D-Ebene zu beschreiben.

Die 'Location' Eigenschaft kann verwendet werden, um es auf dem Bildschirm zu positionieren, indem die X- und Y-Koordinaten festgelegt werden. Sie kann auch verwendet werden, um die Position zu ändern.

Hier sind zwei Beispiele dafür, wie die 'Location' Eigenschaft verwendet werden könnte, um ein Steuerelement zu positionieren:

```csharp
Button button1 = new Button();
button1.Location = new Point(100, 100);
```
In diesem Beispiel wird ein neuer Button erstellt und dann die 'Location' Eigenschaft auf eine neue 'Point' Struktur festgelegt, die die X- und Y-Koordinaten (100, 100) enthält. Diese positioniert den Button 100 Pixel von der linken Kante und 100 Pixel von der oberen Kante des Bildschirms entfernt.

```csharp
private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(150, 150);
        }
```

In diesem Beispiel wird deer selbe Vorgang wie oben schon gezeigt, vereinfacht dargestellt. Somit ist das ganze übersichtlicher aber führt immernoch die selbe Eigenschaft aus. Die Eigenschaft 'Location' legt sich wieder auf einen 'Point' fest. Hier sind bei der neuen 'Point' Struktur die X- und Y-Koordinaten (150, 150) festgelegt.

![psdbg,ülc](https://user-images.githubusercontent.com/110892283/208625368-7119ce82-d0b8-4699-92bb-be9b522ece0a.gif)

## Verifikation

In dem bündigen Text erklären wir das Prinzip von der Eigenschaft 'Location' und wie diese angewendet wird. 
Der Code-Schnipsel zeigt auf, was wir mit dem Erklärten definieren wollen. Es hilft dabei, dies besser zu verstehen.
Das GIF sollte den angewendeten 'Code' in Visual Studio nochmals verdeutlichen. Es zeigt, wie der Code in der Praxis aussieht. 

# Reflektion zum Arbeitsprozess


Unsere Gruppe konnte gut nach IPERKA vorgehen, was uns vieles erleichtert hat. Die Planung haben wir sofern auch gut umsetzten können. 


Wir sind mit dem Implementieren nicht ganz fertig geworden, was aber nicht allzu schlimm ist, denn man lernt aus Fehlern. Daher haben wir gelernt, dass wir unsere Erwartungen ein wenig zu hoch gesetzt haben. 

**VBV**: 
Bei dem nächsten Projekt, sollten wir realistischer denken und uns gegebenfalls dazu auch besser vorbereiten. Die Erwartungen müssen so gesetzt sein, dass sie auch wirklich erfüllt werden können. 
