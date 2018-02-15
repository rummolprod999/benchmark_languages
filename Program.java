import java.util.Date;

public class Program{ 
      
    public static void main (String args[]){
          
        Date a = new Date();
        long s = 0L;
        for(int i = 0; i <3; i++){
            s = fib(45);
        }
        Date b = new Date();
        long c = b.getTime() - a.getTime();
        c = c / 1000 ;
        System.out.println(s);
        System.out.println(c);
        System.out.println(c/3.0);
    }

    public static long fib(int n){
    if(n<3){
        return 1;
    }
    return fib(n-1) + fib(n-2);
    }
}