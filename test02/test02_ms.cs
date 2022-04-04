long sum = 0;
for(int i=0;i<25000;i++){
    for(int j=0;j<25000;j++){
        sum += 1 + i*2 + j*3;
    }
}
Console.WriteLine("sum = " + sum);

