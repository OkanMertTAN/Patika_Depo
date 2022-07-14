
public class Course {
    Teacher teacher;
    String name;
    String code;
    String prefix;
    int note;

    Course(String name,String code ,String prefix){
        this.name=name;
        this.code=code;
        this.prefix=prefix;
    }
    public void checkTeacher(Teacher teacher){
        if(this.teacher.equals(teacher.branch)){
            this.teacher=teacher;
            System.out.println("İşlem Başarılı!");
        }else{
            System.out.println(teacher.name+"Akedemisyen bur dersi veremez.");
        }
    }
    public void printTeacher(){
        if (teacher != null) {
            System.out.println(this.name + " dersinin Akademisyeni : " + teacher.name);
        } else {
            System.out.println(this.name + " dersine Akademisyen atanmamıştır.");
        }
    }

}
