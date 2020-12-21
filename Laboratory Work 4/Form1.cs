using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Laboratory_Work_4
{
    public partial class Window : Form
    {
        private Random random = null;
        private Action solution = null;
        private string filePath = null;

        public Window()
        {
            InitializeComponent();
            random = new Random();
        }

        private void SelectSolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSolution = SelectSolution.SelectedIndex;
            SetDefaults();
            switch (selectedSolution) {
                case 0:
                    solution = Solution1;
                    break;
                case 1:
                    solution = Solution2;
                    break;
                case 2:
                    solution = Solution3;
                    SetTextForLabel(ChangingText, "Максимальное значение:");
                    SetPositionForLabel(ChangingText, 346, 133);
                    break;
                case 3:
                    solution = Solution4;
                    SetTextForLabel(ChangingText, "Сумма:");
                    SetPositionForLabel(ChangingText, 387, 133);
                    break;
                case 4:
                    solution = Solution5;
                    break;
            }
            Menu_SelectedIndexChanged(sender, e);
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SelectSolution.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: selectedIndex = 0; break;
                case 1: selectedIndex = 0; break;
                case 2: selectedIndex = 1; break;
                case 3: selectedIndex = 1; break;
                case 4: selectedIndex = 2; break;
                default: selectedIndex = 0; break;
            }

            Menu.SelectedIndex = selectedIndex;
            Menu.SelectedTab = Menu.TabPages[selectedIndex];
        }

        private void FolderSelect_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.SelectedPath;
                    PathToFolder.Text = filePath;
                    PathToFolder1.Text = filePath;
                }
            }
        }

        private void FileSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    PathToFile.Text = filePath;
                }
            }
        }

        private void SetDefaults()
        {
            solution = null; filePath = null;
            foreach (Control control in Controls) {
                foreach (TextBox textBox in GetAllElements<TextBox>(control)) {
                    textBox.Clear();
                }
            }
        }

        public IEnumerable<Control> GetAllElements<T>(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllElements<T>(ctrl))
                           .Concat(controls)
                           .Where(c => c is T);
        }

        private void SetTextForLabel(Label label, string text)
        {
            label.Text = text;
        }

        private void SetPositionForLabel(Label label, int x, int y)
        {
            label.Location = new Point(x, y);
        }

        private void Accomplish_Click(object sender, EventArgs e)
        {
            if (solution == null) return;
            solution.Invoke();
        }

        private void Solution1()
        {
            if (String.IsNullOrEmpty(filePath)) return;
            if (!File.Exists(filePath)) return;
            SelectedNumbers.Clear();
            AllNumbers.Clear();

            string line = string.Empty; int number = int.MaxValue;
            using (StreamReader stream = new StreamReader(filePath)) {
                AllNumbers.Text = stream.ReadToEnd();
                stream.DiscardBufferedData();
                stream.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

                while (!stream.EndOfStream)
                {
                    line = stream.ReadLine();
                    var selectedNumbers = from t in line.Split(' ')
                                          where int.TryParse(t, out number)
                                          select number;

                    foreach (var item in selectedNumbers.ToList())
                    {
                        if (item % 2 == 1)
                        {
                            SelectedNumbers.Text += $"{line}\r\n";
                            break;
                        }
                    }
                }
            }
        }

        private void Solution2()
        {
            if (String.IsNullOrEmpty(filePath)) return;
            if (!File.Exists(filePath)) return;
            SelectedNumbers.Clear();
            AllNumbers.Clear(); 

            string line = string.Empty; int number = int.MaxValue;
            using (StreamReader stream = new StreamReader(filePath))
            {
                AllNumbers.Text = stream.ReadToEnd();
                stream.DiscardBufferedData();
                stream.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

                while (!stream.EndOfStream)
                {
                    line = stream.ReadLine();
                    var selectedNumbers = (from t in line.Split(' ')
                                          where int.TryParse(t, out number)
                                          select number).ToArray();

                    for (int i = selectedNumbers.Length - 1; i >= 0; i--)
                    {
                        if (selectedNumbers[i] % 5 != 0) break;
                        else if (i == 0) SelectedNumbers.Text += $"{line}\r\n";
                    }
                }
            }
        }

        private void Solution3()
        {
            if (String.IsNullOrEmpty(filePath)) return;
            if (!Directory.Exists(filePath)) return;
            AllNumbers1.Clear();
            filePath = Path.Combine(filePath,"numbers.txt");

            if (!File.Exists(filePath)) File.Create(filePath); int maxValue = int.MinValue;
            using (StreamWriter stream = new StreamWriter(filePath)) {
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int randomValue = random.Next(-100, 100);
                        if (randomValue > maxValue) maxValue = randomValue;
                        stream.Write($"{randomValue} ");
                        AllNumbers1.Text += $"{randomValue} ";
                    }
                    stream.Write("\r\n");
                    AllNumbers1.Text += "\r\n";
                }
            }
            Value.Text = maxValue.ToString();
        }

        private void Solution4()
        {
            if (String.IsNullOrEmpty(filePath)) return;
            if (!Directory.Exists(filePath)) return;
            AllNumbers1.Clear();
            filePath = Path.Combine(filePath, "numbers.txt");

            if (!File.Exists(filePath)) File.Create(filePath);
            double function = 0, number = 0, error = 0.28;
            using (StreamWriter stream = new StreamWriter(filePath)) {
                int count = 0;
                for (double i = 0.1; Math.Abs(function) < error; i += 0.005)
                {
                    function = (i - 0.1) / (Math.Pow(i, 3) + Math.Abs(Math.Tan(2 * i)));
                    stream.Write($"{Math.Round(function,5)} ");
                    if (++count == 5) { stream.Write("\r\n"); count = 0; }
                }
            }

            using (StreamReader stream = new StreamReader(filePath)) {
                AllNumbers1.Text = stream.ReadToEnd();
                var textFile = AllNumbers1.Text.Split(' ');
                var selectedNumbers = (from num in textFile
                                      where double.TryParse(num, out number)
                                      select number).ToArray();
                Value.Text = SumOfItemsWithEvenIndices(selectedNumbers).ToString();
            }
        }

        private double SumOfItemsWithEvenIndices(double[] items)
        {
            double sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (i % 2 == 0) sum += items[i];
            }
            return sum;
        }

        private void Solution5()
        {
            if (String.IsNullOrEmpty(filePath)) return;
            if (!Directory.Exists(filePath)) return;
            File1.Clear(); File2.Clear();

            var w_FilePath = Path.Combine(filePath, "W_File.txt");
            if (!File.Exists(w_FilePath)) File.Create(w_FilePath);
            var f_FilePath = Path.Combine(filePath, "F_File.txt");
            if (!File.Exists(f_FilePath)) File.Create(f_FilePath);

            using (StreamWriter stream = new StreamWriter(w_FilePath)) {
                for (int i = 0; i < 32; i++) {
                    if (i > 0 && i % 5 == 0) {
                        File1.Text += "\r\n";
                        stream.Write("\r\n");
                    }
                    int value = Fibonacci(i); 
                    stream.Write($"{value} ");
                    File1.Text += $"{value} ";
                }
            }

            using (StreamWriter stream = new StreamWriter(f_FilePath)) {
                int number = int.MinValue;
                var numbers = (from num in File1.Text.Split(' ')
                               where int.TryParse(num, out number)
                               select number).ToArray();

                for (int i = 0; i < numbers.Length; i++) {
                    if (i > 0 && i % 5 == 0) {
                        File2.Text += "\r\n";
                        stream.Write("\r\n");
                    }
                    if (i % 2 == 1) {
                        File2.Text += $"{numbers[i]} ";
                        stream.Write($"{numbers[i]} ", 0);
                    }
                }
            }
        }

        private int Fibonacci(int i)
        {
            if (i < 2) return i;
            return Fibonacci(i - 2) + Fibonacci(i - 1);
        }
    }
}
