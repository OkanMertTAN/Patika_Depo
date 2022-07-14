
public class Main {
    public static void main(String[] args) {
        
        Teacher t1 = new Teacher("Okan Mert TAN", "90000000", "MAT");
        Teacher t2 = new Teacher("Buse Güneş", "9000001", "TDE");

        Course mat = new Course("Matematik", "MAT101", "MAT");
        Course tde = new Course("Türk Dili ve Edebiyati", "TDE101", "TDE");

        mat.checkTeacher(t1);
        tde.checkTeacher(t2);

        Student st1 = new Student("Osman Gazi", "565", "185432565", mat, tde);
        st1.addBulkExamNote(90, 70);
        st1.isPass();
    }
}