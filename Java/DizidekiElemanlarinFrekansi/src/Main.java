import java.lang.reflect.Array;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {

        int[] dizi = {10, 20, 20, 10, 10, 20, 5, 20,100,25};
        int[] tekrarEdilenSayılar = new int[dizi.length];

        Arrays.sort(dizi);
        int[] tekrar=new int[tekrarEdilenSayılar.length];
        int sayac=0;
        int sifirKontrol=0;
        int n=1;
        Arrays.sort(dizi);
        
        for (int i = 0; i < dizi.length; i++) {
            if(dizi[i]!=sifirKontrol){
                for (int j = 0; j < dizi.length; j++) {

                    if((i!=j)&&dizi[i]==dizi[j]){
                        n++;
                        sayac=dizi[i];
                        
                    }
                    System.out.println(dizi[i]+" sayısı " + n + " kere tekrar edildi.");
	                n=1;
                }
            }
            
        }
       
        
        
    }
}
/*
 * Java dilinde, dizideki elemanların kaç kez tekrar edildiğini yani frekanslarını bulan programı yazınız.
 Dizi : [10, 20, 20, 10, 10, 20, 5, 20]
Tekrar Sayıları
10 sayısı 3 kere tekrar edildi.
20 sayısı 4 kere tekrar edildi.
5 sayısı 1 kere tekrar edildi.
 */