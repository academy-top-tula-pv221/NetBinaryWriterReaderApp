// BinaryWriter
// BinaryReader

string path = @"D:\RPO\Maxim Efimov\NewDir\file.dat";

int a = 1234;
double x = 345.9872;
long l = 2678516721;
string s = "Hello world";
bool f = true;

User user = new User() { Name = "Bob", Age = 34 };

using (BinaryWriter writer = new(File.Open(path, FileMode.Create)))
{
    //writer.Write(a);
    //writer.Write(x);
    //writer.Write(l);
    //writer.Write(s);
    //writer.Write(f);
}

//using (BinaryReader reader = new(File.Open(path, FileMode.Open)))
//{
//    double xx = reader.ReadDouble();
//    int aa = reader.ReadInt32();
//    long ll = reader.ReadInt64();
//    string ss = reader.ReadString();
//    bool ff = reader.ReadBoolean();

//    Console.WriteLine(aa);
//    Console.WriteLine(xx);
//    Console.WriteLine(ll);
//    Console.WriteLine(ss);
//    Console.WriteLine(ff);
//}

class User
{
    public string Name { set; get; }
    public int Age { set; get; }
}