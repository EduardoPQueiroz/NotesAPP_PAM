namespace Notesapp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name = string.Empty; //ou "";

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
        private void OnGreetClicked(object sender, EventArgs e)
        {
            name = NameEntry.Text;
            GreetLabel.Text = $"Ei {name} você mesmo, você é muitíssimo bem-vindo nesse app, tudo de bom pra você viu, não se preocupe fique a vontade, é um prazer tÊ-lo aqui, não tenha pressa para sair.";
        }
    }
    ///private void OnNameClicked()
    ///{
    ///
    ///}

}
