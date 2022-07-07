import java.util.Scanner;

public class ATM {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int value,bakiye=2000,yatirma,cekmek,right = 2;
        String kullanıcıAdı ,sifre;

        while (right>0) {
        System.out.print("Kullanıcı Girişi : ");
        kullanıcıAdı = input.nextLine();
        System.out.print("Parola Girişi : ");
        sifre=input.nextLine();

        if(kullanıcıAdı.equals("okanmerttan")&& sifre.equals("1234")){
            System.out.print("ATM Sistemine Hoşgeldiniz");

            do {
                System.out.println(
                "1-Para yatırma\n"
                +"2-Para Çekme\n"
                +"3-Bakiye Sorgula\n"
                +"4-Çıkış Yap"
                +"Hangi işlemin yapmak istiyorsanız tuşlayonuz : ");
                value = input.nextInt();
        
                switch (value) {
                    case 1:
                        System.out.print("Ne kadar para yatırmak istiyorsunuz : ");
                        yatirma = input.nextInt();
                        bakiye+=yatirma;
                        break;
                    case 2:
                        System.out.print("Ne kadar para çekmek istiyorsunuz : ");
                        cekmek = input.nextInt();
                        bakiye-=cekmek;
                        break;
                    case 3 : 
                        System.out.println("Bakiyenizdeki toplam para : "+bakiye);
                        break;
                }
                } while (4!=value);

        }else{
            right--;
            System.out.println("Hatalı kullanıcı adı veya şifre. Tekrar deneyiniz.");
                if (right == 0) {
                    System.out.println("Hesabınız bloke olmuştur lütfen banka ile iletişime geçiniz.");
                } else {
                    System.out.println("Kalan Hakkınız : " + right);
                }

            }  
        }
    }
}