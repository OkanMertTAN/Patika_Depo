import java.util.ArrayList;
import java.util.Scanner;

public class TekSayılarınToplamınıBulanProgram {
    public static void main(String[] args) {
        System.out.println("Tek sayı girene kadar  çift ve 4'ün katları olan "+
        "sayıları toplayıp ekrana basan programı yazıyoruz");

        int sayaç=0,sayı,toplam=0;
        

        Scanner input = new Scanner(System.in);

        for (;;) {
            sayaç++;
            System.out.print(sayaç+". sayıyı giriniz : ");
            sayı = input.nextInt();
           
            if(sayı%2==0){
                 if(sayı%4==0 && sayı%2==0)
                {
                toplam+=sayı;
                }
            }else{
                break;
            }
        }
        System.out.println("========================");
        System.out.println("Sonuç:"+toplam);
        System.out.println("========================");
    }
}
