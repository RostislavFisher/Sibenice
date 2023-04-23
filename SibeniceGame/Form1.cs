using System.Collections;

namespace SibeniceGame;

public class Hangman
{
    public static List<HangmanIcons> listOfHangmen = new List<HangmanIcons>()
    {
        new HangmanFirst(),
        new HangmanSecond(),
        new HangmanThird(),
        new HangmanFourth(),
        new HangmanFifth(),
        new HangmanSixth()
    };

}

public class HangmanIcons
{
    public List<List<string>> list;

}

public class HangmanFirst:HangmanIcons
{
    public List<List<string>> list = new List<List<string>>() {
        new List<string>{" ", "+", "-", "-", "+", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{"=", "=", "=", "=", "=", "'", "'"},
    };
    public override string ToString()
    {
        string text = "";
        foreach (var VARIABLE in list)
        {
            text += string.Join("", VARIABLE.ToArray())+"\n";
        }
        return text;
    }

}

public class HangmanSecond:HangmanIcons
{
    public List<List<string>> list = new List<List<string>>() {
        new List<string>{" ", "+", "-", "-", "+", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", "0", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{"=", "=", "=", "=", "=", "'", "'"},
    };
    public override string ToString()
    {
        string text = "";
        foreach (var VARIABLE in list)
        {
            text += string.Join("", VARIABLE.ToArray())+"\n";
        }
        return text;
    }

}

public class HangmanThird:HangmanIcons
{
    public List<List<string>> list = new List<List<string>>() {
        new List<string>{" ", "+", "-", "-", "+", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", "0", " ", " ", "|", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{"=", "=", "=", "=", "=", "'", "'"},
    };    
    public override string ToString()
    {
        string text = "";
        foreach (var VARIABLE in list)
        {
            text += string.Join("", VARIABLE.ToArray())+"\n";
        }
        return text;
    }


}


public class HangmanFourth:HangmanIcons
{
    public List<List<string>> list = new List<List<string>>() {
        new List<string>{" ", "+", "-", "-", "+", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", "0", " ", " ", "|", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{"=", "=", "=", "=", "=", "'", "'"},
    };    
    public override string ToString()
    {
        string text = "";
        foreach (var VARIABLE in list)
        {
            text += string.Join("", VARIABLE.ToArray())+"\n";
        }
        return text;
    }

}

public class HangmanFifth:HangmanIcons
{
    public List<List<string>> list = new List<List<string>>() {
        new List<string>{" ", "+", "-", "-", "+", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", "0", " ", " ", "|", " ", " "},
        new List<string>{"/", "|", "\\", " ", "|", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", " ", " ", " ", "|", " ", " "},
        new List<string>{"=", "=", "=", "=", "=", "'", "'"},
    };
    public override string ToString()
    {
        string text = "";
        foreach (var VARIABLE in list)
        {
            text += string.Join("", VARIABLE.ToArray())+"\n";
        }
        return text;
    }

}

public class HangmanSixth:HangmanIcons
{
    public List<List<string>> list = new List<List<string>>() {
        new List<string>{" ", "+", "-", "-", "+", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{" ", "0", " ", " ", "|", " ", " "},
        new List<string>{"/", "|", "\\", " ", "|", " ", " "},
        new List<string>{" ", "|", " ", " ", "|", " ", " "},
        new List<string>{"/", " ", "\\", " ", "|", " ", " "},
        new List<string>{"=", "=", "=", "=", "=", "'", "'"},
    };
    public override string ToString()
    {
        string text = "";
        foreach (var VARIABLE in list)
        {
            text += string.Join("", VARIABLE.ToArray())+"\n";
        }
        return text;
    }

}

public class Letter
{
    public string letter;
    public bool isGuessed;
}

public class Word
{
    public List<Letter> word = new List<Letter>();
    public int wrongVariants = 0;

    public override string ToString()
    {
        string wordToText = "";
        foreach (var VARIABLE in word)
        {
            wordToText += VARIABLE.isGuessed ? VARIABLE.letter : "_";
        }
        return wordToText;
    }
}
public partial class Form1 : Form
{
    public Word word = new Word();
    
    public Form1()
    {
        InitializeComponent();

    }
    private void button1_Click(object sender, EventArgs e)
    {
        var listOfLetters = word.word.Where(letter => letter.letter.Equals(textBox1.Text));
        if (listOfLetters.Count()==0)
        {
            word.wrongVariants += 1;
        }
        if (word.wrongVariants <= 5)
        {
            foreach (var VARIABLE in listOfLetters)
            {
                VARIABLE.isGuessed = true;
            }
            label1.Text = word.ToString();
            label2.Text = Hangman.listOfHangmen[word.wrongVariants].ToString();
        }
        if (word.wrongVariants >= 5)
        {
            MessageBox.Show("You lose", "Restart game", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
    private void importButton_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                word = new Word();
                foreach (var letter in fileContent)
                {
                    word.word.Add(new Letter(){letter=Char.ToString(letter)});
                }
                label1.Text = word.ToString();
                label2.Text = Hangman.listOfHangmen[0].ToString();

            }
        }
    }

}
