# Lab. 02. Zgadywanka

> Ćwiczenie - prosta gra w "Za dużo za mało" w wariantach konsolowym i desktopowym

* Krzysztof Molenda
* 2021-01-15 (v. 01)
* Cel: nabycie podstawowych umiejętności programistycznych: konstrukcji warunkowego wyboru, sprawdzania poprawności wprowadzanych danych, komunikacji programu z użytkownikiem, przetwarzania cyklicznego (pętli).
* Zagadnienia: dekompozycja problemu na zadania – metoda *top-down*, wyszukiwanie binarne (*binsearch*), liczby pseudolosowe, warunkowy wybór `if-else`, `if-elseif-else`, wczytywanie danych z konsoli, konwersja z napisu na liczbę, zgłaszanie wyjątku (`throw`), wyjątki i ich obsługa (`try-catch`), przetwarzanie cykliczne (`while`, `do-while`), wyznaczanie czasu wykonania programu, przestrzenie nazw (`namespace`).

## Wprowadzenie

Gra w za dużo za mało to prosta rozgrywka między dwoma graczami (tu: komputerem a człowiekiem), polegająca na odgadnięciu przez drugiego gracza (odgadującego) wybranej przez gracza pierwszego (losującego) liczby ze znanego zakresu. Gracz odgadujący proponuje wartość, gracz który wybrał liczbę odpowiada jednym z 3 sformułowań: trafiłeś, za dużo lub za mało. Gra kończy się w chwili, gdy odgadujący poda poprawną wartość.

### Scenariusz rozgrywki

1. Komputer losuje wartość od 1 do 100 i zapamiętuje ją
2. Człowiek próbuje odgadnąć tę wartość, przedstawiając swoją propozycję
3. Komputer porównuje przedstawioną propozycję do zapamiętanej, wylosowanej wartości
    1. jeśli wylosowana = proponowana, wtedy odpowiada TRAFIŁEŚ
    2. jeśli wylosowana > proponowana, wtedy odpowiada ZA MAŁO
    3. jeśli wylosowana < proponowana, wtedy odpowiada ZA DUŻO

Przedstawiony powyżej scenariusz dotyczy tylko jednej próby odgadnięcia wylosowanej przez komputer liczby. Cała gra polega na zadaniu komputerowi serii pytań i uzyskaniu serii odpowiedzi, na podstawie których gracz - odpowiednio wnioskując - dochodzi do poprawnej odpowiedzi.

Zatem, zapisując algorytmicznie, pseudokodem:

```pseudocode
dopóki NIE TRAFIŁEŚ 
  wykonuj kroki 2 oraz 3
koniec dopóki
```

**Strategia odgadującego:**

Przedstawiony problem i strategia postępowania należą do ważnej kategorii problemów informatycznych nazwanych terminem *binsearch* - wyszukiwanie binarne.

Strategia jest prosta - skoro wylosowana liczba jest z przedziału od 1 do 100, to pierwsze pytanie powinno brzmieć:

czy jest to liczba 50?

* Jeśli 50 to za mało, w kroku następnym obszar poszukiwania zmniejsza się o połowę (szukamy w zakresie od 51 do 100, czyli zadajemy pytanie np. czy jest to liczba 75?)
* Jeśli 50 to za dużo, w kroku następnym obszar poszukiwania zmniejsza się o połowę (szukamy w zakresie od 1 do 49, czyli zadajemy pytanie np. czy jest to liczba 25?)

W każdym kroku obszar poszukiwania nieznanej wartości zmniejsza się o połowę. Stąd nazwa "wyszukiwanie binarne" lub "połówkowe".

❓ Pytanie: Stosując powyższą strategię, w maksymalnie ilu krokach odgadniesz wylosowaną wartość?

Przedstawiona idea wyszukiwania binarnego ma szersze zastosowanie informatyczne. Jest ona algorytmem opartym na metodzie "dziel i zwyciężaj" - jednej z głównych metod projektowania algorytmów.

Rozważmy podobny problem do problemu naszej gry w za dużo za mało. W tabeli bazy danych systemu PESEL znajdują się m. in. dane osobowe wszystkich Polaków, w tym imię i nazwisko. Tabela ta zawiera np. 40 milionów wpisów posortowanych rosnąco ze względu na nazwisko. Szukamy osoby o nazwisku, powiedzmy Kowalski.

