using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Hangman
{
    public abstract class Category
    {
        protected string[] _items;
        public string Name { get; protected set; }
        public string GetRandomItem()
        {
            Random r = new Random();
            return _items.ElementAt(r.Next(0, _items.Length));
        }
    }

    class Movies : Category
    {
        public Movies()
        {
            Name = "Movie titles";
            _items = new string[]
            {
                "F o r r e s t   G u m p",
                "F i g h t   C l u b",
                "I n t o u c h a b l e s",
                "I n c e p t i o n",
                "S h r e k",
                "T h e   G o d f a t h e r",
                "Y i p   M a n",
                "D i r t y   H a r r y",
                "T h e   M a r t i a n",
                "A l i e n"
            };
        }
    }

    class Animals : Category
    {
        public Animals()
        {
            Name = "Animal names";
            _items = new string[]
            {
                "C o w",
                "L i o n",
                "W o l f",
                "C a t f i s h",
                "S c o r p i o n",
                "D o l p h i n",
                "C r o c o d i l e",
                "C h i c k e n",
                "T u r k e y",
                "L o b s t e r"
            };
        }
    }

    class Music : Category
    {
        public Music()
        {
            Name = "Song names";
            _items = new string[]
            {
                "E y e   O f   T h e   T i g e r",
                "S m o o t h   C r i m i n a l",
                "B o h e m i a n   R h a p s o d y",
                "C a l l   M e   M a y b e",
                "I n d e s t r u c t i b l e",
                "O n e   M o r e   L i g h t",
                "B u r n   i t   t o   t h e   g r o u n d",
                "R a d i o a c t i v e",
                "D e s p a c i t o",
                "O p p a   g a n g n a m   s t y l e"
            };
        }
    }

    class Games : Category
    {
        public Games()
        {
            Name = "Game titles";
            _items = new string[]
            {
                "T e t r i s",
                "S p a c e   I n v a d e r s",
                "C r a s h   B a n d i c o o t",
                "P o k e m o n   B l u e",
                "S u p e r    M a r i o   B r o s",
                "M i n e c r a f t",
                "T h e   S i m s",
                "C a l l   o f   D u t y",
                "W o r l d   o f   W a r c r a f t",
                "D o o m"
            };
        }
    }

    class Countries : Category
    {
        public Countries()
        {
            Name = "Country Names";
            _items = new string[]
            {
                "U n i t e d   K i n g d o m",
                "L i e c h t e n s t e i n",
                "I c e l a n d",
                "S a n   M a r i n o",
                "V i e t n a m",
                "S a u d i   A r a b i a",
                "P u e r t o   R i c o",
                "F r a n c e",
                "G e r m a n y",
                "A u s t r a l i a"
            };
        }
    }

}
