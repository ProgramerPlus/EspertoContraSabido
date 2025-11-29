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

while(n<alimento){

    n=n+1;
    Console.Write($"{n} para você. ");

a=0;
while(a<n){
   a=a+1;
   Console.Write($"{a} ");
}

s=a+s;

soma=n+s;   

x = alimento-soma; 





 Console.Write($" para mim.\n");


}


Console.WriteLine($"Pica-pau recebeu {n} alimento(s).");
Console.WriteLine($"Raposinha recebeu {s} alimento(s).");
