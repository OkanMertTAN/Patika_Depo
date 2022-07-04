import java.util.Scanner;

public class GirilenSayıyaKadarOlanÇiftSayılarıBulanProgram {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("Girmiş olduğunuz x sayısını, 0'dan başlayarak x sayısına kadar 3 ve 4 tam bölme sistemi ....");
        System.out.print("Sayıyı Giriniz : ");
        float sayı,üçebölensayı=0,dörtebölensayılar=0,ücmodun = 0,dörtmodun = 0,j= 0,k= 0;
        sayı = input.nextFloat();
        
        for (int i = 1; i <= sayı; i++) {
            if(i%3==0){
                j++;
                üçebölensayı += i;
            }
            if(i%4==0){
                k++;
                dörtebölensayılar += i;
            }
        }
        
        ücmodun = üçebölensayı/j;
        dörtmodun = dörtebölensayılar/k;
        System.out.println("----------------------");
        System.out.println("Dörte Bölünen Sayıların Modları : "+dörtmodun);
        System.out.println("Üçe Bölünen Sayıların Modları : "+ücmodun);
        System.out.println("-----------------------");
    }
}
