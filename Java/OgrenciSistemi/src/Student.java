public class Student {
    //Student(), addBulkExamNote(), isPass(), calcAvarage(), printNote()
    String name,stuNo,classes;
    Course mat;
    Course tde;
    double avarage;//Ortalama
    boolean isPass;//Geçme veya Kalma

    Student(String name,String stuNo,String classes,Course mat,Course tde){
        this.name=name;
        this.stuNo=stuNo;
        this.classes=classes;
        this.mat=mat;
        this.tde=tde;
    }
    public void addBulkExamNote(int mat,int tde){//Sınav Notları
        if(mat>=0||mat<=100){
            this.mat.note=mat;
        }
        if(tde>=0||tde<=100){
            this.tde.note=tde;
        }
    }
    public void calcAvarage(){//Not Ortalaması
        this.avarage=(this.mat.note+this.tde.note)/2;

    }
    public boolean isPass(){//Geçme Kalma
        calcAvarage();
        return this.avarage>55;
    }
    public void printNote(){//Görüntüleme
        System.out.println("=========================");
        System.out.println("Öğrenci : " + this.name);
        System.out.println("Matematik Notu : " + this.mat.note);
        System.out.println("Türk Dili ve Edebiyatı Notu : "+this.tde.note);
    }
}
