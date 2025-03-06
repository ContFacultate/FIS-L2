namespace Main{ 
class Main { 
static void Main(string[] args) { 
Ajutor ajutor=new();
string optiune="";
optiune=Console.ReadLine();
if(optiune=="info"){ajutor.Info();}
else if(optiune=="hello"){ajutor.Afisare();}
else if(optiune=="exit"){return;}
else Console.WriteLine(optiune);
} 
Test test = new();
int num=test.getRng(5);
} 
} 

