 
using System; 

 
namespace Test{ 
    
 
    class Test { 
       private int rng{get;set;};
       public Test(){
          rng=(int)Math.random();
       }
       public int getRng(int x){
            return rng%x;
       }
    }
} 
