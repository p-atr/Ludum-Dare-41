using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogue : MonoBehaviour {

	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public GameObject b4;
	public GameObject responseBox;

	private Text text1;
	private Text text2;
	private Text text3;
	private Text text4;
	private Button button1;
	private Button button2;
	private Button button3;
	private Button button4;
	private int cycle = 0;

	private int grilnumber;

	void Start () {
		text1 = b1.GetComponentInChildren<Text> ();
		text2 = b2.GetComponentInChildren<Text> ();
		text3 = b3.GetComponentInChildren<Text> ();
		text4 = b4.GetComponentInChildren<Text> ();

		button1 = b1.GetComponent<Button> ();
		button2 = b2.GetComponent<Button> ();
		button3 = b3.GetComponent<Button> ();
		button4 = b4.GetComponent<Button> ();

		button1.onClick.AddListener(() => SwitchButtonHandler(1));
		button2.onClick.AddListener(() => SwitchButtonHandler(2));
		button3.onClick.AddListener(() => SwitchButtonHandler(3));
		button4.onClick.AddListener(() => SwitchButtonHandler(4));


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SwitchButtonHandler(int buttonNumber){

		if(grilnumber == 0){
			switch (cycle) {
			case 0:
				switch (buttonNumber) {
				case 1:
					respond ("hii");
					break;
				case 2:
					respond ("oh, hey");
					break;
				case 3:
					respond ("I'm great! How about you?");
					break;
				case 4:
					respond ("Not much honestly...");
					break;
				}
				text1.text = "You seem like a bitch!";
				text2.text = "Oh, I like your dress!";
				text3.text = "I don't want to be too direct, but do you have a partner at the moment?";
				text4.text = "Roses are red, Violets are blue, the sunset is pretty, but not prettier than you.";
				break;
			case 1:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("lost");
					break;
				case 2:
					respond ("Thanks! It's my favourite color - blue.");
					break;
				case 3:
					respond ("That's ok... No. My last partner bought me a yellow dress, although he should have known my favourite color is blue!");
					break;
				case 4:
					respond ("Oh, hey, we have a poet over here! Let me try! My favourite color is blue, that's why it's the color of my dress and my shoe.");
					break;
				}
				text1.text = "I also like blue...";
				text2.text = "I like all colors the same.";
				text3.text = "Really? I hate blue.";
				text4.text = "Could we just skip the smalltalk?";
				break;
			case 2:
				switch (buttonNumber) {
				case 1:
					respond ("Then we seem to fit quite nicely. What would you like to drink?");
					break;
				case 2:
					respond ("Oh come on, you have to have favourites to make life interesting. Anyways, what would you like to drink?");
					break;
				case 3:
					respond ("Hm... But opposites attract, don't they! So what would you like to drink?");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				text1.text = "A latte machiato, I think.";
				text2.text = "I drink my coffee black.";
				text3.text = "And then you can spill a little over your shirt?";
				text4.text = "Nothing, thanks. I'm not that into coffee.";
				break;
			case 3:
				switch (buttonNumber) {
				case 1:
					respond ("Ok. Which color of cup do you think I'd like the most?");
					break;
				case 2:
					respond ("Alright. Which color of cup do you think I'd like the most?");
					break;
				case 3:
					SceneManager.LoadScene ("lost");
					break;
				case 4:
					respond ("Really? I don't think I could get up without it. Which color of cup do you think I'd like the most?");
					break;
				}
				text1.text = "Blue of course, since it is your favourite color.";
				text2.text = "Red of course, since it is your favourite color.";
				text3.text = "Green of course, since it is your favourite color.";
				text4.text = "Black of course, since it is your favourite color.";
				break;
			case 4:
				switch (buttonNumber) {
				case 1:
					respond ("Oh, nice you remebered! I'm beginning to like you!");
					break;
				case 2:
					SceneManager.LoadScene ("lost");
					break;
				case 3:
					SceneManager.LoadScene ("lost");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				text1.text = "I... like you too! *kiss*";
				text2.text = "I'm not sure I share the same feelings";
				text3.text = "I like you too. Just as a friend...";
				text4.text = "Woah, that came as a surprise... No, you're not my type.";
				break;
			case 5:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("love");
					break;
				case 2:
					SceneManager.LoadScene ("lost");
					break;
				case 3:
					SceneManager.LoadScene ("lost");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				break;
			default:
				SceneManager.LoadScene ("lost");
				break;
			}

		} else if(grilnumber == 1){
			switch (cycle) {
			case 0:
				switch (buttonNumber) {
				case 1:
					respond ("Oy mate!");
					cycle = 0;
					break;
				case 2:
					respond ("Hello, so how was your day so far?");
					break;
				case 3:
					respond ("Pretty boring i worked the whole day.What about you?");
					break;
				case 4:
					respond ("Im fine, my boss even let me go earlyer for our date, how's your day been?");
					break;
				}
				text1.text = "I woke up at about 9:30 and took a nice and refreshing shower, after that i wanted to eat some cornflakes. But i had no milk and, you know cornflaces without...";
				text2.text = "I dind't do much today i was qite nervous because of our date, so i didn't sleep very well.";
				text3.text = "I pretty much slept until a few houres before our date, because i was awake the whole night playing videogames.";
				text4.text = "Today wasn't very interesting I only filled out a few more divorcepapers.";
				break;
			case 1:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("lost");
					break;
				case 2:
					respond ("Well i had to work the whole day, luckily my boss doesn't notice if i'm playing my favourite game minecraft, anyway do you want a beer?");
					break;
				case 3:
					respond ("I know that, i love to play videogames, but do you want a beer?");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				text1.text = "Beer is for pussys im only drinking alcohol with over 40%!";
				text2.text = "No i dont drink.";
				text3.text = "Of course one or two beer can never be bad!";
				text4.text = "I don't want alcohol to affect our first date.";
				break;
			case 2:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("lost");
					break;
				case 2:
					respond ("Oh that's cool I don't like drunk people. But I don't get out too often so I'm not getting in contact with them too often.");
					break;
				case 3:
					respond ("As long as you not geting drunk, I hate drunk people. But I don't get out too often so I'm not getting in contact with them too often.");
					break;
				case 4:
					respond ("Oh that's cool I don't like drunk people. But I don't get out too often so I'm not getting in contact with them too often.");
					break;
				}
				text1.text = "So why don't you get out too often?";
				text2.text = "Thats perfect, I prefer doing it indoors.";
				text3.text = "I'm not getting out too often too, so what do you do when you're at home?";
				text4.text = "Oh so thats why your skin is so disgustingly pale.";
				break;
			case 3:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("lost");
					break;
				case 2:
					respond ("I love playing videogames especially Minecraft and other survivalgames, thats why. Do you have any favourite Videogames?");
					break;
				case 3:
					respond ("I love playing videogames especially Minecraft and other survivalgames, thats why. Do you have any favourite Videogames?");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				text1.text = "Minecraft, isn't that the game that all the kids play.";
				text2.text = "Yes, I love Jupiter II- Survival.";
				text3.text = "I like playing any videogame.";
				text4.text = "No I hate Gaming.";
				break;
			case 4:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("lost");
					break;
				case 2:
					respond ("I don't know that game, but at least we have something in common, do you want to meet again?");
					break;
				case 3:
					respond ("Wow, thats cool, do you want to meet again?");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				text1.text = "Yes of course.";
				text2.text = "We could play together too.";
				text3.text = "I like you but only as a friend.";
				text4.text = "Sorry but you're not my type.";
				break;
			case 5:
				switch (buttonNumber) {
				case 1:
					SceneManager.LoadScene ("love");
					break;
				case 2:
					SceneManager.LoadScene ("love");
					break;
				case 3:
					SceneManager.LoadScene ("lost");
					break;
				case 4:
					SceneManager.LoadScene ("lost");
					break;
				}
				break;
			default:
				SceneManager.LoadScene ("lost");
				break;
			}
		}
		cycle++;
	}
		

	void respond(string response){
		responseBox.SetActive (true);
		Text txt = responseBox.GetComponentInChildren<Text> ();
		txt.text = response;
	}


}
/* 
1. Hello there.
2. Heeyy!
3. How was your day so far?
4. How are you?

Frage:

1. Oy mate! --> zurück zu begrüssung
2. Hello, so how was your day so far?
3. Pretty boring i worked the whole day.What about you?
4. Im fine, my boss even let me go earlyer for our date, how's your day been?

Antworten:
1. I woke up at about 9:30 and took a nice and refreshing shower, after that i wanted to eat some cornflakes. But i had no milk and, you know cornflaces without...
2. I dind't do much today i was qite nervous because of our date, so i didn't sleep very well.
3. I pretty much slept until a few houres before our date, because i was awake the whole night playing videogames.
4. Today wasn't very interesting i only filled out e few more divorcepapers.

Fragen:
1. lost
2. Well i had to work the whole day, luckily my boss doesn't notice if i'm playing my favourite game minecraft, anyway do you want a beer?
3. I know that, i love to play videogames, but do you want a beer?
4. Lost

Antworten:
1. Beer is for pussys im only drinking alcohol with over 40%!
2. No i dont drink.
3. Of course one or two beer can never be bad!
4. I don't want alcohol to affect our first date.

Fragen:
1.Lost
2. Oh that's cool i don't like drunk people. But i don't get out too often so i'm not getting in contact with them too often.
3. As long as you not geting drunk, i hate drunk people. But i don't get out too often so i'm not getting in contact with them too often.
4. Oh that's cool i don't like drunk people. But i don't get out too often so i'm not getting in contact with them too often.

Antworten:
1. So why don't you get out too often?
2. Thats perfect, I prefer doing it indoors.
3. I'm not getting out too often too, so what do you do when you're at home?
4. Oh so thats why your skin is so disgustingly pale.

Fragen:
1. Lost
2. I love playing videogames especially Minecraft and other survivalgames, thats why. Do you have any favourite Videogames?
3. I love playing videogames especially Minecraft and other survivalgames, thats why. Do you have any favourite Videogames?
4. Lost

Antworten:
1. Minecraft, isn't that the game that all the kids play.
2. Yes, i love Jupiter II- Survival.
3. I like playing any videogame.
4. No i hate Gaming

Fragen:
1. Lost
2. I don't know that game, but at least we have something in common, do you want to meat again?
3. Wow, thats cool, do you eant to meat again?
4. Lost

Antworten:
1. Yes of course
2. we could play together too
3. I like you but only as a friend
4. Sorry but you're not my type.
*/
