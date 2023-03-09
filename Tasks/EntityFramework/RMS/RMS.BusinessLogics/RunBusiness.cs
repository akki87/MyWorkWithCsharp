using RMS.BusinessLogics.ADO.Net;
using RMS.BusinessLogics.Dapper;
using RMS.BusinessLogics.StoredProcedureBulk;
using RMSCodeFirstApproach.Core.Entities;
using RMS.BusinessLogics.System.Data;

using RMS.BusinessLogics.StoredProcedures;
using RMSCodeFirstApproach.Core.Entities;

namespace RMS.BusinessLogics
{
	public class RunBusiness
	{
		public static void Start(string[] args)
		{
			//ADOServices.Services(args);
			//DapperServices.GetList();
			List<Employee> employee = new List<Employee>()
		{

			new Employee() { Id = 1, FirstName = "Thomas", LastName = "Morin", Dob = "1961-04-16", Email = "Thomas.Morin@lol.com" },
			new Employee() { Id = 2, FirstName = "Elizabeth", LastName = "Alford", Dob = "1982-01-13", Email = "EAlford@freelook.com" },
			new Employee() { Id = 3, FirstName = "Johnathan", LastName = "Nichols", Dob = "1946-07-11", Email = "JNichols@freecloud.com" },
			new Employee() { Id = 4, FirstName = "Jeffery", LastName = "Gourlay", Dob = "1955-02-02", Email = "Jeffery.Gourlay@freecloud.com" },
			new Employee() { Id = 5, FirstName = "Fred", LastName = "Sullivan", Dob = "1968-10-07", Email = "FSullivan@freecloud.com" },
			new Employee() { Id = 6, FirstName = "Jimmy", LastName = "Fortune", Dob = "1970-04-03", Email = "Jimmy.Fortune@freelook.com" },
			new Employee() { Id = 7, FirstName = "Ken", LastName = "Fitton", Dob = "1963-08-22", Email = "Ken.Fitton@lol.com" },
			new Employee() { Id = 8, FirstName = "Adrian", LastName = "Sipes", Dob = "1976-04-07", Email = "Adrian.Sipes@happymail.com" },
			new Employee() { Id = 9, FirstName = "Andrew", LastName = "Moise", Dob = "1974-07-27", Email = "Andrew.Moise@goodmail.com" },
			new Employee() { Id = 10, FirstName = "Fred", LastName = "Jordan", Dob = "1989-04-04", Email = "Fred.Jordan@freelook.com" },

			new Employee() { Id = 11, FirstName = "Teresa", LastName = "Renschler", Dob = "1951-11-23", Email = "TRenschler@goodmail.com" },
			new Employee() { Id = 12, FirstName = "Ruth", LastName = "Marley", Dob = "1979-04-26", Email = "RMarley@freelook.com" },
			new Employee() { Id = 13, FirstName = "Joseph", LastName = "Gregory", Dob = "1985-10-24", Email = "JGregory@goodmail.com" },
			new Employee() { Id = 14, FirstName = "Elias", LastName = "Donovan", Dob = "1966-03-18", Email = "Elias.Donovan@goodmail.com" },
			new Employee() { Id = 15, FirstName = "Louise", LastName = "Mcconnaughey", Dob = "1959-01-11", Email = "Louise.Mcconnaughey@lol.com" },
			new Employee() { Id = 16, FirstName = "Laurie", LastName = "Casa", Dob = "1971-08-06", Email = "LCasa@goodmail.com" },
			new Employee() { Id = 17, FirstName = "Chase", LastName = "Poutre", Dob = "1945-08-25", Email = "CPoutre@snowmail.com" },
			new Employee() { Id = 18, FirstName = "John", LastName = "Osmer", Dob = "1955-06-16", Email = "JOsmer@happymail.com" },
			new Employee() { Id = 19, FirstName = "Gilberto", LastName = "Ramirez", Dob = "1963-07-05", Email = "GRamirez@lol.com" },
			new Employee() { Id = 20, FirstName = "John", LastName = "Hopkins", Dob = "1988-08-19", Email = "JHopkins@happymail.com" },

			new Employee() { Id = 21, FirstName = "Rachel", LastName = "Celestine", Dob = "1991-02-12", Email = "Rachel.Celestine@freelook.com" },
			new Employee() { Id = 22, FirstName = "Karen", LastName = "James", Dob = "1976-09-07", Email = "KJames@freelook.com" },
			new Employee() { Id = 23, FirstName = "Agustin", LastName = "Braun", Dob = "1977-07-14", Email = "ABraun@lol.com" },
			new Employee() { Id = 24, FirstName = "Eric", LastName = "Metzger", Dob = "1969-09-25", Email = "EMetzger@freelook.com" },
			new Employee() { Id = 25, FirstName = "Lynn", LastName = "Abbruzzese", Dob = "1990-08-26", Email = "Lynn.Abbruzzese@goodmail.com" },
			new Employee() { Id = 26, FirstName = "Julia", LastName = "Mcelfresh", Dob = "1981-05-06", Email = "JMcelfresh@goodmail.com" },
			new Employee() { Id = 27, FirstName = "Patricia", LastName = "Banks", Dob = "1988-02-27", Email = "Patricia.Banks@goodmail.com" },
			new Employee() { Id = 28, FirstName = "Joan", LastName = "Ezell", Dob = "1972-02-02", Email = "JEzell@snowmail.com" },
			new Employee() { Id = 29, FirstName = "Herbert", LastName = "Willibrand", Dob = "1974-06-17", Email = "Herbert.Willibrand@happymail.com" },
			new Employee() { Id = 30, FirstName = "William", LastName = "Valdivia", Dob = "1968-04-11", Email = "WValdivia@lol.com" },

			new Employee() { Id = 31, FirstName = "Joseph", LastName = "Ternes", Dob = "1958-01-21", Email = "Joseph.Ternes@freecloud.com" },
			new Employee() { Id = 32, FirstName = "Dana", LastName = "Wynn", Dob = "1967-11-17", Email = "DWynn@freecloud.com" },
			new Employee() { Id = 33, FirstName = "Theresa", LastName = "Loy", Dob = "1972-09-20", Email = "TLoy@freelook.com" },
			new Employee() { Id = 34, FirstName = "Patricia", LastName = "Bruns", Dob = "1965-01-13", Email = "Patricia.Bruns@snowmail.com" },
			new Employee() { Id = 35, FirstName = "Eddie", LastName = "Cerbone", Dob = "1946-01-14", Email = "ECerbone@goodmail.com" },
			new Employee() { Id = 36, FirstName = "Cecilia", LastName = "Koch", Dob = "1973-10-26", Email = "Cecilia.Koch@lol.com" },
			new Employee() { Id = 37, FirstName = "Christina", LastName = "Muniz", Dob = "1986-01-15", Email = "Christina.Muniz@freelook.com" },
			new Employee() { Id = 38, FirstName = "Edmund", LastName = "Montes", Dob = "1951-01-27", Email = "EMontes@happymail.com" },
			new Employee() { Id = 39, FirstName = "Esther", LastName = "Bradshaw", Dob = "1975-03-11", Email = "Esther.Bradshaw@happymail.com" },
			new Employee() { Id = 40, FirstName = "Diane", LastName = "Hamilton", Dob = "1944-08-16", Email = "DHamilton@happymail.com" },

			new Employee() { Id = 41, FirstName = "KAREN", LastName = "Kinikini", Dob = "1961-11-14", Email = "KAREN.Kinikini@goodmail.com" },
			new Employee() { Id = 42, FirstName = "Wayne", LastName = "Landry", Dob = "1962-05-11", Email = "Wayne.Landry@freecloud.com" },
			new Employee() { Id = 43, FirstName = "Ruth", LastName = "Jones", Dob = "1981-06-23", Email = "RJones@lol.com" },
			new Employee() { Id = 44, FirstName = "Albert", LastName = "Hall", Dob = "1974-08-16", Email = "Albert.Hall@freelook.com" },
			new Employee() { Id = 45, FirstName = "Melodie", LastName = "Duncan", Dob = "1948-01-10", Email = "Melodie.Duncan@lol.com" },
			new Employee() { Id = 46, FirstName = "Beverly", LastName = "Sharpe", Dob = "1956-01-20", Email = "BSharpe@freelook.com" },
			new Employee() { Id = 47, FirstName = "Alan", LastName = "Humphreys", Dob = "1978-09-27", Email = "AHumphreys@lol.com" },
			new Employee() { Id = 48, FirstName = "Amy", LastName = "Conner", Dob = "1955-05-27", Email = "Amy.Conner@snowmail.com" },
			new Employee() { Id = 49, FirstName = "Chris", LastName = "Bradsher", Dob = "1981-02-07", Email = "CBradsher@happymail.com" },
			new Employee() { Id = 50, FirstName = "Patsy", LastName = "Stringfellow", Dob = "1959-10-26", Email = "Patsy.Stringfellow@snowmail.com" },

			new Employee() { Id = 51, FirstName = "Melissa", LastName = "Choi", Dob = "1983-08-21", Email = "Melissa.Choi@happymail.com" },
			new Employee() { Id = 52, FirstName = "John", LastName = "Buckner", Dob = "1990-04-07", Email = "JBuckner@goodmail.com" },
			new Employee() { Id = 53, FirstName = "Heather", LastName = "Pettyjohn", Dob = "1970-08-01", Email = "HPettyjohn@snowmail.com" },
			new Employee() { Id = 54, FirstName = "Jacqueline", LastName = "Wechter", Dob = "1957-03-13", Email = "Jacqueline.Wechter@snowmail.com" },
			new Employee() { Id = 55, FirstName = "Walter", LastName = "Thomas", Dob = "1989-06-24", Email = "Walter.Thomas@freelook.com" },
			new Employee() { Id = 56, FirstName = "Robert", LastName = "Sanders", Dob = "1961-04-27", Email = "Robert.Sanders@freecloud.com" },
			new Employee() { Id = 57, FirstName = "Patricia", LastName = "Jacobsen", Dob = "1962-06-15", Email = "PJacobsen@freelook.com" },
			new Employee() { Id = 58, FirstName = "Sabrina", LastName = "Bernardo", Dob = "1963-11-07", Email = "Sabrina.Bernardo@goodmail.com" },
			new Employee() { Id = 59, FirstName = "Janette", LastName = "Longstaff", Dob = "1977-10-13", Email = "JLongstaff@lol.com" },
			new Employee() { Id = 60, FirstName = "Wilhelmina", LastName = "Lamour", Dob = "1990-08-18", Email = "Wilhelmina.Lamour@happymail.com" },

			new Employee() { Id = 61, FirstName = "Debra", LastName = "Levalley", Dob = "1985-08-09", Email = "DLevalley@freelook.com" },
			new Employee() { Id = 62, FirstName = "Inez", LastName = "Ford", Dob = "1958-08-15", Email = "Inez.Ford@freelook.com" },
			new Employee() { Id = 63, FirstName = "Jared", LastName = "Mason", Dob = "1966-05-22", Email = "Jared.Mason@snowmail.com" },
			new Employee() { Id = 64, FirstName = "Patrick", LastName = "Cheney", Dob = "1963-08-12", Email = "PCheney@freelook.com" },
			new Employee() { Id = 65, FirstName = "Krystal", LastName = "Burks", Dob = "1962-02-15", Email = "Krystal.Burks@happymail.com" },
			new Employee() { Id = 66, FirstName = "Freddie", LastName = "Fitzgerald", Dob = "1957-06-01", Email = "FFitzgerald@freelook.com" },
			new Employee() { Id = 67, FirstName = "Michelle", LastName = "Johnson", Dob = "1970-02-13", Email = "MJohnson@happymail.com" },
			new Employee() { Id = 68, FirstName = "Jeffrey", LastName = "Gignac", Dob = "1944-11-24", Email = "JGignac@happymail.com" },
			new Employee() { Id = 69, FirstName = "Richard", LastName = "Wise", Dob = "1983-01-06", Email = "RWise@freecloud.com" },
			new Employee() { Id = 70, FirstName = "June", LastName = "Chambers", Dob = "1983-04-01", Email = "June.Chambers@snowmail.com" },

			new Employee() { Id = 71, FirstName = "Brandon", LastName = "Maldonado", Dob = "1965-03-23", Email = "BMaldonado@freelook.com" },
			new Employee() { Id = 72, FirstName = "Amy", LastName = "Hunter", Dob = "1960-07-10", Email = "Amy.Hunter@freelook.com" },
			new Employee() { Id = 73, FirstName = "Brooke", LastName = "Kline", Dob = "1981-11-11", Email = "Brooke.Kline@lol.com" },
			new Employee() { Id = 74, FirstName = "Marie", LastName = "Kennedy", Dob = "1989-03-18", Email = "MKennedy@lol.com" },
			new Employee() { Id = 75, FirstName = "Ethel", LastName = "Pena", Dob = "1967-09-12", Email = "EPena@goodmail.com" },
			new Employee() { Id = 76, FirstName = "Anne", LastName = "Hunt", Dob = "1965-11-10", Email = "AHunt@freelook.com" },
			new Employee() { Id = 77, FirstName = "Donna", LastName = "Ramirez", Dob = "1960-07-07", Email = "DRamirez@lol.com" },
			new Employee() { Id = 78, FirstName = "Lolita", LastName = "Ifill", Dob = "1946-09-07", Email = "LIfill@goodmail.com" },
			new Employee() { Id = 79, FirstName = "Sidney", LastName = "Wolfe", Dob = "1960-04-12", Email = "Sidney.Wolfe@snowmail.com" },
			new Employee() { Id = 80, FirstName = "May", LastName = "Harris", Dob = "1952-02-15", Email = "May.Harris@goodmail.com" },

			new Employee() { Id = 81, FirstName = "Herman", LastName = "Verone", Dob = "1969-10-07", Email = "HVerone@goodmail.com" },
			new Employee() { Id = 82, FirstName = "Sherry", LastName = "Wells", Dob = "1972-02-22", Email = "Sherry.Wells@lol.com" },
			new Employee() { Id = 83, FirstName = "Lyle", LastName = "Jaramillo", Dob = "1969-07-06", Email = "LJaramillo@happymail.com" },
			new Employee() { Id = 84, FirstName = "Amanda", LastName = "Frost", Dob = "1959-09-07", Email = "AFrost@freelook.com" },
			new Employee() { Id = 85, FirstName = "William", LastName = "Barca", Dob = "1953-11-11", Email = "William.Barca@freelook.com" },
			new Employee() { Id = 86, FirstName = "Roberto", LastName = "Castillo", Dob = "1956-08-14", Email = "Roberto.Castillo@freelook.com" },
			new Employee() { Id = 87, FirstName = "Carol", LastName = "Hall", Dob = "1949-03-26", Email = "CHall@goodmail.com" },
			new Employee() { Id = 88, FirstName = "Mike", LastName = "Ward", Dob = "1989-08-18", Email = "MWard@happymail.com" },
			new Employee() { Id = 89, FirstName = "Scarlet", LastName = "Shepard", Dob = "1974-06-27", Email = "SShepard@lol.com" },
			new Employee() { Id = 90, FirstName = "Lawrence", LastName = "Tittle", Dob = "1954-08-06", Email = "Lawrence.Tittle@snowmail.com" },


			new Employee() { Id = 91, FirstName = "Josefina", LastName = "Cobb", Dob = "1989-09-04", Email = "JCobb@lol.com" },
			new Employee() { Id = 92, FirstName = "Andrew", LastName = "Finger", Dob = "1961-02-13", Email = "Andrew.Finger@freelook.com" },
			new Employee() { Id = 93, FirstName = "John", LastName = "Wright", Dob = "1985-04-05", Email = "John.Wright@freecloud.com" },
			new Employee() { Id = 94, FirstName = "Steven", LastName = "Wright", Dob = "1986-03-07", Email = "SWright@goodmail.com" },
			new Employee() { Id = 95, FirstName = "Derrick", LastName = "Silva", Dob = "1951-08-16", Email = "DSilva@lol.com" },
			new Employee() { Id = 96, FirstName = "Myles", LastName = "Carter", Dob = "1991-03-24", Email = "Myles.Carter@goodmail.com" },
			new Employee() { Id = 97, FirstName = "Anthony", LastName = "Oakley", Dob = "1949-11-01", Email = "AOakley@lol.com" },
			new Employee() { Id = 98, FirstName = "Grace", LastName = "Ross", Dob = "1965-08-15", Email = "GRoss@freecloud.com" },
			new Employee() { Id = 99, FirstName = "Terry", LastName = "Suares", Dob = "1983-02-26", Email = "Terry.Suares@snowmail.com" },
			new Employee() { Id = 100, FirstName = "Robert", LastName = "Hicks", Dob = "1965-06-03", Email = "Robert.Hicks@lol.com" }

		};
			Sp_BulkInsert.InsertEmployees(employee);
			//ADOServices.Services(args);
			//DapperServices.GetList();
			Sp_Insertion.InsertEmployees(new Employee("Yogesh", "Nethula", "2001-07-25", "nykumar@qualminds.com"));
			//ADOServices.Services(args);
			//DapperServices.GetList();
			IDbConnectionServices.GetList("Customer");
			IDbConnectionServices.GetListDapper("Customer");
		}
	}
}