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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace payroll_application.windows
{
    
    public partial class autWindow : Window
    {
        double xGradient = 0.1f;
        double yGradient = 0.1f;
        public autWindow()
        {
            InitializeComponent();


            DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(dispatcherTimerTick);
            timer.Interval = new TimeSpan(100000);
            timer.Start();
        }

        private void dispatcherTimerTick(object sender, EventArgs e)
        {
            GradientStopCollection gsc = new GradientStopCollection();
            Point point = Mouse.GetPosition(this);

            if (point.X > 0)
            {
                    gsc.Add(new GradientStop
                {
                    Color = (Color)ColorConverter.ConvertFromString("#FF664EF4"),
                    Offset = 0.5
                }) ;
                gsc.Add(new GradientStop
                {
                    Color = (Color)ColorConverter.ConvertFromString("#CC01B6E9"),
                    Offset = 0.5
                });



                LinearGradientBrush linear = new LinearGradientBrush(gsc)
                {
                     StartPoint = new Point(1 - xGradient, 1 - yGradient),
                     EndPoint = new Point(0 + xGradient, 0 + yGradient)
                };
                    myGrid.Background = linear;
                

                xGradient = point.X / 500 ;
                yGradient = point.Y / 500;

                
                
            }
            label.Content = xGradient;
            
            
        }



        public void enterMouseInImage(object obj , MouseEventArgs e) {
            
            
            

            ((Image)obj).Width += 5;

        }
        public void leaveMouseInImage(object obj, MouseEventArgs e)
        {
            ((Image)obj).Width -= 5;

        }

        public void exitClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void dragClick(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
