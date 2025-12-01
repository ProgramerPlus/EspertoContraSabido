using System.ComponentModel;

Console.Clear();
Console.WriteLine("--- Esperto contra sabido ---");

Console.WriteLine("Quantos alimentos serão distribuidos?");
int alimento=Convert.ToInt32(Console.ReadLine()!);

int n=0;
int a =0;
int s=0;
int soma=0;
int x=0;
int l=0;
int y=0;
int t=0;

while(n<alimento){

    n=n+1;
    Console.Write($"{n} para você. ");
y=n;
if(l==1 && x==0 || alimento==n){n=alimento;break;}

a=0;
while(a<n){
   a=a+1;
   if(x==a || x==0 && l==1){n=alimento;break;}
   Console.Write($"{a} ");
   
}

s=a+s;

soma=n+s;   

x = alimento-soma; 



if(x<=n){l=1;}


 Console.Write($" para mim.\n");

if(l==1 && x==0){n=alimento;break;}

}


Console.WriteLine($"Pica-pau recebeu {y} alimento(s).");
Console.WriteLine($"Raposinha recebeu {s} alimento(s).");
