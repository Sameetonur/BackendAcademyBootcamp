namespace Proje02;

class Program
{
    static void RandomStudents(string[] students)
    {
        Random rnd = new Random();
        int randomIndex;

        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length); //7
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }

    }
    static void AssingToTeams(string[] students, string[] teamName, double memberCount)
    {
        int teamCounter = 0;
        string currentteamName;
        for (int i = 0; i < students.Length; i += 4)
        {
            currentteamName = teamName[teamCounter];
            System.Console.WriteLine($" Takım Adı: {currentteamName} ");
            for (int j = 0; j < memberCount; j++)
            {
                Console.WriteLine($"\t\t- {students[i + j]}");
            }
            System.Console.WriteLine();
        }
    }
    static string[] GetStudents()
    {
        string[] result ={
            "Hakan Çakdı",
            "Tunacan Eşki",
            "Rojin Çetiz",
            "Elif Öztürk",
            "Ömer Taştekin",
            "Enes Kılıçaslan",
            "Atlas Uyar",
            "Erdem Yüce Gül",
            "Enes Can Aydemir",
            "Irmak Özen",
            "Burhan Torun",
            "Miraç Katmer",
            "Bedirhan Çaylı",
            "Melina Balcı",
            "Merve Kahraman",
            "Kerem Can Kırpar",
            "Gizem Yüksel",
            "Celal Uğur koçan",
            "Tahir Bural Avar",
            "Samet Önür",
            "Alyna Çelen",
            "Elifnur Binci",
            "Doğukan Babayiğit",
            "Emre Kılıç"
        };
    }
    static string[] GetTeamNames()
    {
        return [
             "Debugger",
            "CodeWars",
            "Algorithmics",
            "BinaryCoders",
            "nullPointers",
            "DevDynamics"
        ];
    }

    static void Main(string[] args)
    {
        string[] students = GetStudents();
        string[] teams = GetTeamNames();

        double memberCount = 4;
        int teamcount = (int)Math.Ceiling(students.Length / memberCount);

        string[] teams = new string[teamcount];

        //students dizimizi karıştırıyoruz
        RandomStudents(students);
        //ref kullanarak yaparsak ne farkı olur ? !!! ÖDEVV !!!
        AssingToTeams(students, teams, 4);




    }
}
