if( args.Length != 1 ) goto end_with_error;
int counter = 0;
int.TryParse(args[0], out counter);
if( counter != 25000 ) goto end_with_error;

long sum = 0;
for(int i=0;i<counter;i++){
    for(int j=0;j<counter;j++){
        sum += 1 + i*2 + j*3;
    }
}
Console.WriteLine("sum = " + sum);
return;
            
end_with_error:
Console.WriteLine("Run with parameter of 25000 !");

