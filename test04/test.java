public class test {
    public static void main(String args[]) {

        if( args.length != 1 ){
            System.out.println("Run with parameter of 25000 !");
            return;
        }
        int counter = 0;
        try{
            counter = Integer.parseInt(args[0]);
        }catch(Exception ex){}
        if( counter != 25000 ){
            System.out.println("Run with parameter of 25000 !");
            return;
        }

        long sum = 0;
        for(int i=0;i<counter;i++){
            for(int j=0;j<counter;j++){
                sum += 1 + i*2 + j*3;
            }
        }
        System.out.println("sum = " + sum);
    }
}

