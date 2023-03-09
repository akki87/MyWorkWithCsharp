using System.Collections.Concurrent;

namespace ConcurrentApplication
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string dob { get; set; }
        public string emailID { get; set; }

        public Employee(int? Id, string? FirstName, string? LastName, int? dob, string? emailID)
        {
            Id = Id;
            FirstName = FirstName;
            LastName = LastName;
            dob = dob;
            emailID = emailID;

        }
        public Employee() { }

    }
    public class Records
    {
        #region EmployeeQueue
        static List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 2, FirstName = "Elizabeth", LastName = "Alford", dob = "1982-01-13", emailID = "EAlford@freelook.com" },
                new Employee() { Id = 3, FirstName = "Johnathan", LastName = "Nichols", dob = "1946-07-11", emailID = "JNichols@freecloud.com" },
                new Employee() { Id = 1, FirstName = "Thomas", LastName = "Morin", dob = "1961-04-16", emailID = "Thomas.Morin@lol.com" },
                new Employee() { Id = 4, FirstName = "Jeffery", LastName = "Gourlay", dob = "1955-02-02", emailID = "Jeffery.Gourlay@freecloud.com" },
                new Employee() { Id = 5, FirstName = "Fred", LastName = "Sullivan", dob = "1968-10-07", emailID = "FSullivan@freecloud.com" },
                new Employee() { Id = 6, FirstName = "Jimmy", LastName = "Fortune", dob = "1970-04-03", emailID = "Jimmy.Fortune@freelook.com" },
                new Employee() { Id = 7, FirstName = "Ken", LastName = "Fitton", dob = "1963-08-22", emailID = "Ken.Fitton@lol.com" },
                new Employee() { Id = 8, FirstName = "Adrian", LastName = "Sipes", dob = "1976-04-07", emailID = "Adrian.Sipes@happymail.com" },
                new Employee() { Id = 9, FirstName = "Andrew", LastName = "Moise", dob = "1974-07-27", emailID = "Andrew.Moise@goodmail.com" },
                new Employee() { Id = 10, FirstName = "Fred", LastName = "Jordan", dob = "1989-04-04", emailID = "Fred.Jordan@freelook.com" },

                new Employee() { Id = 11, FirstName = "Teresa", LastName = "Renschler", dob = "1951-11-23", emailID = "TRenschler@goodmail.com" },
                new Employee() { Id = 12, FirstName = "Ruth", LastName = "Marley", dob = "1979-04-26", emailID = "RMarley@freelook.com" },
                new Employee() { Id = 13, FirstName = "Joseph", LastName = "Gregory", dob = "1985-10-24", emailID = "JGregory@goodmail.com" },
                new Employee() { Id = 14, FirstName = "Elias", LastName = "Donovan", dob = "1966-03-18", emailID = "Elias.Donovan@goodmail.com" },
                new Employee() { Id = 15, FirstName = "Louise", LastName = "Mcconnaughey", dob = "1959-01-11", emailID = "Louise.Mcconnaughey@lol.com" },
                new Employee() { Id = 16, FirstName = "Laurie", LastName = "Casa", dob = "1971-08-06", emailID = "LCasa@goodmail.com" },
                new Employee() { Id = 17, FirstName = "Chase", LastName = "Poutre", dob = "1945-08-25", emailID = "CPoutre@snowmail.com" },
                new Employee() { Id = 18, FirstName = "John", LastName = "Osmer", dob = "1955-06-16", emailID = "JOsmer@happymail.com" },
                new Employee() { Id = 19, FirstName = "Gilberto", LastName = "Ramirez", dob = "1963-07-05", emailID = "GRamirez@lol.com" },
                new Employee() { Id = 20, FirstName = "John", LastName = "Hopkins", dob = "1988-08-19", emailID = "JHopkins@happymail.com" },

                new Employee() { Id = 21, FirstName = "Rachel", LastName = "Celestine", dob = "1991-02-12", emailID = "Rachel.Celestine@freelook.com" },
                new Employee() { Id = 22, FirstName = "Karen", LastName = "James", dob = "1976-09-07", emailID = "KJames@freelook.com" },
                new Employee() { Id = 23, FirstName = "Agustin", LastName = "Braun", dob = "1977-07-14", emailID = "ABraun@lol.com" },
                new Employee() { Id = 24, FirstName = "Eric", LastName = "Metzger", dob = "1969-09-25", emailID = "EMetzger@freelook.com" },
                new Employee() { Id = 25, FirstName = "Lynn", LastName = "Abbruzzese", dob = "1990-08-26", emailID = "Lynn.Abbruzzese@goodmail.com" },
                new Employee() { Id = 26, FirstName = "Julia", LastName = "Mcelfresh", dob = "1981-05-06", emailID = "JMcelfresh@goodmail.com" },
                new Employee() { Id = 27, FirstName = "Patricia", LastName = "Banks", dob = "1988-02-27", emailID = "Patricia.Banks@goodmail.com" },
                new Employee() { Id = 28, FirstName = "Joan", LastName = "Ezell", dob = "1972-02-02", emailID = "JEzell@snowmail.com" },
                new Employee() { Id = 29, FirstName = "Herbert", LastName = "Willibrand", dob = "1974-06-17", emailID = "Herbert.Willibrand@happymail.com" },
                new Employee() { Id = 30, FirstName = "William", LastName = "Valdivia", dob = "1968-04-11", emailID = "WValdivia@lol.com" },

                new Employee() { Id = 31, FirstName = "Joseph", LastName = "Ternes", dob = "1958-01-21", emailID = "Joseph.Ternes@freecloud.com" },
                new Employee() { Id = 32, FirstName = "Dana", LastName = "Wynn", dob = "1967-11-17", emailID = "DWynn@freecloud.com" },
                new Employee() { Id = 33, FirstName = "Theresa", LastName = "Loy", dob = "1972-09-20", emailID = "TLoy@freelook.com" },
                new Employee() { Id = 34, FirstName = "Patricia", LastName = "Bruns", dob = "1965-01-13", emailID = "Patricia.Bruns@snowmail.com" },
                new Employee() { Id = 35, FirstName = "Eddie", LastName = "Cerbone", dob = "1946-01-14", emailID = "ECerbone@goodmail.com" },
                new Employee() { Id = 36, FirstName = "Cecilia", LastName = "Koch", dob = "1973-10-26", emailID = "Cecilia.Koch@lol.com" },
                new Employee() { Id = 37, FirstName = "Christina", LastName = "Muniz", dob = "1986-01-15", emailID = "Christina.Muniz@freelook.com" },
                new Employee() { Id = 38, FirstName = "Edmund", LastName = "Montes", dob = "1951-01-27", emailID = "EMontes@happymail.com" },
                new Employee() { Id = 39, FirstName = "Esther", LastName = "Bradshaw", dob = "1975-03-11", emailID = "Esther.Bradshaw@happymail.com" },
                new Employee() { Id = 40, FirstName = "Diane", LastName = "Hamilton", dob = "1944-08-16", emailID = "DHamilton@happymail.com" },

                new Employee() { Id = 41, FirstName = "KAREN", LastName = "Kinikini", dob = "1961-11-14", emailID = "KAREN.Kinikini@goodmail.com" },
                new Employee() { Id = 42, FirstName = "Wayne", LastName = "Landry", dob = "1962-05-11", emailID = "Wayne.Landry@freecloud.com" },
                new Employee() { Id = 43, FirstName = "Ruth", LastName = "Jones", dob = "1981-06-23", emailID = "RJones@lol.com" },
                new Employee() { Id = 44, FirstName = "Albert", LastName = "Hall", dob = "1974-08-16", emailID = "Albert.Hall@freelook.com" },
                new Employee() { Id = 45, FirstName = "Melodie", LastName = "Duncan", dob = "1948-01-10", emailID = "Melodie.Duncan@lol.com" },
                new Employee() { Id = 46, FirstName = "Beverly", LastName = "Sharpe", dob = "1956-01-20", emailID = "BSharpe@freelook.com" },
                new Employee() { Id = 47, FirstName = "Alan", LastName = "Humphreys", dob = "1978-09-27", emailID = "AHumphreys@lol.com" },
                new Employee() { Id = 48, FirstName = "Amy", LastName = "Conner", dob = "1955-05-27", emailID = "Amy.Conner@snowmail.com" },
                new Employee() { Id = 49, FirstName = "Chris", LastName = "Bradsher", dob = "1981-02-07", emailID = "CBradsher@happymail.com" },
                new Employee() { Id = 50, FirstName = "Patsy", LastName = "Stringfellow", dob = "1959-10-26", emailID = "Patsy.Stringfellow@snowmail.com" },

                new Employee() { Id = 51, FirstName = "Melissa", LastName = "Choi", dob = "1983-08-21", emailID = "Melissa.Choi@happymail.com" },
                new Employee() { Id = 52, FirstName = "John", LastName = "Buckner", dob = "1990-04-07", emailID = "JBuckner@goodmail.com" },
                new Employee() { Id = 53, FirstName = "Heather", LastName = "Pettyjohn", dob = "1970-08-01", emailID = "HPettyjohn@snowmail.com" },
                new Employee() { Id = 54, FirstName = "Jacqueline", LastName = "Wechter", dob = "1957-03-13", emailID = "Jacqueline.Wechter@snowmail.com" },
                new Employee() { Id = 55, FirstName = "Walter", LastName = "Thomas", dob = "1989-06-24", emailID = "Walter.Thomas@freelook.com" },
                new Employee() { Id = 56, FirstName = "Robert", LastName = "Sanders", dob = "1961-04-27", emailID = "Robert.Sanders@freecloud.com" },
                new Employee() { Id = 57, FirstName = "Patricia", LastName = "Jacobsen", dob = "1962-06-15", emailID = "PJacobsen@freelook.com" },
                new Employee() { Id = 58, FirstName = "Sabrina", LastName = "Bernardo", dob = "1963-11-07", emailID = "Sabrina.Bernardo@goodmail.com" },
                new Employee() { Id = 59, FirstName = "Janette", LastName = "Longstaff", dob = "1977-10-13", emailID = "JLongstaff@lol.com" },
                new Employee() { Id = 60, FirstName = "Wilhelmina", LastName = "Lamour", dob = "1990-08-18", emailID = "Wilhelmina.Lamour@happymail.com" },

                new Employee() { Id = 61, FirstName = "Debra", LastName = "Levalley", dob = "1985-08-09", emailID = "DLevalley@freelook.com" },
                new Employee() { Id = 62, FirstName = "Inez", LastName = "Ford", dob = "1958-08-15", emailID = "Inez.Ford@freelook.com" },
                new Employee() { Id = 63, FirstName = "Jared", LastName = "Mason", dob = "1966-05-22", emailID = "Jared.Mason@snowmail.com" },
                new Employee() { Id = 64, FirstName = "Patrick", LastName = "Cheney", dob = "1963-08-12", emailID = "PCheney@freelook.com" },
                new Employee() { Id = 65, FirstName = "Krystal", LastName = "Burks", dob = "1962-02-15", emailID = "Krystal.Burks@happymail.com" },
                new Employee() { Id = 66, FirstName = "Freddie", LastName = "Fitzgerald", dob = "1957-06-01", emailID = "FFitzgerald@freelook.com" },
                new Employee() { Id = 67, FirstName = "Michelle", LastName = "Johnson", dob = "1970-02-13", emailID = "MJohnson@happymail.com" },
                new Employee() { Id = 68, FirstName = "Jeffrey", LastName = "Gignac", dob = "1944-11-24", emailID = "JGignac@happymail.com" },
                new Employee() { Id = 69, FirstName = "Richard", LastName = "Wise", dob = "1983-01-06", emailID = "RWise@freecloud.com" },
                new Employee() { Id = 70, FirstName = "June", LastName = "Chambers", dob = "1983-04-01", emailID = "June.Chambers@snowmail.com" },

                new Employee() { Id = 71, FirstName = "Brandon", LastName = "Maldonado", dob = "1965-03-23", emailID = "BMaldonado@freelook.com" },
                new Employee() { Id = 72, FirstName = "Amy", LastName = "Hunter", dob = "1960-07-10", emailID = "Amy.Hunter@freelook.com" },
                new Employee() { Id = 73, FirstName = "Brooke", LastName = "Kline", dob = "1981-11-11", emailID = "Brooke.Kline@lol.com" },
                new Employee() { Id = 74, FirstName = "Marie", LastName = "Kennedy", dob = "1989-03-18", emailID = "MKennedy@lol.com" },
                new Employee() { Id = 75, FirstName = "Ethel", LastName = "Pena", dob = "1967-09-12", emailID = "EPena@goodmail.com" },
                new Employee() { Id = 76, FirstName = "Anne", LastName = "Hunt", dob = "1965-11-10", emailID = "AHunt@freelook.com" },
                new Employee() { Id = 77, FirstName = "Donna", LastName = "Ramirez", dob = "1960-07-07", emailID = "DRamirez@lol.com" },
                new Employee() { Id = 78, FirstName = "Lolita", LastName = "Ifill", dob = "1946-09-07", emailID = "LIfill@goodmail.com" },
                new Employee() { Id = 79, FirstName = "Sidney", LastName = "Wolfe", dob = "1960-04-12", emailID = "Sidney.Wolfe@snowmail.com" },
                new Employee() { Id = 80, FirstName = "May", LastName = "Harris", dob = "1952-02-15", emailID = "May.Harris@goodmail.com" },

                new Employee() { Id = 81, FirstName = "Herman", LastName = "Verone", dob = "1969-10-07", emailID = "HVerone@goodmail.com" },
                new Employee() { Id = 82, FirstName = "Sherry", LastName = "Wells", dob = "1972-02-22", emailID = "Sherry.Wells@lol.com" },
                new Employee() { Id = 83, FirstName = "Lyle", LastName = "Jaramillo", dob = "1969-07-06", emailID = "LJaramillo@happymail.com" },
                new Employee() { Id = 84, FirstName = "Amanda", LastName = "Frost", dob = "1959-09-07", emailID = "AFrost@freelook.com" },
                new Employee() { Id = 85, FirstName = "William", LastName = "Barca", dob = "1953-11-11", emailID = "William.Barca@freelook.com" },
                new Employee() { Id = 86, FirstName = "Roberto", LastName = "Castillo", dob = "1956-08-14", emailID = "Roberto.Castillo@freelook.com" },
                new Employee() { Id = 87, FirstName = "Carol", LastName = "Hall", dob = "1949-03-26", emailID = "CHall@goodmail.com" },
                new Employee() { Id = 88, FirstName = "Mike", LastName = "Ward", dob = "1989-08-18", emailID = "MWard@happymail.com" },
                new Employee() { Id = 89, FirstName = "Scarlet", LastName = "Shepard", dob = "1974-06-27", emailID = "SShepard@lol.com" },
                new Employee() { Id = 90, FirstName = "Lawrence", LastName = "Tittle", dob = "1954-08-06", emailID = "Lawrence.Tittle@snowmail.com" },


                new Employee() { Id = 91, FirstName = "Josefina", LastName = "Cobb", dob = "1989-09-04", emailID = "JCobb@lol.com" },
                new Employee() { Id = 92, FirstName = "Andrew", LastName = "Finger", dob = "1961-02-13", emailID = "Andrew.Finger@freelook.com" },
                new Employee() { Id = 93, FirstName = "John", LastName = "Wright", dob = "1985-04-05", emailID = "John.Wright@freecloud.com" },
                new Employee() { Id = 94, FirstName = "Steven", LastName = "Wright", dob = "1986-03-07", emailID = "SWright@goodmail.com" },
                new Employee() { Id = 95, FirstName = "Derrick", LastName = "Silva", dob = "1951-08-16", emailID = "DSilva@lol.com" },
                new Employee() { Id = 96, FirstName = "Myles", LastName = "Carter", dob = "1991-03-24", emailID = "Myles.Carter@goodmail.com" },
                new Employee() { Id = 97, FirstName = "Anthony", LastName = "Oakley", dob = "1949-11-01", emailID = "AOakley@lol.com" },
                new Employee() { Id = 98, FirstName = "Grace", LastName = "Ross", dob = "1965-08-15", emailID = "GRoss@freecloud.com" },
                new Employee() { Id = 99, FirstName = "Terry", LastName = "Suares", dob = "1983-02-26", emailID = "Terry.Suares@snowmail.com" },
                new Employee() { Id = 100, FirstName = "Robert", LastName = "Hicks", dob = "1965-06-03", emailID = "Robert.Hicks@lol.com" }
        };
        #endregion
        public static ConcurrentQueue<Employee> EmployeeQueue = new ConcurrentQueue<Employee>(employees);
    }
    public class Operations
    {
        public async Task<bool> DeleteFromQueue(ConcurrentQueue<Employee> Queue)
        {
            Employee s = null;
            for (int i = 0; i < Queue.Count - 1; i++)
            {
                Queue.TryDequeue(out s);
            }
            return true;
        }
        public async Task<bool> PrintEmployee(ConcurrentQueue<Employee> Queue)
        {
            Employee obj = null;
            while (Queue.TryDequeue(out obj))
            {
                await Task.Delay(10000);
                Console.WriteLine($" started Print Employee");
                Console.WriteLine($"{obj.Id} {obj.emailID} thread ID : {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($" Ended Print Employee");
                Console.WriteLine($"The Queue count {Queue.Count}");
            }
            return true;
        }
    }
}
