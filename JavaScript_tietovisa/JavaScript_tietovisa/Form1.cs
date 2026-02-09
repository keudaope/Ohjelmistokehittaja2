namespace JavaScript_tietovisa
{
    public partial class Form1 : Form
    {
        string[] kysymykset = {"Mihin HTML elementtiin sijoitamme JavaScript koodin",
        "Mit‰ HTML attribuuttia k‰ytet‰‰n viittaamaan ulkoiseen JavaScript tiedostoon",
        "Kuinka kirjoitat 'Moikka' alert viestin‰",
        "JavaScript on suoraan 'Java' ohjelmointikielen sukulainen",
        "JavaScript muuttujan pit‰‰ alkaa tietyll‰ merkill‰"};
        char[] vastaukset = new char[5];
        char[] oikeat = { 'b','a','d','b','d' };
        string[][] vaihtoehdot = new string[][]{ new string[]{ "a. <js>", "b. <script>", "c. <body>", "d. <link"},
        new string[]{"a. src", "b. link", "c. rel", "d. href" } }; 
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            aRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            bRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            cRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            dRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }
        public void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 5)
        }
    }
}