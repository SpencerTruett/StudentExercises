using System;

namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      Exercise MartinsAquarium = new Exercise("Martin's Aquarium", "HTML");
      Exercise Glassdale = new Exercise("Glassdale", "Javascript");
      Exercise KandyKorner = new Exercise("Kandy Korner", "Javascript");
      Exercise Nutshell = new Exercise("Nutshell", "React.js");

      Cohort Cohort36 = new Cohort("Cohort 36");
      Cohort Cohort37 = new Cohort("Cohort 37");
      Cohort Cohort38 = new Cohort("Cohort 38");
      Cohort Cohort39 = new Cohort("Cohort 39");


      Student JohnGilliam = new Student("John", "Gilliam", "John Gilliam", Cohort37);
      Cohort37.addStudent(JohnGilliam);
      Student HoldenParker = new Student("Holden", "Parker", "Holden Parker", Cohort37);
      Cohort37.addStudent(HoldenParker);
      Student WillyMetcalf = new Student("Willy", "Metcalf", "Willy Metcalf", Cohort37);
      Cohort37.addStudent(WillyMetcalf);
      Student JansenVanDerSpuy = new Student("Jansen", "van der Spuy", "Jansen van der Spuy", Cohort37);
      Cohort37.addStudent(JansenVanDerSpuy);
      Student SpencerTruett = new Student("Spencer", "Truett", "Spencer Truett", Cohort37);
      Cohort37.addStudent(SpencerTruett);
      Student JohnLong = new Student("John", "Long", "John Long", Cohort36);
      Cohort36.addStudent(JohnLong);


      Instructor SteveBrownlee = new Instructor("Steve", "Brownlee", "coach", Cohort37, "Dad Jokes");
      Instructor MoSilvera = new Instructor("Mo", "Silvera", "Mo", Cohort37, "Everything");
      Instructor LeahHoefling = new Instructor("Leah", "Hoefling", "Leah", Cohort37, "Awesomeness");
      Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adamsheaf", Cohort37, "stuff");
      Instructor RoseWisotzky = new Instructor("Rose", "Wisotzky", "Rose Wisotzky", Cohort37, "stuff");
      Instructor BrendaLong = new Instructor("Brenda", "Long", "bjlong", Cohort37, "stuff");

      SteveBrownlee.assignExercise(Nutshell, SpencerTruett);
      SteveBrownlee.assignExercise(KandyKorner, JohnLong);
      SteveBrownlee.assignExercise(MartinsAquarium, HoldenParker);
      SteveBrownlee.assignExercise(Glassdale, JansenVanDerSpuy);
      SteveBrownlee.assignExercise(Glassdale, WillyMetcalf);
      SteveBrownlee.assignExercise(Nutshell, WillyMetcalf);


      foreach (Student student in Cohort37.Students)
      {
        student.Description();
      }

      foreach (Student student in Cohort36.Students)
      {
        student.Description();
      }


    }
  }
}