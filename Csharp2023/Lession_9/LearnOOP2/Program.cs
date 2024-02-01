using Infratructure;
using static Infratructure.School;
using static Infratructure.Student;

var anna = new Student("ana", 10, 3, 6);
var anna2 = new EnglishStudent ("ana", 10, 3, 6,5.8);
var historySchool1 = new GenericSchool<HistoryStudent>();
var englishSchool1 = new GenericSchool<EnglishStudent>();

Console.ReadKey();

