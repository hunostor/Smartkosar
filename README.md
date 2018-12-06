# Smartkosar
Probafeladat

## Verzió
ASP.NET Core 2.1

## Telepítés
Az alkalmazáshoz készített migráció létrehozza az adatbázist, és feltölti minta adatokkal.

ehez a console -ban futtatni kell: "dotnet ef database update"

Ehez szükséges a lokális gépen egy standard módon telepített MSSQL Express.

A felhasználók mindig pontosan ugyanazokkal az adatokkal jönnek létre és a csomagok
hozzájuk kapcsolódnak.
A létrejövő csomagok azonosítóit viszont véletlenszerűen generálja a rendszer.

Admin felhasználónak nincsennek csomagjai, viszont lehetősége van a /Admin útvonalon
adminisztrálni a csomagokat.


Minta felhasználók
- felhasznalo1@gmail.com, pass: qwertz1
- felhasznalo2@gmail.com, pass: qwertz1

Admin felhasználó: 
- admin@admin.hu, pass: admin123
