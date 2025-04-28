// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
int x = 0;
int i = 0;
int ii = 0;

int d = 255; //bir müşterinin kayıt olduğu günden bu yana geçen süre
//1. Anlamlı değişken ismi kullanın:
int daysSinceCustomerCreated = 255;
int custDays = 250;
int musterininKaydindanGunSayisi = 255;

//bool banuAlkan = false;
bool isAvailableForReservation = true;
//2. kısaltma konusunda dikkatli olun.
int hp = 100;
//marka olan hp
int hpPrinters = 100;
//hp sos
//health point
//horse power
//hit point
//3. Değişkenin tipine göre isimlendirme yapın:
bool isApproved = false;
int age = 45;

var currentStock = 100;
var taxRate = 0.20;

//4. kompleks nesnelerde, nesne; sınıf adını içermelidir / içerebilir.
var customerDataTable = new DataTable();
var randomNumberGenerator = new Random();
//Random random = new Random();


//aşağıdaki kodu yazan yazılımcı kör oldu (okuyan da :D )
//var o = 0;
//var l = 1;
//if (o==l || l==0)
//{
//    o = 1;
//}

string password = "Pa$$w0rd";

bool isIncludeLetter = true;
bool isIncludeDigit = true;
bool isIncludeSymbol = true;

bool isAvailablePassword = isIncludeLetter && isIncludeDigit && isIncludeSymbol;

if (isAvailablePassword)
{

}

int number = 5;
var isSmallThen10 = number < 10;

var products = new List<string>();
var productList = new List<string>();

List<int[]> cells = new List<int[]>();
List<int[]> getFlaggedCells()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cells)
    {
        var checkCellState = cell[0];
        if (checkCellState == CellTypes.Flagged)
        {
            flaggedCells.Add(cell);
        }
    }
    return flaggedCells;
}

enum CellType
{
    Empty = 1,
    Opened = 2,
    Flagged = 4,
    Exploded = 8
}

public class CellTypes
{
    public const int Flagged = 4;
    public const int Opened = 2;
    public const int Exploded = 8;
    public const int Empty = 1;
}




