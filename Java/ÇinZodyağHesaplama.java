import java.util.Scanner;

public class ÇinZodyağHesaplama {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("Çin Zodyağ Hesaplama");
        System.out.println();
        System.out.println("Çin Zodyağ nedir ? ");
        System.out.println("----------------------------------------------------------------------------------------------");
        System.out.println("4000 bin yıldır kullanılan bir astroloji çeşididir Çin astrolojisi ve insanları"
        + "12 değişik burç ve sembollerle tanımlar. Çin Zodyağı bu 12 burcun eşit aralıklarla(10 derece genişliğinde) sıralandığı bir" 
        + "hayvan halkasıdır ve yıldızlarla pek bir ilgisi yoktur.");
        System.out.println("Çin Zodyağ Ayları : Maymun, Horoz, Köpek, Domuz, Fare, Öküz, Kaplan, Tavşan, Ejderha, Yılan, At, Koyun");
        System.out.println("----------------------------------------------------------------------------------------------");
        System.out.print("Hangi yılda doğdunuz : ");
        int yıl ,bölme,carpma,sonuc;

        yıl  = input.nextInt();

        bölme = yıl/12;
        carpma = bölme*12;
        sonuc = yıl-carpma;

        if(sonuc==0){System.out.println("Burçunuz Maymun");}
        else if(sonuc==1){System.out.println("Burçunuz Horoz");}
        else if(sonuc==2){System.out.println("Burçunuz Köpek");}
        else if(sonuc==3){System.out.println("Burçunuz Domuz");}
        else if(sonuc==4){System.out.println("Burçunuz Fare");}
        else if(sonuc==5){System.out.println("Burçunuz Öküz");}
        else if(sonuc==6){System.out.println("Burçunuz Kaplan");}
        else if(sonuc==7){System.out.println("Burçunuz Tavşan");}
        else if(sonuc==8){System.out.println("Burçunuz Ejderha");}
        else if(sonuc==9){System.out.println("Burçunuz Yılan");}
        else if(sonuc==10){System.out.println("Burçunuz At");}
        else if(sonuc==11){System.out.println("Burçunuz Koyun");}
        else
        {
            System.out.println("Geçersiz değerlerden dolayı işlem yapılamadı.");
        }
    }
}
