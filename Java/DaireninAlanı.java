import java.util.Scanner;

public class DaireninAlanı {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        float yarıcap,merkezacı,alan;
        float pi = 3.14f;

        System.out.print("Dairenin Yarıçapı : ");
        yarıcap = input.nextFloat();

        System.out.print("Dairenin Merkez Açı  : ");
        merkezacı = input.nextFloat();

        alan = (pi*(yarıcap*yarıcap)*merkezacı)/360;
        System.out.print("Dairenin Alanı : "+alan);
    }
}