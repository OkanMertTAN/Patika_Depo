import java.util.Scanner;
import java.util.Arrays;

public class GirilenSayılardanMinveMaxDeğerleriBulma {
        public static void main(String[] args) {
            Scanner input = new Scanner(System.in);

            System.out.print("Kaç tane sayı girmek istiyorsunuz : ");
            int nSayı = input.nextInt();
            int[] dizi = new int[nSayı];

            for (int i = 1; i <= nSayı; i++) {
                System.out.print(i+". Sayıyı giriiniz : ");
                dizi[i] = input.nextInt();    
            }

            System.out.println("En büyük sayı : "+Arrays.stream(dizi).max().getAsInt());
            System.out.println("En küçük sayı : "+Arrays.stream(dizi).min().getAsInt());
        }
}