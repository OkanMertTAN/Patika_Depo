import java.util.Scanner;

public class HesapMakinesi {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        float deger1 , deger2 , select;

        System.out.println("Hesap Makinesi");
        System.out.println("-------------");
        System.out.println("Toplama için 1 'i ,");
        System.out.println("Çıkartma için 2 'yi ,");
        System.out.println("Çarpma için 3 'ü ,");
        System.out.println("Bölme için 4 'tü ,");
        System.out.println("-------------");
        System.out.print("İstediğini İşlem İçin Tuşlayınız : ");
        select = input.nextFloat();

        System.out.print("İlk Sayıyı Giriniz : ");
        deger1 = input.nextFloat();
        System.out.print("İkinic Sayıyı Giriniz : ");
        deger2 = input.nextFloat();

        

        float toplam,cıkartma,carpma,bölme;

        if(select==1){
            toplam = deger1+deger2;
            System.out.println("Toplamanın Sonucu : "+toplam);
        }
        else if(select==2){
            if(deger1>deger2)
            {
                cıkartma = deger1-deger2;
            }
            else
            {
                cıkartma = deger2-deger1;
            }
            System.out.println("Çıkartma İşlemin Sonucu : "+cıkartma);
        }
        else if(select==3)
        {
            carpma = deger1*deger2;
            System.out.println("Çarpma İşlemi Sonucu : "+carpma);
        }
        else if(select==4)
        {
            bölme = deger1/deger2;
            
            System.out.println("Bölme İşlemi Sonucu : "+bölme);
        }
        System.out.println("İşlem Bitti.");

    }
}
