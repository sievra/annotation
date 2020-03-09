using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace annotation
{
    public partial class Form1 : Form
    {
        List<Sentence> sentences = new List<Sentence>();

        public Form1()
        {
            InitializeComponent();
        }

        void fillSentences()
        {
            string text = textBox1.Text;
            List<char> dots = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                    dots.Add('.');
                if (text[i] == '!')
                    dots.Add('!');
                if (text[i] == '?')
                    dots.Add('?');
            }
            string[] sen = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            sentences.Clear();
            for (int i = 0; i < sen.Count(); i++)
            {
                if (i < dots.Count)
                    sentences.Add(new Sentence(sen[i].Trim() + dots[i], i));
                else
                    sentences.Add(new Sentence(sen[i].Trim(), i));
                //MessageBox.Show(sen[i].Trim() + dots[i]);
            }

            textBox2.Clear();
            foreach (var sent in sentences)
                textBox2.Text += sent.position + ". " + sent.text + Environment.NewLine;
        }

        void fillTokens()
        {
            textBox3.Clear();
            int i = 0;
            if (sentences.Count != 0)
                progressBar.Value = i * 100 / sentences.Count;
            foreach (var sen in sentences)
            {
                sen.getTokens();
                textBox3.Text += sen.position + ". " + sen.tokens + Environment.NewLine;
                i++;
                if (sentences.Count != 0)
                    progressBar.Value = i * 100 / sentences.Count;
            }
        }

        void fillStop()
        {
            List<string> stop = new List<string>();
            StreamReader reader = new StreamReader("stop.txt");
            while (!reader.EndOfStream)
                stop.Add(reader.ReadLine());
            reader.Close();
            textBox4.Clear();
            foreach (var sen in sentences)
            {
                sen.deleteStop(ref stop);
                textBox4.Text += sen.position + ". " + sen.tokens + Environment.NewLine;
            }
        }

        Dictionary<string, int> m = new Dictionary<string, int>();

        void fillRangeTokens()
        {
            Dictionary<string, int> m1 = new Dictionary<string, int>();
            foreach (Sentence sen in sentences)
            {
                string[] tokens = sen.tokens.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var tok in tokens)
                    if (m1.ContainsKey(tok))
                        m1[tok]++;
                    else
                        m1.Add(tok, 1);
            }
            var ordered = m1.OrderBy(x => -x.Value);
            //m = ordered;

            textBox5.Clear();
            foreach (var dic in ordered)
            {
                if (dic.Value > 1)
                    m.Add(dic.Key, dic.Value);
                textBox5.Text += dic.Key + ' ' + dic.Value + Environment.NewLine;
            }
        }

        void fillKeyWords()
        {
            textBox6.Clear();
            int n = Math.Min(8, m.Count);
            int i = 0;
            foreach (var item in m)
            {
                textBox6.Text += item.Key + Environment.NewLine;
                i++;
                if (i == n)
                    break;
            }
        }

        void fillSentencesWeight()
        {
            foreach (var sen in sentences)
                sen.getWeight(m);
            List<Sentence> a = new List<Sentence>(sentences);
            sentences.Clear();
            textBox7.Clear();
            foreach (var sen in a.OrderBy(x => -x.weight))
            {
                sen.getWeight(m);
                sentences.Add(sen);
                textBox7.Text += sen.position + " (" + sen.weight + "). " + sen.text + Environment.NewLine;
            }
        }

        void fillResult()
        {
            textBox8.Clear();
            List<Sentence> res = new List<Sentence>();
            for (int i = 0; i * 100 / sentences.Count < 100 - numUDPercent.Value; i++)
                res.Add(sentences[i]);
            foreach (var sen in res.OrderBy(x => x.position))
                textBox8.Text += sen.text + ' ';
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            fillSentences();
            fillTokens();
            fillStop();
            fillRangeTokens();
            fillKeyWords();
            fillSentencesWeight();
            fillResult();
        }

        void readFile(string name)
        {
            StreamReader reader = new StreamReader(name);
            textBox1.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            readFile("red.txt");
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            readFile("introduction.txt");
        }
    }
}
