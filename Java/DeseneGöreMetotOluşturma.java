import java.util.ArrayList;
import java.util.Scanner;

public class DeseneGöreMetotOluşturma {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int sayı;

        System.out.print("Sayı Giriniz : ");
        sayı = input.nextInt();
        Islem(sayı);
        
    }
    private static void Islem(int sayı)
    {
        int[] azalansayı = new int[(sayı/5)+1];
        int deger1 = -1; 
        for (int i = sayı; i>=0; i-=5) {
            deger1++;
            azalansayı[deger1]=i;
        }
        
        int artanBaşlangıcı=azalansayı[deger1];

        int[] artansayı = new int[(sayı/5)+1];
        int deger2=-1;
        for (int i = artanBaşlangıcı; i <=sayı; i+=5) {
            deger2++;
            artansayı[deger2]=i;
        }
        System.out.println("===============================");
        System.out.println("---Azalan Hali---");
        for (int i : azalansayı) {
            System.out.println(i);
        }
        System.out.println("===============================");
        System.out.println("---Artan Hali---");
        for (int i : artansayı) {
            System.out.println(i);
        }



    }
}