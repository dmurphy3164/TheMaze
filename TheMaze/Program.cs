using System;

namespace TheMaze
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Maze!!\n\nIn this Adventure you will have to make choices and have some luck to stay alive.\n\nYou WILL be asked questions that require a response. Be Carefull, you only have 50 hitpoints before you die.\n\nPlease press the Enter Key after typing your answer.\n\nThank you and have Fun!\n\nPlease press 'enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake to a cold damp sensation on your back...           Hit Enter\n ");
            Console.ReadLine();
            Console.WriteLine("It's dark and you can't remember what happened or why your here!...          Hit Enter\n");
            Console.ReadLine();
            Console.WriteLine("You start to panic!!!!!!!!!          Hit Enter\n\n");
            Console.ReadLine();
            Console.WriteLine("Your eyes finally start to ajust to the darkness and you see your a Large wooden door infront of you.\n");
            Console.WriteLine($"Do you wish to open the door? Please type 'yes' or 'no.\n");

            string pathAns = Console.ReadLine().Trim().ToLower();

            while (pathAns.Trim().ToLower() != "yes")

                if (pathAns.Trim().ToLower() == "")
                {
                    pathAns = Console.ReadLine().Trim().ToLower();
                }

                else if (pathAns.Trim().ToLower() == "no")
                {
                    Console.WriteLine("\nYou continue to stand in the dark. Are you sure you don't want to open the door? Please type 'yes' or 'no'.");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }

                else if (pathAns.Trim().ToLower() != "no")
                {
                    Console.WriteLine("\nYou are too worried to think about anything other than yes or no. You're still standing in the dark. Are you sure you don't want to open the door? Please type 'yes' or 'no'.");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }

            Console.Clear();
            Console.WriteLine("\nYou open the door an are instantly blinded by the light.\n\nAs your eyes adjust to the light you see that you are in a hallway...          Hit Enter\n\n");
            Console.ReadLine();
            Console.WriteLine("With nowhere else to go you begin to walk forward down the hall.\n");
            Console.WriteLine("After A few minutes of walking down the hall you come accross a split in the paths.\n\nIt's not long and you can see the path connects back together in just a few hundred meters.\n");

            var hp = 50;
            int monstdam = 10;


            while (pathAns.Trim().ToLower() != "left")
                if (pathAns.Trim().ToLower() == "right")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please type the direction you would like to go...            'left' or 'right'");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }
            if (pathAns.Trim().ToLower() == "left")
            {
                Console.WriteLine("\nYou begin walking down the left hall...          Hit Enter\n");
                Console.ReadLine();
                Console.WriteLine("'CLICK'\n\n\nYou look down to see you stepped on a wire...\n\nA mecanical noise begins echoing from the walls.\n\nSuddenly a dart shoots from the wall and hits you in the leg.\n\nYou begin to run toward the end of the hallway.\n\nbut a few more darts hit your arm.\n\nYou finally reach the end of the hall where the two paths rejoin.\n\nThe Darts have stopped but you're not unscathed.\n\n'You have lost 5 hitpoints.'\n");
                hp -= 5;
            }
            else
            {
                Console.WriteLine("\nYou begin walking down the right hall...          Press Enter\n");
                Console.ReadLine();
                Console.WriteLine("As you walk down the hall you nervously look around.\n\nYou see nothing in particular that stands out.\n\nYou make it to the end of the hall where the path rejoins... \n\nWondering why the path even split to begin with. ");
            }

            Console.WriteLine("\nAgain you see there is only one path forward.\n\nYou begin to walk forward down the hall.\n\nHit Enter\n\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("After walking down this hall for what feels like hours you start to feel tired.\n\nDo you wish to take a nap?");

            do
            {
                if (pathAns.Trim().ToLower() == "yes")
                {
                    Console.WriteLine("\nYou decide against your better judgement to take a nap here in this cold long hallway\n\nYou lay down against the wall and in a mere secounds your out cold\n\n\n\nYou suddenly snap awake and look around. Everything seems the same as before you fell asleep.\n\nYou're not sure how long you have been out but you feel much better.\n\n'You have gained 10 hitpoints!'");
                    hp += 10;
                    break;
                }
                else if (pathAns.Trim().ToLower() == "no")
                {
                    Console.WriteLine("\nThere is no way you are taking a nap in this place. You shake off that tired felling an push on.       Hit Enter\n\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease answer 'yes' or 'no'.");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }

            }
            while (pathAns.Trim().ToLower() != "notsure");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYou continue on walking down the hall for about an hour and you come accross a large room.\n\nThis room has another split in the paths.\n\nThis time, you can't see whether they connect back together or not.\n\nOn the floor of this room you see a spiral.\n\nHit Enter");
            Console.ReadLine();

            var randRoll = new Random();
            int userRoll = randRoll.Next(1, 21);


            while (pathAns.Trim().ToLower() != "right")
            {
                if (pathAns.Trim().ToLower() == "left")
                {
                    Console.WriteLine("You enter the left hallway and walk for a few minutes.\n\nAs you continue walking you begin to feel dizzy.\n\nThe hall begins to feel like it is spinning.");
                    userRoll = randRoll.Next(1, 21);

                    while (userRoll <= 5)
                    {
                        Console.WriteLine("You stumble to the ground, the spinning is too much and you cant get up\n\n Hit Enter");
                        Console.ReadLine();
                        userRoll = randRoll.Next(1, 21);
                    }

                    Console.WriteLine("\nDo you wish to turn back?            'Yes' or 'No'");
                    pathAns = Console.ReadLine().Trim().ToLower();
                    if (pathAns.Trim().ToLower() == "no")
                    {
                        userRoll = randRoll.Next(1, 21);
                        while (userRoll <= 5)
                        {
                            Console.WriteLine("\nYou stumble to the ground, so much spinning! Must.. Head..  Back..     Hit Enter\n\n");
                            Console.ReadLine();
                            userRoll = randRoll.Next(1, 21);
                        }
                        Console.WriteLine("\nYou fight off the dizzyness! Knowing you can't go further you turn back.");


                    }
                    else if (pathAns.Trim().ToLower() == "yes")
                    {
                        Console.WriteLine("\nYou're dizzy but you successfully begin to head back the way you came.\n\nYou make it back to the split.\n");
                        Console.WriteLine("\nPlease type the direction you would like to go...            'left' or 'right'");
                        pathAns = Console.ReadLine().Trim().ToLower();

                    }
                    else
                    {
                        Console.WriteLine("Unsure of whether to head back or not, you decide to stay on the safe side and turn around.");

                    }
                }
                else
                {
                    Console.WriteLine("\nPlease type the direction you would like to go...            'left' or 'right'");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }
            }
            Console.WriteLine("\nYou enter the right hallway and walk for a few minutes. As you walk forward you see a door.\n\nYou begin to open the door when there is a bright light and a loud bang!!!!\n\n\n\nAs you open your eyes you see...\n\n\n\n\n\n\nHit Enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("         CONFETTI!!!!\n\n\nAnd a sign the says 'Congrats you made it through this far, but there is still a way to go.'\n");

            Console.WriteLine("Well once again it is time to continue forward down the path.\n\nA few minutes into walking and you come accross a set of stairs.\n\nDo You wish to go 'up' or 'down'");
            pathAns = Console.ReadLine().Trim().ToLower();

            if (pathAns.Trim().ToLower() == "up")
            {
                Console.WriteLine("You begin heading up the stairs.\n\nAbout halfway up you hear a crack!\n\nThe step breaks below you.\n\nYou look for something to grab but there is nothing\n\n\nYou begin to fall.      Hit Enter");
                Console.ReadLine();
                Console.WriteLine("You fall to the bottom of the stairs, crashing all the way down.\n\nI guess you will have to go downstairs.\n\n'You have just lost 10 Hitpoints'\n");
                hp -= 10;
            }
            else if (pathAns.Trim().ToLower() != "down")
            {
                Console.WriteLine("Unsure of whether to head up or down, you decide to go up.");
                Console.WriteLine("You begin heading up the stairs.\n\nAbout halfway up you hear a crack!\n\nThe step breaks below you.\n\nYou look for something to grab but there is nothing\n\n\nYou begin to fall.      Hit Enter");
                Console.ReadLine();
                Console.WriteLine("You fall to the bottom of the stairs, crashing all the way down.\n\nI guess you will have to go downstairs.\n\n'You have just lost 10 Hitpoints'\n");
                hp -= 10;
            }
            Console.WriteLine("You begin to head down the stairs.\n\nWith each step you wonder if you made the right choice.\n\nAt the bottom of the steps you see the path now heads begins to head forward at a slight incline.\n\nHit Enter");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("After walking you again come to a room with two doors.\n\nThere is a sign that says 'Please choose a room to wait in.\n\n");
            while (pathAns.Trim().ToLower() != "right")
                if (pathAns.Trim().ToLower() == "left")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please pick a room to wait in...            'left' or 'right'");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }
            if (pathAns.Trim().ToLower() == "right")
            {
                Console.WriteLine("\nYou walk into the right room and begin to wait...          Hit Enter\n");
                Console.ReadLine();
                Console.WriteLine("After waiting for an hour or so you begin to hear a hissing.\n\n\nA strange gas begins to fill the room...\n\nYou begin choking and you run for the room's door... Its locked.\n\nYou begin to lose consciousness.\n\n\n\n\n\nYou wake up on the floor in pain with new boils on your skin.\n\nThe door is open and it is a new path yet again.\n\n'You have lost 15 hitpoints.'\n");
                hp -= 15;
            }
            else
            {
                Console.WriteLine("\nYou walk into the left room and begin to wait...          Hit Enter\n");
                Console.ReadLine();
                Console.WriteLine("After waiting for an hour or so you begin to hear a hissing.\n\n\nA strange gas begins to fill the room...\n\nYou run for the room's door... Its locked.\n\nYou begin to lose consciousness.\n\n\n\n\n\nYou wake up on the floor with a blanket and some food to eat.\n\nThe door is open and it is a new path yet again.\n\n'You have gained 10 hitpoints.'\n");
                hp += 10;
            }

            Console.WriteLine("You begin to walk down the new hallway.      Hit Enter");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You walk a few minutes and see a door with a sign\n\nIt says 'Enter and face a powerful beast that hasn't eaten in 3 Months or wait here and see what happens.'\n\nHit Enter");
            Console.ReadLine();
                         
             Console.WriteLine("Please type the word 'enter' or 'wait'");
             pathAns = Console.ReadLine().Trim().ToLower();


            if (pathAns.Trim().ToLower() == "wait")
            {
                Console.WriteLine("You decide to wait rather than fight a starving beast.\n\nA few minutes into waiting you hear a click.\n\nDarts shoot from the wall and stab you in the leg.\n\nYou run throught the door anyway.\n\n'You lose 5 hitpoints.'\n\n");
                hp -= 5;
            }
            else if (pathAns.Trim().ToLower() == "enter")
            { }

            else 
                Console.WriteLine("Unsure, you end up waiting rather than fight a starving beast.\n\nA few minutes into waiting you hear a click.\n\nDarts shoot from the wall and stab you in the leg.\n\nYou run throught the door anyway.\n\n'You lose 5 hitpoints.'\n\n");
            hp -= 5;



            Console.WriteLine("Apon entering the door you walk forward.\n\nYou see no beast... but you stay on your guard.\n\nThen you see it...       Hit Enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("In front of you lying on the ground is a dead lion.\n\nClearly it had been starved.\n\nYou wonder why you are here but proceed on.\n\nHit Enter");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nYou continue on walking down the hall for about an hour and you come accross a large room.\n\nThis room has another split in the paths.\n\nThis all seems very familiar!\n\nOn the floor of this room you see a mirror. It is reflecting the ceiling which is decorated with a spiral.\n\nHit Enter");
            Console.ReadLine();

            while (pathAns.Trim().ToLower() != "left")
            {
                if (pathAns.Trim().ToLower() == "right")
                {
                    Console.WriteLine("You enter the right hallway and walk for a few minutes.\n\nAs you continue walking you begin to feel dizzy.\n\nThe hall begins to feel like it is spinning.");
                    userRoll = randRoll.Next(1, 21);

                    while (userRoll <= 3)
                    {
                        if (hp >= 1)
                        {
                            Console.WriteLine("You stumble to the ground, the spinning is too much and you cant get up.\n\nDarts start shooting from the walls.\n\nA few hit you!\n\n'You lose 5 hitpoints'\n\nHit Enter");
                            Console.ReadLine();
                            hp -= 5;
                            userRoll = randRoll.Next(1, 21);
                        }
                        else
                        {
                            while (hp <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You have died because your hitpoints have reached zero or below\n\n Please exit the window.");
                                Console.ReadLine();
                            }
                        }
                    }

                    Console.WriteLine("\nDo you wish to turn back?            'yes' or 'no'");
                    pathAns = Console.ReadLine().Trim().ToLower();
                    if (pathAns.Trim().ToLower() == "no")
                    {
                        userRoll = randRoll.Next(1, 21);
                        while (userRoll <= 5)
                        {
                            if (hp >= 1)
                            {
                                Console.WriteLine("\nYou stumble to the ground, so much spinning!\n\nThe poison is building up!\n\n'You lose 10 hitpoints.'\n\n Must.. Head..  Back..     Hit Enter\n\n");
                                Console.ReadLine();
                                hp -= 10;
                                userRoll = randRoll.Next(1, 21);
                            }
                            else
                            {
                                while (hp <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You have died because your hitpoints have reached zero or below\n\n Please exit the window.");
                                    Console.ReadLine();
                                }
                            }
                        }
                        Console.WriteLine("\nYou fight off the dizzyness! Knowing you can't go further you turn back.");


                    }
                    else if (pathAns.Trim().ToLower() == "yes")
                    {
                        Console.WriteLine("\nYou're dizzy but you successfully begin to head back the way you came.\n\nYou make it back to the split.\n");
                        Console.WriteLine("\nPlease type the direction you would like to go...            'left' or 'right'");
                        pathAns = Console.ReadLine().Trim().ToLower();

                    }
                    else
                    {
                        Console.WriteLine("Unsure of whether to head back or not, you decide to stay on the safe side and turn around.");

                    }
                }
                else
                {
                    Console.WriteLine("\nPlease type the direction you would like to go...            'left' or 'right'");
                    pathAns = Console.ReadLine().Trim().ToLower();
                }
            }
                Console.WriteLine("\nYou enter the left hallway and walk for a few minutes. As you walk forward you see a door.\n\nYou begin to open the door when there is a bright light and a loud bang!!!!\n\n\n\nAs you open your eyes you see...\n\n\n\n\n\n\nHit Enter");
                Console.ReadLine();
                Console.WriteLine("Another sign!!\n\nThis one reads 'Congrats on making it this far. You have reached the final stage.'\n\nYou walk forward wondering what the final stage will look like.\n\nHit Enter");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("As you walk down the final hallway you begin to hear growling.\n\nHit Enter");
                Console.ReadLine();
                Console.WriteLine("You come across a Minotaur!!!\n\nThere are bone and bodies scattered all accross the room.\n\nThere is an open door at the end of the room.\n\nDo you wish to try to run or fight\n\n");


                int enemyRoll = randRoll.Next(1, 21);
                bool outcomeRun = (enemyRoll + 10 >= userRoll);
                bool outcomeFight = (enemyRoll - 5 >= userRoll);

                while (pathAns.Trim().ToLower() != "run")
                {
                    if (pathAns.Trim().ToLower() == "fight")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please type if you would like to...            'run' or 'fight'");
                        pathAns = Console.ReadLine().Trim().ToLower();
                    }

                }
                    if (pathAns.Trim().ToLower() == "run")
                    {
                        Console.WriteLine("\nYou try to run past the beast, its fast!\n\nYou try to manuver through all the bodies littering the floor.\n\nHit Enter\n");
                        Console.ReadLine();
                        userRoll = randRoll.Next(1, 21);
                        enemyRoll = randRoll.Next(1, 21);

                        while (outcomeRun == true && hp > 0)
                        {
                            hp -= monstdam;

                            Console.WriteLine($"The Beast grabs you and throughs you back!\n\n'You lose 10 hitpoints'\n");
                            enemyRoll = randRoll.Next(1, 21);
                            userRoll = randRoll.Next(1, 21);
                            outcomeRun = (enemyRoll + 10 >= userRoll);
                        }
                        if (hp <= 0)
                        {
                            Console.WriteLine("You again are thrown back this time the beast charges you.\n\nYou try to dodge but there just isnt enough time.\n\nIt slams you into the wall and everything goes dark. You have died.\n\nHit Enter\n");
                            Console.ReadLine();
                            Console.Clear();
                         while (hp <= 0)
                         {
                        Console.WriteLine("You have died because your hitpoints have reached zero or below\n\n Please exit the window.\n");
                        Console.ReadLine();
                         }
                        }
                        else outcomeRun = false;
                        Console.WriteLine("You succesffully dodge the beast and run through the open door.\n\nYou slam it shut. You hear the beast screeching through the door.\n");

                    }

                    else if (pathAns.Trim().ToLower() == "fight")
                    {
                        Console.WriteLine("\nYou try to fight the beast, its fast!\n\nYou grab a sharp bone to use as a weapon.\n\nYou try to manuver through all the bodies littering the floor.\n\nHit Enter");
                        Console.ReadLine();
                        userRoll = randRoll.Next(1, 21);
                        enemyRoll = randRoll.Next(1, 21);

                        while (outcomeFight == true && hp > 0)
                        {
                            hp -= monstdam;

                            Console.WriteLine($"The Beast grabs you and throughs you back!\n\n'You lose 10 hitpoints'\n");
                            enemyRoll = randRoll.Next(1, 21);
                            userRoll = randRoll.Next(1, 21);
                            outcomeRun = (enemyRoll - 5 >= userRoll);
                        }
                        if (hp <= 0)
                        {
                            Console.WriteLine("You again are thrown back this time the beast charges you.\n\nYou try to dodge but there just isnt enough time.\n\nIt slams you into the wall and everything goes dark. You have died.\n\nHit Enter\n");
                            Console.ReadLine();
                            Console.Clear();
                         while (hp <= 0)
                         {
                        Console.WriteLine("You have died because your hitpoints have reached zero or below\n\n Please exit the window.\n");
                        Console.ReadLine();
                          }
                        }
                        else outcomeRun = false;
                        Console.WriteLine("You succesffully stab the beast in the heart with your weapon.\n\nIt collapes to the ground... It is dead.\n\n You wonder to the open door in the back of the room.\n\nYou slam it shut. You don't want to take any chances.\n");

                    }

            Console.WriteLine("\nYou have made it past the final stage!!!\n\nYou walk forward up the final tunnel.\n\nYou see sunlight ahead\n\nYou feel the breeze hit your skin.\n\nNow its time to figure out where you are?\n\nHit Enter\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Congrats on surviving the Maze!!!\n\nPlease exit the window.\n");
            

                
            
        }   
    }     
}

