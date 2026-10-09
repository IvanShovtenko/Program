//numer 1
// Console.WriteLine("Write: name ");
// string name = Console.ReadLine()!;
// Console.WriteLine("Write: symbol ");
// char symbol = char.Parse(Console.ReadLine()!);
// Console.WriteLine("Write: level ");
// int level = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Write: gold ");
// int money = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Write: weight ");
// double kg = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Write: existence ");
// bool is_exist = bool.Parse(Console.ReadLine()!);
// Console.WriteLine($"=== EKWIPUNEK ===\nName:{name}\nSynbol:{symbol}\nLevel:{level}\nGold:{money}\nWeight:{kg}\nOn map:{is_exist}");

//numer 2
// int gold = 10;
// int expirience = 15;
// int training = 3;
// expirience+=25;
// expirience*=2;
// gold-=8;
// gold+=15;
// training++;
// Console.WriteLine($"{gold}\n{expirience}\n{training}");

//numer 3
// Console.WriteLine("Write: food");
// int food = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Write: people");
// int people = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Write: days");
// int days = int.Parse(Console.ReadLine()!);

// int food_on_person = food/people;
// int left = food%people;
// double food_on_day = food/people;
// double ocas_food_day = food/days; 
// Console.WriteLine($"Wyniki: \n{food_on_person}\n{left}\n{food_on_day}\n{ocas_food_day}");

//numer 4
// Console.WriteLine("Wpisz punkty życia");
// int punkty = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Wpisz mikstury");
// int mikstury = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Wpisz czy masz klucz");
// bool klucz = bool.Parse(Console.ReadLine()!);
// Console.WriteLine("Wpisz czy masz mapę");
// bool mapa = bool.Parse(Console.ReadLine()!);

// bool żyje = punkty>0;
// bool maPelneZdrowie = punkty>100;
// bool maZaopatrzenie = mikstury>=1;
// bool maPrzedmiotNawigacyjny = klucz==true && mapa==true;
// bool gotowyDoWyprawy = żyje==true || maZaopatrzenie==true && maPrzedmiotNawigacyjny==true;
// Console.WriteLine($" Wyniki: \n{żyje}\n{maPelneZdrowie}\n{maZaopatrzenie}\n{maPrzedmiotNawigacyjny}\n{gotowyDoWyprawy}");

//numer 5
// Console.WriteLine("Imię: ");
// string name = Console.ReadLine()!;
// Console.WriteLine("Wpisz max punkty życia");
// int punkty = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Wpisz act punkty życia");
// int act_punkty = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Wpisz bronię");
// int bronia = int.Parse(Console.ReadLine()!);
// Console.WriteLine("podstawowa śiła");
// int siła = int.Parse(Console.ReadLine()!);
// Console.WriteLine("ataka: ");
// double ataka = double.Parse(Console.ReadLine()!);
// Console.WriteLine("ogólne ataki");
// int all_atacks = int.Parse(Console.ReadLine()!);

// bronia +=all_atacks;
// siła += all_atacks;
// int mnoznik = (int) ataka;
// mnoznik = all_atacks*2;
// int damage = all_atacks + mnoznik;
// double cos = (double) act_punkty;
// double procent = Math.Round(cos/punkty*100,2);
// bool zyje = act_punkty>0;
// bool maPelneZdrowie = act_punkty==punkty;

// Console.WriteLine(
//     $"----Wyniki----: \nName:{name}\nZycie maksymalne:{punkty}\nZycie teraz:{act_punkty}\nBronia:{bronia}\nSiła:{siła}\nUltra_ataka:{mnoznik}\nDamage:{damage}\nZycie w procentach:{procent} %\nZyje:{zyje}\nPełne zdrowie:{maPelneZdrowie}"
// );


Console.WriteLine("Imię: ");
string name = Console.ReadLine()!;
Console.WriteLine("Wpisz max punkty życia: ");
int zdrowie = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz potoczne punkty życia: ");
int teraz_zdrowie = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz bronię: ");
int bronia = int.Parse(Console.ReadLine()!);
Console.WriteLine("podstawowa śiła: ");
int siła = int.Parse(Console.ReadLine()!);
Console.WriteLine("Extra ataka: ");
double extra_ataka = double.Parse(Console.ReadLine()!);
Console.WriteLine("mnoznik extra_ataki: ");
double mnoznik = double.Parse(Console.ReadLine()!);
Console.WriteLine("Zwykłe Obrażenia: ");
int zw_obrzenia = int.Parse(Console.ReadLine()!);
Console.WriteLine("Obrażenia extra_ataki: ");
int ex_obrazenia = int.Parse(Console.ReadLine()!);
int max_plecak = 10;
int plecak = 6;
int wolne_miejsca = max_plecak-plecak;
int gold = 50;
int liczba_cz = 5;
double gold_per_one = gold/liczba_cz;
int pozostało = gold%liczba_cz;
bool na_mape = true;
bool żyje = zdrowie>0;
bool pelne_zdr = teraz_zdrowie==zdrowie;
bool leczenie = teraz_zdrowie<30;
bool miejsce = plecak<max_plecak;
bool gotowa = teraz_zdrowie>=70 || miejsce==true || żyje==true;
double teraz_zdrowie_d = (double) teraz_zdrowie;
double zdrowie_d = (double) zdrowie;
double procent = Math.Round(teraz_zdrowie_d/zdrowie_d*100,2);
Console.WriteLine(
    ($"+==========================================+\n" +
    "|\t\tKARTA BOHATERA\t\t|\n"+
    "+==========================================+\n"+
    $"|Bohater:{name}\n"+
    "+------------------------------------------+\n"+
    $"|Zdrowie:{teraz_zdrowie}/{zdrowie} ({procent}%)|\n"+
    $"|Siła:{siła}|\n"+
    $"|Premia broni:{bronia}|\n"+
    $"|Zwykłe obrażenia:{zw_obrzenia}|\n"+
    $"|Mnożnik ataku specjalnego:{mnoznik}|\n"+
    $"|Obrażenia ataku specjalnego:{extra_ataka}|\n"+
    "+------------------------------------------+\n"+
    $"|Plecak: {plecak}/{max_plecak}|\n"+
    $"|Wolne miejsca: {wolne_miejsca}|\n"+
    $"|Gold:{gold}|\n"+
    $"|Liczba członków drużyny:{liczba_cz}|\n"+
    $"|Złoto dla jednej osoby:{gold_per_one}|\n"+
    $"|Złoto pozostające w skarbcu:{pozostało}|\n"+
    "+------------------------------------------+\n"+
    $"|Ma mapę:{na_mape}|\n"+
    $"|Żyje:{żyje}|\n"+
    $"|Ma pełne zdrowie: {pelne_zdr}|\n"+
    $"|Wymaga leczenia:{leczenie}|\n"+
    $"|Ma miejsce w plecaku:{miejsce}|\n"+
    $"|Gotowa do wyprawy:{gotowa}|\n"+
    "+==========================================+")
);
