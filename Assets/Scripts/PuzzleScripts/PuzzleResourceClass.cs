﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
// Author: PopeSpacious(GitHub)
// Date: 11/04/2018
/* Summary: This is a resource class that works as a functor. It is used in the Tangram, Anagram and Cryptogram puzzles.
 * This data used to be in files but in order for it to work on OpenGL the data had to be internal to the program
*/

public class PuzzleResourceClass
{
	//passes a list of 4 lettered objects back
	public List<string> GetFour() {
		string []myList = {"APEX", "AQUA","ARTS","BABY","BACK","BAKE","BIRD","BOLD","BOLT","BONE","BOOT","BOXY","BUCK","BUFF","BULB","BUMP","BUZZ",
		"CAKE","CAMP","CART","CATS","CHEW","CHIP","CHOP","COAX","COLD","COMB","COME","CONE","COOK","COZY","CREW","CROW","CURD","DEAD",
		"DOCK","DOGS","DOJO","DOME","DONE","DOZY","DUCK","DUMP","EXAM","FAIL","FAKE","FAUX","FAZE","FIRE","FIZZ","FLAX","FLEX","FLIP","FLUX",
		"FOLD","FOXY","FROG","FROM","FUNK","FUZZ","GAZE","GLUE","HACK","HATS","HAWK","HAZE","HAZY","HEAD","HERO","JACK","JADE","JAIL","JAMS",
		"JAVA","JAWS","JAZZ","JEEP","JERK","JETS","JINX","JIVE","JOBS","JOCK","JOKE","JOLT","JUGS","JUKE","JUMP","JUNK","JURY","JUST","KICK",
		"KING","KIWI","KNEW","KNOB","KNOW","KYAK","LAID","LAKE","LAZY","LICK","LINK","LOAN","LOCK","LONE","LOOT","LUCK","LUMP","LYNX","MAIL",
		"MAZE","MENU","MILK","MINX","MIST","MOCK","MONK","MUCH","MUCK","MUST","NAME","NECK","NEWS","NEWT","NEXT","NICE","NOON","NUMB","OATS",
		"ONYX","OOZE","PACK","PAID","PAIN","PART","PECK","PICK","PINK","PIXY","PLAN","POKE","PUCK","PUMP","PUNK","QUIT","QUIZ","RAID","RAKE",
		"RATS","RAZE","RICE","RIDE","RINK","RISK","ROCK","ROME","ROOM","ROOT","RUBY","SAID","SINK","SIZE","SNOW","SOCK","SOLD","SOOT","SWAN",
		"TAIL","TAKE","TALE","TICK","TOES","TOLD","TOMB","UNIT","URNS","USED","VERY","VIAL","VINE","VOID","WALK","WART","WAVY","WAXY","WHIM",
		"WHIP","WHIZ","WICK","WIFE","WIMP","WINK","WORD","ZEAL","ZERO","ZINC","ZIPS","ZONE","ZOOM"};
		return new List<string>(myList);
	}
	//passes a list of 5 lettered objects back
	public List<string> GetFive() {
		string []myList = {"ABODE","ADORN","AFFIX","ALARM","AMAZE","APPLE","ARROW","BLIMP","BLOCK","BONES","BOXER","BOXES","BRICK","BRINE","BROKE",
		"BROWN","BUGGY","BULKY","CANDY","CHALK","CHAMP","CHIMP","CHOMP","CHUCK","CIVIC","CLICK","CLOCK","CLOWN","CLUCK","CORGI","COZEY","CRACK",
		"CRAMP","CRAZE","CRAZY","CROOK","CROWN","CRUMB","CUBBY","CUBIC","CUFFS","CURSE","CYBER","DADDY","DODGE","DONUT","DRUMS","DUMMY","ENJOY",
		"ENZYM","EQUAL","ERUPT","EXAMS","EXILE","FAZED","FEAST","FERRY","FIELD","FIFTH","FIHGT","FIZZY","FJORD","FLAKE","FLAME","FLANK","FLICK",
		"FLUNK","FLUTE","FOGGY","FROGS","FROST","FUNKY","FUZZY","GHOUL","GLAZE","GLOOM","GRAND","GROWN","GRUMP","GUILD","GUMMY","GUPPY","HAPPY",
		"HAUNT","HEIST","HELIX","HELLO","HERTZ","HIPPO","HOBBY","HOUSE","INPUT","JADED","JAPAN","JAZZY","JELLY","JERKS","JEWEL","JOCKS","JOKER",
		"JOKES","JOLLY","JOYED","JUKED","JUMPS","JUMPY","JUNKY","KAZOO","KEBOB","KEMPT","KIOSK","KITTY","KNACK","KNIFE","LEARN","LEGAL","LEMON",
		"LIGHT","LIMBO","LIVID","LOTTO","LOYAL","LUCKY","LUMEN","LUMPY","MACAW","MAJOR","MARCH","MAYBE","MAZES","METER","MIMIC","MINOR","MIXED",
		"MOMMY","MULCH","MURAL","NINJA","NYMPH","ORDER","OZONE","PILLS","PINKY","PIXEL","PIXIE","PIZZA","PLUMP","POPPY","PUCKS","PUNCH","PUPPY",
		"QUADS","QUAIL","QUAKE","QUEEN","QUEST","QUICK","QUILT","QUIRK","QUITE","QUOTE","ROGUE","SHOOT","SKULK","SKULL","SKUNK","SMELL","SMOKE",
		"SNACK","SNEAK","SOLVE","SQUAD","SQUID","STORM","STRAW","SUPER","SWAMP","SWELL","SWORD","THIEF","THROW","TRADE","TRASH","TREAT","TRICK",
		"TRUMP","UNBOX","UNCUT","UTTER","VOTES","VOWEL","WALTZ","WATCH","WHALE","WILDS","WONKY","WORLD","YODLE","YOUTH","ZESTY"};
		return new List<string>(myList);
	}
	//passes a list of 6 lettered objects back
	public List<string> GetSix() {
		string []myList = {"ABDUCT","ABROAD","ACCENT","ACCEPT","ACCESS","ACHING","ACIDIC","ACTING","ACTION","ACTIVE","ACTORS","ADAPTS","ADDICT","ADDING",
		"ADMIRE","ADVICE","AFFORD","AFFRAID","AGENDA","ALASKA","ALBUMS","ALWAYS","BANANA","BANJOS","BANKER","BANZAI","BARKED","BASICS","BASKET",
		"BATTER","BEARDS","BEATEN","BEETLE","BEFORE","BELIEF","BELUGA","BIKERS","BILLOW","BINDER","BOOGER","BORDER","BRONZE","BUSHES","CAESAR",
		"CASHEW","CHAPEL","CHEEKY","CHOOSE","CHROME","DEEPEN","DEFECT","DELUXE","DEPUTY","DIPPER","DOCTOR","DONKEY","DOUGHY","DRAPED","DRUIDS","EMBERS",
		"EMPIRE","EMPLOY","EQUIPS","FAMOUS","FARMER","FEEBLE","FESTER","FICKLE","FIDDLE","FILTER","FROLIC","FUTURE","GASKET","GHOSTS","GOBLET","GREASE",
		"GRUMPY","GUILTY","HACKED","HUDDLE","HUMBLE","ICECAP","ICONIC","IGLOOS","IGNORE","IMPACT","INGOTS","JOGGER","JOKERS","JOYFUL","JUICED","KABABS",
		"KELPIE","KELVIN","KENNEL","KIDNAP","KILLED","KIMCHI","KITTEN","LAUGHS","LAWFUL","LEAGUE","LETTER","LLAMAS","MANGOS","MANTLE","MANTRA","MARROW",
		"MATRES","MITTEN","MOHAWK","MORTAL","NATIVE","NEURON","NEWEST","NEWTON","NOSILY","NOVICE","OCELOT","ODDEST","OMELET","OPTION","ORANGE","ORIGIN",
		"ORPHAN","OTTERS","PAINTS","PARCEL","PARLEY","PARODY","PARROT","PATENT","PAYING","PEDDLE","PERIOD","PHOTON","PINCER","POETRY","POISON","POWERS",
		"PRAISE","PYTHON","QUARTZ","QUIRKS","QUOTES","RABBIT","RADISH","RANDOM","RAPTOR","RAREST","RAVENS","RECALL","SCARFS","SCHOOL","SCYTHE","SEDUCE",
		"SELECT","SENSOR","SERIAL","SHANTI","SHOWER","SILVER","SINGED","SISTER","SLOGAN","SMOOTH","SOLIDS","STAPLE","TARGET","TAUGHT","TEACUP","THINGS",
		"THRILL","TICKET","TOKENS","TOONIE","TOWERS","TOXINS","TRENCH","TROPHY","TWENTY","UNCOIL","UNPACK","UNSUNG","UNWRAP","UPTIME","USEFUL","VERIFY",
		"VIABLE","WANTED","WEAKEN","WEAPON","WHIMSY","WIGGLE","WINDED","WINTER","WRAITH","YOGURT","ZEPHYR","ZIPPER"};
		return new List<string>(myList);
	}
	//passes all coordinates for difficult tangrams
	public string GetTanDiff() {
		string myList = "-7.3705,-0.13,0,180,0:-8.8705,-1.63,0,270,0:-9.1705,4.17,0,225,0:-7.8705,1.87,0,135,0:-5.7705,1.87,0,135,0:-7.3705,3.47,0,135,0:-9.3705,2.37,0,180,0;"+
		"-7.0705,-1.13,0,180,0:-9.9705,-1.13,0,0,0:-7.9705,3.47,0,0,0:-5.5705,-1.83,0,0,0:-6.4705,1.07,0,0,0:-7.9705,1.37,0,225,0:-4.0705,-1.13,0,225,0;"+
		"-9.7705,0.67,0,225,0:-7.6705,2.17,0,45,0:-6.5705,4.27,0,0,0:-7.9705,-1.03,0,90,0:-5.0705,1.87,0,90,0:-9.3705,-1.43,180,224,1:-5.7705,0.47,0,315,0;"+
		"-9.7705,0.67,0,225,0:-7.6705,-1.53,0,225,0:-6.6705,4.87,0,0,0:-8.1705,3.27,0,45,0:-10.1705,-1.13,0,180,0:-7.6705,1.67,180,315,1:-5.5705,2.77,0,0,0;"+
		"-7.4705,-1.53,0,0,0:-7.4705,1.47,0,180,0:-7.4705,-4.03,0,180,0:-8.1705,-0.03,0,270,0:-6.7705,-0.03,0,90,0:-9.6705,0.67,180,90,1:-7.4705,3.97,0,0,0;"+
		"-6.6705,1.27,0,90,0:-9.2705,-0.63,0,225,0:-4.1705,-0.73,0,270,0:-7.4705,2.77,0,270,0:-7.4705,-0.23,0,270,0:-4.4705,2.07,180,270,1:-6.7705,-1.63,0,135,0;"+
		"-7.1705,1.47,0,135,0:-9.2705,-0.63,0,225,0:-9.2705,2.47,0,270,0:-4.5705,1.97,0,315,0:-5.5705,-0.13,0,45,0:-6.1705,3.57,180,45,1:-7.1705,-0.63,0,180,0;"+
		"-8.1705,3.47,0,0,0:-8.3705,-1.13,0,315,0:-6.1678,-0.03,0,90,0:-9.8705,0.47,0,225,0:-6.7705,1.47,0,45,0:-6.2705,-2.03,0,315,0:-8.3705,0.97,0,270,0;"+
		"-6.7705,2.77,0,315,0:-4.2705,0.87,0,270,0:-7.9705,0.37,0,135,0:-9.4705,1.17,0,90,0:-8.3705,-0.93,0,315,0:-10.9705,0.37,0,180,0:-6.7705,-1.43,0,90,0;"+
		"-7.2705,3.47,0,180,0:-4.3705,3.47,0,0,0:-5.1705,1.27,0,315,0:-5.9705,-0.43,0,135,0:-3.8705,1.47,0,45,0:-7.2705,0.47,180,269,1:-5.4705,-1.93,0,90,0;"+
		"-9.0705,-0.53,0,225,0:-7.9705,3.97,0,90,0:-10.4705,1.17,0,270,0:-5.9705,-0.43,0,135,0:-5.9705,6.17,0,45,0:-7.2705,0.47,180,269,1:-9.4705,2.57,0,135,0";
		return myList;
	}
	//passes all coordinates for Medium difficulty tangrams
	public string GetTanMed() {
		string myList = "-8.3705,-0.13,0,225,0:-6.2705,1.97,0,45,0:-5.2705,4.07,0,0,0:-5.1705,-0.03,0,225,0:-8.9705,2.37,0,45,0:-12.4705,1.87,0,45,0:-10.9705,0.87,0,135,0;"+
		"-7.5705,1.47,0,0,0:-7.4705,-3.53,0,180,0:-6.5705,-1.03,0,0,0:-9.0705,2.27,0,180,0:-6.1705,2.27,0,180,0:-8.5705,-1.03,0,45,0:-7.5705,4.07,0,180,0;"+
		"-5.8705,0.97,0,0,0:-9.9705,-1.13,0,0,0:-7.0705,-1.53,0,180,0:-5.5705,-1.83,0,0,0:-6.8705,5.27,0,0,0:-7.9705,1.37,0,225,0:-6.8705,3.47,0,270,0;"+
		"-9.7705,0.67,0,225,0:-5.4705,-2.83,0,225,0:-6.5705,4.27,0,0,0:-7.9705,-1.03,0,90,0:-5.0705,1.87,0,90,0:-9.3705,-1.43,180,224,1:-5.7705,0.47,0,315,0;"+
		"-7.2705,0.07,0,0,0:-11.1705,4.87,0,45,0:-9.4705,0.87,0,45,0:-10.9705,2.27,0,90,0:-7.6705,3.17,0,45,0:-5.2705,0.57,180,44,1:-9.1705,2.67,0,0,0;"+
		"-5.0705,0.37,0,45,0:-9.9705,0.37,0,315,0:-7.4705,-2.43,0,0,0:-8.1705,-0.03,0,270,0:-6.7705,-0.03,0,90,0:-9.7705,2.17,180,180,1:-7.4705,1.47,0,135,0;"+
		"-6.8705,-1.73,0,270,0:-9.7705,-0.53,0,90,0:-10.5705,1.67,0,45,0:-5.6705,0.67,0,45,0:-6.1705,4.77,0,90,0:-7.2705,1.17,0,315,0:-6.8705,3.27,0,225,0;"+
		"-6.8705,-1.13,0,0,0:-9.8705,-1.13,0,180,0:-8.8705,4.97,0,0,0:-10.3705,3.37,0,315,0:-7.2705,2.37,0,135,0:-9.1705,1.07,180,179,1:-8.8705,2.87,0,270,0;"+
		"-10.6705,-0.63,0,225,0:-6.4705,-0.63,0,135,0:-10.6705,2.57,0,270,0:-4.7705,0.87,0,135,0:-3.7705,-0.13,0,315,0:-9.5705,3.57,180,224,1:-8.5705,1.47,0,270,0;"+
		"-4.3705,2.87,0,45,0:-8.3705,1.17,0,180,0:-6.1705,0.37,0,225,0:-5.9705,-0.83,0,315,0:-11.1705,-1.13,0,0,0:-10.5705,0.37,180,89,1:-2.2705,4.97,0,270,0";
		return myList;
	}

