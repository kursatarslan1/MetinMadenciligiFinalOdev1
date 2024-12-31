using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using net.zemberek.erisim;
using net.zemberek.bilgi;
using net.zemberek.tr.yapi;
using net.zemberek.yapi;


namespace MetinMadenciligiFinalOdev1
{
    internal class TextAnalyzer
    {
        private string Input { get; set; }
        private int PunctuationCount { get; set; }
        private int SentenceCount { get; set; }
        private int WordCount { get; set; }
        private int LetterCount { get; set; }
        private List<string> Words { get; set; }
        private String[] Syllables {  get; set; }
        private HashSet<string> UniqueRoots { get; set; }
        private Kelime[] Cozumler {  get; set; }



        // Zemberek
        Zemberek zemberek = new Zemberek(new TurkiyeTurkcesi());

        // Regex
        private readonly string PunctuationPattern = @"(\.\.\.|[.,?!])";
        private readonly string SentencePunctuationPattern = @"(\.\.\.|[.!?])";
        private readonly string WordPattern = @"\b\w+(?<![.,!?])\b";
        private readonly string LetterPattern = @"[a-zA-ZçÇğĞıİöÖşŞüÜ]";
        private readonly string SentencePattern = @"(?<!\w\.\w)(?<![A-Za-z]\.\.\.)[A-Z].*?(?:\.{3}|[.!?])";

        // constructor method
        public TextAnalyzer(string inputText )
        {
            Input = inputText;
            Words = new List<string>();
        }

        /// <summary>
        /// Verilen metindeki noktalama işaretlerini bulan metot.
        /// </summary>
        /// <returns>int punctuation count</returns>
        public int GetPunctuationCount()
        {
            MatchCollection matches = Regex.Matches(Input, PunctuationPattern);
            PunctuationCount = matches.Count;
            return matches.Count;
        }

        /// <summary>
        /// Verilen metindeki cümle sayısını bulan metot.
        /// </summary>
        /// <returns>int sentence count</returns>
        public int GetSentenceCount()
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                return 0; 
            }

            MatchCollection matches = Regex.Matches(Input, SentencePunctuationPattern);
            SentenceCount = matches.Count;

