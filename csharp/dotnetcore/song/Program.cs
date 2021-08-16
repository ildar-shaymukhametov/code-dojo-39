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
            return @$"{firstVerse.GetLyrics()}

{secondVerse.GetLyrics()}

{new ThirdVerse("bird", secondVerse).GetLyrics()}

{new Verse("cat").SwallowAnimal()};
Fancy that to swallow a cat!
{GetFourthVerseRefrain()}
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{new Verse("dog").SwallowAnimal()};
What a hog, to swallow a dog!
{GetFifthVerseRefrain()}
{GetFourthVerseRefrain()}
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{new Verse("cow").SwallowAnimal()};
I don't know how she swallowed a cow!
{GetSixthVerseRefrain()}
{GetFifthVerseRefrain()}
{GetFourthVerseRefrain()}
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{new Verse("horse..").SwallowAnimal()}.
...She's dead, of course!";
        }

        private static string GetFirstVerseRefrain()
        {
            return "I don't know why she swallowed a fly - perhaps she'll die!";
        }

        private static string GetSecondVerseRefrain()
        {
            return "She swallowed the spider to catch the fly;";
        }

        private static string GetThirdVerseRefrain()
        {
            return "She swallowed the bird to catch the spider,";
        }

        private static string GetFourthVerseRefrain()
        {
            return "She swallowed the cat to catch the bird,";
        }

        private static string GetFifthVerseRefrain()
        {
            return "She swallowed the dog to catch the cat,";
        }

        private static string GetSixthVerseRefrain()
        {
            return "She swallowed the cow to catch the dog,";
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
}
