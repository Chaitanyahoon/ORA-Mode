using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BizarreStand.ToolWindow
{
    public partial class StandWindowControl : UserControl
    {
        private readonly List<string> _quotes = new List<string>
        {
            "“Yare Yare Daze...”",
            "“I, Giorno Giovanna, have a dream.”",
            "“You thought it was a clean build, but it was ME, DIO!”",
            "“This is... the resolve of my Stand.”",
            "“USELESS! USELESS! USELESS! (The bug persists)”",
            "“Are you gonna do the ‘ora ora’ thing?!”",
            "“Great days are coming for your code.”",
            "“Even in this rot, a flower of hope can bloom.”",
            "“HEAVEN’S DOOR! Remove this bug!”",
            "“Stand Name: [CLEAN COMPILE]”",
            "“Oh? You’re refactoring me?”",
            "“The World! Stop the runtime!”",
            "“NIGERUNDAYO! (When prod breaks)”",
            "“Code is Unbreakable.”",
            "“My code has no weaknesses!” - Kira Yoshikage",
            "“Next you’ll say: ‘It works on my machine!’”",
            "“Speedwagon withdraws coolly.”",
            "“Do you believe in ‘Gravity’? (Dependencies)”",
            "“Arigato... Gyro.”",
            "“A bit closer to Heaven (Clean Code).”"
        };
        private readonly Random _random = new Random();

        public StandWindowControl()
        {
            this.InitializeComponent();
        }

        private void OnRefreshQuote(object sender, RoutedEventArgs e)
        {
            int index = _random.Next(_quotes.Count);
            QuoteText.Text = _quotes[index];
            
            // Randomly switch Chibi
            bool useHero = _random.Next(2) == 0;
            string imageName = useHero ? "ChibiHero.png" : "ChibiVillain.png";
            var uri = new Uri($"pack://application:,,,/BizarreStand;component/Resources/{imageName}");
            ChibiImage.Source = new System.Windows.Media.Imaging.BitmapImage(uri);

            // Play Sound if Enabled
            if (SoundToggle.IsChecked == true)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }
    }
}
