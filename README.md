Telkek
======

Visual Basic 2008 Form App

Feladat:

Patakfalván a faluszélen levő beépítetlen területet szeli ketté a Dirib patak. Az önkormányzat elhatározta, hogy építési telkek kialakításával létrehozza a Szép jövő lakótelepet. A beépítés
után egy téglalap alakú területen két utca jön létre: Gazdagsor és Jólétsor. A két sor lakói „lábszomszédok”, de telkeiket elválasztja egymástól a Dirib patak. A két utca párhuzamos, az
utcafrontokat 80 méter választja el egymástól. Mindkét soron azonos számú téglalap alakú telket jelöltek ki, soronként legfeljebb 30-at. Gazdagsoron csak páratlan, Jólétsoron csak páros
házszámokat adnak ki (1-től, illetve 2-től indulva kihagyásmentesen számozva). Egy telek szélessége maximum 40 méter. Az utcák végén egy-egy híd köti össze a patak két partját. A
telkek kijelölésénél figyelembe vették a patak medrének nyomvonalát.

A kijelölt telkekről kimutatás készült, amit a telkek.txt fájl tartalmaz. Ennek a fájlnak az első sora tartalmazza a kiosztandó telkek számát, majd az ezt követő sorokban az egyes
telkek adatai találhatók. Az első adat a házszám, a második a telek szélessége, míg a harmadik az erre merőlegesen mért hosszúsága. Gazdagsor esetén az összes adat rendelkezésre áll, Jólétsor
esetében viszont a hosszúság adatok helyén 0 áll. Az adatok között pontosan egy szóköz található.

1. Olvassa be a telkek.txt állományban található adatokat, s annak felhasználásával oldja meg a következő feladatokat! Ha az állományt nem tudja beolvasni, akkor a benne található
adatok közül Gazdagsor 1., 3., 5., 7. és 9. számú, valamint Jólétsor 2., 4., 6., 8. és 10. számú telkének adatait jegyezze be a programba, s úgy oldja meg a feladatokat!

2. Hány métert kell annak gyalogolnia, aki körbe akarja járni a két utcát? A kiszámított távolságot írassa ki a képernyőre!

3. Az önkormányzat előírásai szerint a 20 m széles vagy annál keskenyebb telkek esetén teljes utcafront beépítést kell alkalmazni. Határozza meg és a képernyőre írassa ki, hogy
ez hány telekre vonatkozik a Jólétsoron!

4. Hány háznyira van egymástól a legnagyobb és a legkisebb területű telek Gazdagsoron? A két telek között elhelyezkedő telkek számát, valamint a legnagyobb és legkisebb telek
házszámát, illetve területét írassa ki a képernyőre!

5. Az önkormányzat telekadót fog kivetni. Az adót Fabatkában számolják. A 700 négyzetméteres és annál kisebb telkek esetén ez 51 Fabatka négyzetméterenként, az ennél nagyobb
telkeknél az első 700 négyzetméterre vonatkozóan szintén 51 Fabatka, 700 négyzetméter felett egészen 1000 négyzetméterig 39 Fabatka a négyzetméterenkénti adó. Az
1000 négyzetméter feletti részért négyzetméter árat nem, csak 200 Fabatka egyösszegű általányt kell fizetni. A 15 m vagy annál keskenyebb, illetve a 25 m vagy annál rövidebb
telkek tulajdonosai 20% adókedvezményben részesülnek. Az adó meghatározásánál 100 Fabatkás kerekítést kell használni (pl. 6238 esetén 6200, 6586 esetén 6600). Határozza
meg, mekkora adóbevételre számíthat Gazdagsor után az önkormányzat!

6. Melyik a 3 utolsó telek a Jólétsoron? A házszámokat és a telkeknek a Jólétsor elejétől mért távolságát írja ki a képernyőre a házszámok szerint csökkenő sorrendben!

7. Határozza meg Jólétsor telkeinek hosszúságát! Vegye figyelembe, hogy a szemben fekvő telkek patak felőli határvonalait az utcafrontra merőleges irányban legalább 10 méternek
kell elválasztania egymástól! Szemben fekvőnek számítanak a telkek akkor is, ha csak a telkek valamelyik széle van egymással szemben. (Például a 10-es számú telekkel csak a 9-
es és 11-es számú telek van szemben.) A számításnál a feltételnek megfelelő legnagyobb telkeket kell kialakítani! Jólétsor adatait írja ki a joletsor.csv fájlba! Az egyes sorokban
a házszám, a szélesség és a hosszúság szerepeljen! Az adatokat pontosan egy pontosvessző válassza el egymástól!
