import java.util.Scanner;

public class UçakBiletiFiyatıHesaplama {
    public static void main(String[] args) {
        System.out.println("Uçak Bileti Fiyatı Hesaplama");
        Scanner input = new Scanner(System.in);
        int km ,yas,yön,fiyat,indirimlifiyat;
        int yenifiyat,cifyönlüyenifiyat,cifyönlüyeniindirimin;
        System.out.print("Mesafeniz kaç km  : ");
        km = input.nextInt();
        System.out.print("Kaç Yaşındasınız : ");
        yas = input.nextInt();
        System.out.print("Tek yön ise 1 , çif yön ise 2 tuşlayınız : ");
        yön = input.nextInt();

        fiyat = km*10/100;

        

        if(yön==1){
            if(yas>0 && yas<12){
                indirimlifiyat = fiyat*50/100;
                yenifiyat = fiyat-indirimlifiyat;
                System.out.print("Tek yönlü uçak biletiniz : "+yenifiyat);
            }else if(yas>12 && yas<24){
                indirimlifiyat = fiyat*10/100;
                yenifiyat = fiyat-indirimlifiyat;
                System.out.print("Tek yönlü uçak biletiniz : "+yenifiyat);
            }else if(yas>64){
                indirimlifiyat = fiyat*30/100;
                yenifiyat = fiyat-indirimlifiyat;
                System.out.print("Tek yönlü uçak biletiniz : "+yenifiyat);
            }
        }
        else if(yön==2){
            if(yas>0 && yas<12){
                indirimlifiyat = fiyat*50/100;
                yenifiyat = fiyat-indirimlifiyat;
                cifyönlüyeniindirimin = yenifiyat*20/100;
                cifyönlüyenifiyat = yenifiyat-cifyönlüyeniindirimin;
                System.out.print("Çift yönlü uçak biletiniz : "+cifyönlüyenifiyat);
                
            }else if(yas>12 && yas<24){
                indirimlifiyat = fiyat*10/100;
                yenifiyat = fiyat-indirimlifiyat;
                cifyönlüyeniindirimin = yenifiyat*20/100;
                cifyönlüyenifiyat = yenifiyat-cifyönlüyeniindirimin;
                System.out.print("Çift yönlü uçak biletiniz : "+cifyönlüyenifiyat);
                
            }else if(yas>64){
                indirimlifiyat = fiyat*30/100;
                yenifiyat = fiyat-indirimlifiyat;
                cifyönlüyeniindirimin = yenifiyat*20/100;
                cifyönlüyenifiyat = yenifiyat-cifyönlüyeniindirimin;
                System.out.print("Çift yönlü uçak biletiniz : "+cifyönlüyenifiyat);
            }
        }
        else
        {
            System.out.println("Lütfen Geçerli Değerlel Giriniz !!!!!!!!!!!!!");
        }
    }
}
