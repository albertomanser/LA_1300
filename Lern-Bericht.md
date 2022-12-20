# Lern-Bericht
Gruppe Candy (Alberto Manser, Cyril Lutziger, Salma Tanner, Pascal Oestrich, Keanu Koelewijn)

## Einleitung

In unserem Projekt bei dem wir zum ersten mal mit WinForms gearbeitet haben, versuchten wir ein Schiffeversenken Spiel zu implementieren und haben viel Neues gelernt.

## Was habe ich gelernt?

Wir Erklären in diesem Lern Bericht wie man in WinForms die Control.Location Eigenschaft benutzt.
## Definition

Control.Location Ruft die Koordinaten der oberen linken Ecke des Steuerelements relativ zur oberen linken Ecke seines Containers ab oder legt diese fest.
## Beschreibung

Die 'Location' Eigenschaft von 'Control' ist eine Eigenschaft in Windows Forms von Microsoft, die die Position eines Steuerelements auf dem Bildschirm angibt. Die Eigenschaft ist vom Typ 'Point', der ein X- und Y-Koordinatensystem verwendet, um die Position auf einer 2D-Ebene zu beschreiben.

Die 'Location' Eigenschaft kann verwendet werden, um es auf dem Bildschirm zu positionieren, indem die X- und Y-Koordinaten festgelegt werden. Sie kann auch verwendet werden, um die Position zu ändern.

Hier sind zwei Beispiele dafür, wie die 'Location' Eigenschaft verwendet werden könnte, um ein Steuerelement zu positionieren:

```csharp
Button button1 = new Button();
button1.Location = new Point(100, 100);
```
In diesem Beispiel wird ein neuer Button erstellt und dann die 'Location' Eigenschaft auf eine neue 'Point' Struktur festgelegt, die die X- und Y-Koordinaten (100, 100) enthält. Dies positioniert den Button 100 Pixel von der linken Kante und 100 Pixel von der oberen Kante des Bildschirms entfernt.

```csharp
private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(150, 150);
        }
```

In diesem Beispiel wird die 'Location' Eigenschaft auf eine neue 'Point' Struktur festgelegt, die die X- und Y-Koordinaten (150, 150) enthält. Dies positioniert den Button 150 Pixel von der linken Kante und 150 Pixel von der oberen Kante des Bildschirms entfernt, wenn er mit einem Click ausgelöst wird.

![psdbg,ülc](https://user-images.githubusercontent.com/110892283/208625368-7119ce82-d0b8-4699-92bb-be9b522ece0a.gif)

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
