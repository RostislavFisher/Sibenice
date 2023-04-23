namespace SibeniceGame;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button importButton;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox1.Location = new System.Drawing.Point(10, 10);
        this.textBox1.Size = new System.Drawing.Size(200, 20);
        this.textBox1.Name = "textBox1";
        this.textBox1.Text = "";
        this.textBox1.MaxLength = 1;
        
        this.button1 = new System.Windows.Forms.Button();
        this.button1.Location = new System.Drawing.Point(250, 10);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 60);
        this.button1.Text = "Click me";
        this.button1.Click += new System.EventHandler(this.button1_Click);
        
        this.label1 = new System.Windows.Forms.Label();
        this.label1.Location = new System.Drawing.Point(10, 50);
        this.label1.AutoSize = true;
        // this.label1.Size = new System.Drawing.Size(100, 20);
        this.label1.Text = "IMPORT WORD";
        
        this.label2 = new System.Windows.Forms.Label();
        this.label2.Location = new System.Drawing.Point(10, 100);
        this.label2.AutoSize = true;
        // this.label1.Size = new System.Drawing.Size(100, 20);
        this.label2.Text = Hangman.listOfHangmen[0].ToString();
        
        this.importButton = new System.Windows.Forms.Button();
        this.importButton.Location = new System.Drawing.Point(400, 50);
        this.importButton.Name = "importButton";
        this.importButton.Size = new System.Drawing.Size(75, 50);
        this.importButton.Text = "Import";
        this.importButton.Click += new System.EventHandler(this.importButton_Click);

        
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.importButton);


    }

    #endregion
}