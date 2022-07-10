import java.util.Scanner;
public class MükemmelSayı {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int number,sum=0;

        System.out.print("Sayıyı Giriniz : ");
        number = input.nextInt();

        for (int i = 1; i < number; i++) {
            if(number%i==0){
                sum+=i;
            }
        }
        if(number==sum){
            System.out.print(sum+" Bu sayı mükemmel sayıdır.");
        }else{
            System.out.print(sum+" Bu sayı mükemmel sayı değildir.");
        }
    }
}
