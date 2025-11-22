/* using System;
using System.Windows.Forms;

namespace NumberConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Create TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // Create Converter Tab
            TabPage tabConverter = new TabPage("Converter");

            // Create Input TextBox
            TextBox txtInput = new TextBox { Name = "txtInput", Top = 20, Left = 20, Width = 200 };
            tabConverter.Controls.Add(txtInput);

            // Input Base ComboBox
            ComboBox cmbInputBase = new ComboBox { Name = "cmbInputBase", Top = 20, Left = 240, Width = 100 };
            cmbInputBase.Items.AddRange(new string[] { "Decimal", "Binary", "Hex" });
            cmbInputBase.SelectedIndex = 0;
            tabConverter.Controls.Add(cmbInputBase);

            // Output Base ComboBox
            ComboBox cmbOutputBase = new ComboBox { Name = "cmbOutputBase", Top = 60, Left = 240, Width = 100 };
            cmbOutputBase.Items.AddRange(new string[] { "Decimal", "Binary", "Hex" });
            cmbOutputBase.SelectedIndex = 1;
            tabConverter.Controls.Add(cmbOutputBase);

            // Convert Button
            Button btnConvert = new Button { Name = "btnConvert", Text = "Convert", Top = 60, Left = 20, Width = 200 };
            tabConverter.Controls.Add(btnConvert);

            // Result TextBox
            TextBox txtResult = new TextBox { Name = "txtResult", Top = 100, Left = 20, Width = 320, ReadOnly = true };
            tabConverter.Controls.Add(txtResult);

            // Explanation TextBox
            TextBox txtExplanation = new TextBox { Name = "txtExplanation", Top = 140, Left = 20, Width = 320, Height = 150, ReadOnly = true, Multiline = true, ScrollBars = ScrollBars.Vertical };
            tabConverter.Controls.Add(txtExplanation);

            // Button click event
            btnConvert.Click += (s, e) =>
            {
                ConvertNumber(txtInput.Text, cmbInputBase.Text, cmbOutputBase.Text, txtResult, txtExplanation);
            };

            // Create Credits Tab
            TabPage tabCredits = new TabPage("Credits");
            Label lblCredits = new Label
            {
                Text = "Created by https://github.com/david-marin-0xff",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            tabCredits.Controls.Add(lblCredits);

            // Add tabs to TabControl
            tabControl.TabPages.Add(tabConverter);
            tabControl.TabPages.Add(tabCredits);

            // Add TabControl to Form
            this.Controls.Add(tabControl);
            this.Text = "Number Converter";
            this.Width = 400;
            this.Height = 350;
        }

        private void ConvertNumber(string input, string inputBase, string outputBase, TextBox txtResult, TextBox txtExplanation)
        {
            try
            {
                int number = 0;

                // Convert input to decimal first
                switch (inputBase)
                {
                    case "Decimal":
                        number = int.Parse(input);
                        break;
                    case "Binary":
                        number = Convert.ToInt32(input, 2);
                        break;
                    case "Hex":
                        number = Convert.ToInt32(input, 16);
                        break;
                    default:
                        throw new Exception("Invalid input base.");
                }

                string result = "";
                string explanation = $"Input '{input}' as {inputBase} = {number} in Decimal.\n";

                // Convert decimal to output
                switch (outputBase)
                {
                    case "Decimal":
                        result = number.ToString();
                        explanation += $"Decimal output = {result}";
                        break;
                    case "Binary":
                        result = Convert.ToString(number, 2);
                        explanation += $"Binary output = {result}";
                        break;
                    case "Hex":
                        result = Convert.ToString(number, 16).ToUpper();
                        explanation += $"Hex output = {result}";
                        break;
                    default:
                        throw new Exception("Invalid output base.");
                }

                txtResult.Text = result;
                txtExplanation.Text = explanation;
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error";
                txtExplanation.Text = ex.Message;
            }
        }
    }
}
*/ 
// First version of the code has been commented out.
/* New version starts here 
using System;
using System.Windows.Forms;
using System.Drawing;

namespace NumberConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Set app title
            this.Text = "NumberConverterGUI";

            // Create TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // ---------- Converter Tab ----------
            TabPage tabConverter = new TabPage("Converter");
            tabConverter.BackColor = Color.FromArgb(255, 230, 230); // light red background

            // Input TextBox
            TextBox txtInput = new TextBox { Name = "txtInput", Top = 20, Left = 20, Width = 200, BackColor = Color.MistyRose };
            tabConverter.Controls.Add(txtInput);

            // Input Base ComboBox
            ComboBox cmbInputBase = new ComboBox { Name = "cmbInputBase", Top = 20, Left = 240, Width = 100, BackColor = Color.LightCoral };
            cmbInputBase.Items.AddRange(new string[] { "Decimal", "Binary", "Hex", "Octal" });
            cmbInputBase.SelectedIndex = 0;
            tabConverter.Controls.Add(cmbInputBase);

            // Output Base ComboBox
            ComboBox cmbOutputBase = new ComboBox { Name = "cmbOutputBase", Top = 60, Left = 240, Width = 100, BackColor = Color.LightCoral };
            cmbOutputBase.Items.AddRange(new string[] { "Decimal", "Binary", "Hex", "Octal" });
            cmbOutputBase.SelectedIndex = 1;
            tabConverter.Controls.Add(cmbOutputBase);

            // Convert Button
            Button btnConvert = new Button { Name = "btnConvert", Text = "Convert", Top = 60, Left = 20, Width = 200, BackColor = Color.IndianRed, ForeColor = Color.White };
            tabConverter.Controls.Add(btnConvert);

            // Result TextBox
            TextBox txtResult = new TextBox { Name = "txtResult", Top = 100, Left = 20, Width = 320, ReadOnly = true, BackColor = Color.Pink };
            tabConverter.Controls.Add(txtResult);

            // Explanation TextBox
            TextBox txtExplanation = new TextBox
            {
                Name = "txtExplanation",
                Top = 140,
                Left = 20,
                Width = 320,
                Height = 150,
                ReadOnly = true,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.PeachPuff
            };
            tabConverter.Controls.Add(txtExplanation);

            // Button click event
            btnConvert.Click += (s, e) =>
            {
                ConvertNumber(txtInput.Text, cmbInputBase.Text, cmbOutputBase.Text, txtResult, txtExplanation);
            };

            // ---------- Credits Tab ----------
            TabPage tabCredits = new TabPage("Credits");
            tabCredits.BackColor = Color.FromArgb(255, 230, 230);
            Label lblCredits = new Label
            {
                Text = "Created by https://github.com/david-marin-0xff",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            tabCredits.Controls.Add(lblCredits);

            // Add tabs to TabControl
            tabControl.TabPages.Add(tabConverter);
            tabControl.TabPages.Add(tabCredits);

            // Add TabControl to Form
            this.Controls.Add(tabControl);
            this.Width = 400;
            this.Height = 350;
        }

        private void ConvertNumber(string input, string inputBase, string outputBase, TextBox txtResult, TextBox txtExplanation)
        {
            try
            {
                int number = 0;
                string formulaInput = "";

                // Convert input to decimal first
                switch (inputBase)
                {
                    case "Decimal":
                        number = int.Parse(input);
                        formulaInput = input;
                        break;
                    case "Binary":
                        number = Convert.ToInt32(input, 2);
                        formulaInput = $"Convert.ToInt32(\"{input}\", 2)";
                        break;
                    case "Hex":
                        number = Convert.ToInt32(input, 16);
                        formulaInput = $"Convert.ToInt32(\"{input}\", 16)";
                        break;
                    case "Octal":
                        number = Convert.ToInt32(input, 8);
                        formulaInput = $"Convert.ToInt32(\"{input}\", 8)";
                        break;
                    default:
                        throw new Exception("Invalid input base.");
                }

                string result = "";
                string formulaOutput = "";

                // Convert decimal to output
                switch (outputBase)
                {
                    case "Decimal":
                        result = number.ToString();
                        formulaOutput = result;
                        break;
                    case "Binary":
                        result = Convert.ToString(number, 2);
                        formulaOutput = $"Convert.ToString({number}, 2)";
                        break;
                    case "Hex":
                        result = Convert.ToString(number, 16).ToUpper();
                        formulaOutput = $"Convert.ToString({number}, 16)";
                        break;
                    case "Octal":
                        result = Convert.ToString(number, 8);
                        formulaOutput = $"Convert.ToString({number}, 8)";
                        break;
                    default:
                        throw new Exception("Invalid output base.");
                }

                txtResult.Text = result;
                txtExplanation.Text = $"// C# formula used:\n// Input: {formulaInput}\n// Output: {formulaOutput}";
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error";
                txtExplanation.Text = ex.Message;
            }
        }
    }
}
*/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace NumberConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Set app title
            this.Text = "NumberConverterGUI";

            // Create TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // ---------- Converter Tab ----------
            TabPage tabConverter = new TabPage("Converter");
            tabConverter.BackColor = Color.FromArgb(255, 230, 230); // light red background

            // Input TextBox
            TextBox txtInput = new TextBox { Name = "txtInput", Top = 20, Left = 20, Width = 200, BackColor = Color.MistyRose };
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tabConverter.Controls.Add(txtInput);

            // Input Base ComboBox
            ComboBox cmbInputBase = new ComboBox { Name = "cmbInputBase", Top = 20, Left = 240, Width = 100, BackColor = Color.LightCoral };
            cmbInputBase.Items.AddRange(new string[] { "Decimal", "Binary", "Hex", "Octal" });
            cmbInputBase.SelectedIndex = 0;
            cmbInputBase.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tabConverter.Controls.Add(cmbInputBase);

            // Output Base ComboBox
            ComboBox cmbOutputBase = new ComboBox { Name = "cmbOutputBase", Top = 60, Left = 240, Width = 100, BackColor = Color.LightCoral };
            cmbOutputBase.Items.AddRange(new string[] { "Decimal", "Binary", "Hex", "Octal" });
            cmbOutputBase.SelectedIndex = 1;
            cmbOutputBase.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tabConverter.Controls.Add(cmbOutputBase);

            // Convert Button
            Button btnConvert = new Button { Name = "btnConvert", Text = "Convert", Top = 60, Left = 20, Width = 200, BackColor = Color.IndianRed, ForeColor = Color.White };
            btnConvert.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tabConverter.Controls.Add(btnConvert);

            // ---------- Zoom Buttons ----------
            Button btnZoomIn = new Button
            {
                Name = "btnZoomIn",
                Text = "Zoom In",
                Top = 100,
                Left = 20,
                Width = 100,
                BackColor = Color.LightGreen
            };
            btnZoomIn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tabConverter.Controls.Add(btnZoomIn);

            Button btnZoomOut = new Button
            {
                Name = "btnZoomOut",
                Text = "Zoom Out",
                Top = 100,
                Left = 130,
                Width = 100,
                BackColor = Color.LightSalmon
            };
            btnZoomOut.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tabConverter.Controls.Add(btnZoomOut);

            // Result TextBox
            TextBox txtResult = new TextBox { Name = "txtResult", Top = 140, Left = 20, Width = 320, ReadOnly = true, BackColor = Color.Pink };
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabConverter.Controls.Add(txtResult);

            // Explanation TextBox
            TextBox txtExplanation = new TextBox
            {
                Name = "txtExplanation",
                Top = 180,
                Left = 20,
                Width = 320,
                Height = 150,
                ReadOnly = true,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.PeachPuff
            };
            txtExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            tabConverter.Controls.Add(txtExplanation);

            // ---------- Button click events ----------
            btnConvert.Click += (s, e) =>
            {
                ConvertNumber(txtInput.Text, cmbInputBase.Text, cmbOutputBase.Text, txtResult, txtExplanation);
            };

            btnZoomIn.Click += (s, e) =>
            {
                txtExplanation.Font = new Font(txtExplanation.Font.FontFamily, txtExplanation.Font.Size + 1);
            };

            btnZoomOut.Click += (s, e) =>
            {
                if (txtExplanation.Font.Size > 1)
                    txtExplanation.Font = new Font(txtExplanation.Font.FontFamily, txtExplanation.Font.Size - 1);
            };

            // ---------- Credits Tab ----------
            TabPage tabCredits = new TabPage("Credits");
            tabCredits.BackColor = Color.FromArgb(255, 230, 230);
            Label lblCredits = new Label
            {
                Text = "Created by https://github.com/david-marin-0xff",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            tabCredits.Controls.Add(lblCredits);

            // Add tabs to TabControl
            tabControl.TabPages.Add(tabConverter);
            tabControl.TabPages.Add(tabCredits);

            // Add TabControl to Form
            this.Controls.Add(tabControl);
            this.Width = 400;
            this.Height = 400; // slightly taller to fit zoom buttons
        }

        private void ConvertNumber(string input, string inputBase, string outputBase, TextBox txtResult, TextBox txtExplanation)
        {
            try
            {
                int number = 0;
                string explanation = "";

                // Step 1: Convert input to decimal
                switch (inputBase)
                {
                    case "Decimal":
                        number = int.Parse(input);
                        explanation += $"Step 1: Input is already Decimal: {number}{Environment.NewLine}{Environment.NewLine}";
                        break;
                    case "Binary":
                        number = Convert.ToInt32(input, 2);
                        explanation += $"Step 1: Convert Binary '{input}' to Decimal using Convert.ToInt32(\"{input}\", 2) = {number}{Environment.NewLine}{Environment.NewLine}";
                        break;
                    case "Hex":
                        number = Convert.ToInt32(input, 16);
                        explanation += $"Step 1: Convert Hex '{input}' to Decimal using Convert.ToInt32(\"{input}\", 16) = {number}{Environment.NewLine}{Environment.NewLine}";
                        break;
                    case "Octal":
                        number = Convert.ToInt32(input, 8);
                        explanation += $"Step 1: Convert Octal '{input}' to Decimal using Convert.ToInt32(\"{input}\", 8) = {number}{Environment.NewLine}{Environment.NewLine}";
                        break;
                }

                // Step 2: Convert decimal to desired output
                string result = "";
                switch (outputBase)
                {
                    case "Decimal":
                        result = number.ToString();
                        explanation += $"Step 2: Output is Decimal: {result}{Environment.NewLine}";
                        break;
                    case "Binary":
                        result = Convert.ToString(number, 2);
                        explanation += $"Step 2: Convert Decimal {number} to Binary using Convert.ToString({number}, 2) = {result}{Environment.NewLine}";
                        break;
                    case "Hex":
                        result = Convert.ToString(number, 16).ToUpper();
                        explanation += $"Step 2: Convert Decimal {number} to Hex using Convert.ToString({number}, 16) = {result}{Environment.NewLine}";
                        break;
                    case "Octal":
                        result = Convert.ToString(number, 8);
                        explanation += $"Step 2: Convert Decimal {number} to Octal using Convert.ToString({number}, 8) = {result}{Environment.NewLine}";
                        break;
                }

                txtResult.Text = result;
                txtExplanation.Text = explanation;
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error";
                txtExplanation.Text = "Oops! Something went wrong. Make sure your input is correct." +
                                      $"{Environment.NewLine}{Environment.NewLine}Details: {ex.Message}";
            }
        }
    }
}
