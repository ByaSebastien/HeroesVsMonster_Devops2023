namespace HeroesVsMonster.Utils.Compenents
{
    public static class TitleScreen
    {       
        public static void Display()
        {
            Screen.PrintFullScreen(0,Pictures.ScreenBackground);
            Screen.PrintFullScreen(5, Pictures.Logo);
            Screen.PrintFullScreen(38, "Créé par Bya Sébastion");
            Screen.PrintFullScreen(43, "Remerciement à Khun ly & Flavian Ovyn");
            Screen.PrintVerticalMenu(31, "Appuyer sur enter");

        }
    }
}
