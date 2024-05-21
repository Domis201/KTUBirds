
# Projektas "KTU Birds"

## Komandos Nariai

> Dominykas Margis, IFIN-2/3,  
> Osvaldas Žilinskas, IFIN-2/3  
> Justas Balčikonis, IFIN-2/3  
> Eliza Mikolajevič, IFIN-2/3

## TECHNINĖ UŽDUOTIS

Užsakovas: žaidimo kūrėjai
Funkciniai reikalavimai:  
•	Žaidimas skirtas PC platformai.  
•	Žaidimo tikslinė auditorija yra paaugliai ir jaunimas.  
•	Priešai turi veikti autonomiškai.  
•	Skirtingi lygiai turi skirtis sudėtingumu.  
•	Turi būti skirtingų kliūdžių dizainų.  
•	Nustatymų meniu skirtas reguliuoti muzikos ir garso efektų garsumą.
•	Žaidime turi būti lyderių lentelė.  
•	Žaidimas turi būti pakankamai trumpas, kad greit neatsibostų ir pavyktų išgauti varžymosi efektą, t.y. kuris žaidėjas pereis visus lygius greičiausiai.  
•	Žaidimo rezoliucija turi prisitaikyti prie žaidėjo rezoliucijos.
Nefunkciniai reikalavimai:  
•	Žaidimas turi būti kontroliuojamas su pele.  
•	Žaidimas turi būti optimizuotas  
•	Užimamos atmintis dydis neturi viršyti 500 MB.  
•	Jį turi palaikyti Windows OS.  
•	Žaidimo lygiai turi užsikrauti greičiau nei per 2 sekundes.  
Reikšminiai žodžiai: Platformer, Destroy, Physics-based, Casual puzzle.  

## TESTAVIMAI

Prieš atliekant kiekvieną testą žaidimas buvo paleidžiamas iš naujo. Testavome UI veikimą bei žaidimo mechanikas.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/25446fd0-6e43-4428-be6d-578282873138)


## TRUMPA NAUDOTOJO DOKUMENTACIJA

Žaidėjas yra baltas paukščiukas, kurio tikslas yra pataikyti tiesiai į monstrus arba į dėžes, kad jos nukristų ant tu pačių monstrų. Yra 2 priešų tipai:
-	Paprastas monstras, kuris nėra kažkuo ypatingas.

-	Bosas, kuris yra didesnis pagal dydį ir moka judėti į šonus.

Taip pat yra sukurtos kliūtis, kurios apsunkins užduotį žaidėjui:
-	Įvairios reljefo variacijos.
-	Dėžės, kurios turi skirtingas fizines savybes (svoris, ant kiek sunkiai stumiasi, dydis).


## Vartotojo vadovas

Vartotojas yra pasitinkamas meniu, kuriame žaidėjas gali pradėti žaidimą, pakeisti nustatymus arba išeiti iš žaidimo.

Pasirinkus nustatymus, vartotojas patenka į kitą menių, kur gali pasirinkti muzikos ir garso efektų garsumo lygi.

Norint pradėti žaidimą, reikia paspausti mygtuką “Play” ir vartotojas automatiškai patenka į pirmą lygį. 

Viršutiniame kairiajame kampe mes turi rodyklius, kurie parodo kiek vartotojas dar turi bandymų (baltas paukščiukas ir skaičius 3) ir taip pat kiek dar liko monstrų (raudonas monstras ir skaičius 3). Viršuje per centrą vartotojas gali matyti kiek laiko jis jau žaidžia. Viršutiniame dešiniajame kampe yra du mygtukai: 
-	„Reset“. Žaidėjas gali pradėti dabartinį lygį iš naujo.
-	„Pause“. Žaidėjas gali sustabdyti žaidimą. Paspaudus šį mygtuką, atsidaro pauzės meniu, kuris yra labai panašus į pagrinidnį. Vartotojas turi galimybę pasikeisti garso nustatymus, pratęsti žaidimą arba sugrįšti į pagrindinį menių.

Sėkmingai įveikus visus 5 lygius, vartotojas pamato „Game Over“ meniu, kuris informuoja apie žaidimo pabaigą. Žaidėjas gali išeiti į pagrindinį menių, išeiti iš pačio žaidimo arba nueiti į nustatymų menių. 

Taip pat, paspaudus mygtuką su žvaigždute, žaidėjas gali pažiūrėti lyderių lentą. Vartotojas pamatys žaidėjų vardus ir jų finišavimo laiką. Pačioje apačioje yra mygtukas, su kuriuo galima sugrįžti į „Game Over“ menių.

Pralaimėjimo ekrano šiame žaidime nėra, nes jei vartotojas nesugeba iš 3-ų bandymų praeiti lygį – jis automatiškai pradeda lygį iš pradžių.
