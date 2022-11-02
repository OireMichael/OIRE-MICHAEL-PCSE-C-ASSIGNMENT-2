namespace ASSIGNMENT2

//**********************       OIRE MICHAEL SEM2 PCSE. C# TEST ASSIGNMENT 2       ************
{
    public delegate void StudentDetails(string message);

    internal class Program
    {
        
        public String studentAddress { get; set; }
        public int studentId { get; set; }
        public string studentName { get; set; }


        public String StudentAddress
        {
            get
            {
                return studentAddress;
            }
            set
            {
                studentAddress = value;
            }
        }
        static void Main(string[] args)
        {

            //******************************QUESTION 1 ************
            Console.WriteLine("\t\t QUESTION 1 \n");
            

            StudentDetails del = new StudentDetails(getStudentName);
            string Name = "MICHAEL OIRE";
            del(Name);

            StudentDetails del1 = new StudentDetails(getStudentId);
            int Id = 101;
            string strid =Convert.ToString(Id);
            del1(strid);


            //******************************QUESTION 2 ************

            Console.WriteLine("\t\t QUESTION 2 \n");

            Program objAddress = new Program();
            objAddress.studentAddress = "Soroti City East, Otatai Ward Owollo Village";
            string Address = objAddress.studentAddress;
            Console.WriteLine("My Address is: " + Address);



            Program student = new Program()
            { 
            studentId = Id,
            studentName = Name,
            studentAddress = Address
            };

            //*****************************  QUESTION 3 ***************
            Console.WriteLine("\t\t QUESTION 3 \n");

            Dictionary<int, Program> dictionaryProgram = new Dictionary<int, Program>();
            dictionaryProgram.Add(student.studentId,student);

            Program student1o1 = dictionaryProgram[Id];
            Console.WriteLine("Student Id = {0}, Student Name = {1}, Student Address = {2},",
                student1o1.studentId, student1o1.studentName, student1o1.studentAddress);
        }
        static void getStudentName(string stName)
        {
            Console.WriteLine("My Name is: "+ stName);
        }
        static void getStudentId(string stId)
        {
  
            Console.WriteLine("My id Number is: "+ stId);
        }
    }
}