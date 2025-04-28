// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");


string getRandomWord(List<string> words)
{
    //1. Bir fonksiyon SADECE BİR İŞ YAPAR (One job at a time!)
    return "ayna";
}

string getPuzzledWord(string word)
{
    //2. Fonksiyon minimum satır içermeli.
    return "****";
}

void showPuzzle(string puzzledWord)
{

}

string getLetterFromUser()
{
    //3. En ideal fonksiyon, en az parametreli olandır. 
    return "a";
}

bool isWordIncludeLetter(string word, string letter)
{
    return true;
}

string replaceSymbolToLetter(string letter, string puzzledWord)
{
    return "a**a";
}
void decrease()
{
    //hakkı düş
}

bool suggestWord(string word, string suggest)
{
    return word == suggest;
}

/*
 *  1. Bir isim listesi içinden kelime seç.
 *  2. Seçtiğin kelimeyi * ile gizle.
 *  3. Ekranda göster.
 *  4. Kullanıcıdan harf iste.
 *  5. Girilen harfin kelime içinde olup olmadığına bak.
 *  6. Eğer varsa, harfin konumundaki *'ı harf ile değiştir.
 *  7. Yoksa bir hak düş.
 *  8. Kelimeyi tahmin etmesini iste
 *  9. Bilirse "Bildiniz"
 *  10. Bilemezse "Bilemediniz"
 */
var word = getRandomWord(new List<string>());
var puzzled = getPuzzledWord(word);
showPuzzle(puzzled);
var letter = getLetterFromUser();
if (isWordIncludeLetter(word, letter))
{
    puzzled = replaceSymbolToLetter(letter, puzzled);
    showPuzzle(puzzled);
}
else
{
    decrease();
}
suggestWord(word,"ayna");
Random  random = new Random();

ReportGenerator reportGenerator = new ReportGenerator("C:\\bilmemne.xlsx");
reportGenerator.CreateReport(new ReportOption { });