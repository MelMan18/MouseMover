namespace movemouse
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer t;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Avvia il timer che muoverà il mouse ogni 10 secondi
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 10000; // 10 secondi
            t.Tick += new EventHandler(MoveMouse);
            t.Start();
        }
                private void button2_Click(object sender, EventArgs e)
        {
            // Esci dal programma
            Close();
        }

        private void MoveMouse(object sender, EventArgs e)
        {
            // Muovi il mouse in una posizione casuale sullo schermo
            Cursor.Position = new System.Drawing.Point(
                (new Random()).Next(0, Screen.PrimaryScreen.Bounds.Width),
                (new Random()).Next(0, Screen.PrimaryScreen.Bounds.Height));
        }


    }
}