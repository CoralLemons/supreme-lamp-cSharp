using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // invoke intro for user
            Character user = startGameIntro();

            // placeholder to keep console open for now :)
            Console.WriteLine("Congrats! You have a piece of paper! What does it say?");
            Console.Read(); // keep console open for a sec


        }// end main

        private static Character startGameIntro() {
            // get character name
            Console.WriteLine("You awake in a dark and foggy meadow near a small pond. Your right arm is submerged in the water\nand you stare at your reflection, trying to remember how you got here.\nWhat do you want to call yourself?");
            String name = Console.ReadLine();
            int i = 0;
            while (name == null && i < 5) {
                Console.WriteLine("Hm, I see you didn't enter a name. Let's try this again");
                name = Console.ReadLine();
                i++; //if loops 5 times, give pre-made name
            }// loop until character has a name or premade flag is declared

            if (name == null) {
                name = "Albatross the Strange";
            }// give premade name

            Console.WriteLine("Oh, hello there " + name + " let's begin your adventure.");

            // get character description
            Console.WriteLine(name + " staggers onto their feet and cannot help but to linger near the pond, confused as to what has transpired.\n\"If I can study my reflection long enough, maybe I can figure out who I am...\"\nWhat does " + name + " see?");
            String description = Console.ReadLine();
            int j = 0;
            while (description == null && i < 3)
            {
                Console.WriteLine("Hm, I see you didn't enter a description of what your character looks like. Let's try this again");
                description = Console.ReadLine();
                j++; //if loops 3 times, give pre-made description
            }// loop until character has a description or premade flag is declared

            if (description == null)
            {
                description = "A very strange person that couldn't even describe their own reflection. What happened to them?...";
            }// give premade description

            // get weapon and dmg 
            Console.Write("\n\n" + name + " decides it is time to leave the mysterious meadow and figure out how they got here in the first place.");
            Console.Write("\nDeciding where to go was not difficult, there was only one path leading to and from this area so that is where " + name + " went.");
            Console.Write("\nSome time passes, potentially a single hour but it felt significantly longer from the fatigue and pulsating migraine\nbut luck was on your side as you come to a small village where the faded sign reads \"Dry Gulch\", how ironic.");
            Console.Write("\nThe town seems very empty with most buildings in extremely poor condition aside from the inn, so you go there to see if anyone remembers you from the night before");
            Console.Write("\nSurprisingly, the inn is a bit busy with about two dozen rowdy people all grouped together and a mean looking innkeeper who seems to barely tolerate the crowd simply for the large profit");
            Console.Write("\nYou make your way past the group of large men, about twice your weight, of whom many are drinking the foulest beer you've ever smelled and pinch your nose in disgust");
            Console.Write("Finally making it to the counter, you see the innkeeper staring down the group of men and grumbling under his breath but cannot make out what he said\n\n");

            Console.WriteLine("You pause for a moment, knowing only about this man from your short observations, thinking about how to speak to him:\n" +
                "A) Snap your fingers in-front of his face to get his attention and start rambling off questions, " +
                "B) Introduce yourself and ask if you have been in here before, " +
                "C) Make a comment about the loudmouth guests and talk about how people should have some respect");

            String choice = Console.ReadLine(); // grab A||B||C from user 
            String weapon;
            int weaponDmg;

            switch (choice) {
                case "A":
                    Console.WriteLine("The innkeeper's eyes widen and he stares at you like he's trying to squish your head with his imagination as you ramble on.\"HAVE YOU LOST YOUR MIND?!\" Without another word, the group of men you passed gather around you and haul you out of the inn.");
                    Console.WriteLine("You decide to not go back inside, that was very embarrasing and everyone is visibly upset. While on your butt, you look around and spot a broken dagger sticking out of a hay bale, might as well grab it for your journey.");
                    weapon = "Broken Dagger";
                    weaponDmg = 2;
                    break;
                case "B":
                    Console.WriteLine("Innkeeper directs his attention toward you and his face softens a bit before realizing who you are. \"" + name + " you say? Had so much fun you had to come back for more, eh? " +
                        "Your friend left a note, but he also left a bill so hows about paying the tab and I'll pass you the paper and the gift he left. How does say... 5 coins sound?\" You look into your pocket and see 10 shiny coins. (\"Y/N\")");
                    String nextChoice = Console.ReadLine();
                        if (nextChoice == "Y")
                        {
                        Console.WriteLine("Inkeeper grins and holds out his hand and waits for all the coins you agreed to give then reaches under the counter and grabs a wrinkled piece of paper tied to a sheathed weapon." +
                            " \"Pleasure doing business, now if you don't mind I have people-watching to do.\" He waves his hand in a 'shooing' motion");
                        weapon = "Sword";
                        weaponDmg = 5;
                        }   
                        else {
                        Console.WriteLine("Inkeeper huffs and shrugs then he hands you the paper but keeps the gift. \"I can sell the weapon for more anyway, take the stupid paper. Now, if you don't mind I have people-watching to do.\" He waves his hand in a 'shooing' motion");
                        weapon = "Fists";
                        weaponDmg = 1;
                        }// no
                    break;
                case "C":
                    Console.WriteLine("Innkeeper directs his attention toward you scoffs at the remark. \"You don't remember how terrible of a customer you were, huh? I guess you're here about the note your friend left. "+
                        "I mean, he DID leave a note, but he also left a bill so hows about paying the tab and I'll pass you the paper and the gift he left. How does say... 10 coins sound?\" You look into your pocket and see 10 shiny coins. (\"Y/N\")");
                    String otherChoice = Console.ReadLine();
                    if (otherChoice == "Y")
                    {
                        Console.WriteLine("Inkeeper grins and holds out his hand and waits for all the coins you agreed to give then reaches under the counter and grabs a wrinkled piece of paper tied to a sheathed weapon." +
                            " \"Pleasure doing business, now if you don't mind I have people-watching to do.\" He waves his hand in a 'shooing' motion");
                        weapon = "Sword";
                        weaponDmg = 5;
                    }
                    else
                    {
                        Console.WriteLine("Inkeeper huffs and shrugs then he hands you the paper but keeps the gift. \"I can sell the weapon for more anyway, take the stupid paper. Now, if you don't mind I have people-watching to do.\" He waves his hand in a 'shooing' motion");
                        weapon = "Fists";
                        weaponDmg = 1;
                    }// no
                    break;
                default: // if A||B||C was not picked, default dialogue
                    Console.WriteLine("The innkeeper directs his gaze toward you, looks you up and down, then huffs.\"Can I help you buddy? I noticed you've been staring at me, I'm trying to keep an eye on these guys after what happened last night. " +
                        "Say, you kinda look like one of the hooligans I had to deal with. What's your name?\" He squints his eyes and takes a step back to get a better look from a distance. Oh I remember you... I think you should leave.");
                    weapon = "Fists";
                    weaponDmg = 1;
                    break;
            }// user weapon and starting info depends on how they talked to innkeeper

            // String inName, String inDesc, String inStartingWeapon, int inWeaponAtk
            Character character = new Character(name, description, weapon, weaponDmg);
            return character;
        }// end startGame -- return to main the character created by user

    }// end Program class

}// end namespace
