﻿using System;
using System.Collections.Generic;
using System.IO;

namespace MapleWzParser {
    public static class Serializer {
        public static void Save(string path, Dictionary<int, string> data) {
            Console.WriteLine($"Saving '{path}'...");

            using (var file = File.Open(path, FileMode.Create)) {
                var bw = new BinaryWriter(file);

                bw.Write(data.Count);
                foreach (KeyValuePair<int, string> pair in data) {
                    bw.Write(pair.Key);
                    bw.Write(pair.Value);
                }
            }
        }

        public static void Save(string path, Dictionary<int, string[]> data) {
            Console.WriteLine($"Saving '{path}'...");

            using (var file = File.Open(path, FileMode.Create)) {
                var bw = new BinaryWriter(file);

                bw.Write(data.Count);
                foreach (KeyValuePair<int, string[]> pair in data) {
                    bw.Write(pair.Key);
                    foreach (string str in pair.Value) {
                        bw.Write(str);
                    }
                }
            }
        }
    }
}
