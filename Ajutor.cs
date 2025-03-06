 
using System; 

 
namespace Ajutor{ 
    
 
    class Ajutor { 
        
        public void Afisare(){
            Console.Write("HELLO WORLD");
        }
           public void Info(){
            string numeProiect="Numele proiectului";
            string numeFacultate="Universitatea Politehnica Timisoara";
            string numeAutor="Bordinc Razvan";
            Console.Write($"nume proiect: {numeProiect}\nnume facultate: {numeFacultate}\nnume autor: {numeAutor}");
        }
    }
} 
