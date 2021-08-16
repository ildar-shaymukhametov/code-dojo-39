using System;
using Xunit;
using song;

namespace test
{
    public class Test
    {
        [Fact]
        public void Song()
        {
            var song = Program.GetSong();
            Assert.Equal(song, @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a bird;
How absurd to swallow a bird.
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a cat;
Fancy that to swallow a cat!
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a dog;
What a hog, to swallow a dog!
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!");
        }
        [Fact]
        public void Custom_animals()
        {
            var song = Program.GetSong("animal1", "animal2", "animal3", "animal4", "animal5", "animal6", "animal7");

            Assert.Equal(song, @"There was an old lady who swallowed a animal1.
I don't know why she swallowed a animal1 - perhaps she'll die!

There was an old lady who swallowed a animal2;
That wriggled and wiggled and tickled inside her.
She swallowed the animal2 to catch the animal1;
I don't know why she swallowed a animal1 - perhaps she'll die!

There was an old lady who swallowed a animal3;
How absurd to swallow a animal3.
She swallowed the animal3 to catch the animal2,
She swallowed the animal2 to catch the animal1;
I don't know why she swallowed a animal1 - perhaps she'll die!

There was an old lady who swallowed a animal4;
Fancy that to swallow a animal4!
She swallowed the animal4 to catch the animal3,
She swallowed the animal3 to catch the animal2,
She swallowed the animal2 to catch the animal1;
I don't know why she swallowed a animal1 - perhaps she'll die!

There was an old lady who swallowed a animal5;
What a hog, to swallow a animal5!
She swallowed the animal5 to catch the animal4,
She swallowed the animal4 to catch the animal3,
She swallowed the animal3 to catch the animal2,
She swallowed the animal2 to catch the animal1;
I don't know why she swallowed a animal1 - perhaps she'll die!

There was an old lady who swallowed a animal6;
I don't know how she swallowed a animal6!
She swallowed the animal6 to catch the animal5,
She swallowed the animal5 to catch the animal4,
She swallowed the animal4 to catch the animal3,
She swallowed the animal3 to catch the animal2,
She swallowed the animal2 to catch the animal1;
I don't know why she swallowed a animal1 - perhaps she'll die!

There was an old lady who swallowed a animal7...
...She's dead, of course!");
        }
    }
}