❓ W ilu maksymalnie krokach znajdziemy taki wpis lub stwierdzimy, że w bazie nie ma takiej osoby?

---

## Etapy realizacji zadania

### Krok 1 - wariant monolityczny

Wszystko w `Main()` - logika i interfejs użytkownika, wariant aplikacji konsolowej

Zagadnienia:

* `Console.Write()`, `Console.WriteLine()`
* Generowanie liczb losowych (`Random`)
* `Console.ReadLine()`, konwersja napisu na liczbę, obsługa wyjątków zgłaszanych przy konwersji
* Warunkowy wybór: `if-elseif-else`
* pętla

#### 1. Projektujemy jedną rozgrywkę

```csharp
namespace Gra
{
    class Program
    {

        static void Main(string[] args)
        {
            //1. komputer losuje liczbę od 1 do 100
            // i prosi o podanie propozycji przez człowieka

            //2. Człowiek proponuje

            //3. Komputer ocenia odpowiedź

        } //koniec Main
    
    }
}
```

#### 2. Losowanie

Wykorzystujemy generator liczb losowych (klasa Random) – deklarujemy ją w kontekście globalnym (poza Main()) i wewnątrz Main() wywołujemy generator.Next(1, 101). Poczytaj: <https://docs.microsoft.com/en-us/dotnet/api/system.random>

```csharp
  ...
    class Program
    {

        static Random generator = new Random();

        static void Main(string[] args)
        {
            //1. komputer losuje liczbę od 1 do 100
            // i prosi o podanie propozycji przez człowieka
            int wylosowana = generator.Next(1, 101);
            Console.WriteLine("Wylosowalem liczbę z zakresu 1..100. Odgadnij ją " +                                                 
                               wylosowana); //usunąć w wersji ostatecznej

            //2. Człowiek proponuje

            //3. Komputer ocenia odpowiedź

        } //koniec main
    }
}
```

Przetestuj.

#### 3. Propozycja człowieka i ocena przez komputer

```csharp
class Program
{
    static Random generator = new Random();

    static void Main(string[] args)
    {
        //1. komputer losuje liczbę od 1 do 100
        // i prosi o podanie propozycji przez człowieka
        int wylosowana = generator.Next(1, 101);
        Console.WriteLine("Wylosowalem liczbę z zakresu 1..100. Odgadnij ją" + wylosowana); //usunąć w wersji ostatecznej

        //2. Człowiek proponuje
        Console.Write("Podaj propozycję: ");
        int propozycja = Convert.ToInt32(Console.ReadLine());

        //3. Komputer ocenia odpowiedź
        if (propozycja < wylosowana)
            Console.WriteLine("za mało");
        else if (propozycja > wylosowana)
            Console.WriteLine("za dużo");
        else
            Console.WriteLine("trafiłeś");

    } //koniec main
}
```

#### 4. Zwielokrotniamy rozgrywkę

```csharp
class Program
{

    static Random generator = new Random();

    static void Main(string[] args)
    {
        //1. komputer losuje liczbę od 1 do 100
        // i prosi o podanie propozycji przez człowieka
        int wylosowana = generator.Next(1, 101);
        Console.WriteLine("Wylosowalem liczbę z zakresu 1..100. Odgadnij ją " +                                                 
                            wylosowana); //usunąć w wersji ostatecznej

DOPÓKI NIE TRAFIONO WYKONUJ
        //2. Człowiek proponuje
        Console.Write("Podaj propozycję: ");
        int propozycja = Convert.ToInt32(Console.ReadLine());

        //3. Komputer ocenia odpowiedź
        if (propozycja < wylosowana)
            Console.WriteLine("za mało");
        else if (propozycja > wylosowana)
            Console.WriteLine("za dużo");
        else
            Console.WriteLine("trafiłeś");
KONIEC DOPÓKI

    } //koniec main
}
```

Implementacja pętli - użycie `while`:

