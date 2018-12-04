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

## Használat
A csomagnevek viszont véletlenszerűen generálódnak a migráció futásakor.
Hogy ki lehessen a keresést próbálni a "/Packages" útvonal nincsen levédve
ott az összes csomag fel van sorolva egy táblázatban, az aktuális szállítási
állapottal és a felhasználó nevével akihez tartozik.

Minta felhasználók
- felhasznalo1@gmail.com, pass: qwerty1
- felhasznalo2@gmail.com, pass: qwerty1
