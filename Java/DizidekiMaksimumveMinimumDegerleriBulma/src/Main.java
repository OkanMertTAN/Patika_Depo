import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int[] dizi = {15, 12, 788, 1, -1, -778, 2, 0};

        System.out.println("Sayıyı Giriniz: ");

        int sayı = input.nextInt();
        int min =dizi[0];
        int max = dizi[0];

        Arrays.sort(dizi);
        //778,15,12,2,1,0,-1,-778
        for (int i:dizi) {
            if (i<sayı){
                min=i;
            }
            if (i>sayı){
                max=i;
                break;
            }
        }

        System.out.println(min);
        System.out.println(max);
    }


}
/*
Ödev
Dizideki elemanların girilen sayıdan küçük en yakın sayıyı ve en büyük en yakın sayıyı bulan programı yazınız.

Dizi : {15,12,788,1,-1,-778,2,0}
Girilen Sayı : 5
Girilen sayıdan küçük en yakın sayı : 2
Girilen sayıdan büyük en yakın sayı : 12
*/