```csharp
bool trafiono = false;
//dopóki nie trafiono wykonuj
while( ! trafiono )
{
    …

    //3. Komputer ocenia odpowiedź
    if (propozycja < wylosowana)
        Console.WriteLine("za mało");
    else if (propozycja > wylosowana)
        Console.WriteLine("za dużo");
    else
    {
        Console.WriteLine("trafiłeś");
        trafiono = true;
    }
} // koniec dopóki
```

#### 5. Bronimy się przed błędami

```csharp
int propozycja = Convert.ToInt32(Console.ReadLine()); //tu się może pojawić wyjątek
```

Sprawdź, jakie wyjątki: <https://docs.microsoft.com/en-us/dotnet/api/system.convert.toint32> należy otoczyć blokiem try-catch

```csharp
while( ! trafiono )
{
    //2. Człowiek proponuje
    Console.Write("Podaj propozycję: ");
    try 
    {
        int propozycja = Convert.ToInt32(Console.ReadLine()); //tu się może pojawić wyjątek
        if (propozycja < 1 || propozycja > 100)
        throw new ArgumentOutOfRangeException("poza zakresem 1..100");

        //3. Komputer ocenia odpowiedź
        if (propozycja < wylosowana)
            Console.WriteLine("za mało");
        else if (propozycja > wylosowana)
            Console.WriteLine("za dużo");
        else
        {
            Console.WriteLine("trafiłeś");
            trafiono = true;
        }
    }
    catch(ArgumentOutOfRangeException e)
    {
        Console.WriteLine("mówiłem, ze od 1 do 100");
        Console.WriteLine(e.StackTrace);
    }
    catch (FormatException)
    {
        Console.WriteLine("wpis nie przypomina liczby"); //np. wiqyidwq
    }
    catch (OverflowException)
    {
        Console.WriteLine("przesadziłeś z rozmiarm liczby"); //np. 1235217351275371572143
    }
    catch // wszystkie pozostałe przypadki
    {
        Console.WriteLine("bliżej nieokreślony błąd");
    }
} // koniec dopóki
```

Przetestuj

#### 6. Mierzymy czas

Na początku programu umieść:

```csharp
System.Diagnostics.Stopwatch czas = System.Diagnostics.Stopwatch.StartNew();
```

Na końcu programu:

```csharp
czas.Stop();
Console.WriteLine("czas gry = " + czas.Elapsed);
```

---

### Krok 2 - wariant modularny (proceduralny)

Refaktoryzacja poprzedniego kodu, klasa traktowana jako moduł, uproszczenie kodu, określenie procedur i funkcji wielokrotnego użycia.

---

### Krok 3 - wariant obiektowy

* Projekt typu _Class library_, `.Net Standard`
* Klasa `Gra` opisująca model gry (dostarczająca API dla gry)
* Pola klasy, właściwości, metody
* Hermetyzacja
* Testy jednostkowe

---

### Krok 4 - aplikacja konsolowa oparta na modelu gry

Projekt aplikacji konsolowej, wykorzystującej opracowany model gry.

Podział na część odpowiedzialną za widok (obsługa konsoli) oraz kontroler (komunikację widoku z modelem).

---

### Krok 5 - aplikacja okienkowa (WinForm) oparta na modelu gry

* model programowania oparty na zdarzeniach
* logika interfejsu

---

## Propozycje rozszerzenia projektu

1. Zaimplementuj wariant gry, w którym to komputer odgaduje liczbę wylosowaną (wymyśloną) przez człowieka, zaś człowiek odpowiada na pytania komputera.

2. Zaimplementuj wariant gry *komputer-człowiek* uwzględniający co najwyżej jedno "oszustwo":
   1. komputer losuje liczbę
   2. człowiek próbuje ja odgadnąć
   3. komputer może (nie musi) raz się "pomylić" podając fałszywą odpowiedź
   4. człowiek wie, że komputer może (nie musi) raz oszukać, ale nie wie kiedy.

3. Zaimplementuj wariant gry z poprzedniego punktu w układzie *człowiek-komputer*.

---

## Wyzwania

* Wyzwanie 1: aplikacja WPF oparta na modelu gry

* Wyzwanie 2: aplikacja ASP .Net oparta na modelu gry

* Wyzwanie 3: aplikacja typu _web service_ oparta na modelu gry

* Wyzwanie 4: aplikacja Xamarin oparta na modelu gry