	//passes all coordinates for easy tangrams
	public string GetTanEasy() {
		string myList = "-9.4678,2.27,0,225,0:-7.3678,2.27,0,45,0:-6.1678,-0.13,0,45,0:-10.9678,-3.33,0,225,0:-7.8678,3.87,0,135,0:-7.6678,-1.63,0,270,0:-9.4678,-2.83,0,90,0;"+
		"-9.4678,2.27,0,225,0:-7.3678,2.27,0,135,0:-11.8678,0.47,0,45,0:-11.1678,-1.03,0,0,0:-3.8678,-0.33,0,135,0:-11.9678,3.37,0,270,0:-5.4678,0.17,0,90,0;"+
		"-7.5678,2.87,0,180,0:-5.2678,-2.43,0,180,0:-9.7678,-0.93,0,135,0:-6.6678,-3.23,0,0,0:-3.8678,-0.33,0,135,0:-9.7678,2.07,180,89,1:-5.4678,0.17,0,90,0;"+
		"-11.5678,1.07,0,45,0:-5.2678,1.07,0,315,0:-7.2678,2.87,0,225,0:-8.3678,1.27,0,0,0:-5.9678,2.67,0,135,0:-11.5678,-2.03,180,135,1:-11.5678,3.17,0,90,0;"+
		"-10.1678,-0.43,0,135,0:-7.9678,-2.93,0,180,0:-6.9678,1.37,0,225,0:-10.6678,3.27,0,135,0:-9.7678,2.07,0,180,0:-7.0678,-0.43,180,45,1:-9.6678,4.87,0,135,0;"+
		"-9.8705,0.17,0,0,0:-9.9705,3.17,0,0,0:-5.2705,0.87,0,45,0:-5.2705,-1.33,0,90,0:-8.4705,-2.83,0,135,0:-6.7705,-2.03,0,0,0:-10.0705,-2.33,0,90,0;"+
		"-7.2705,-1.13,0,90,0:-9.7705,-0.53,0,315,0:-8.6705,2.97,0,180,0:-7.9705,-2.63,0,270,0:-8.5705,4.77,0,0,0:-7.9705,1.17,0,270,0:-7.2705,-4.13,0,225,0;"+
		"-7.4705,-2.83,0,135,0:-9.5705,-2.83,0,225,0:-9.3705,3.37,0,0,0:-6.3705,-0.83,0,315,0:-8.8705,1.77,0,45,0:-10.7705,-0.43,180,179,1:-10.4705,1.27,0,270,0;"+
		"-7.9705,-0.63,0,45,0:-7.9705,1.47,0,135,0:-3.8705,0.37,0,90,0:-9.7705,3.17,0,90,0:-10.8705,3.77,0,45,0:-10.0705,-2.53,180,134,1:-10.0705,0.57,0,270,0;"+
		"-10.6705,-0.63,0,225,0:-6.4705,-0.63,0,135,0:-8.5705,-2.73,0,180,0:-11.0705,1.77,0,180,0:-6.0705,1.77,0,180,0:-5.4705,3.27,180,0,1:-8.5705,-0.63,0,270,0;"+
		"-8.1705,-0.33,0,0,0:-8.0705,-3.33,0,0,0:-8.2705,2.17,0,0,0:-5.0705,-4.13,0,180,0:-2.9705,-0.73,0,0,0:-2.8705,-4.13,180,0,1:-2.9705,-2.43,0,180,0";
		return myList;
	}
	
	
	
}

