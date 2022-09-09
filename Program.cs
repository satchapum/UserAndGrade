public class Program {
    public static string InputName() {
        Console.Write("Please Input your Name :");

        return Console.ReadLine();
    }

    public static string InputSurname() {
        Console.Write("Please Input your Surname :");

        return Console.ReadLine();
    }

    public static string InputNumberID() {
        Console.Write("Please Input your ID :");

        return Console.ReadLine();
    }

    public static float InputGrade() {
        Console.Write("Please Input your Grade :");

        return float.Parse(Console.ReadLine());
    }
    
    public static void Main(string[] args) {
        User[] UserInfo = new User[8]; 
        int UserRunNumber = 0;

        while(UserRunNumber < 8) {
            string Name = InputName(UserRunNumber);
            string Surname = InputSurname(UserRunNumber);
            string NumberID = InputNumberID(UserRunNumber);
            float Grade = InputGrade(UserRunNumber);
            UserInfo[UserRunNumber] = new User(Name, Surname, NumberID, Grade);
            UserRunNumber++;
        }

    }
}