using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
  
    // powitanie
    WriteLine ("Welcome in RockPaperScissors game!\n");
    //zasady gry
    WriteLine (" Game rules: \n(1) Push any number from 1 to 3, then [enter] \n(2) Paper wins with rock\n(3) Rock wins with scissors\n(4) Scissors wins with paper");
    WriteLine ("\n [push any key to continue]");
    ReadKey ();
    Clear ();
     while (true) {

     //deklaracja player 1
     WriteLine("[Player 1] choose your type:\n(1) Rock\n(2) Paper\n(3) Scissors");
     string player1choose = ReadLine();
     int player1chooseInt;
     while(!Int32.TryParse(player1choose, out player1chooseInt)
     || player1chooseInt > 3
     || player1chooseInt <=0 ){
       WriteLine("Select correct number");
       player1choose = ReadLine();}
     Clear ();

     //deklaracja player 2
     WriteLine("[Player 2] choose your type:\n(1) Rock\n(2) Paper\n(3) Scissors");
     string player2choose = ReadLine();
     int player2chooseInt;
     while(!Int32.TryParse(player2choose, out player2chooseInt)
     || player2chooseInt > 3
     || player2chooseInt <=0 ){
       WriteLine("Select correct number");
       player2choose = ReadLine();}
     Clear ();

     //rozpisać warunki wygranej
     if (player1choose == player2choose){
      WriteLine ("Remis\n");}
     else if (player1choose == "1" && player2choose == "2"){ WriteLine ("Paper beats Rock. Player 2 wins.");}
     else if (player1choose == "1" && player2choose == "3"){ WriteLine ("Rock beats Scissors. Player 1 wins.");}
     else if (player1choose == "2" && player2choose == "1"){ WriteLine ("Paper beats Rock. Player 1 wins.");}
     else if (player1choose == "2" && player2choose == "3"){ WriteLine ("Scissors beat Paper. Player 2 wins.");}
     else if (player1choose == "3" && player2choose == "1"){ WriteLine ("Rock beats Scissors. Player 2 wins.");}
     else if (player1choose == "3" && player2choose == "2"){ WriteLine ("Scissors beat Paper. Player 1 wins.");}
     WriteLine ("\n [push any key to continue or ctrl+C to exit]");
      ReadKey ();
      Clear ();
      /*zrobić funkcje liczenia wyniku
      WriteLine ("Score:");
      WriteLine ("\n Player1\n Player2");
     ReadKey ();
     Clear ();*/
      
    } 
  }
}