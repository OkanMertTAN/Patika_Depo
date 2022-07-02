import java.util.Scanner;

class Program 
{
    public static void main(String[] args) {
        System.out.println("Karne Ortalaması Hesaplaması");

        Scanner input = new Scanner(System.in);
        int matematikNotu , türkçeNotu , fizikNotu , kimyaNotu , karneOrt ;

        System.out.println("Matematik Notunuz : ");
        matematikNotu = input.nextInt();

        System.out.println("Türkçe Notunuz : ");
        türkçeNotu = input.nextInt();

        System.out.println("Fizik Notunuz : ");
        fizikNotu = input.nextInt();

        System.out.println("Kimya Notunuz : ");
        kimyaNotu = input.nextInt();

        karneOrt = (matematikNotu+türkçeNotu+fizikNotu+kimyaNotu)/4;

        System.out.println("Karne Ortalaması : "+ karneOrt);
    }
}