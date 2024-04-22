using System.Text.Json;

namespace DiscordToCharAI
{
    public partial class Form1 : Form
    {
        public class Item
        {
            public Int128 ID { get; set; }
            public string Timestamp { get; set; }
            public string Contents { get; set; }
        }

        String filepath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            DialogResult Result = openFile.ShowDialog();

            if (Result == DialogResult.OK)
            {
                Selected.Text = "Selected: " + Path.GetFileName(openFile.FileName);
                filepath = openFile.FileName;
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(filepath) && filepath.ToLower().EndsWith("messages.json"))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                DialogResult Result = saveFile.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    string savePath = saveFile.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(savePath))
                        {
                            string jsonText = File.ReadAllText(filepath);
                            Item[] items = JsonSerializer.Deserialize<Item[]>(jsonText);

                            foreach (var item in items)
                            {
                                if(!item.Contents.Contains("https"))
                                {
                                    writer.WriteLine("{{char}}:" + item.Contents);
                                }
                            }

                            MessageBox.Show(
                                "Successfully wrote converted file to " + Path.GetFileName(savePath),
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    } catch (Exception exception)
                    {
                        MessageBox.Show(
                            "Error saving file: " + exception.Message,
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else // Error if submitted file is not .json
            {
                MessageBox.Show(
                    "Invalid file! Must be discord message json file ('messages.json').",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}