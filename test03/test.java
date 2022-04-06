public class test02 {
    public static void main(String args[]) {
        long sum = 0;
        for(int i=0;i<25000;i++){
            for(int j=0;j<25000;j++){
                sum += 1 + i*2 + j*3;
            }
        }
        System.out.println("sum = " + sum);
    }
}

