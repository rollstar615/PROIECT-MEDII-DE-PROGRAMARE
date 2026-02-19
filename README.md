# PROIECT-MEDII-DE-PROGRAMARE# Coworking Space Booking System

## Descriere proiect

Aplicație web realizată în **ASP.NET Core Razor Pages** pentru gestionarea rezervărilor într-un spațiu de coworking.
Aplicația permite administrarea locațiilor, sălilor, membrilor, pachetelor de servicii și rezervărilor.

##  Tehnologii utilizate

* ASP.NET Core Razor Pages
* Entity Framework Core
* SQL Server / LocalDB
* Bootstrap (UI)

##  Structura bazei de date

Aplicația utilizează 5 tabele relaționate:

* **Locatie** – spații coworking disponibile
* **Sala** – săli din fiecare locație
* **Membru** – utilizatori ai platformei
* **PachetServiciu** – tipuri servicii / abonamente
* **Rezervare** – rezervări efectuate (relații cu Sala, Membru și Pachet)

##  Funcționalități principale

* Operații CRUD complete pentru toate entitățile:

  * creare
  * vizualizare
  * modificare
  * ștergere
* Validare date folosind DataAnnotations
* Relații între tabele gestionate prin Entity Framework Core

