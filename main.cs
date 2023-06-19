using System;

class HelloWorld {
    
    static void map(int mapMake, int placeUsed, int placeUsedSection) {
        int spaceLength = 17;
        string nameOutput = "";
        string s = "";
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
                for(int x = names[placeUsed][placeUsedSection].Length; x < spaceLength; x++)
                    s += " ";
                /*string*/ nameOutput = names[placeUsed][placeUsedSection];
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
            case 10:
                for(int x = 0; x < charloc.Length; x++)
                    if(charloc[x] == placeUsed)
                        nameOutput += (x+1) + " ";
                for(int x = nameOutput.Length; x < spaceLength; x++)
                    s += " ";
                if(nameOutput.Length > spaceLength)
                   nameOutput = nameOutput.Substring(0, spaceLength);
                Console.Write("|" + nameOutput + s);
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
    
    private static string[][] names;
    private static string[] price = {   "",  "60", "",  "60", "", "200", "100",  "", "100", "120", "",  "140", "0", "140", "160", "200", "180", "",  "180", "200", "", "220", "",  "220", "240", "200", "260", "260", "0", "280", "",  "300", "300", "",  "320", "200", "",  "350", "", "400"};
    private static string[] pph = {     "0", "50", "0", "50", "0", "0",   "50",  "0", "50",  "50" , "0", "100", "0", "100", "100", "0",   "100", "0", "100", "100", "0", "150", "0", "150", "150", "0",   "150", "150", "0", "150", "0", "200", "200", "0", "200", "0",   "0", "200", "0", "200"};
    private static string[] rent = {    "0", "2",  "0", "4",  "0", "0",   "6",   "0", "6",   "8",   "0", "10",  "0", "10",  "12",  "0",   "14",  "0", "14",  "16",  "0", "18",  "0", "18",  "20",  "0",   "22",  "22",  "0", "24",  "0", "26",  "26",  "0", "28",  "0",   "0", "35",  "0", "50"};
    private static string[] rent1 = {   "0", "10", "0", "20", "0", "0",   "30",  "0", "30",  "40",  "0", "50",  "0", "50",  "60",  "0",   "70",  "0", "70",  "80",  "0", "90",  "0", "90",  "100", "0",   "110", "110", "0", "120", "0", "150", "130", "0", "150", "0",   "0", "175", "0", "200"};
    private static string[] rent2 = {   "0", "30", "0", "60", "0", "0",   "90",  "0", "90",  "100", "0", "150", "0", "150", "180", "0",   "200", "0", "200", "220", "0", "250", "0", "250", "300", "0",   "330", "330", "0", "360", "0", "390", "390", "0", "450", "0",   "0", "500", "0", "600"};
    private static string[] rent3 = {   "0", "90", "0", "180","0", "0",   "270", "0", "270", "300", "0", "450", "0", "450", "500", "0",   "550", "0", "550", "600", "0", "700", "0", "700", "750", "0",   "800", "800", "0", "850", "0", "900", "900", "0", "1000","0",   "0", "1100","0", "1400"};
    private static string[] rent4 = {   "0", "160","0", "320","0", "0",   "400", "0", "400", "450", "0", "625", "0", "625", "700", "0",   "750", "0", "750", "800", "0", "875", "0", "875", "925", "0",   "975", "975", "0", "1025","0", "1100","1100","0", "1200","0",   "0", "1300","0", "1700"};
    private static string[] rentH = {   "0", "250","0", "450","0", "0",   "550", "0", "550", "600", "0", "750", "0", "750", "900", "0",   "950", "0", "950", "1000","0", "1050","0", "1050","1100","0",   "1150","1150","0", "1200","0", "1275","1275","0", "1400","0",   "0", "1500","0", "0"};
    private static string[] mortgage = {"0", "30", "0", "30", "0", "100", "50",  "0", "50",  "60",  "0", "70",  "0", "70",  "80",  "0",   "90",  "0", "90",  "100", "0", "110", "0", "110", "120", "0",   "130", "130", "0", "140", "0", "150", "150", "0", "160", "0",   "0", "175", "0", "200"};
    static void defaultCreate(){
        string[] nameList = {"Go","Mediterranean Avenue","Community Chest","Baltic Avenue","Income Tax","Reading Railroad", "Oriental Avenue", "Chance", "Vermont Avenue", "Connecticut Avenue", "Jail / Just Visiting", "St. Charles Place", "Electric Company", "States Avenue", "Virginia Avenue", "Pennsylvania Railroad", "St. James Place", "Community Chest", "Tennessee Avenue", "New York Avenue", "Free Parking", "Kentucky Avenue", "Chance", "Indiana Avenue", "Illinois Avenue", "B. & O. Railroad", "Atlantic Avenue", "Ventnor Avenue", "Water Works", "Marvin Gardens", "Go To Jail", "Pacific Avenue", "North Carolina Avenue", "Community Chest", "Pennsylvania Avenue", "Short Line", "Chance", "Park Place", "Luxury Tax", "Boardwalk"};
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
            names[x][2] = "" + -1;
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
        for(int x = 0; x < 11; x++)
            map(10, x, 0);
        map(5, 0, 0);
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
            map(10, 39-x, 0);
            map(6, 0, 0);
            map(10, 11 + x, 0);
            map(5, 0, 0);
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
        //map(2, 0, 0);
        for(int x = 30; x > 19; x--)
            map(10, x, 0);
        map(5, 0, 0);
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
                    Console.WriteLine("What would player " + turn + " like to do?\nr-roll.");
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
    private static int[] charloc;
    private static int turn;
    static void Main() {
        Console.Clear();
        defaultCreate();
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
        Console.Clear();
        charMoney = new int[playerAmount];
        charloc = new int[playerAmount];
        for(int x = 0; x < playerAmount; x++)
        {
            charMoney[x] = 2000;
            charloc[x] = 0;
        }
        turn = 1;
        while(letter != "辞める")
        {
            Console.Clear();
            printOutMap();
            for(int x = 0; x < playerAmount; x++)
                Console.Write("p"+(x+1)+" - " +charMoney[x] + " ");
            Console.WriteLine();
            output(1, lang);
            letter = Console.ReadLine();
            switch(letter)
                {
                    case "r":
                        {
                            Console.Clear();
                            int r1 = rnd.Next(1, 7);
                            int r2 = rnd.Next(1, 7);
                            dice(r1);
                            dice(r2);
                            charloc[turn-1] += r1+r2;
                            if(charloc[turn-1] >= 40)
                                charMoney[turn-1] += 200;
                            charloc[turn-1] %= 40;
                            Console.WriteLine("You rolled a " + (r1+r2) + "!");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("You landed on " + names[charloc[turn-1]][0] + "!");
                            //Console.WriteLine("|"+names[charloc[turn-1]][1]+"|");
                            if(names[charloc[turn-1]][1] != "")
                            {
                                if(names[charloc[turn-1]][2] == "-1")
                                    {
                                        Console.WriteLine("Nobody owns it, do you want to buy it for " + names[charloc[turn-1]][1] + "?\nY/N");
                                        string YN = Console.ReadLine();
                                        while(YN != "Y" && YN != "N" && YN != "y" && YN != "n")
                                                YN = Console.ReadLine();
                                        if(YN == "Y" || YN == "y")
                                        {
                                            names[charloc[turn-1]][2] = "" + (turn-1);
                                            names[charloc[turn-1]][1] = rent[turn-1];
                                        }
                                    }
                                else if(names[charloc[turn-1]][2] == "" + (turn-1))
                                    {
                                        Console.WriteLine("You already own this.");
                                        Console.ReadLine();
                                    }
                                else
                                    {
                                        if(charloc[turn-1] == 12 || charloc[turn-1] == 28)
                                            {
                                                int minusMoney = 4 * (r1+r2);
                                                if(names[12][2] == names[28][2])
                                                    minusMoney = 10 * (r1+r2);
                                                Console.WriteLine("You don't own this so you will have to pay " + minusMoney + " to player " + Int32.Parse((names[charloc[turn-1]][2]+1)));
                                                charMoney[turn-1] -= minusMoney;
                                                charMoney[Int32.Parse((names[charloc[turn-1]][2]))] += minusMoney;
                                            }
                                        else
                                            {
                                                Console.WriteLine("You don't own this so you will have to pay " + names[charloc[turn-1]][1] + " to player " + Int32.Parse((names[charloc[turn-1]][2]+1)));
                                                charMoney[turn-1] -= Int32.Parse(names[charloc[turn-1]][1]);
                                                charMoney[Int32.Parse((names[charloc[turn-1]][2]))] += Int32.Parse(names[charloc[turn-1]][1]);
                                            }
                                            Console.ReadLine();
                                    }
                            }
                            else
                            {
                                switch(names[charloc[turn-1]][0])
                                {
                                    case "Community Chest":
                                        Console.WriteLine("1");
                                        break;
                                    case "Income Tax":
                                        if(charMoney[turn-1]*.1>=200)
                                            charMoney[turn-1] -= 200;
                                        else
                                            charMoney[turn-1] = (int)(charMoney[turn-1]*.9);
                                        break;
                                    case "Chance":
                                        Console.WriteLine("3");
                                        break;
                                    case "Luxury Tax":
                                        charMoney[turn-1] -= 75;
                                        break;
                                    case "Go To Jail":
                                        charloc[turn-1] = 11;
                                        break;
                                    case "Free Parking":
                                        Console.WriteLine("6");
                                        break;
                                    default:
                                        break;
                                }
                                Console.ReadLine();
                            }
                            //Console.ReadLine();
                            Console.Clear();
                            turn++;
                            if(playerAmount < turn)
                                turn = 1;
                            break;
                        }
                    case "ゐ":
                        {
                            letter = Console.ReadLine();
                            if(letter == "１")
                                for(int x = 0; x <= 100; x++)
                                     dice(rnd.Next(1, 7));
                            if(letter == "２")
                                for(int x = 0; x < playerAmount; x++)
                                    charloc[x] = rnd.Next(0, 40);
                            if(letter == "３")
                                for(int x = 0; x < 40; x++)
                                    {
                                        names[x][2] = "" + 0;
                                        names[x][1] = rent[x];
                                    }
                            if(letter == "４")
                                for(int x = 0; x < playerAmount; x++)
                                    charloc[x] = 39;
                            if(letter == "５")
                                for(int x = 0; x < playerAmount; x++)
                                    charMoney[x] = 50000;
                            if(letter == "６")
                                for(int x = 0; x < playerAmount; x++)
                                    charMoney[x] = 10;
                            break;
                        }
                }
                Console.Clear();
        }
    }
}






