import java.util.Scanner;

public class GirilenSayıdanKüçük2KuvvetleriniBulanProgram {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int sayı;
        System.out.println("Girmiş olduğunuz x sayısını, 0'dan başlayarak x sayısına kadar 3 ve 4 tam bölme sistemi ....");
        System.out.print("Sayıyı Giriniz : ");
        sayı = input.nextInt();

        System.out.println("------------------------------");
        System.out.println("Dörtün Kuvvetleri : ");
        for (int i = 1; i <= sayı; i*=4) {
            System.out.print(i+",");
        }
        System.out.println("Beşin Kuvvetleri : ");
        for (int i = 1; i <= sayı; i*=5) {
            System.out.print(i+",");
        }
        System.out.println("------------------------------");

    }
}
