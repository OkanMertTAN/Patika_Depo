import java.util.Scanner;

public class ÜsHesabi {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Üst Hesabı Sistemi");
        for ( ; ;) {
            System.out.print("Taban Giriniz : ");
            int taban = input.nextInt();
            System.out.print("Üst Giriniz : ");
            int üst = input.nextInt();
            int üstlüDeger = ÜsAlma(taban, üst);
            System.out.println("========================");
            System.out.println("Sonuc : "+üstlüDeger);
            System.out.println("========================");
        }        
    }
    public static int ÜsAlma(int taban,int üst){
        int üslüDeger = 1;
        for (int i = 1; i <=üst; i++) {
            üslüDeger*=taban;
        }
        return üslüDeger;
    }
}