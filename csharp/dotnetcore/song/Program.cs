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
            return @$"{new FirstVerse("fly")}

{new Verse("spider").SwallowAnimal()};
That wriggled and wiggled and tickled inside her.
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{new Verse("bird").SwallowAnimal()};
How absurd to swallow a bird.
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

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

        protected virtual string GetLyrics()
        {
            return string.Empty;
        }

        protected virtual string GetRefrain()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return GetLyrics();
        }
    }

    public class FirstVerse : Verse
    {
        public FirstVerse(string animal) : base(animal)
        {
        }

        protected override string GetLyrics()
        {
            return $"{SwallowAnimal()}.\n{GetRefrain()}";
        }

        protected override string GetRefrain()
        {
            return $"I don't know why she swallowed a {animal} - perhaps she'll die!";
        }
    }
}
