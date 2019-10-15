using System;
using System.Collections.Generic;
using Xunit;

namespace GameZone.Tests
{
    public class SuspendPersonTests
    {
        [Fact]

        void canGetValidRandomNumber()
        {
            SuspendPerson sp = new SuspendPerson();
            int max = 4;
            int seed = sp.getValidRandomSeed(max);
            Assert.InRange(seed, 0, max);
        }

        [Fact]
        void canGetLetterWhenGuessedAndBlankOtherwise()
        {
            SuspendPerson sp = new SuspendPerson();
            List<char> guessed = new List<char>() { 'a', 'x', 'd' };

            Assert.Equal('a', sp.getLetterOrBlank(guessed, 'a'));
            Assert.Equal('_', sp.getLetterOrBlank(guessed, 'c'));
        }

        [Fact]
        void canInitGuessWordListWithGivenList()
        {
            SuspendPerson sp = new SuspendPerson();
            string[] words = { "abc", "def" };
            string[] defaultWords = { "porcupine" };

            List<string> actualWordList = sp.initGuessWordList(words);
            List<string> expectedWordList = new List<string>(words);
            Assert.Equal(expectedWordList, actualWordList);


        }
        [Fact]
        void canInitGuessWordListWithOrDefaultIfGivenEmptyList()
        {
            SuspendPerson sp = new SuspendPerson();
            string[] defaultWords = { "porcupine" };


            List<string> actualWordList = sp.initGuessWordList(new string[] { "" });
            List<string> expectedWordList = new List<string>(defaultWords);
            Assert.Equal(expectedWordList, actualWordList);

        }

        [Fact]
        void canGetGameStatusWinLoseOrGoing()
        {
            SuspendPerson sp = new SuspendPerson();
            string guessWord = "enemy";
            int lives = 3;
            int matched = 3;
            Assert.Equal(0, sp.getGameStatus(lives, matched, guessWord));
            lives = 0;
            matched = 3;
            Assert.Equal(-1, sp.getGameStatus(lives, matched, guessWord));
            lives = 3;
            matched = 4;
            Assert.Equal(1, sp.getGameStatus(lives, matched, guessWord));


        }

        //?Should test for sort() be included?



    }
}
