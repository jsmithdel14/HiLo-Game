public class Dealer
{
    //List<Card> cards = new List<Card>();
    int c_score = 0;
    bool isPlaying = true; 
    int last_card = 0;
    string player_answer = "";
    int total_points = 300;
    public Dealer(){

    }

    public void StartGame(){
        while (isPlaying){
            ShowCard();
            AskQuestion();
            ShowAnswer();
            ShowScore();
            PlayAgain();
        }
    }

    public void ShowCard(){
        
        Card card = new Card();
        card.Pull();
        c_score = card.value;
        Console.WriteLine($"The card is: {c_score}");
    }

    public void AskQuestion(){
        Console.WriteLine("Higher or Lower? [h/l] ");
        string p_answer = Console.ReadLine();
        player_answer = p_answer;
    }

    public void ShowAnswer(){
        int l_card = c_score;
        last_card = l_card;
        Card card = new Card();
        card.Pull();
        c_score = card.value;
        Console.WriteLine($"The next card was: {c_score}");
    }
    public void ShowScore(){
        //Player points = new Player(300);
        if (player_answer.ToLower() == "h" && c_score > last_card){

            total_points += 100;
        }
        else if (player_answer.ToLower() == "l" && c_score < last_card){
            total_points += 100;
        }
        else {
            total_points -= 75;
        }
        Console.WriteLine($"Your score is: {total_points}");
    }

    public void PlayAgain(){
        if (total_points > 0){
            Console.Write("Play again? [y/n] ");
            string play = Console.ReadLine();
            if (play == "n"){
                isPlaying = false;
            }
            isPlaying = (play == "y");
        }
        else {
            isPlaying = false;
        }
        
    }
}



