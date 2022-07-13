import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);

        String ad;
        int calısmaSaati,yil;
        double maas;

        System.out.print("Adınızı giriniz : ");
        ad=input.nextLine();

        System.out.print("Çalışma saatinizi giriniz : ");
        calısmaSaati = input.nextInt();

        System.out.print("İşe başladığınız yılı giriniz : ");
        yil = input.nextInt();

        System.out.print("Maaşınızı giriniz : ");
        maas=input.nextDouble();

        Employee isci1 = new Employee(ad, maas,calısmaSaati, yil);
        isci1.raiseSalary(isci1.maas, isci1.yil);
        isci1.tax(isci1.maas);
        isci1.bonus(isci1.maas);
        isci1.roString();
    }
    
}
