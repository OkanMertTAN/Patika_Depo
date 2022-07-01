import java.util.Scanner;

public class UcgenAlanHesaplama {
    public static void main(String[] args) {
        System.out.println("Ucgen Alan Hesaplama");

        float kenar1,kenar2,taban,u;
        float alan,cevresi,yükseklik;
        Scanner input = new Scanner(System.in);

        System.out.println("Birinci Kenarın Uzunluğu Girirniz : ");
        kenar1 = input.nextFloat();
        System.out.println("İkinci Kenarın Uzunluğu Girirniz : ");
        kenar2 = input.nextFloat();
        System.out.println("Tabanı Kenarın Uzunluğu Girirniz : ");
        taban = input.nextFloat();
        System.out.println("Yüksekliğini Giriniz : ");
        yükseklik = input.nextFloat();

        u = (kenar1+kenar2+taban)/2;
        cevresi = u*2;
        alan = (taban*yükseklik)/2;
        
        System.out.println("Üçgenin Alanı : "+alan);
        System.out.print("Üçgenin Çevresi : "+cevresi);
    }
}