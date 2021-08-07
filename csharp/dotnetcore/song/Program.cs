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

        public static string GetSong(string animal1 = "fly", string animal2 = "spider", string animal3 = "bird", string animal4 = "cat", string animal5 = "dog", string animal6 = "cow", string animal7 = "horse")
        {
            return $@"There was an old lady who swallowed a {animal1}.
I don't know why she swallowed a {animal1} - perhaps she'll die!

There was an old lady who swallowed a {animal2};
That wriggled and wiggled and tickled inside her.
She swallowed the {animal2} to catch the {animal1};
I don't know why she swallowed a {animal1} - perhaps she'll die!

There was an old lady who swallowed a {animal3};
How absurd to swallow a {animal3}.
She swallowed the {animal3} to catch the {animal2},
She swallowed the {animal2} to catch the {animal1};
I don't know why she swallowed a {animal1} - perhaps she'll die!

There was an old lady who swallowed a {animal4};
Fancy that to swallow a {animal4}!
She swallowed the {animal4} to catch the {animal3},
She swallowed the {animal3} to catch the {animal2},
She swallowed the {animal2} to catch the {animal1};
I don't know why she swallowed a {animal1} - perhaps she'll die!

There was an old lady who swallowed a {animal5};
What a hog, to swallow a {animal5}!
She swallowed the {animal5} to catch the {animal4},
She swallowed the {animal4} to catch the {animal3},
She swallowed the {animal3} to catch the {animal2},
She swallowed the {animal2} to catch the {animal1};
I don't know why she swallowed a {animal1} - perhaps she'll die!

There was an old lady who swallowed a {animal6};
I don't know how she swallowed a {animal6}!
She swallowed the {animal6} to catch the {animal5},
She swallowed the {animal5} to catch the {animal4},
She swallowed the {animal4} to catch the {animal3},
She swallowed the {animal3} to catch the {animal2},
She swallowed the {animal2} to catch the {animal1};
I don't know why she swallowed a {animal1} - perhaps she'll die!

There was an old lady who swallowed a {animal7}...
...She's dead, of course!";
        }
    }
}
