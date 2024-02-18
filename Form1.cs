namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private uint ROR(uint value, int shift)
        {
            return (value >> shift) | (value << (32 - shift));
        }

        private uint XOR(uint a, uint b)
        {
            return a ^ b;
        }

        private uint Generate(string seed, string mac)
        {
            if (seed.Length != 12 || mac.Length != 2 || !IsValidInput(seed) || !IsValidHex(mac))
            {
                MessageBox.Show("Invalid input! Seed must be 12 alphanumeric characters, and the Last MAC Octet must be a valid hexadecimal value of two characters.", "Error");
                return 0;
            }

            string seed_substring = seed.Substring(0, 6);
            uint mac_hex = Convert.ToUInt32(mac, 16) & 0x7;
            uint seed_hex = Convert.ToUInt32(seed_substring, 16) & 0x00FFFFFF;

            uint b = seed_hex;
            uint r = ROR(b + 0xA11F5AC6, (int)mac_hex);
            uint q = XOR(r, b);
            return q;
        }

        private bool IsValidInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidHex(string input)
        {
            if (input.Length != 2) return false;
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && (c < 'A' || c > 'F') && (c < 'a' || c > 'f'))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seed = SEED_text.Text;
            string mac = MAC_text.Text;

            if (!IsValidHex(mac))
            {
                MessageBox.Show("Invalid MAC value. The Last MAC Octet must be a valid hexadecimal value of two characters.", "Error");
                return;
            }

            uint result = Generate(seed, mac);

            string result_hex = result.ToString("X"); // Convert to hexadecimal string
            result_hex = result_hex.PadLeft(8, '0'); // Ensure it's 8 characters long

            Box_out.Text = "ATEN1, " + result_hex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}