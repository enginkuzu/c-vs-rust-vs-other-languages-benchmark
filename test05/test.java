import java.util.HashMap;
public class test {
    public static void main(String args[]) {

        long total = 0;
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();

        long time1 = System.currentTimeMillis();
        for(int i=0;i<25000000;i++){
            map.put(i, i);
        }
        long time2 = System.currentTimeMillis();
        System.out.println("HashMap put "+(time2-time1)+" ms");

        new java.util.Scanner(System.in).nextLine();

        long time3 = System.currentTimeMillis();
        for(int i=0;i<25000000;i++){
            total += map.get(i);
        }
        long time4 = System.currentTimeMillis();
        System.out.println("total = "+total);
        System.out.println("HashMap get "+(time4-time3)+" ms");
    }
}

