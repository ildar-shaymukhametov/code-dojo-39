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
        protected readonly string animal;

        public Verse(string animal)
        {
            this.animal = animal;
        }

        public string SwallowAnimal()
        {
            return $"There was an old lady who swallowed a {animal}";
        }

        public virtual string GetLyrics()
        {
            return string.Empty;
        }

        public virtual string GetRefrain()
        {
            return string.Empty;
        }
    }

    public class FirstVerse : Verse
    {
        public FirstVerse(string animal) : base(animal)
        {
        }

        public override string GetLyrics()
        {
            return $"{SwallowAnimal()}.\n{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return $"I don't know why she swallowed a {animal} - perhaps she'll die!";
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
            return $"{SwallowAnimal()};\n" +
                $"That wriggled and wiggled and tickled inside her.\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return "She swallowed the spider to catch the fly;\n" +
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
            return $"{SwallowAnimal()};\n" +
                $"How absurd to swallow a {animal}.\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return "She swallowed the bird to catch the spider,\n" +
                $"{previousVerse.GetRefrain()}";
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
            return $"{SwallowAnimal()};\n" +
                $"Fancy that to swallow a {animal}!\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return "She swallowed the cat to catch the bird,\n" +
                $"{previousVerse.GetRefrain()}";
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
            return $"{SwallowAnimal()};\n" +
                $"What a hog, to swallow a {animal}!\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return "She swallowed the dog to catch the cat,\n" +
                $"{previousVerse.GetRefrain()}";
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
            return $"{SwallowAnimal()};\n" +
                $"I don't know how she swallowed a {animal}!\n" +
                $"{GetRefrain()}";
        }

        public override string GetRefrain()
        {
            return "She swallowed the cow to catch the dog,\n" +
                $"{previousVerse.GetRefrain()}";
        }
    }

    public class SeventhVerse : Verse
    {
        public SeventhVerse(string animal) : base(animal)
        {
        }

        public override string GetLyrics()
        {
            return $"{SwallowAnimal()}...\n" +
                "...She's dead, of course!";
        }
    }
}
