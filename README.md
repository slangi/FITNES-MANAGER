# Fitness Manager

## Opis projekta
**Fitness Membership Manager** je namizna aplikacija, izdelana v jeziku **C#** z uporabo **Windows Forms**, namenjena upravljanju članov fitnes centra in njihovih članstev.  
Projekt je bil razvit v okviru seminarske naloge pri predmetu **OPR3** in vključuje praktično uporabo konceptov objektno usmerjenega programiranja.

Aplikacija omogoča dodajanje navadnih in premium članov, prikaz podatkov o članstvu, izračun cen ter uporabo različnih OOP pristopov, kot so abstraktni razredi, vmesniki, polimorfizem, delegati in dogodki.

---

## Glavne funkcionalnosti
- dodajanje novih članov
- izbira tipa člana: **Navaden** ali **Premium**
- nastavitev cene članstva
- nastavitev trajanja članstva v dnevih
- izbira popusta za premium člane
- prikaz seznama vseh članov
- prikaz podrobnosti izbranega člana
- preverjanje, ali je članstvo še aktivno
- izračun končne cene članstva
- prikaz VIP dostopa za premium člane
- štetje vseh članov in premium članov
- obvestila ob dodajanju člana
- preverjanje članstev, ki kmalu potečejo

---

## Uporabljene tehnologije
- **C#**
- **.NET**
- **Windows Forms**
- **Visual Studio**
- **Git & GitHub**

---

## OOP koncepti v projektu
Projekt vključuje naslednje koncepte objektno usmerjenega programiranja:

### Abstraktni razredi
Razred `Member` je implementiran kot abstraktni razred, iz katerega dedujeta:
- `StandardMember`
- `PremiumMember`

### Polimorfizem
Objekti tipa `StandardMember` in `PremiumMember` se uporabljajo prek skupnega tipa `Member`.

### Vmesniki
Uporabljena sta vmesnika:
- `IPriceCalculable`
- `IDisplayable`

### Indekserji
Razred `MemberCollection` omogoča dostop do članov:
- po indeksu
- po imenu

### Delegati
Uporabljeni delegati:
- `MemberAddedHandler`
- `NotificationHandler`
- `MemberFilter`

### Dogodki
Razred `MemberManager` uporablja dogodke za:
- obveščanje ob dodajanju novega člana
- pošiljanje sistemskih obvestil

---

## Struktura projekta
Projekt je razdeljen na dva dela:

### `fitnes.core`
Class library, ki vsebuje poslovno logiko:
- `Member`
- `StandardMember`
- `PremiumMember`
- `Membership`
- `DiscountLevel`
- `MemberCollection`
- `MemberManager`
- `Delegates`
- `IPriceCalculable`
- `IDisplayable`

### `fitnes.manager`
Windows Forms uporabniški vmesnik:
- `Form1.cs`
- `Form1.Designer.cs`

---

## Namestitev in zagon

### 1. Kloniranje repozitorija
```bash
git clone [TUKAJ_DODAJ_POVEZAVO_DO_REPOZITORIJA]
