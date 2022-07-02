import java.util.Scanner;

public class VucüdKitleIndeks {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        double  kilo , boy , vucüdIndeks;
        
        System.out.print("Kilonuzu Giriniz : ");
        kilo = input.nextDouble();

        System.out.print("Boyunuzu Giriniz : ");
        boy = input.nextDouble();

        vucüdIndeks = (boy*boy)/kilo;

        System.out.print("Vucüd İndeks : "+vucüdIndeks);
    }
}
/*Kilo (kg) / Boy(m) * Boy(m) */