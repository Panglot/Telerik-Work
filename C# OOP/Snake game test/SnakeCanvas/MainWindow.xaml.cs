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

namespace SnakeCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);

            /* Here user can change the speed of the snake.
             * Possible speeds are FAST, MODERATE, SLOW and DAMNSLOW */
            timer.Interval = MODERATE;
            timer.Start();

            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            paintSnake(startingPoint);
            currentPosition = startingPoint;

            // Instantiate Food Objects
            for (int n = 0; n < 10; n++)
            {
                paintBonus(n);
            }
        }
        private void paintSnake(Point currentposition)
        {

            /* This method is used to paint a frame of the snake´s body
             * each time it is called. */

            Ellipse newEllipse = new Ellipse();
            newEllipse.Fill = snakeColor;
            newEllipse.Width = headSize;
            newEllipse.Height = headSize;

            Canvas.SetTop(newEllipse, currentposition.Y);
            Canvas.SetLeft(newEllipse, currentposition.X);

            int count = paintCanvas.Children.Count;
            paintCanvas.Children.Add(newEllipse);
            snakePoints.Add(currentposition);

            // Restrict the tail of the snake
            if (count > length)
            {
                paintCanvas.Children.RemoveAt(count - length + 9);
                snakePoints.RemoveAt(count - length);
            }
        }

        private void paintBonus(int index)
        {
            Point bonusPoint = new Point(rnd.Next(5, 620), rnd.Next(5, 380));

            Ellipse newEllipse = new Ellipse();
            newEllipse.Fill = Brushes.Red;
            newEllipse.Width = headSize;
            newEllipse.Height = headSize;

            Canvas.SetTop(newEllipse, bonusPoint.Y);
            Canvas.SetLeft(newEllipse, bonusPoint.X);
            paintCanvas.Children.Insert(index, newEllipse);
            bonusPoints.Insert(index, bonusPoint);
        }
    }

    private void OnButtonKeyDown(object sender, KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.Down:
                if (previousDirection != (int)MOVINGDIRECTION.UPWARDS)
                    direction = (int)MOVINGDIRECTION.DOWNWARDS;
                break;
            case Key.Up:
                if (previousDirection != (int)MOVINGDIRECTION.DOWNWARDS)
                    direction = (int)MOVINGDIRECTION.UPWARDS;
                break;
            case Key.Left:
                if (previousDirection != (int)MOVINGDIRECTION.TORIGHT)
                    direction = (int)MOVINGDIRECTION.TOLEFT;
                break;
            case Key.Right:
                if (previousDirection != (int)MOVINGDIRECTION.TOLEFT)
                    direction = (int)MOVINGDIRECTION.TORIGHT;
                break;
        }
        previousDirection = direction;

    }

    private void timer_Tick(object sender, EventArgs e)
    {
        // Expand the body of the snake to the direction of movement

        switch (direction)
        {
            case (int)MOVINGDIRECTION.DOWNWARDS:
                currentPosition.Y += 1;
                paintSnake(currentPosition);
                break;
            case (int)MOVINGDIRECTION.UPWARDS:
                currentPosition.Y -= 1;
                paintSnake(currentPosition);
                break;
            case (int)MOVINGDIRECTION.TOLEFT:
                currentPosition.X -= 1;
                paintSnake(currentPosition);
                break;
            case (int)MOVINGDIRECTION.TORIGHT:
                currentPosition.X += 1;
                paintSnake(currentPosition);
                break;
        }

        // Restrict to boundaries of the Canvas
        if ((currentPosition.X < 5) || (currentPosition.X > 620) ||
            (currentPosition.Y < 5) || (currentPosition.Y > 380))
            GameOver();

        // Hitting a bonus Point causes the lengthen-Snake Effect
        int n = 0;
        foreach (Point point in bonusPoints)
        {

            if ((Math.Abs(point.X - currentPosition.X) < headSize) &&
                (Math.Abs(point.Y - currentPosition.Y) < headSize))
            {
                length += 10;
                score += 10;

                // In the case of food consumption, erase the food object
                // from the list of bonuses as well as from the canvas
                bonusPoints.RemoveAt(n);
                paintCanvas.Children.RemoveAt(n);
                paintBonus(n);
                break;
            }
            n++;
        }

        // Restrict hits to body of Snake

        for (int q = 0; q < (snakePoints.Count - headSize * 2); q++)
        {
            Point point = new Point(snakePoints[q].X, snakePoints[q].Y);
            if ((Math.Abs(point.X - currentPosition.X) < (headSize)) &&
                 (Math.Abs(point.Y - currentPosition.Y) < (headSize)))
            {
                GameOver();
                break;
            }
        }
    }
}
