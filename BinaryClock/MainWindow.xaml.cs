using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BinaryClock {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ImageSource binaryclock_on = new BitmapImage(new Uri("binaryclock.png", UriKind.Relative));
        ImageSource binaryclock_off = new BitmapImage(new Uri("binaryclock-off.png", UriKind.Relative));

        private int dtHour;
        private int dtMinute;
        private int dtSecond;
        public MainWindow() {
            InitializeComponent();
            loaded_clock();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += (TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e) {
            DateTime currentdate = DateTime.Now;
            dtHour = currentdate.Hour;
            dtMinute = currentdate.Minute;
            dtSecond = currentdate.Second;
            display_hourdots();
            display_minutedots();
            display_seconddots();
        }

        #region clock_load
        private void loaded_clock() {
            hourdot_1_1.Source = binaryclock_off;
            hourdot_1_2.Source = binaryclock_off;
            hourdot_2_1.Source = binaryclock_off;
            hourdot_2_2.Source = binaryclock_off;
            hourdot_2_3.Source = binaryclock_off;
            hourdot_2_4.Source = binaryclock_off;
            minutedot_1_1.Source = binaryclock_off;
            minutedot_1_2.Source = binaryclock_off;
            minutedot_1_3.Source = binaryclock_off;
            minutedot_2_1.Source = binaryclock_off;
            minutedot_2_2.Source = binaryclock_off;
            minutedot_2_3.Source = binaryclock_off;
            minutedot_2_4.Source = binaryclock_off;
            seconddot_1_1.Source = binaryclock_off;
            seconddot_1_2.Source = binaryclock_off;
            seconddot_1_3.Source = binaryclock_off;
            seconddot_2_1.Source = binaryclock_off;
            seconddot_2_2.Source = binaryclock_off;
            seconddot_2_3.Source = binaryclock_off;
            seconddot_2_4.Source = binaryclock_off;
        }
        #endregion

        #region hourdots
        private void display_hourdots() {
            switch (dtHour) {
                case 0: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 1: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 2: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 3: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 4: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 5: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 6: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 7: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 8: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 9: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 10: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 11: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 12: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 13: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 14: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 15: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 16: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 17: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 18: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 19: {
                        hourdot_1_1.Source = binaryclock_on;
                        hourdot_1_2.Source = binaryclock_off;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 20: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_on;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 21: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_on;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 22: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_on;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 23: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_on;
                        hourdot_2_1.Source = binaryclock_on;
                        hourdot_2_2.Source = binaryclock_on;
                        hourdot_2_3.Source = binaryclock_off;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 24: {
                        hourdot_1_1.Source = binaryclock_off;
                        hourdot_1_2.Source = binaryclock_on;
                        hourdot_2_1.Source = binaryclock_off;
                        hourdot_2_2.Source = binaryclock_off;
                        hourdot_2_3.Source = binaryclock_on;
                        hourdot_2_4.Source = binaryclock_off;
                        break;
                    }
            }
        }
        #endregion

        #region minutedots
        private void display_minutedots() {
            switch (dtMinute) {
                #region 00-09
                case 0: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 1: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 2: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 3: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 4: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 5: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 6: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 7: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 8: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 9: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 10-19
                case 10: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 11: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 12: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 13: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 14: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 15: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 16: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 17: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 18: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 19: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 20-29
                case 20: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 21: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 22: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 23: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 24: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 25: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 26: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 27: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 28: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 29: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 30-39
                case 30: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 31: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 32: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 33: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 34: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 35: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 36: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 37: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 38: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 39: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_on;
                        minutedot_1_3.Source = binaryclock_off;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 40-49
                case 40: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 41: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 42: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 43: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 44: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 45: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 46: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 47: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 48: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 49: {
                        minutedot_1_1.Source = binaryclock_off;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 50-59
                case 50: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 51: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 52: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 53: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 54: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 55: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 56: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 57: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_on;
                        minutedot_2_3.Source = binaryclock_on;
                        minutedot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 58: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_off;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 59: {
                        minutedot_1_1.Source = binaryclock_on;
                        minutedot_1_2.Source = binaryclock_off;
                        minutedot_1_3.Source = binaryclock_on;
                        minutedot_2_1.Source = binaryclock_on;
                        minutedot_2_2.Source = binaryclock_off;
                        minutedot_2_3.Source = binaryclock_off;
                        minutedot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
            }
        }
        #endregion

        #region seconddots
        private void display_seconddots() {
            switch (dtSecond) {
                #region 00-09
                case 0: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 1: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 2: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 3: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 4: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 5: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 6: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 7: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 8: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 9: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 10-19
                case 10: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 11: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 12: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 13: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 14: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 15: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 16: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 17: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 18: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 19: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 20-29
                case 20: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 21: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 22: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 23: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 24: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 25: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 26: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 27: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 28: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 29: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 30-39
                case 30: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 31: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 32: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 33: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 34: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 35: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 36: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 37: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 38: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 39: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_on;
                        seconddot_1_3.Source = binaryclock_off;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 40-49
                case 40: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 41: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 42: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 43: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 44: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 45: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 46: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 47: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 48: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 49: {
                        seconddot_1_1.Source = binaryclock_off;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
                #region 50-59
                case 50: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 51: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 52: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 53: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 54: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 55: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 56: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 57: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_on;
                        seconddot_2_3.Source = binaryclock_on;
                        seconddot_2_4.Source = binaryclock_off;
                        break;
                    }
                case 58: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_off;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                case 59: {
                        seconddot_1_1.Source = binaryclock_on;
                        seconddot_1_2.Source = binaryclock_off;
                        seconddot_1_3.Source = binaryclock_on;
                        seconddot_2_1.Source = binaryclock_on;
                        seconddot_2_2.Source = binaryclock_off;
                        seconddot_2_3.Source = binaryclock_off;
                        seconddot_2_4.Source = binaryclock_on;
                        break;
                    }
                #endregion
            }
        }
        #endregion

    }
}
