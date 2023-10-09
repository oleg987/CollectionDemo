internal class Program
{
    public static void Main(string[] args)
    {
        string firstText =
            @"The sun hung low, casting long shadows across the quiet town. Birds chirped their evening lullaby, a gentle reminder of nature's symphony. The aroma of freshly baked bread wafted from the corner bakery, enticing passersby with its warm embrace. Laughter echoed through the cobblestone streets as children played, their innocence painting the world with vibrant hues.

As dusk settled in, the sky transformed into a canvas of oranges, pinks, and purples, a masterpiece only nature could create. The rhythmic sound of waves crashing against the shore provided a soothing backdrop to the day's end. Couples strolled hand in hand, sharing stolen glances and secret smiles, their hearts dancing to a silent melody.

Tenderness lingered in the air, a tangible force that wrapped around the town like a comforting blanket. It was a place where time seemed to slow, where moments were cherished, and where the simplest joys held the most profound meaning.";

        string secondText = @"The city hummed with energy, a symphony of life that reverberated through its bustling streets. Skyscrapers stretched towards the heavens, their steel frames reaching for the infinite possibilities that lay beyond. Neon signs adorned storefronts, casting a kaleidoscope of colors upon the pavement below.

People hurried past, each with a purpose and a destination. The scent of street food mingled with the sharp tang of city air, creating a unique fragrance that was unmistakably urban. Cars honked their horns in a cacophony of impatience, the soundtrack of a metropolis in constant motion.

Amid the chaos, there was a certain magic that danced in the air. It was the pulse of ambition, the heartbeat of dreams being chased. The city was a tapestry of stories, each thread woven into the fabric of its existence. It was a place of endless opportunity, where the bold dared to carve their mark upon the world.";
        
        /*
         * 1. Получить уникальные слова для каждого текста.
         * 2. Проверить написаны ли тексты с помощь одних и тех же слов.
         *      Example,
         *      ["x", "x", "y"] vs ["y", "y", "x", "y", "x"] => true
         *      ["x", "x"] vs ["x", "y"] => false
         * 3. Вывести частоту использования слов для какждого текста.
         *      Example, ["x", "x", "y", "x", "y"] => "x" -> 3, "y" -> 2
         * 4. Вывести слова которые есть в первом тексте, но нет во втором и наоборот.
         *      Example, ["a", "b", "c"] vs ["b", "c", "d"] => ["a", "d"]
         *
         * (!) Регистр не важен "The" == "the" == "THE"
         * (!) Знаки пунктуации не являются частью слов
         */
    }
}