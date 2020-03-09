using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace annotation
{
    class Sentence
    {
        public string text, tokens;
        public int position;
        public int weight;

        public Sentence(string s, int pos)
        {
            text = s;
            position = pos;
        }

        public void getTokens()
        {
            StreamWriter writer = new StreamWriter("mystem/input.txt");
            writer.WriteLine(text);
            writer.Close();

            //Process.Start(Path.Combine(Environment.CurrentDirectory, "mystem\\mystem.exe"), "input.txt output.txt");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "mystem\\mystem.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-ld mystem\\input.txt mystem\\output.txt";
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(startInfo);
            p.WaitForExit();

            StreamReader reader = new StreamReader("mystem/output.txt");
            string s = reader.ReadLine();
            reader.Close();

            tokens = s;
        }

        public void deleteStop(ref List <string> stop)
        {
            foreach (string sto in stop)
            {
                string st = '{' + sto + '}';
                int ind = tokens.IndexOf(st);
                while (ind != -1)
                {
                    tokens = tokens.Remove(ind, st.Length);
                    ind = tokens.IndexOf(st);
                }
            }
        }

        public void getWeight(Dictionary <string, int> m)
        {
            weight = 0;
            string[] token = tokens.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var tok in token)
                if (m.ContainsKey(tok))
                    weight += m[tok];
        }
    }
}
