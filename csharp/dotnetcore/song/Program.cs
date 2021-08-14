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
            return @$"{SwallowAnAnimal("fly")}.
{GetFirstVerseRefrain()}

{SwallowAnAnimal("spider")};
That wriggled and wiggled and tickled inside her.
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{SwallowAnAnimal("bird")};
How absurd to swallow a bird.
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{SwallowAnAnimal("cat")};
Fancy that to swallow a cat!
{GetFourthVerseRefrain()}
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{SwallowAnAnimal("dog")};
What a hog, to swallow a dog!
She swallowed the dog to catch the cat,
{GetFourthVerseRefrain()}
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{SwallowAnAnimal("cow")};
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
She swallowed the dog to catch the cat,
{GetFourthVerseRefrain()}
{GetThirdVerseRefrain()}
{GetSecondVerseRefrain()}
{GetFirstVerseRefrain()}

{SwallowAnAnimal("horse..")}.
...She's dead, of course!";
        }

        private static string SwallowAnAnimal(string animal)
        {
            return $"There was an old lady who swallowed a {animal}";
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
    }
}
