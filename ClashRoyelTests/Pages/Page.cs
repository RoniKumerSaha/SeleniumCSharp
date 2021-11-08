using System;

namespace ClashRoyelTests.Pages
{
    public static class Page
    {
        [ThreadStatic]
        public static CardsPage CardsPage;

        public static void Init()
        {
            CardsPage = new CardsPage();
        }
    }
}