            return matches.Count;
        }

        /// <summary>
        /// Verilen metindeki kelime sayısını bulan metot.
        /// </summary>
        /// <returns>int word count</returns>
        public int GetWordCount()
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                return 0;
            }

            MatchCollection matches = Regex.Matches(Input, WordPattern);
            WordCount = matches.Count;

            foreach (Match match in matches)
            {
                Words.Add(match.Value);
            }

            return matches.Count;
        }

        /// <summary>
        /// Verilen metindeki toplam hece sayısını bulan metot.
        /// </summary>
        /// <returns></returns>
        public int GetSyllableCount()
        {
            //String[] text = Input.Split(' ');
            int syllableCount = 0;

            foreach (String word in Words) 
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;
                else
                {
                    //Words.Add(word);
                    String[] syllable = zemberek.hecele(word);
                    Syllables = syllable;
                    syllableCount += syllable.Length;
                }
            }

            return syllableCount;
        }

        /// <summary>
        /// Verilen metindeki toplam harf sayısını bulan metot.
        /// </summary>
        /// <returns></returns>
        public int GetLetterCount()
        {
            if (string.IsNullOrWhiteSpace(Input))
                return 0;

            MatchCollection matches = Regex.Matches(Input, LetterPattern);
            LetterCount = matches.Count;

            return matches.Count;
        }

        /// <summary>
        /// Verilen metindeki benzersiz köklerin sayısını bulan metot.
        /// </summary>
        /// <returns>int: Benzersiz kök sayısı</returns>
        public int GetUniqueRootCount()
        {
            if (string.IsNullOrWhiteSpace(Input))
                return 0;

            var uniqueRoots = new HashSet<string>();

            foreach (string word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;

                // Kelimenin çözümlerini al
                Kelime[] cozumler = zemberek.kelimeCozumle(word);
                Cozumler = cozumler;
                foreach (Kelime cozum in cozumler)
                {
                    string kok = cozum.kok().icerik(); 
                    uniqueRoots.Add(kok); 
                }
            }

            UniqueRoots = uniqueRoots;
            return uniqueRoots.Count;
        }


        /// <summary>
        /// Verilen metindeki cümlelerin ortalama kelime sayısını bulan metot.
        /// </summary>
        /// <returns>double: Ortalama kelime sayısı</returns>
        public double GetAverageWordsPerSentence()
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                return 0;
            }

            MatchCollection sentenceMatches = Regex.Matches(Input, SentencePattern);

            if (sentenceMatches.Count == 0)
            {
                return 0;
            }

            int totalWords = 0;

            foreach (Match match in sentenceMatches)
            {
                string sentenceText = match.Value.Trim(); 
                int wordCountInSentence = Regex.Matches(sentenceText, WordPattern).Count;
                totalWords += wordCountInSentence;
            }

            double averageWordsPerSentence = (double)totalWords / sentenceMatches.Count;

            return averageWordsPerSentence;
        }

        /// <summary>
        /// Verilen metindeki kelimelerin ortalama hece sayısını bulan metot.
        /// </summary>
        /// <returns>double: Ortalama hece sayısı</returns>
        public double GetAverageSyllablesPerWord()
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                return 0;
            }


            int totalSyllables = 0;
            int wordCount = 0;

            foreach (string word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;


                int syllableCount = Syllables.Length;

                totalSyllables += syllableCount;
                wordCount++;
            }

            if (wordCount == 0)
            {
                return 0;
            }

            double averageSyllablesPerWord = (double)totalSyllables / wordCount;

            return averageSyllablesPerWord;
        }

        /// <summary>
        /// Verilen metindeki kelimelerin ortalama harf sayısını bulan metot.
        /// </summary>
        /// <returns>double: Ortalama harf sayısı</returns>
        public double GetAverageLettersPerWord()
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                return 0;
            }

            int totalLetters = 0;
            int wordCount = 0;

            foreach (string word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;

                int letterCount = Regex.Matches(word, LetterPattern).Count;

                totalLetters += letterCount;
                wordCount++;
            }

            if (wordCount == 0)
            {
                return 0;
            }

            double averageLettersPerWord = (double)totalLetters / wordCount;

            return averageLettersPerWord;
        }

        /// <summary>
        /// En çok ve en az kullanılan 3 kökü bulan metot.
        /// </summary>
        /// <returns>Tuple<List<string>, List<string>>: İlk eleman en çok kullanılanlar, ikinci eleman en az kullanılanlar.</returns>
        public (List<string> mostUsed, List<string> leastUsed) GetMostAndLeastUsedRoots()
        {
            if (string.IsNullOrWhiteSpace(Input))
                return (new List<string>(), new List<string>());

            var rootCounts = new Dictionary<string, int>();

            foreach (string word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;

                Kelime[] cozumler = zemberek.kelimeCozumle(word);
                foreach (Kelime cozum in cozumler)
                {
                    string kok = cozum.kok().icerik();
                    if (rootCounts.ContainsKey(kok))
                    {
                        rootCounts[kok]++;
                    }
                    else
                    {
                        rootCounts[kok] = 1;
                    }
                }
            }

            var mostUsed = rootCounts.OrderByDescending(kvp => kvp.Value).Take(3).Select(kvp => $"{kvp.Key} ({kvp.Value})").ToList();
            var leastUsed = rootCounts.OrderBy(kvp => kvp.Value).Take(3).Select(kvp => $"{kvp.Key} ({kvp.Value})").ToList();

            return (mostUsed, leastUsed);
        }


        /// <summary>
        /// En çok ve en az kullanılan 3 heceyi bulan metot.
        /// </summary>
        /// <returns>Tuple<List<string>, List<string>>: İlk eleman en çok kullanılanlar, ikinci eleman en az kullanılanlar.</returns>
        public (List<string> mostUsed, List<string> leastUsed) GetMostAndLeastUsedSyllables()
        {
            if (string.IsNullOrWhiteSpace(Input))
                return (new List<string>(), new List<string>());

            var syllableCounts = new Dictionary<string, int>();

            foreach (string word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;

                String[] hece = zemberek.hecele(word);
                foreach (string syllable in hece)
                {
                    if (syllableCounts.ContainsKey(syllable))
                    {
                        syllableCounts[syllable]++;
                    }
                    else
                    {
                        syllableCounts[syllable] = 1;
                    }
                }
            }

            var mostUsed = syllableCounts.OrderByDescending(kvp => kvp.Value).Take(3).Select(kvp => $"{kvp.Key} ({kvp.Value})").ToList();
            var leastUsed = syllableCounts.OrderBy(kvp => kvp.Value).Take(3).Select(kvp => $"{kvp.Key} ({kvp.Value})").ToList();

            return (mostUsed, leastUsed);
        }

        /// <summary>
        /// En çok ve en az kullanılan 3 harfi bulan metot.
        /// </summary>
        /// <returns>Tuple<List<string>, List<string>>: İlk eleman en çok kullanılanlar, ikinci eleman en az kullanılanlar.</returns>
        public (List<string> mostUsed, List<string> leastUsed) GetMostAndLeastUsedLetters()
        {
            if (string.IsNullOrWhiteSpace(Input))
                return (new List<string>(), new List<string>());

            var letterCounts = new Dictionary<string, int>();

            foreach (char ch in Input)
            {
                if (Regex.IsMatch(ch.ToString(), LetterPattern))
                {
                    string letter = ch.ToString().ToLower();

                    if (letterCounts.ContainsKey(letter))
                    {
                        letterCounts[letter]++;
                    }
                    else
                    {
                        letterCounts[letter] = 1;
                    }
                }
            }

            var mostUsed = letterCounts.OrderByDescending(kvp => kvp.Value)
                                       .Take(3)
                                       .Select(kvp => $"{kvp.Key} ({kvp.Value})")
                                       .ToList();

            var leastUsed = letterCounts.OrderBy(kvp => kvp.Value)
                                        .Take(3)
                                        .Select(kvp => $"{kvp.Key} ({kvp.Value})")
                                        .ToList();

            return (mostUsed, leastUsed);
        }

        /// <summary>
        /// Verilen metindeki hece sayısına göre kelime sayılarını veren metot.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> GetSyllableCountByGroup()
        {
            var syllableGroups = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 },
                { 4, 0 },
                { 5, 0 },
                { 6, 0 }
            };

            foreach (String word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;

                String[] syllables = zemberek.hecele(word);
                int syllableCount = syllables.Length;

                if (syllableCount >= 6)
                {
                    syllableGroups[6]++;
                }
                else if (syllableCount >= 5)
                {
                    syllableGroups[5]++;
                }
                else if (syllableCount >= 4)
                {
                    syllableGroups[4]++;
                }
                else if (syllableCount >= 3)
                {
                    syllableGroups[3]++;
                }
                else if (syllableCount == 2)
                {
                    syllableGroups[2]++;
                }
                else if (syllableCount == 1)
                {
                    syllableGroups[1]++;
                }
            }

            return syllableGroups;
        }

        /// <summary>
        /// Verilen metindeki kelimelerin aldığı ek sayısına göre dağılımlarını bulan metot.
        /// </summary>
        /// <returns>Dictionary<int, int>: Her bir ek sayısına göre kelime sayısı</returns>
        public Dictionary<int, int> GetWordCountBySuffix()
        {
            var suffixGroups = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 }, 
                { 3, 0 }, 
                { 4, 0 }, 
                { 5, 0 }, 
                { 6, 0 }  
            };

            foreach (string word in Words)
            {
                if (!zemberek.kelimeDenetle(word))
                    continue;

                Kelime[] cozumler = zemberek.kelimeCozumle(word);

                foreach (Kelime cozum in cozumler)
                {

                    int suffixCount = cozum.ekSayisi();

                    if (suffixCount >= 6)
                    {
                        suffixGroups[6]++; 
                    }
                    else if (suffixCount >= 5)
                    {
                        suffixGroups[5]++;
                    }
                    else if (suffixCount >= 4)
                    {
                        suffixGroups[4]++;
                    }
                    else if (suffixCount >= 3)
                    {
                        suffixGroups[3]++;
                    }
                    else if (suffixCount == 2)
                    {
                        suffixGroups[2]++;
                    }
                    else if (suffixCount == 1)
                    {
                        suffixGroups[1]++;
                    }
                }
            }

            return suffixGroups;
        }

        public List<string> AnalyzeText()
        {
            List<string> analysisResults = new List<string>();

            // 1. Noktalama işareti sayısı
            analysisResults.Add($"Punctuation Count: {GetPunctuationCount()}");

            // 2. Cümle sayısı
            analysisResults.Add($"Sentence Count: {GetSentenceCount()}");

            // 3. Kelime sayısı
            analysisResults.Add($"Word Count: {GetWordCount()}");

            // 4. Hece sayısı
            analysisResults.Add($"Syllable Count: {GetSyllableCount()}");

            // 5. Harf sayısı
            analysisResults.Add($"Letter Count: {GetLetterCount()}");

            // 6. Benzersiz kök sayısı
            analysisResults.Add($"Unique Root Count: {GetUniqueRootCount()}");

            // 7. Cümle başına ortalama kelime sayısı
            analysisResults.Add($"Average Words Per Sentence: {GetAverageWordsPerSentence()}");

            // 8. Kelime başına ortalama hece sayısı
            analysisResults.Add($"Average Syllables Per Word: {GetAverageSyllablesPerWord()}");

            // 9. Kelime başına ortalama harf sayısı
            analysisResults.Add($"Average Letters Per Word: {GetAverageLettersPerWord()}");

            // 10. En çok kullanılan 3 kök ve en az kullanılan 3 kök
            var roots = GetMostAndLeastUsedRoots();
            analysisResults.Add($"Most Used Roots: {string.Join(", ", roots.mostUsed)}");
            analysisResults.Add($"Least Used Roots: {string.Join(", ", roots.leastUsed)}");

            // 11. En çok kullanılan 3 hece ve en az kullanılan 3 hece
            var syllables = GetMostAndLeastUsedSyllables();
            analysisResults.Add($"Most Used Syllables: {string.Join(", ", syllables.mostUsed)}");
            analysisResults.Add($"Least Used Syllables: {string.Join(", ", syllables.leastUsed)}");

            // 12. En çok kullanılan 3 harf ve en az kullanılan 3 harf
            var letters = GetMostAndLeastUsedLetters();
            analysisResults.Add($"Most Used Letters: {string.Join(", ", letters.mostUsed)}");
            analysisResults.Add($"Least Used Letters: {string.Join(", ", letters.leastUsed)}");

            // 13. Hece sayısına göre kelime dağılımı
            var syllableGroups = GetSyllableCountByGroup();
            analysisResults.Add("Syllable Count Distribution: " + string.Join(", ", syllableGroups.Select(kvp => $"{kvp.Key} syllable(s): {kvp.Value} word(s)")));

            // 14. Ek sayısına göre kelime dağılımı
            var suffixGroups = GetWordCountBySuffix();
            analysisResults.Add("Suffix Count Distribution: " + string.Join(", ", suffixGroups.Select(kvp => $"{kvp.Key} suffix(es): {kvp.Value} word(s)")));

            return analysisResults;
        }

    }
}
