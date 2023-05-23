/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld {
    
    static void map(int mapMake, int placeUsed, int placeUsedSection) {
        switch(mapMake)
        {
            case 1:
                for(int x = 0; x < 11; x++)
                    Console.Write("+-----------------");
                map(4, 0, 0);
                break;
            case 2:
                for(int x = 0; x < 11; x++)
                    Console.Write("|                 ");
                map(5, 0, 0);
                break;
            case 3:
                int spaceLength = 17;
                string s = "";
                for(int x = names[placeUsed][placeUsedSection].Length; x < spaceLength; x++)
                    s += " ";
                string nameOutput = names[placeUsed][placeUsedSection];
                if(names[placeUsed][placeUsedSection].Length > spaceLength)
                   nameOutput = names[placeUsed][placeUsedSection].Substring(0, spaceLength);
                Console.Write("|" + nameOutput + s);
                break;
            case 4:
                Console.WriteLine("+");
                break;
            case 5:
                Console.WriteLine("|");
                break;
            case 6:
                Console.Write("|                                                                                                                                                                 ");
                break;
            case 7:
                Console.WriteLine("|                 |                                                                                                                                                                 |                 |");
                break;
            case 8:
                Console.Write("+-----------------");
                for(int x = 0; x < 9; x++)
                    Console.Write("------------------");
                Console.Write("+-----------------");
                map(4, 0, 0);
                break;
            case 9:
                Console.Write("+-----------------+");
                for(int x = 0; x < 9; x++)
                    Console.Write("                 ");
                for(int x = 0; x < 8; x++)
                    Console.Write(" ");
                Console.Write("+-----------------");
                map(4, 0, 0);
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
    
    private static string[][] names;
    static void defaultCreate(){
        string[] nameList = {"Go","Mediterranean Avenue","Community Chest","Baltic Avenue","Income Tax","Reading Railroad", "Oriental Avenue", "Chance", "Vermont Avenue", "Connecticut Avenue", "Jail / Just Visiting", "St. Charles Place", "Electric Company", "States Avenue", "Virginia Avenue", "Pennsylvania Railroad", "St. James Place", "Community Chest", "Tennessee Avenue", "New York Avenue", "Free Parking", "Kentucky Avenue", "Chance", "Indiana Avenue", "Illinois Avenue", "B. & O. Railroad", "Atlantic Avenue", "Ventnor Avenue", "Water Works", "Marvin Gardens", "Go To Jail", "Pacific Avenue", "North Carolina Avenue", "Community Chest", "Pennsylvania Avenue", "Short Line", "Chance", "Park Place", "Luxury Tax", "Boardwalk"};
        string[] price = {"0", "60", "0", "60", "0", "200", "100", "0", "100", "120", "0", "140", "0", "140", "160", "200", "180", "0", "180", "200", "0", "220", "0", "220", "240", "200", "260", "260", "0", "280", "0", "300", "300", "0", "320", "200", "0", "350", "0", "400"};
        int lengthOfBoard = nameList.Length;
        names = new string[lengthOfBoard][];
        for(int x = 0; x < lengthOfBoard; x++)
        {
            names[x] = new string[3]; 
            names[x][0] = nameList[x];
            if(price.Length > x)
                names[x][1] = price[x];
            else
                names[x][1] = "a";
            names[x][2] = "" + 0;
        }
    }
    
    static void printOutMap()
    {
        map(1, 0, 0);
        map(2, 0, 0);
        for(int x = 0; x < 11; x++)
            map(3, x, 0);
        map(5, 0, 0);
        for(int x = 0; x < 11; x++)
            map(3, x, 1);
        map(5, 0, 0);
        map(2, 0, 0);
        map(8, 0, 0);
        
        for(int x = 0; x < 9; x++)
        {
            map(7, 0, 0);
            map(3, 39-x, 0);
            map(6, 0, 0);
            map(3, 11 + x, 0);
            map(5, 0, 0);
            map(3, 39-x, 1);
            map(6, 0, 0);
            map(3, 11 + x, 1);
            map(5, 0, 0);
            map(7, 0, 0);
            if(x != 8)
                map(9, 0, 0);
            else
                map(8, 0, 0);
        }
        
        map(2, 0, 0);
        for(int x = 30; x > 19; x--)
            map(3, x, 0);
        map(5, 0, 0);
        for(int x = 30; x > 19; x--)
            map(3, x, 1);
        map(5, 0, 0);
        map(2, 0, 0);
        map(1, 0, 0);
    }
    
    static void output(int line, string lang)
    {
        switch(line)
        {
            case 0:
                if(lang == "日本語")
                    Console.WriteLine("何人で遊びますか？");
                else
                    Console.WriteLine("How many players do you have?");
                break;
            case 1:
                if(lang == "日本語")
                    Console.WriteLine("");
                else
                    Console.WriteLine("What would you like to do?\nr-roll.");
                break;
            case 2:
                Console.WriteLine("That ins't a number.");
                break;
            case 3:
                Console.WriteLine("Please have a number that is greater than 1.");
                break;
            default:
                Console.WriteLine("Error.");
                break;
        }
    }
    
    static void dice(int r)
    {
        Console.WriteLine("+-----+");
        switch(r)
        {
            case 1:
                Console.WriteLine("|     |\n|  0  |\n|     |");
                break;
            case 2:
                Console.WriteLine("|     |\n|0   0|\n|     |");
                break;
            case 3:
                Console.WriteLine("|0   0|\n|     |\n|  0  |");
                break;
            case 4:
                Console.WriteLine("|0   0|\n|     |\n|0   0|");
                break;
            case 5:
                Console.WriteLine("|0   0|\n|  0  |\n|0   0|");
                break;
            case 6:
                Console.WriteLine("|0   0|\n|0   0|\n|0   0|");
                break;
            default:
                Console.WriteLine(r);
                break;
        }
        Console.WriteLine("+-----+");
    }
    
    private static int[] charMoney;
    static void Main() {
        defaultCreate();
        // printOutMap();
        string letter = "草";
        string lang = "分からない";
        output(0, lang);
        int playerAmount = 0;
        Random rnd = new Random();
        while(!(2 <= playerAmount))
        {
            try
                {
                    playerAmount = Int32.Parse(Console.ReadLine());
                    if(playerAmount <= 1)
                        output(3, lang);
                }
            catch (Exception e) 
                {
                    output(2, lang);
                }
        }
        charMoney = new int[playerAmount];
        for(int x = 0; x < playerAmount; x++)
            charMoney[x] = 2000;
        while(letter != "辞める")
        {
            printOutMap();
            for(int x = 0; x < playerAmount; x++)
                Console.Write("p"+x+" - " +charMoney[x] + " ");
            Console.WriteLine();
            output(1, lang);
            letter = Console.ReadLine();
            switch(letter)
                {
                    case "r":
                        {
                            int r1 = rnd.Next(1, 7);
                            int r2 = rnd.Next(1, 7);
                            dice(r1);
                            dice(r2);
                            break;
                        }
                    case "ゐ":
                        {
                            letter = Console.ReadLine();
                            if(letter == "１")
                                for(int x = 0; x <= 100; x++)
                                     dice(rnd.Next(1, 7));
                            break;
                        }
                }
        }
    }
}



