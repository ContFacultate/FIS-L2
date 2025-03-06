namespace Main{ 
class Main { 
static void Main(string[] args) { 
Ajutor ajutor=new();
ajutor.Afisare();
string optiune="";
optiune=Console.ReadLine();
if(optiune=="info"){ajutor.Info();}
else if(optiune=="hello"){ajutor.Afisare();}
else if(optiune=="exit"){return;}
else Console.WriteLine(optiune);git
} 
} 
} 

