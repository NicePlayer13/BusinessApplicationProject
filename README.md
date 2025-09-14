# BusinessApplicationProject

## 📌 Auftragsverwaltungs-System

### 🏗️ Einführung
Dieses Projekt ist eine **Auftragsverwaltungs-Software**, die mit **C# und Entity Framework Core** entwickelt wurde. Es dient der Verwaltung von **Kunden, Bestellungen, Rechnungen und Artikeln**. Die Anwendung basiert auf **Windows Forms (WinForms)** und nutzt **Microsoft SQL Server** als Datenbank.

Das Projekt wurde als **Schulprojekt** entwickelt und folgt modernen Softwareentwicklungspraktiken.

---

## 🚀 Installation & Einrichtung

### 🔧 Voraussetzungen
Bevor du das Projekt startest, stelle sicher, dass du folgende Tools installiert hast:

1. **.NET 8 SDK** ([Download](https://dotnet.microsoft.com/download/dotnet/8.0))
2. **Microsoft SQL Server (LocalDB)** (wird mit Visual Studio installiert)
3. **Git** ([Download](https://git-scm.com/))
4. **Visual Studio 2022** mit dem **.NET Desktop Development**- und **Entity Framework Core**-Workload

---

## 🏠 Projekt einrichten

### 🔹 1️⃣ Repository klonen
Öffne ein Terminal (PowerShell oder CMD) und klone das Projekt:
```sh
git clone https://github.com/NicePlayer13/BusinessApplicationProject.git
cd BusinessApplicationProject
```

---

## 📦 Datenbank einrichten

### 🔹 2️⃣ Konfiguration der Datenbank
Die Anwendung verwendet **SQL Server LocalDB** mit folgender Konfiguration:
- **Server**: `(localdb)\mssqllocaldb`
- **Datenbankname**: `BusinessApplicationProjectDB`

Falls du eine andere SQL-Instanz nutzt, bearbeite `AppDbContext.cs`:
```csharp
optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BusinessApplicationProjectDB;Trusted_Connection=True;");
```

---

## 📜 Migrationen & Datenbankupdate

### 🔹 3️⃣ Erste Migration erstellen
Falls noch keine Migrationen existieren:
```sh
dotnet ef migrations add InitialCreate
```

Falls die Datenbank bereits existiert, aber fehlerhaft ist, **lösche und erstelle sie neu**:
```sh
dotnet ef database drop --force
dotnet ef database update
```

Falls `dotnet ef` nicht gefunden wird, installiere das Entity Framework CLI-Tool:
```sh
dotnet tool install --global dotnet-ef
```

Falls es danach immer noch nicht funktioniert:
```sh
dotnet tool restore
```
Oder lokal im Projekt:
```sh
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet tool restore
```

### 🔄 Datenbank und Migrationen komplett zurücksetzen (wenn Probleme auftreten)

Falls du eine Migration erstellt hast, aber `Up()` oder `Down()` sind leer oder du bekommst Fehler wie `invalid column`:
```sh
dotnet ef database drop --force
dotnet ef migrations remove
```
Dann eine neue Migration sauber erstellen:
```sh
dotnet ef migrations add InitialCreate
```
Und direkt anwenden:
```sh
dotnet ef database update
```

### 📉 Sicherstellen: SQL Server LocalDB ist installiert
Prüfen ob LocalDB verfügbar ist:
```sh
sqllocaldb info
```
Du solltest `MSSQLLocalDB` oder ähnliche Instanzen sehen. Falls nicht, installiere Visual Studio mit "SQL Server Data Tools" oder lade [LocalDB manuell herunter](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb).

---

## 🏁 Anwendung starten
1. **Öffne das Projekt in Visual Studio**
2. **Setze `FormMain` als Startprojekt**
3. **Starte die Anwendung über `F5` oder `dotnet run`**

---

## 🛠️ Häufige Fehler & Lösungen

### ❌ **Fehlermeldung: "dotnet ef" nicht gefunden**
👉 **Lösung:**
```sh
dotnet tool restore
```
Oder:
```sh
dotnet tool install --global dotnet-ef
```

### ❌ **Fehlermeldung: "Invalid column name 'CustomerAddressId'"**
👉 **Lösung:**  
1. Prüfe, ob die Spalte `CustomerAddressId` in der Tabelle **Customers** existiert.  
2. Falls nicht, führe eine neue Migration durch:
```sh
dotnet ef migrations add FixCustomerAddress
dotnet ef database update
```

### ❌ **Fehlermeldung: "Cannot drop database because it is currently in use"**
👉 **Lösung:**  
Beende alle aktiven SQL-Verbindungen:
```sql
USE master;
ALTER DATABASE BusinessApplicationProjectDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE BusinessApplicationProjectDB;
```
Dann erstelle die Datenbank erneut:
```sh
dotnet ef database update
```

---

## 🧱 Projektstruktur (Architektur)
- `Model/` – Entitäten wie `Customer`, `Order`, `Article`
- `Repository/` – Generische Repositories mit DbContext
- `Controller/` – Businesslogik-Schicht mit DI
- `View/` – WinForms-Bedienoberfläche
- `Validation/` – Eingabeprüfungen mit Regex
- `temporaryFiles/` – Hilfsklassen wie `Utils.cs`

---

## 📜 Lizenz
Da es sich um ein Schulprojekt handelt, unterliegt dieses Projekt keiner spezifischen Lizenz.

---

## 📩 Kontakt & Support
📧 **Entwickler:** Khabat Rammo / Maximilian Degen  
🔗 **GitHub:** [github.com/NicePlayer13](https://github.com/NicePlayer13)

---

### **🚀 Viel Erfolg mit der Anwendung!**
