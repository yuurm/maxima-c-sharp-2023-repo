// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");




//------------------------

bool alive = true;
bool isDead = false;

byte bit1 = 1;
byte bit2 = 102;

sbyte bit1s = -101;
sbyte bit2s = 102;

short n1 = 1;
short n2 = 102;

ushort n1u = 1;
ushort n2u = 102;

int a = 10;
int b = 0b101;  
int c = 0xFF;  

uint au = 10;
uint bu = 0b101;
uint cu = 0xFF;

long al = -10;
long bl = 0b101;
long cl = 0xFF;
ulong aul = 10;
ulong bul = 0b101;
ulong cul = 0xFF;




char ac = 'A';
char bc = '\x5A';
char cc = '\u0420';

string hello = "Hello";
string word = "world";

object ao = 22;
object bo = 3.14;
object co = "hello code";

float af = 3.14F;
float bf = 30.6f;
 
decimal cm = 1005.8M;
decimal dm = 334.8m;


uint auu = 10U;
long bll = 20L;
ulong cull = 30UL;

int ai = 4;
System.Int32 bi32 = 4;

var hellov = "Hello World";
var cv = 20;

/*
 * var c;
c= 20;
 */
//--------------
string hellostr = "Привет мир";
Console.WriteLine(hellostr);
Console.WriteLine("maxima");
Console.WriteLine("maxima c# .net...");
Console.WriteLine(24.5);

string name = "Youra";
int age = 36;
bool isEmployed = false;
double weight = 78.65;
 
Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmployed}");

string namestr = "George";
int agestr = 36;
double height = 1.7;
Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");


Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);


Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");

Console.Write("Введите свое имя: ");
string? nameInput = Console.ReadLine();
Console.WriteLine($"Привет {nameInput}");


Console.Write("Введите имя: ");
string? namei = Console.ReadLine();
 
Console.Write("Введите возраст: ");
int agei = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите рост: ");
double heighti = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Введите размер зарплаты: ");
decimal salaryi = Convert.ToDecimal(Console.ReadLine());
 
Console.WriteLine($"Имя: {namei}  Возраст: {agei}  Рост: {heighti}м  Зарплата: {salaryi}$");



int x1 = 5;
int z1 = ++x1; 
Console.WriteLine($"{x1} - {z1}");
 
int x2 = 5;
int z2 = x2++; 
Console.WriteLine($"{x2} - {z2}");

int x12 = 5;
int z12 = --x12; 
Console.WriteLine($"{x1} - {z1}");
 
int x21 = 5;
int z21 = x21--; 
Console.WriteLine($"{x21} - {z21}");


int az = 3;
int bz = 5;
int cz = 40;
int dz = cz---bz*az;    
Console.WriteLine($"a={az}  b={bz}  c={cz}  d={dz}");


int dx = (cz-(--bz))*az;    // a=3  b=4  c=40  d=108
Console.WriteLine($"a={az}  b={bz}  c={cz}  d={dx}");

//send


























