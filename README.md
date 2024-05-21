
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
![image](https://github.com/Domis201/KTUBirds/assets/120787865/55bedf7e-a8c9-47bb-a256-c2747b7a757c)
Trečiasis testas tikrina, ar esant žaidime galime pasiekti pauzės meniu ir jame esančias parinktis.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/efa568dd-a77d-4de5-ba04-124f0aa6d13d)
![image](https://github.com/Domis201/KTUBirds/assets/120787865/a4dcc1c1-4341-4285-9fe0-c915fa487fec)
![image](https://github.com/Domis201/KTUBirds/assets/120787865/0ea28949-3712-428c-8e17-586b44ce02b5)
![image](https://github.com/Domis201/KTUBirds/assets/120787865/2e20e0bb-f1d8-4074-8206-0194b261f394)
![image](https://github.com/Domis201/KTUBirds/assets/120787865/eada9553-8f09-4849-80ae-88077b652268)
![image](https://github.com/Domis201/KTUBirds/assets/120787865/b009a588-6baf-4fe4-bbdb-85e7435f084d)
![image](https://github.com/Domis201/KTUBirds/assets/120787865/f69b8845-aa73-4e88-8c04-9355c64449ca)


## TRUMPA NAUDOTOJO DOKUMENTACIJA

Žaidėjas yra baltas paukščiukas, kurio tikslas yra pataikyti tiesiai į monstrus arba į dėžes, kad jos nukristų ant tu pačių monstrų. Yra 2 priešų tipai:
-	Paprastas monstras, kuris nėra kažkuo ypatingas.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/a3291b0a-366f-4f48-834d-cc00970561af)

-	Bosas, kuris yra didesnis pagal dydį ir moka judėti į šonus.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/aa912b70-bb5f-496e-9655-c5526cb9bc98)

Taip pat yra sukurtos kliūtis, kurios apsunkins užduotį žaidėjui:
-	Įvairios reljefo variacijos.
-	Dėžės, kurios turi skirtingas fizines savybes (svoris, ant kiek sunkiai stumiasi, dydis).


## Vartotojo vadovas

Vartotojas yra pasitinkamas meniu, kuriame žaidėjas gali pradėti žaidimą, pakeisti nustatymus arba išeiti iš žaidimo.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/d6306a33-d15d-43a0-897d-dfded390e2a9)

Pasirinkus nustatymus, vartotojas patenka į kitą menių, kur gali pasirinkti muzikos ir garso efektų garsumo lygi.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/359dcf4e-73a7-4f05-bd97-6ed58f4061c6)

Norint pradėti žaidimą, reikia paspausti mygtuką “Play” ir vartotojas automatiškai patenka į pirmą lygį. 
![image](https://github.com/Domis201/KTUBirds/assets/120787865/67e20aec-7db1-4f4f-b812-ded537f3b702)

Viršutiniame kairiajame kampe mes turi rodyklius, kurie parodo kiek vartotojas dar turi bandymų (baltas paukščiukas ir skaičius 3) ir taip pat kiek dar liko monstrų (raudonas monstras ir skaičius 3). Viršuje per centrą vartotojas gali matyti kiek laiko jis jau žaidžia. Viršutiniame dešiniajame kampe yra du mygtukai: 
-	„Reset“. Žaidėjas gali pradėti dabartinį lygį iš naujo.
-	„Pause“. Žaidėjas gali sustabdyti žaidimą. Paspaudus šį mygtuką, atsidaro pauzės meniu, kuris yra labai panašus į pagrinidnį. Vartotojas turi galimybę pasikeisti garso nustatymus, pratęsti žaidimą arba sugrįšti į pagrindinį menių.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/e09669bf-e260-428e-8d70-22b7ccfd8108)

Sėkmingai įveikus visus 5 lygius, vartotojas pamato „Game Over“ meniu, kuris informuoja apie žaidimo pabaigą. Žaidėjas gali išeiti į pagrindinį menių, išeiti iš pačio žaidimo arba nueiti į nustatymų menių. 
![image](https://github.com/Domis201/KTUBirds/assets/120787865/7a97e298-7b0d-44c0-b9ae-0e3e8b8718d4)

Taip pat, paspaudus mygtuką su žvaigždute, žaidėjas gali pažiūrėti lyderių lentą. Vartotojas pamatys žaidėjų vardus ir jų finišavimo laiką. Pačioje apačioje yra mygtukas, su kuriuo galima sugrįžti į „Game Over“ menių.
![image](https://github.com/Domis201/KTUBirds/assets/120787865/3008b3a5-a77e-4fc5-b023-1c692a9922f2)

Pralaimėjimo ekrano šiame žaidime nėra, nes jei vartotojas nesugeba iš 3-ų bandymų praeiti lygį – jis automatiškai pradeda lygį iš pradžių.
