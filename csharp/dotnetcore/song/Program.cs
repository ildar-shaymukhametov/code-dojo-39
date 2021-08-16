using System;

namespace song
{
    public class Program
    {
        static void Main(string[] args)
        {
            var song = GetSong();

            Console.WriteLine(song);
        }

        public static string GetSong()
        {
            var firstVerse = new FirstVerse("fly");
            var secondVerse = new SecondVerse("spider", firstVerse);
            var thirdVerse = new ThirdVerse("bird", secondVerse);
            var fourthVerse = new FourthVerse("cat", thirdVerse);
            var fifthVerse = new FifthVerse("dog", fourthVerse);
            var sixthVerse = new SixthVerse("cow", fifthVerse);
            return @$"{firstVerse.GetLyrics()}

{secondVerse.GetLyrics()}

{thirdVerse.GetLyrics()}

{fourthVerse.GetLyrics()}

{fifthVerse.GetLyrics()}

{sixthVerse.GetLyrics()}

{new SeventhVerse("horse").GetLyrics()}";
        }
    }

    public class Verse
    {
        public string Animal { get; }

        public Verse(string animal)
        {
            this.Animal = animal;
        }

        public string GetFirstLine()
        {
            return $"There was an old lady who swallowed a {Animal}";
        }

        public virtual string GetLyrics()
        {
            return string.Empty;
        }

        public virtual string GetRefrain()
        {
            return string.Empty;
        }

        protected string ComposeRefrain(Verse previousVerse)
        {
            return $"{Catch(previousVerse.Animal)},\n{previousVerse.GetRefrain()}";
        }

        protected string Catch(string animal)
        {
            return $"She swallowed the {Animal} to catch the {animal}";
        }
    }

    public class FirstVerse : Verse
    {
        public FirstVerse(string animal) : base(animal)
        {
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()}.\n{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return $"I don't know why she swallowed a {Animal} - perhaps she'll die!";
        }
    }

    public class SecondVerse : Verse
    {
        private readonly Verse previousVerse;
        public SecondVerse(string animal, Verse previousVerse) : base(animal)
        {
            this.previousVerse = previousVerse;
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()};\n" +
                $"That wriggled and wiggled and tickled inside her.\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return $"{Catch(previousVerse.Animal)};\n" +
                $"{previousVerse.GetRefrain()}";
        }
    }

    public class ThirdVerse : Verse
    {
        private readonly Verse previousVerse;
        public ThirdVerse(string animal, Verse previousVerse) : base(animal)
        {
            this.previousVerse = previousVerse;
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()};\n" +
                $"How absurd to swallow a {Animal}.\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return ComposeRefrain(previousVerse);
        }
    }

    public class FourthVerse : Verse
    {
        private readonly Verse previousVerse;
        public FourthVerse(string animal, Verse previousVerse) : base(animal)
        {
            this.previousVerse = previousVerse;
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()};\n" +
                $"Fancy that to swallow a {Animal}!\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return ComposeRefrain(previousVerse);
        }
    }
    
    public class FifthVerse : Verse
    {
        private readonly Verse previousVerse;
        public FifthVerse(string animal, Verse previousVerse) : base(animal)
        {
            this.previousVerse = previousVerse;
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()};\n" +
                $"What a hog, to swallow a {Animal}!\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return ComposeRefrain(previousVerse);
        }
    }

    public class SixthVerse : Verse
    {
        private readonly Verse previousVerse;
        public SixthVerse(string animal, Verse previousVerse) : base(animal)
        {
            this.previousVerse = previousVerse;
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()};\n" +
                $"I don't know how she swallowed a {Animal}!\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return ComposeRefrain(previousVerse);
        }
    }

    public class SeventhVerse : Verse
    {
        public SeventhVerse(string animal) : base(animal)
        {
        }

        public override string GetLyrics()
        {
            return $"{GetFirstLine()}...\n" +
                "...She's dead, of course!";
        }
    }
}
