import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int index;

        System.out.println("Sayıları Sıralama");
        System.out.print("İşlemde kaç sayıdan oluşmasını istiyorsunuz : ");
        index = input.nextInt();

        int[] sayılar = new int[index];

        for (int i = 0; i < sayılar.length; i++) {
            System.out.print((i+1)+". sayıyı giriniz : ");
            sayılar[i]=input.nextInt();
        }

        Arrays.sort(sayılar);

        System.out.println("============================");
        System.out.print(Arrays.toString(sayılar));
    }
    
}