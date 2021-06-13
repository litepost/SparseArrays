/*
* https://www.hackerrank.com/challenges/sparse-arrays/problem
*/

using System;
using System.Collections.Generic;

namespace SparseArrays {
    class Program {
        static void Main(string[] args) {
            //string[] strings = new string[] { };
            //string[] qry = new string[] { "abc", "def", "a" };
            string[] strings = new string[] { "every", "voice", "engaged", "foundation", "every", "", "", "" };
            string[] qry = new string[] { "every", "foundation", "Foundation", "" };
            int[] ans = matchingStrings(strings, qry);
            printResults(qry, ans);
        }

        static void printResults(string[] q, int[] counts) {
            for (int i = 0; i < q.Length; i++) {
                Console.WriteLine($"{(q[i] == "" ? "empty" : q[i])}: {counts[i]}");
            }
        }

        static int[] matchingStrings(string[] strings, string[] queries) {
            Dictionary<string, int> words = new Dictionary<string, int>();
            int[] resp = new int[queries.Length];

            foreach (string w in strings) {
                if (words.ContainsKey(w)) {
                    words[w]++;
                } else {
                    words.Add(w, 1);
                }
            }

            for (int i = 0; i < queries.Length; i++) {
                if (words.ContainsKey(queries[i]))
                    resp[i] = words[queries[i]];
                else
                    resp[i] = 0;
            }

            return resp;
        }
    }
}
