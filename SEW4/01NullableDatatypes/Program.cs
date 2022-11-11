int i = 100;
int? j = null;          //noch keinen Wert zugewiesen
int k;


Console.WriteLine(j);
Console.WriteLine(i);
//Console.WriteLine(k);

j = i * 100;

if (j.HasValue)         // ungleich null
{
    k = j.Value * 100;
}


k = i * j.GetValueOrDefault() * 100;

j = null;

string s = null;
string? s2 = null;
