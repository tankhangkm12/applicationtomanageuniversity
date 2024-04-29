namespace UniversityManager
{

    // class University 
    class University
    {
        public static int countuniversity = 0;
        public University(string name, ref Contact contact, string describe, int year)
        {
            this.name = name;
            this.contact = contact;
            this.description = describe;
            this.yearestable = year;
        }
        // property of university
        private string name;
        private string description;
        private List<Student> students = new List<Student>();
        private Majormanage majormanage;
        private int yearestable;
        private Contact contact = new Contact();


        //method of university

        //setter of university
        public Majormanage getmajormanage()
        {
            return majormanage;
        }
        public Contact getcontact() { return contact; }
        public void setname(string n)
        {
            this.name = n;
        }

        public void setdescription(string d)
        {
            this.description = d;

        }
        public void setyearestable(int year)
        {
            this.yearestable = year;
        }

        //getter of university
        public string getName() { return name; }
        public string getDescription() { return description; }
        public int getyearestable() { return yearestable; }

        //total student
        public List<Student> GetListStudent() { return students; }

        //add student
        public void addStudent(Student student)
        {
            students.Add(student);
        }

        // remove student
        public void removeStudent(Student student)
        {
            students.Remove(student);
        }

        //find student 
        public void findStudent(string name)
        {

        }

        public void findStudent(int id)
        {

        }

        //public show all infor student
        public void showallStudnet()
        {

        }
        //find student 
        public void findMajor(string name)
        {

        }

        public void findMajor(int id)
        {

        }

        //public show all infor student
        public void showallMajor()
        {

        }


    }

    //class contact
    class Contact
    {
        public Contact() { }
        public Contact(string address, string numberphone, string email, string website)
        {
            this.address = address;
            this.phonenumber = numberphone;
            this.email = email;
            this.website = website;
        }
        private string address, email, phonenumber, website;

        public void setandress(string andress)
        {
            this.address = andress;
        }
        public void setemail(string email)
        {
            this.email = email;
        }

        public void setphonenumber(string phone)
        {
            this.phonenumber = phone;
        }

        public void setwebsite(string web)
        {
            this.website = web;
        }
        public string getandress()
        {
            return this.address;
        }
        public string getemail()
        {
            return this.email;
        }

        public string getphonenumber()
        {
            return this.phonenumber;
        }

        public string getwebsite()
        {
            return this.website;
        }
    }

    // class Student

    public class BirthdayOfStudent
    {
        private int date, month, year;
        private string birthday;

        public void setbirthday()
        {
            System.Console.Write("Enter day of birth: ");
            string date = System.Console.ReadLine();

            System.Console.Write("Enter month of birth: ");
            string month = System.Console.ReadLine();

            System.Console.Write("Enter day of birth: ");
            string year = System.Console.ReadLine();

            birthday = $"{date}/{month}/{year}";
        }

        public string getbirthday() => birthday;

        public int getyear() => year;
    }

    class Student
    {
        public static int countstudent;
        //construction function
        public Student()
        {

        }
        public Student(string name, int age, BirthdayOfStudent birthday, Physical physical, Major major)
        {
            this.name = name;
            this.age = age;
            this.birthday = birthday.getbirthday();
            this.physical = physical;
            this.major = major.getname();


            studentnumbercode = createStudentnumbercode();
            countstudent++;
        }

        //properties of student

        private string name;
        private int age;
        private string birthday;
        private string studentnumbercode;
        private Physical physical;
        private static List<Subject> subjects = new List<Subject>();
        private string major;
        private double average = Average();

        public string createStudentnumbercode()
        {
            Random random = new Random();
            Major major = new Major();
            Majormanage majormanage = new Majormanage();
            string index1 = Convert.ToString(DateTime.Now.Year);
            string index2 = Convert.ToString(random.Next(1, majormanage.gettotalstudentofmajor(major)));
            string index3 = major.getmajorID();
            return studentnumbercode = "T" + index1 + index2 + index3;

        }
        // 
        public static double Average()
        {
            double s = 0;
            for (int i = 0; i < subjects.Count(); i++)
            {
                s += subjects[i].getScore();
            }
            return s;
        }

        public void setname(string n) { this.name = n; }
        public string getname() { return name; }
        //getter and setter
        public string getstudentnumbercode()
        {
            return studentnumbercode;
        }

    }

    //class score of student
    class Score
    {
        Subject subject;

    }

    //class subject
    class Subject
    {

        private string name;
        private double score;
        private string describe;
        private List<Teacher> teacherofsubject = new List<Teacher>();
        private Credit credit;


        //method

        public List<Teacher> GetTeaches() { return teacherofsubject; }
        public Credit getcredit() { return credit; }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname() { return name; }

        public void setdescribe(string describe)
        {
            this.describe = describe;
        }
        public string getdescribe()
        {
            return describe;
        }
        public double getScore()
        {
            double attendance_point, exercise_point, practice_point, midterm_point, final_point;
            int point_tranning;
            do
            {
                string creditinput = System.Console.ReadLine();
                double credit = Convert.ToDouble(creditinput);  // double credit=double.Parse(creditinput)
                if (credit >= 0 && credit <= 3)
                {
                    attendance_point = Convert.ToDouble(System.Console.ReadLine());
                    exercise_point = double.Parse(System.Console.ReadLine());
                    midterm_point = double.Parse(System.Console.ReadLine());
                    final_point = Convert.ToDouble(System.Console.ReadLine());
                    point_tranning = Convert.ToInt32(System.Console.ReadLine());

                    score = ((attendance_point + exercise_point) / 2) * 0.1 + midterm_point * 0.2 + final_point * 0.7;
                    break;
                }
                else if (credit > 3)
                {
                    attendance_point = Convert.ToDouble(System.Console.ReadLine());
                    exercise_point = double.Parse(System.Console.ReadLine());
                    practice_point = double.Parse(System.Console.ReadLine());
                    midterm_point = double.Parse(System.Console.ReadLine());
                    final_point = Convert.ToDouble(System.Console.ReadLine());
                    point_tranning = Convert.ToInt32(System.Console.ReadLine());

                    if (credit < 7)
                    {
                        score = ((attendance_point + exercise_point + practice_point) / 3) * 0.1 + midterm_point * 0.2 + final_point * 0.7;

                    }
                    else
                    {
                        score = ((attendance_point + exercise_point * 2 + practice_point) / 4) * 0.1 + midterm_point * 0.2 + final_point * 0.7;

                    }
                    break;
                }
                else
                {
                    System.Console.WriteLine("Had error! Please entered again!");
                }
            }
            while (true);


            return score;
        }



    }
    // class credit to sign subject
    class Credit
    {

    }


    //class physical of student
    class Physical
    {
        public Physical(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }
        private double height, weight;

        // method
        // getter and setter
        public void setheight(double h)
        {

        }
        public double getheight()
        {
            return height;
        }

        public void setweight(double h)
        {

        }
        public double getweight()
        {
            return weight;
        }
    }

    class Major
    {
        public Major() { }
        public Major(string n, string des, string id)
        {
            this.name = n;
            this.decribe = des;
            this.majorID = id;
        }
        public Major(string name, string id)
        {
            this.name = name;
            this.majorID = id;
        }
        private string name, decribe, majorID;
        private List<Student> studentofmajor = new List<Student>();


        public void setname(string n) { this.name = n; }
        public string getname() { return name; }

        public void setdecribe(string d) { this.decribe = d; }
        public string getdecribe() { return decribe; }

        public void setmajorID(string id) { this.majorID = id; }
        public string getmajorID() { return majorID; }

        public List<Student> getstudentofmajor()
        {
            return studentofmajor;
        }
    }

    class Majormanage
    {
        public Majormanage()
        {
            majorlist = new List<Major>();
        }
        private Major major;
        private List<Major> majorlist = new List<Major>();



        public void addmajor(Major major)
        {
            majorlist.Add(major);
        }
        //method get total student of major
        public int gettotalstudentofmajor(Major m)
        {
            foreach (Major major in majorlist)
            {
                if (major == m)
                {
                    return major.getstudentofmajor().Count();
                }
            }
            return 1;
        }

        //method add stduent to major
        public void addStudenttomajor(Student student) { major.getstudentofmajor().Add(student); }

        //method remove student from major
        public void removeStudentfrommajor(Student student) { major.getstudentofmajor().Remove(student); }

        //show all major
        public void showAllMajor() { foreach (Major major in majorlist) { System.Console.WriteLine("name: " + major.getname() + "\n"); System.Console.WriteLine("ID: " + major.getmajorID() + "\n"); } }

        public void showstudentsofmajor()
        {
            System.Console.Write("Enter major that you want search infomation about student here: ");
            string search = System.Console.ReadLine();
            string question;
            do
            {
                foreach (Major major in majorlist)
                {
                    if (major.getname().Contains(search))
                    {
                        foreach (Student student in major.getstudentofmajor()) { System.Console.WriteLine("name: " + student.getname() + "\n"); System.Console.WriteLine("studentnumbercode: " + student.getstudentnumbercode() + "\n"); System.Console.WriteLine(); }
                    }
                    else
                    {
                        System.Console.WriteLine("Not Found " + search + "!");
                    }
                }
                while (true)
                {
                    System.Console.Write("Do you want to continue? (y/n)) ");
                    question = System.Console.ReadLine().ToLower();
                    if (question == "y" || question == "no") { break; }
                    else { System.Console.WriteLine("Please entered y/n !"); }

                }
            }
            while (question == "y");

        }
    }

    class Teacher
    {


    }
    class Operation
    {
        Majormanage majormanage = new Majormanage();
        Subject subject = new Subject();
        // create university
        public University createUniversity()
        {
            System.Console.Write("Enter name of university: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Enter year established here: ");
            int year = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter address of university: ");
            //get info contact
            string address = System.Console.ReadLine();
            System.Console.Write("Enter phone number of university: ");
            string numberphone = System.Console.ReadLine();
            System.Console.Write("Enter email of university: ");
            string email = System.Console.ReadLine();
            System.Console.Write("Enter website of university: ");
            string website = System.Console.ReadLine();
            System.Console.Write("Enter description of university: ");
            string describe = System.Console.ReadLine();

            Contact contact = new Contact(address, numberphone, email, website);
            University university = new University(name, ref contact, describe, year);
            return university;
        }



        public void addmajor()
        {
            string q;
            do
            {
                // create major 
                System.Console.Write("Enter major name here: ");
                string name = System.Console.ReadLine();
                System.Console.Write("Enter decribe of major here: ");
                string describe = System.Console.ReadLine();
                System.Console.Write("Enter major id here: ");
                string id = System.Console.ReadLine();
                Major major = new Major(name, describe, id);
                majormanage.addmajor(major);
                System.Console.Write("Do you want to continue? (y/n)) ");
                q = System.Console.ReadLine().ToLower();
            }
            while (q == "y");
        }
        public void addsubject()
        {
            string q;
            do
            {
                // create major 
                System.Console.Write("Enter subject name here: ");
                subject.setname(System.Console.ReadLine());
                System.Console.Write("Enter description of subject here: ");
                subject.setdescribe(System.Console.ReadLine());




                System.Console.Write("Do you want to continue? (y/n)) ");
                q = System.Console.ReadLine().ToLower();
            }
            while (q == "y");
        }

        public void addstudent(University uni)
        {
                // input name ,age
                System.Console.Write("Enter name of student here: ");
                string name = System.Console.ReadLine();
                System.Console.Write("Enter age of student here: ");
                int age = Convert.ToInt32(System.Console.ReadLine());
                //input  birthday
                BirthdayOfStudent birthdayofstudent = new BirthdayOfStudent();
                System.Console.WriteLine("Enter birthayday of student here: ");
                birthdayofstudent.setbirthday();
                // input major of student
                System.Console.Write("Get major of student here: ");
                string namemajor = System.Console.ReadLine();
                System.Console.Write("Enter ID of Major here: ");
                string majorid = System.Console.ReadLine();
                //input physical of student
                System.Console.Write("Get height of student here: ");
                double height = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Enter weight of student here: ");
                double weight = Convert.ToDouble(System.Console.ReadLine());

                //create of object of property of student
                Physical physical = new Physical(height, weight);
                Major major = new Major(namemajor, majorid);
                Student student = new Student(name, age, birthdayofstudent, physical, major);
                uni.addStudent(student);
        }

        
        public void Showinfouni(ref University uni)
        {
            System.Console.WriteLine("University " + uni.getName() + " is established in "+uni.getyearestable()+"."+uni.getDescription());
            System.Console.WriteLine($"-contact:\n   +address: {uni.getcontact().getandress()}\n    +phone number: {uni.getcontact().getphonenumber()}\n    +email: {uni.getcontact().getemail()}\n    +website: {uni.getcontact().getwebsite()}\n");
            System.Console.WriteLine($"have total {uni.GetListStudent().Count()} student: ");
            foreach (Student student in uni.GetListStudent())
            {
                System.Console.WriteLine($"   +{student.getname()}\n   +Student number code: {student.getstudentnumbercode()}");
            }

        }
    }
    class Proggram
    {
        public static void Main(string[] arggs)
        {
            Operation op = new Operation();
            University uni = op.createUniversity();
            //op.addsubject();
            //op.addmajor();
            op.addstudent(uni);
            op.Showinfouni(ref uni);

        }
    }
}



