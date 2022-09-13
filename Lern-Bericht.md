# LA_Number-Guesser_Lernbericht
Von Cyril Lutziger

# Einleitung

Ich habe ein kleine Spiel Programmiert, in welchem man eine Zahl zwischen 1 und 100 erraten muss die zufällig von dem Programm ausgegeben wird.
Das Spiel kann mit verschiedensten Fehlern oder Fehlereingaben umgehen und gibt dannach auch noch eine antwort zum User.
Dieser Lern-Bericht dokumentiert was ich in meinem Spiel gemacht habe in form von Text und Fotos

# Neues Wissen

In diesem Projekt habe ich die Grunlagen des Programmieren besser verstehen können und habe auch neues dazu gelernt, sowie: Schleifen, welche in diesem Projekt eines der wichtigsten Sachen waren, If, while oder else, welche auch eine wichtige rolle gespielt haben und auch noch wie man eine Zufällige nummer zwischen 2 Zahlen generiert.
In dieser Dokumentation werde ich ausschliesslich über Try und Catch/Schleife reden und auch beschreiben wie dies funktioniert

# Beschreibung

Um eine solche Schleife zu Codieren oder Programmieren benötigt man ein Try und ein Catch.
Das Try und Catch wird in diesem fall benutzt um Potenzielle fehler, abstürze oder Code fehler aufzuspühren und sie auch richtig behandeln, sodass das programm dabei nicht abstürzt
Das Try ist hier um die Eingabe zu überprüfen welche in der Schleife überprüfen werden sollte.
Das Catch ist hier um Potenzielle fehler zu entdecken und um den Code auszuführen.
In meinem Spiel habe ich es hauptsächlich benutzt, dass wenn man z.B. eine Zahl will und der User einen Buchstaben oder ein Sonderzeichen eingibt eine Fehlermeldung ausgibt, und den User erneut für eine Zahl fragt.

```c#
{

try
 {
	eingabe = Convert.ToInt32(Console.ReadLine());
     check = true;
     Console.WriteLine("");
 }
 catch
 {
	Console.ForegroundColor = ConsoleColor.Red;
     Console.WriteLine("                 --<|Ihre Eingabe wurde von diesem Programm nicht erkannt. Bitte geben Sie dies erneut ein|>--");
     check = false;
 }
}
 ```




![grafik](https://user-images.githubusercontent.com/110893288/189858335-38cf1383-f245-46b5-a7c4-cea46df80fe6.png)

# Verifikation

Text:
Der Text hier Beschreibt wie eine Try und Catch Schleife aussieht und wie und wo diese auch benutzt wird.

Code:
Der Code zeigt wie die Schleife in einem Programm aussieht und wie diese auch ausgegeben wird.

Foto:
Das Foto zeigt die Ausgabe welche bei einer ungültigen eingabe ausgegeben wird.

# Reflektion

Was gut lief:
Ich konnte mit Motivation an meinem Programm arbeiten und wenn ich probleme hatte konnte ich diese nach einer weile mit oder ohne Hilfe beiseitigen.

Was nicht gut Lief:
Ich habe oft unnötige Hilfe gebraucht welche einfach zu lösen waren.

# VBV
Ein Verbesserungsvorschlag währe, bevor ich jemamdem eine Frage stelle, dies zuerst online zu recherchieren und schauen ob es eine Lösung zu meinem Problem gibt.
