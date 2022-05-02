if( args.Length != 1 ){ Console.WriteLine("Run with parameter!"); return; }
int counter = 0;
int.TryParse(args[0], out counter);

long sum = 0;
for(int i=0;i<counter;i++){
    for(int j=0;j<counter;j++){
        sum += 1 + i*2 + j*3;
    }
}
Console.WriteLine("sum = " + sum);

if( counter != 25000 ){ Console.WriteLine("Run with parameter of 25000 !"); }

