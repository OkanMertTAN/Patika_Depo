import java.util.Scanner;

public class ManavKasası {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        float armut = 2.14f; 
        float elma = 3.67f;
        float domates = 1.11f;
        float muz = 0.95f;
        float patlıcan = 5;

        float armutKilo,elmaKilo,domatesKilo,muzKilo,patlıcanKilo;
        float armutFiyat,elmaFiyat,domatesFiyat,muzFiyat,patlıcanFiyat;

        System.out.println("--- Manaz Kasası ---");

        System.out.print("Armuttan Kaç Kilo : ");
        armutKilo = input.nextFloat();

        System.out.print("Elmadan Kaç Kilo : ");
        elmaKilo = input.nextFloat();

        System.out.print("Domatesten Kaç Kilo : ");
        domatesKilo = input.nextFloat();

        System.out.print("Muztan Kaç Kilo : ");
        muzKilo = input.nextFloat();

        System.out.print("Patlıcan Kaç Kilo : ");
        patlıcanKilo = input.nextFloat();

        System.out.println("-----------------------------");

        armutFiyat = armut*armutKilo;
        System.out.println("Armutun Fiyatı : "+armutFiyat);

        elmaFiyat = elma*elmaKilo;
        System.out.println("Elmanın Fiyatı : "+elmaFiyat);

        domatesFiyat = domates*domatesKilo;
        System.out.println("Domates Fiyatı : "+domatesFiyat);

        muzFiyat = muz*muzKilo;
        System.out.println("Muz Fiyatı : "+muzFiyat);

        patlıcanFiyat = patlıcan*patlıcanKilo;
        System.out.println("Patlıcan Fiyatı : "+patlıcanFiyat);

        System.out.println("-----------------------------");
    }
}
/*Armut : 2,14 TL
Elma : 3,67 TL
Domates : 1,11 TL
Muz: 0,95 TL
Patlıcan : 5,00 TL */